
namespace CarShopSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPurchase = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.home2 = new CarShopSystem.Home();
            this.purchaseInfo2 = new CarShopSystem.PurchaseInfo();
            this.dataBase1 = new CarShopSystem.DataBase();
            this.contactUs2 = new CarShopSystem.ContactUs();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.btnPurchase);
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 687);
            this.panel1.TabIndex = 0;
            // 
            // btnPurchase
            // 
            this.btnPurchase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPurchase.FlatAppearance.BorderSize = 0;
            this.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchase.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPurchase.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnPurchase.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPurchase.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPurchase.Location = new System.Drawing.Point(0, 200);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(200, 100);
            this.btnPurchase.TabIndex = 3;
            this.btnPurchase.Text = "Purchase Info";
            this.btnPurchase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("MV Boli", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Weixin;
            this.iconButton3.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 35;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 632);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(200, 55);
            this.iconButton3.TabIndex = 1;
            this.iconButton3.Text = "Contact Us";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Wpforms;
            this.iconButton2.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 100);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(200, 100);
            this.iconButton2.TabIndex = 0;
            this.iconButton2.Text = "Cars Window";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconButton1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(200, 100);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Home";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.contactUs2);
            this.panel2.Controls.Add(this.dataBase1);
            this.panel2.Controls.Add(this.purchaseInfo2);
            this.panel2.Controls.Add(this.home2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1262, 687);
            this.panel2.TabIndex = 1;
            // 
            // home2
            // 
            this.home2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.home2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home2.Location = new System.Drawing.Point(0, 0);
            this.home2.Name = "home2";
            this.home2.Size = new System.Drawing.Size(1262, 687);
            this.home2.TabIndex = 0;
            // 
            // purchaseInfo2
            // 
            this.purchaseInfo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.purchaseInfo2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchaseInfo2.Location = new System.Drawing.Point(0, 0);
            this.purchaseInfo2.Name = "purchaseInfo2";
            this.purchaseInfo2.Size = new System.Drawing.Size(1262, 687);
            this.purchaseInfo2.TabIndex = 1;
            // 
            // dataBase1
            // 
            this.dataBase1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dataBase1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataBase1.Location = new System.Drawing.Point(0, 0);
            this.dataBase1.Name = "dataBase1";
            this.dataBase1.Size = new System.Drawing.Size(1262, 687);
            this.dataBase1.TabIndex = 2;
            // 
            // contactUs2
            // 
            this.contactUs2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.contactUs2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contactUs2.Location = new System.Drawing.Point(0, 0);
            this.contactUs2.Name = "contactUs2";
            this.contactUs2.Size = new System.Drawing.Size(1262, 687);
            this.contactUs2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 687);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel2;
        private DataBase dataBase2;
        private Home home1;
        private FontAwesome.Sharp.IconButton btnPurchase;
        private PurchaseInfo purchaseInfo1;
        private ContactUs contactUs1;
        private ContactUs contactUs2;
        private DataBase dataBase1;
        private PurchaseInfo purchaseInfo2;
        private Home home2;
    }
}

