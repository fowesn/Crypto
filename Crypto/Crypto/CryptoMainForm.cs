using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
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
            // вывод сеансового ключа
            StringBuilder sb = new StringBuilder();
            foreach(byte bytekey in aesprovider.Key)
                sb.Append(bytekey);
            
            SessionKey.Text = sb.ToString();
        }

        private void GenerateDS_Click(object sender, EventArgs e)
        {

        }

        private void ChooseFile_Click(object sender, EventArgs e)
        {

        }

        private void SaveEncryptedFile_Click(object sender, EventArgs e)
        {

        }

        private void SaveDecryptedFile_Click(object sender, EventArgs e)
        {

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
