using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
namespace Crypto
{
    public partial class CryptoMainForm : Form
    {
        private int KeySize;
        RSACryptoServiceProvider provider;
        public CryptoMainForm()
        {
            InitializeComponent();
            KeySize = 1024;
            provider = new RSACryptoServiceProvider(KeySize);

        }

        private void Generate_Click(object sender, EventArgs e)
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
    }
}
