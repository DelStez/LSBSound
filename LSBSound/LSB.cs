using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace LSBSound
{
    public class LSB
    {
        public byte[] audioBytes;
        public BitArray bitsText { get; set; }
        public int numberOfSymbols; // кол-во сиволов 
        public int bitOnC;

        public LSB(string message, int y, string path) //передача данных в текущий класс (режим кодирования)
        {
            audioBytes = File.ReadAllBytes(path);
            numberOfSymbols = message.Length;
            bitOnC = y;
            GetBitsOfMessage(message);
        }

        public LSB(bool[] arr, int y) //передача данных в текущий класс (режим декодирования)
        {
        }

       public byte[] insertTextToImage() // LSB -кодировние
        {
            bitsText = new BitArray(audioBytes);
            int bitCount = 0; //счетчики битов сообщения и битов аудио
            int allbit = 0;
            bool getAllNeedPixel = false; // булевая переменная, необходимая для выхода из внешнего цикла
            for (int i = 0, j = 0; i < audioBytes.Length && j < bitsText.Count; i++)
            {
                BitArray bitsOfByte = new BitArray(audioBytes[i]);
                bitsOfByte[bitsOfByte.Count - 1] = bitsOfByte[bitsOfByte.Count - 1] ? true : false;
            }

            // for (int i = 0, j = 0; i < bitsSound.Length && j < bitsText.Length; i++, j++)
            // {
            //     for (int k = 0; k < 8; k++)
            //     {
            //         byte bit = (byte)(((int)secretMessage[j] >> k) & 1);
            //         audioBytes[i] = (byte)((audioBytes[i] & 254) + bit);
            //         i++;
            //     }
            //     i--; // Важно не забыть уменьшить i, чтобы не пропустить байты аудиофайла.
            // }
            return null; // возвращаем результат
        }

        public void GetBitsOfMessage(string message) // получение битового массива сообщения
        {
            byte[] temp = Encoding.Default.GetBytes(message); //перевод в массив байтов
            bitsText = new BitArray(temp); // перевод в массив битов
        }
        private int SetBit(bool currentBit, int i)
        {
            BitArray n = new BitArray(new int[] {  }); 
            if (currentBit)// если значение бита = 1
                n[i] = true;
            else
                n[i] = false;
            int[] y = new int[1]; //получаем значение  пикселя в привычном виде (натурального числа)
            n.CopyTo(y, 0);
            return y[0];
        }
    }
}