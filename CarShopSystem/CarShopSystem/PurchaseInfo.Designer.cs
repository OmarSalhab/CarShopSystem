
namespace CarShopSystem
{
    partial class PurchaseInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTax = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInstallment = new FontAwesome.Sharp.IconButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(380, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(754, 353);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconButton1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(186, 137);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(130, 47);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "View";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(104, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Car ID :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(186, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnTax
            // 
            this.btnTax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.btnTax.FlatAppearance.BorderSize = 0;
            this.btnTax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTax.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTax.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTax.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            this.btnTax.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTax.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTax.IconSize = 25;
            this.btnTax.Location = new System.Drawing.Point(346, 520);
            this.btnTax.Name = "btnTax";
            this.btnTax.Size = new System.Drawing.Size(130, 47);
            this.btnTax.TabIndex = 6;
            this.btnTax.Text = "Cash + Tax";
            this.btnTax.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTax.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTax.UseVisualStyleBackColor = false;
            this.btnTax.Click += new System.EventHandler(this.btnTax_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(181, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Years";
            // 
            // btnInstallment
            // 
            this.btnInstallment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.btnInstallment.FlatAppearance.BorderSize = 0;
            this.btnInstallment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstallment.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstallment.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInstallment.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.btnInstallment.IconColor = System.Drawing.Color.Gainsboro;
            this.btnInstallment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInstallment.IconSize = 25;
            this.btnInstallment.Location = new System.Drawing.Point(186, 520);
            this.btnInstallment.Name = "btnInstallment";
            this.btnInstallment.Size = new System.Drawing.Size(130, 47);
            this.btnInstallment.TabIndex = 8;
            this.btnInstallment.Text = "Car Installment";
            this.btnInstallment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInstallment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInstallment.UseVisualStyleBackColor = false;
            this.btnInstallment.Click += new System.EventHandler(this.btnInstallment_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(187, 462);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(129, 22);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.iconButton2.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 24;
            this.iconButton2.Location = new System.Drawing.Point(296, 439);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(18, 23);
            this.iconButton2.TabIndex = 10;
            this.iconButton2.Text = "iconButton2";
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(346, 462);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(130, 22);
            this.txtPrice.TabIndex = 11;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(341, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Car Price";
            // 
            // PurchaseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnInstallment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTax);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PurchaseInfo";
            this.Size = new System.Drawing.Size(1262, 687);
            this.Load += new System.EventHandler(this.PurchaseInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton btnTax;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnInstallment;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
    }
}
