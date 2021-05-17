using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AESencryptor
{

    /// <summary>
    /// AES Encryptor for BMP files to encrypted JPEG files
    /// using ECB, CBC and CFB ciper modes
    /// 
    /// Author: Ammon Leslie
    /// ID: 1501041
    /// 
    /// </summary>
    public partial class Form1 : Form
    {
        // class scope for use across methods
        Bitmap import;
        String inputFile;

        // set constants for key/block sizes
        const int KEY_SIZE = 128;
        const int BLOCK_SIZE = 128;

        public Form1()
        {
            InitializeComponent();

            // set dialog filters
            openFileDialog1.Filter = "Bitmap Files|*.bmp|All Files|*.*";
            saveFileDialog1.Filter = "JPEG Files|*.jpeg;*.jpg|All Files|*.*";
        }

        /// <summary>
        /// Prompts the user to select a file to import for encryption
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonImport_Click(object sender, EventArgs e)
        {
            // prompt user to select import file
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // store import
                try
                {
                    // hold in temp in case exception thrown
                    Bitmap tempImport = new Bitmap(openFileDialog1.FileName);

                    labelImport.Text = "'" + Path.GetFileName(openFileDialog1.FileName) + "' imported!";

                    // dispose of any previous bitmap (seems to work better than relying on GC)
                    if (import != null)
                    {
                        import.Dispose();
                    }

                    // update proper Bitmap object
                    import = tempImport;
                    inputFile = openFileDialog1.FileName;

                    pictureBoxPreviewImport.Image = import;
                }

                // unsupported file type handling
                catch
                {
                    MessageBox.Show("Import failed: Invalid file type");
                }
                
            }

            // toggle Encrypt button enabled
            buttonEncrypt.Enabled = (import != null);

            
        }

        /// <summary>
        /// Encrypts the imported file and prompts the user to save it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            string key = textBoxKey.Text;

            // setup encryptor
            Aes myAes = Aes.Create();

            myAes.BlockSize = BLOCK_SIZE;
            myAes.KeySize = KEY_SIZE;

            // setup mode
            myAes.Mode = GetCipherMode();

            // setup key
            byte[] tempKeyArray = ConvertHexStringToBytes(key);

            // stop encryption if key is invalid size
            if (tempKeyArray.Length != myAes.KeySize / 8)
            {
                MessageBox.Show("Key is not the required size (128bits/16 bytes), please check your key input.");
                return;
            }
            // assign key to encryptor
            myAes.Key = tempKeyArray;

            using (FileStream fileStream = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
            {
                using (MemoryStream ms = new MemoryStream())
                {

                    fileStream.CopyTo(ms);

                    // Store header in byte array (we will used this after encryption)
                    byte[] headerArray = ms.ToArray().Take(54).ToArray();
                    byte[] imageArray = ms.ToArray().Skip(54).ToArray();

                    // encrypt image data
                    ICryptoTransform myEncrypt = myAes.CreateEncryptor(myAes.Key, myAes.IV);
                    byte[] encrypted = myEncrypt.TransformFinalBlock(imageArray, 0, imageArray.Length);

                    // recombine header and image data
                    byte[] exportArray = new byte[headerArray.Length + encrypted.Length];
                    Buffer.BlockCopy(headerArray, 0, exportArray, 0, headerArray.Length);
                    Buffer.BlockCopy(encrypted, 0, exportArray, headerArray.Length, encrypted.Length);


                    // generate filename
                    string outFile = Path.GetFileNameWithoutExtension(inputFile) + "_" + myAes.Mode + ".jpg";
                    saveFileDialog1.FileName = outFile;

                    // get save location
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        //// Save bitmap file
                        // File.WriteAllBytes(saveFileDialog1.FileName, exportArray);

                        // Save Bitmap as JPEG
                        using (MemoryStream bitmapMS = new MemoryStream(exportArray))
                        {
                            using (Bitmap newImage = new Bitmap(bitmapMS))
                            {
                                newImage.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
                            }
                        }

                        // Open saved file
                        System.Diagnostics.Process.Start(saveFileDialog1.FileName);
                    }
                }
            }

            // Output AES attributes (testing purposes)
            Console.WriteLine("KEY: " + BitConverter.ToString(myAes.Key));
            Console.WriteLine("MODE: " + myAes.Mode);
            Console.WriteLine("IV: " + BitConverter.ToString(myAes.IV));


        }

        /// <summary>
        /// Takes a string of hexadecimal values and returns it as an array of bytes
        /// </summary>
        /// <param name="hex">String of hexadecimal values</param>
        /// <returns>Byte array of hexadecimal values</returns>
        private byte[] ConvertHexStringToBytes(string hex)
        {
            string[] hexArray = new string[hex.Length / 2];
            byte[] byteArray = new byte[hexArray.Length];

            try
            {
                // split string into string array
                for (int i = 0; i < hex.Length; i += 2)
                {
                    hexArray[i / 2] = hex.Substring(i, 2);
                }

                // convert hex values into bytes
                for (int i = 0; i < hexArray.Length; i++)
                {
                    byteArray[i] = Convert.ToByte(hexArray[i], 16);
                }
            }
            catch
            {
                MessageBox.Show("Key was unable to be coverted to bytes, please check your key input.");

                // return an empty array
                byteArray = new byte[0];
            }

            return byteArray;
        }

        /// <summary>
        /// Checks the form radio buttons and returns the selected cipher mode
        /// </summary>
        /// <returns>Selected cipher mode</returns>
        private CipherMode GetCipherMode()
        {
            if (radioButtonCBC.Checked)
            {
                return CipherMode.CBC;
            }
            else if (radioButtonCFB.Checked)
            {
                return CipherMode.CFB;
            }
            else
            {
                return CipherMode.ECB;
            }
        }
    }
}
