using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSBSound
{
    public partial class Form1 : Form
    {
        byte[] audio;
        Stopwatch stopwatch;
        public Form1()
        {
            InitializeComponent();
            OutputConsole.Bind(console);
            stopwatch = new Stopwatch();
        }
        

        private void encryptButton_Click(object sender, EventArgs e)
        {
            if (audio != null)
            {
                byte[] file;                
                file = AudioSteganography.EncryptTextLinear(audio, textBox.Text);
                if (file != null)
                {
                    DialogResult res = saveWav.ShowDialog();
                    if (res == System.Windows.Forms.DialogResult.OK)
                    {
                        File.WriteAllBytes(saveWav.FileName, file);
                        OutputConsole.Write("Wav-файл сохранен");
                    }
                }
            }
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            if (audio != null)
            {
                string text;
                //text = null;
                text = AudioSteganography.DecryptTextLinear(audio);
                if (text != null)
                {
                    textBox.Text = text;
                    OutputConsole.Write("Текст расшифрован");
                }
                //else
                //{
                //    OutputConsole.Write("В данном файле нет скрытого сообщения");
                //    decryptButton.Enabled = false;
                //}

            }

            //if (audio == null)
            //{
            //    OutputConsole.Write("В данном файле нет скрытого сообщения");
            //}

            //if (AudioSteganography.DecryptTextLinear(audio) == null)
            //{
            //    OutputConsole.Write("В данном файле нет скрытого сообщения");
            //}
        }


        private void console_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = console.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                MessageBox.Show(console.Items[index].ToString());
            }
        }


        private void console_KeyDown(object sender, KeyEventArgs e)
        {
            if (console.SelectedIndex >= 0 && e.KeyCode == Keys.Delete)
            {
                console.Items.RemoveAt(console.SelectedIndex);
            }
        }

        private void loadWavFile_Click(object sender, EventArgs e)
        {
            this.encryptButton.Enabled = true;
            this.decryptButton.Enabled = true;
            DialogResult res = loadWav.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                audio = File.ReadAllBytes(loadWav.FileName);
                WavAudio wav = new WavAudio(audio);
                if (wav.data != null)
                {
                    OutputConsole.Write(string.Format("Аудиофайл загружен "));
                    OutputConsole.Write(string.Format ("Количество сэмплов: {0}", wav.totalSamples));
                    OutputConsole.Write(string.Format("Максимальный размер шифруемого сообщения для этого файла = {0}", FileSizeFormatProvider.GetFileSize(wav.bytesAvailable)));
                    audioLabel.Text = string.Format("Использован wav-файл: {0}", loadWav.SafeFileName);
                    audioLabel.Visible = true;
                    string text;
                    text = AudioSteganography.DecryptTextLinear(audio);
                    if (text != null)
                    {
                        OutputConsole.Write("В файле скрыто сообщение");
                        this.encryptButton.Enabled = false;
                    }
                    else
                    {
                        OutputConsole.Write("В файле ничего не обнаружено");
                        this.decryptButton.Enabled = false;
                    }
                }
                else
                {
                    audio = null;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Clear();
        }
    }
}