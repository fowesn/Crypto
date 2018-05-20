using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using System.IO;

namespace Crypto
{

    public partial class CryptoMainForm : Form
    {
        private int KeySize;
        RSACryptoServiceProvider rsaprovider;
        AesCryptoServiceProvider aesprovider;
        RSAParameters parameters;

        public CryptoMainForm()
        {
            InitializeComponent();
            KeySize = 1024;
            rsaprovider = new RSACryptoServiceProvider(KeySize);
            parameters = rsaprovider.ExportParameters(false);  //вот тут все ключи
            aesprovider = new AesCryptoServiceProvider();
            // создание сеансового ключа
            aesprovider.GenerateKey();
            // создание вектора инициализации
            aesprovider.GenerateIV();
            // вывод сеансового ключа
            StringBuilder sb = new StringBuilder();
            foreach(byte bytekey in aesprovider.Key)
                sb.Append(bytekey);
            
            SessionKey.Text = sb.ToString();

            // пока не выбран файл, нельзя работать с подписью
            GenerateDS.Enabled = false;
            CheckDS.Enabled = false;
            // и с файлм как ни странно тоже
            SaveEncryptedFile.Enabled = false;
            SaveDecryptedFile.Enabled = false;
        }

        private void ChooseFile_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() != DialogResult.OK)
                return;

            FilePath.Text = OpenFileDialog.FileName;
            // после выбора файла можно со спокойной душой тыкать на все кнопки
            GenerateDS.Enabled = true;
            CheckDS.Enabled = true;
            SaveEncryptedFile.Enabled = true;
            SaveDecryptedFile.Enabled = true;

            /*System.IO.StreamReader sr = new
                   System.IO.StreamReader(OpenFileDialog.FileName);
            MessageBox.Show(sr.ReadToEnd());
            sr.Close();*/
        }

        private void GenerateDS_Click(object sender, EventArgs e)
        {

        }

        private void SaveEncryptedFile_Click(object sender, EventArgs e)
        {
            // выбрать файл для шифрования
            if (SaveFileDialog.ShowDialog() != DialogResult.OK)
                return;
            string Path = FilePath.Text;
            // перед шифрованием надо не иначе как считать файл
            StreamReader sr = new StreamReader(Path);
            string Message = sr.ReadToEnd();
            sr.Close();

            // создаём энкриптор(шифратор) - как я поняла, это нужная штука для того чтобы зашифровать файл (юзается дальше для CryptoStream)
            ICryptoTransform encryptor = aesprovider.CreateEncryptor();
            // открываем файл как поток с шифратором
            CryptoStream cs = new CryptoStream(SaveFileDialog.OpenFile(), encryptor, CryptoStreamMode.Write);
            StreamWriter sw = new StreamWriter(cs);
            sw.Write(Message); // записываем в поток сообщение при помощи шифратора
            sw.Close();
            cs.Close();
        }

        private void SaveDecryptedFile_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            string Path = FilePath.Text;
            
            //дешифратор
            ICryptoTransform decryptor = aesprovider.CreateDecryptor();

            // создаём поток с данными из зашфрованного файла
            MemoryStream ms = new MemoryStream(File.ReadAllBytes(Path));
            // создаём поток с дешифратором
            CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read);
            StreamReader sr = new StreamReader(cs);
            string Message = sr.ReadToEnd();

            sr.Close(); cs.Close(); ms.Close();

            // записываем расшифрованное сбщ в файл
            StreamWriter sw = new StreamWriter(SaveFileDialog.OpenFile());
            sw.Write(Message);
            sw.Close();
             
        }

        private void EncryptSessionKey_Click(object sender, EventArgs e)
        {

        }

        private void DecryptSessionKey_Click(object sender, EventArgs e)
        {

        }

        private void CheckDS_Click(object sender, EventArgs e)
        {

        }
    }
}
