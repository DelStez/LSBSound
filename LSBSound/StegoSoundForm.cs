using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Media;
using System.Text;
using NAudio.Dsp;
using NAudio.Wave;

namespace LSBSound
{
    public partial class StegoSoundForm : Form
    {
        public OpenFileDialog openDialog = new OpenFileDialog();
        public byte[] audioBytes;
        private SoundPlayer _soundPlayer = new SoundPlayer(); 
        public WaveOutEvent player = new WaveOutEvent();
        public bool isPlaying = false;
        public bool isneedResume = false;
        
        public string dir = "c:\\";
        public string fileSoundPath = string.Empty;
        public string filetxtPath = string.Empty;
        public string Content = string.Empty;
        
        
        public StegoSoundForm()
        {
            InitializeComponent();
        }
        
        
        
        private void StegoSound_Load(object sender, EventArgs e)
        {
        }

        private void comboBoxmode_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            
            int numBit = Convert.ToInt32(comboBox1.SelectedItem);
            if (comboBoxmode.SelectedIndex == 0 && player != null)
            {
                if (Content != null)
                {
                    BitArray mess = new BitArray(Encoding.UTF8.GetBytes(Content));
                    LSB newSoundMessage = new LSB( Content, numBit, fileSoundPath);
                    newSoundMessage.insertTextToImage();
                    

                }
                else 
                    MessageBox.Show("Отсуствует текст", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (comboBoxmode.SelectedIndex == 1 && player != null)
            {
            }
            else
                MessageBox.Show("Отсуствует аудиофайл", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void loadSound_Click(object sender, EventArgs e)
        {
            openDialog.FileName = string.Empty;
            openDialog.Filter = "Звуковые файлы (*.wav, *.mp3, *.ogg, *.m4a)|*.wav;*.mp3;*.ogg; *.m4a|Все файлы (*.*)|*.*";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                fileSoundPath = openDialog.FileName;
                soundBox.Text = filetxtPath;
                audioBytes = File.ReadAllBytes(openDialog.FileName);
            }
        }

        private void loadText_Click(object sender, EventArgs e)
        {
            openDialog.FileName = string.Empty;
            openDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openDialog.FilterIndex = 2;
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                filetxtPath = openDialog.FileName;
                txtBox.Text = filetxtPath;
                ShowTxt(filetxtPath);
            }
        }

        private void ShowTxt(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                contentBox.Text = reader.ReadToEnd();
                Content = contentBox.Text;
            }
        }

        private void CheckingExtAndPlay(string path)
        {
            string filePath = path;
            string extension = Path.GetExtension(filePath);
            switch (extension)
            {
                case ".mp3":
                    Mp3FileReader mp3File = new Mp3FileReader(filePath);
                    player.Init(mp3File);
                    break;
                case ".wav":
                    AudioFileReader wavFile = new AudioFileReader(filePath);
                    player.Init(wavFile);
                    break;
                case ".m4a":
                    MediaFoundationReader m4aFile = new MediaFoundationReader(filePath);
                    player.Init(m4aFile);
                    break;
                // другие форматы
                default:
                    throw new NotImplementedException($"Player for {extension} file type not implemented");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isPlaying)
            {
                if (!isneedResume)
                {
                    CheckingExtAndPlay(fileSoundPath);
                    player.Play();
                    isPlaying = true;
                    button1.Text = "||";
                }
                else
                {
                    player.Play();
                    isPlaying = true;
                    button1.Text = "||";
                }
            }
            else
            {
                    isPlaying = false;
                    isneedResume = true;
                    button1.Text = "⏵";
                    player.Pause();
            }
            
        }

        public void SoundWaveImage(string path)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.Stop();
        }
    }
}