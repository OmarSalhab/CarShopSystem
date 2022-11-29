using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShopSystem
{
    public partial class Form1 : Form
    {
        //Fields 
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 100);
            panel1.Controls.Add(leftBorderBtn);
        }
        //struct
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
        }

            private void Form1_Load(object sender, EventArgs e)
            {
            ActivateButton(iconButton1, RGBColors.color1);
            contactUs2.Hide(); 
             purchaseInfo2.Hide();
             dataBase1.Hide();
            }
            //Methods
            private void ActivateButton(object senderBtn, Color color)
            {

                if (senderBtn != null)
                {
                     DisableButton();

                    //Button
                    currentBtn = (IconButton)senderBtn;
                    currentBtn.BackColor = Color.FromArgb(37, 36, 87);
                    currentBtn.ForeColor = color;
                    currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                    currentBtn.IconColor = color;
                    currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                    currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                    //Left Border button 
                    leftBorderBtn.BackColor = color;
                    leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                    leftBorderBtn.Visible = true;
                    leftBorderBtn.BringToFront();
                   
                }
            }
            private void DisableButton()
             {
                if (currentBtn != null)
                {
                    currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                    currentBtn.ForeColor = Color.Gainsboro;
                    currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                    currentBtn.IconColor = Color.Gainsboro;
                    currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                    currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                }
              }
            private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            purchaseInfo2.Hide();
            contactUs2.Hide();
            dataBase1.Hide();
            home2.Show();
            home2.BringToFront();
            
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            contactUs2.Hide();
            purchaseInfo2.Hide();
            home2.Hide();
            dataBase1.Show();
            dataBase1.BringToFront();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            home2.Hide();
            dataBase1.Hide();
            purchaseInfo2.Hide();
            contactUs2.Show();
            contactUs2.BringToFront();

        }

        private void home1_Load(object sender, EventArgs e)
        {

        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            contactUs2.Hide();
            home2.Hide();
            dataBase1.Hide();
            purchaseInfo2.Show();
            purchaseInfo2.BringToFront();

        }

        private void purchaseInfo1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
