using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Squeezy_Data_Compressor
{
    public partial class JPEG_Compress : Form
    {
        private static string fileToCompress;
        private static long compressionFactor;

        public JPEG_Compress()
        {
            InitializeComponent();
        }

        private void btn_select_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "jpeg files (*.jpeg) | *.jpeg | jpg files (*.jpg) | *.jpg";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileToCompress = @openFileDialog.FileName;
                label1.Text = "File selected:   " + fileToCompress;
            }
        }

        private void btn_compress_Click(object sender, EventArgs e)
        {
            //compressionFactor = Int32.Parse(textBox1.Text);
            compressionFactor = Convert.ToInt32(textBox1.Text);
            VaryQualityLevel(fileToCompress, compressionFactor);
        }

        private void VaryQualityLevel(string filename, long factor)
        {
            // Get a bitmap. The using statement ensures objects  
            // are automatically disposed from memory after use.  
            using(Bitmap bmp1 = new Bitmap(filename))
            {
                ImageCodecInfo jpegEncoder = GetEncoder(ImageFormat.Jpeg);

                // Create an Encoder object based on the GUID  
                // for the Quality parameter category.
                System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;

                // Create an EncoderParameters object.  
                // An EncoderParameters object has an array of EncoderParameter  
                // objects. In this case, there is only one  
                // EncoderParameter object in the array.  
                EncoderParameters myEncoderParameters = new EncoderParameters(1);

                EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, factor);
                myEncoderParameters.Param[0] = myEncoderParameter;
                try
                {
                    //error on the next line
                    bmp1.Save(@"c:\compressedImage.jpg", jpegEncoder, myEncoderParameters);
                } catch (Exception e)
                {
                    label1.Text = e.ToString();
                }
            } 
        }


        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }
    }
}
