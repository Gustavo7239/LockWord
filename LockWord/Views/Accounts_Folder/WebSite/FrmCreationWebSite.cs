﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LockWord.Views
{
    public partial class FrmCreationWebSite : Form
    {
        private string defImageName = "";
        private string imageName = "";
        private Color colorIte = Color.Black;

        public static String rutaBD = Path.Combine(Application.StartupPath, "DataBase\\LocalWord.sqlite");
        SQLiteHelper sqlh = new SQLiteHelper(rutaBD);

        public FrmCreationWebSite()
        {
            InitializeComponent();
            this.BackColor = colorIte;
        }
        private void BtnControlWindowAction_Click(object sender, EventArgs e)
        {
            LWButtonActions bt = (LWButtonActions)sender;
            if (bt.Name == "BtnClose")
            {
                this.Close();
            }
            else if (bt.Name == "BtnMinimize")
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void PnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BrnCreate_Click(object sender, EventArgs e)
        {
            if (isReadyToInsert())
            {
                string WebName = TxtWebName.Text;
                string link = TxtLink.Text;
                string description = TxtDescription.Text;
                SaveImage();

                WebSite ws = new WebSite
                {
                    ID = 0,
                    WebName = WebName,
                    Link = link,
                    Description = description,
                    ImageName = imageName,
                    IsFontWhite = isWhite(),
                    ItemColor = colorIte
                };

                sqlh.AddWebSite(ws);

                MessageBox.Show("Website added successfully.");

                this.Close();
            }
            else
            {
                MessageBox.Show("Please complete all fields.");
            }
            
        }

        private bool isWhite()
        {
            bool val = false;
            if(LblNameWebSite.ForeColor == Color.White)
            {
                val = true;
            }
            return val;
        }

        private bool isReadyToInsert()
        {
            bool value = false;

            if (
                TxtWebName.Text != "" ||
                TxtLink.Text != "" ||
                TxtDescription.Text != "" 
                )
            {
                value = true; 
            }

            return value;
        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            TxtWebName.Text = "";
            TxtLink.Text = "";
            TxtDescription.Text = "";
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPhotoWebSite_Click(object sender, EventArgs e)
        {
            defImageName = SelectImage(); //ruta de la imagen 

            if (!string.IsNullOrEmpty(defImageName))
            {
                // Here you can save the image path into a variable or do anything else with it
                Console.WriteLine("Selected image: " + defImageName);
                PctPhotoWebSite.ImageLocation = defImageName;
            }
            else
            {
                Console.WriteLine("No image selected.");
            }
        }
        public string SelectImage()
        {
            string imagePath = null;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All files|*.*";
            openFileDialog.Title = "Select an image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;
                BtnPhotoWebSite.Text = imagePath;
            }else
            {
                BtnPhotoWebSite.Text = "Choose one foto for the WebSite";
            }

            return imagePath;
        }

        public void SaveImage()
        {
            string destinationFolder = Path.Combine(Application.StartupPath, "Images");
            string imagePath = defImageName; 
            imageName = Path.GetFileName(imagePath);

            string destinationPath = Path.Combine(destinationFolder, imageName);

            try
            {
                File.Copy(imagePath, destinationPath, true);
                Console.WriteLine("Image saved successfully to: " + destinationPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving image: " + ex.Message);
            }
        }

        private void TxtWebName_TextChanged(object sender, EventArgs e)
        {
            LblNameWebSite.Text = TxtWebName.Text;
        }

        private void BtnChangeColorBackground_Click(object sender, EventArgs e)
        {
            Color c = GenerarColorParaTarjetaCredito();
            colorIte = c;
            PnlPreview.BackColor = colorIte;
        }
        private Color GenerarColorParaTarjetaCredito()
        {
            Random rnd = new Random();

            int red = rnd.Next(100, 256); // Componente rojo entre 100 y 255
            int green = rnd.Next(100, 256); // Componente verde entre 100 y 255
            int blue = rnd.Next(100, 256); // Componente azul entre 100 y 255

            return Color.FromArgb(red, green, blue);
        }

        private void BtnChangeColorTxt_Click(object sender, EventArgs e)
        {
            if (BtnChangeColorTxt.IconColor == Color.White)
            {
                BtnAddAccount.IconColor = Color.Black;
                LblNameWebSite.ForeColor = Color.Black;
                BtnChangeColorTxt.IconColor = Color.Black;
                BtnChangeColorBackground.IconColor = Color.Black;
            }
            else
            {
                BtnAddAccount.IconColor = Color.White;
                LblNameWebSite.ForeColor = Color.White;
                BtnChangeColorTxt.IconColor = Color.White;
                BtnChangeColorBackground.IconColor = Color.White;
            }
        }
    }
}
