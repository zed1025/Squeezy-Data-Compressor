﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Squeezy_Data_Compressor
{
    public partial class MainForm : Form
    {
        //variable to store the directory for compression
        private static string directoryForCompression;
        private static string fileForDecompression;

        public MainForm()
        {
            InitializeComponent();
        }
        

        //button for choosing the directory for compression
        private void button1_Click(object sender, EventArgs e)
        {   
            //opens a dialogue box and lets you select a file
            OpenFileDialog openFileDialog = new OpenFileDialog();

            //the following line prevents the OpenFileDialogue from choosing files other than .txt files for compression
            openFileDialog.Filter = "txt files (*.txt) | *.txt";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string directory;
                directory = openFileDialog.FileName;
                label3.Text = directory;

                //extracting directory name from the file path
                int temp = directory.LastIndexOf('\\');
                directory = directory.Substring(0, temp);
                
                label3.Text = directory + "  directory selected.";
                directoryForCompression = @directory;
            }
        }

        //compress button
        private void button2_Click(object sender, EventArgs e)
        {
            if(directoryForCompression != null)
            {
                DirectoryInfo directorySelected = new DirectoryInfo(directoryForCompression);
                Compress(directorySelected);
                label3.Text = "File Compresses in directory: " + directoryForCompression;
            }

        }

        //method to compress files.
        public void Compress(DirectoryInfo directorySelected)
        {
            foreach (FileInfo file in directorySelected.GetFiles("*.txt"))
                using (FileStream originalFileStream = file.OpenRead())
                {
                    if ((File.GetAttributes(file.FullName) & FileAttributes.Hidden)
                         != FileAttributes.Hidden & file.Extension != ".cmp")
                    {
                        using (FileStream compressedFileStream = File.Create(file.FullName + ".cmp"))
                        {
                            using (DeflateStream compressionStream = new DeflateStream(compressedFileStream, CompressionMode.Compress))
                            {
                                originalFileStream.CopyTo(compressionStream);
                            }
                        }
                        FileInfo info = new FileInfo(directoryForCompression + "\\" + file.Name + ".cmp");
                        Console.WriteLine("Compressed {0} from {1} to {2} bytes.", file.Name, file.Length, info.Length);
                    }
                }
        }

        //method for decompression
        public static void Decompress(FileInfo fileToDecompress)
        {
            using (FileStream originalFileStream = fileToDecompress.OpenRead())
            {
                string currentFileName = fileToDecompress.FullName;
                string newFileName = currentFileName.Remove(currentFileName.Length - fileToDecompress.Extension.Length);

                using (FileStream decompressedFileStream = File.Create(newFileName))
                {
                    using (DeflateStream decompressionStream = new DeflateStream(originalFileStream, CompressionMode.Decompress))
                    {
                        decompressionStream.CopyTo(decompressedFileStream);
                        Console.WriteLine("Decompressed: {0}", fileToDecompress.Name);
                    }
                }
            }
        }



        private void btn_SelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "cmp files (*.cmp) | *.cmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string temp;
                temp = openFileDialog.FileName;
                
                label4.Text = temp + "  file selected.";
                fileForDecompression = @temp;
            }
        }

        private void btn_Decompress_Click(object sender, EventArgs e)
        {
            FileInfo fileToDecompress = new FileInfo(fileForDecompression);
            Decompress(fileToDecompress);
            label4.Text = "File decompressed at " + fileForDecompression;
        }
    }
}
