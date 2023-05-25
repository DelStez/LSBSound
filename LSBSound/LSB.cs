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

       public void insertTextToSound() // LSB -кодировние
        {
            // Вычисляем длину сообщения в битах
            int messageLength = message.Length;
            int bitsNeeded = 0;
            while (messageLength > 0)
            {
                messageLength >>= 1;
                bitsNeeded++;
            }
        }

        public void GetBitsOfMessage(string message) // получение битового массива сообщения
        {
            byte[] temp = Encoding.Default.GetBytes(message); //перевод в массив байтов
            bitsText = new BitArray(temp); // перевод в массив битов
        }
    }
}