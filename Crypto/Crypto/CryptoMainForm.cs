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
        private string SignPath;
        private RSACryptoServiceProvider rsaprovider;
        private AesCryptoServiceProvider aesprovider;
        private DSACryptoServiceProvider dsaprovider;
        private RSAParameters parameters;

        public CryptoMainForm()
        {
            InitializeComponent();
            KeySize = 1024;
            rsaprovider = new RSACryptoServiceProvider(KeySize);
            parameters = rsaprovider.ExportParameters(false);  //вот тут все ключи
            dsaprovider = new DSACryptoServiceProvider(KeySize);
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

            // нельзя расшифровать ключ, пока он не зашифрован
            DecryptSessionKey.Enabled = false;
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

            string[] PartPath = FilePath.Text.Split(new char[] { '\\' });
            SignPath = "";
            for (int i = 0; i < PartPath.Length - 1; i++)
                SignPath += PartPath[i] + "\\";
            SignPath += "sign." + PartPath[PartPath.Length - 1] + ".sign";

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

        private void SaveEncryptedFile_Click(object sender, EventArgs e)
        {
            // выбрать файл для шифрования
            if (SaveEncryptedFileDialog.ShowDialog() != DialogResult.OK)
                return;
            string Path = FilePath.Text;
            // перед шифрованием надо не иначе как считать файл
            StreamReader sr = new StreamReader(Path);
            string Message = sr.ReadToEnd();
            sr.Close();

            // создаём энкриптор(шифратор) - как я поняла, это нужная штука для того чтобы зашифровать файл (юзается дальше для CryptoStream)
            ICryptoTransform encryptor = aesprovider.CreateEncryptor();
            // открываем файл как поток с шифратором
            CryptoStream cs = new CryptoStream(SaveEncryptedFileDialog.OpenFile(), encryptor, CryptoStreamMode.Write);
            StreamWriter sw = new StreamWriter(cs);
            sw.Write(Message); // записываем в поток сообщение при помощи шифратора
            sw.Close();
            cs.Close();
            MessageBox.Show("Зашифровано", "Ура", MessageBoxButtons.OK);
        }

        private void SaveDecryptedFile_Click(object sender, EventArgs e)
        {
            if (SaveDecryptedFileDialog.ShowDialog() != DialogResult.OK)
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
            StreamWriter sw = new StreamWriter(SaveDecryptedFileDialog.OpenFile());
            sw.Write(Message);
            sw.Close();
            MessageBox.Show("Расшифровано", "Ура", MessageBoxButtons.OK);
        }
        private byte[] EncryptedKey;
        private void EncryptSessionKey_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            // метод для шифрования rsa
            EncryptedKey = rsaprovider.Encrypt(aesprovider.Key, true);
            foreach (byte bytekey in EncryptedKey)
                sb.Append(bytekey);
            SessionKey.Text = sb.ToString();
            DecryptSessionKey.Enabled = true;
        }

        private void DecryptSessionKey_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            // метод для расшифрования rsa
            byte[] DecryptedKey = rsaprovider.Decrypt(EncryptedKey, true);
            foreach (byte bytekey in DecryptedKey)
                sb.Append(bytekey);
            SessionKey.Text = sb.ToString();
        }

        private void GenerateDS_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream(File.ReadAllBytes(FilePath.Text));
            // метод для создания цифровой подписи
            byte[] Sign = dsaprovider.SignData(ms);
            File.WriteAllBytes(SignPath, Sign);
            MessageBox.Show("Документ подписан", "Ура");
        }

        private void CheckDS_Click(object sender, EventArgs e)
        {
            if (!File.Exists(SignPath))
            {
                MessageBox.Show("Подпись не найдена", "Боль", MessageBoxButtons.OK);
                return;
            }
            byte[] Sign = File.ReadAllBytes(SignPath);
            // пытаемся проверить цифровую подпись. если исключение, значит длина подпичи не равняется 40 байтам, иначе проверяется подпись на совпадение
            try
            {
                // метод для проверки цифровой подписи
                if (dsaprovider.VerifyData(File.ReadAllBytes(FilePath.Text), Sign))
                    MessageBox.Show("Подпись совпадает", "Всё хорошо", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Подпись не совпадает", "Всё плохо", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("В файле " + SignPath + " содержится не подпись", "Всё плохо", MessageBoxButtons.OK);
            }
        }
    }
}
