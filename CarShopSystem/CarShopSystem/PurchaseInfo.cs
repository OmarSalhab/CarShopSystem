using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;


namespace CarShopSystem
{
    public partial class PurchaseInfo : UserControl
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LENOVO\Desktop\Database1.accdb");
        public PurchaseInfo()
        {
            InitializeComponent();
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.TextLength) >= 1)
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from table1 WHERE CarId= " + textBox1.Text + " ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();
            }
            else
                MessageBox.Show("Please Put The Car ID First");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PurchaseInfo_Load(object sender, EventArgs e)
        {
            
        }

       

        private void btnInstallment_Click(object sender, EventArgs e)
        {
            
           
            if (Convert.ToInt32(txtPrice.TextLength)>=1)
            {
                 int cprice;
                Double mpay = 0.0;

                cprice = Convert.ToInt32(txtPrice.Text);

                Double fpay = (cprice * 20) / 100;
                cprice = Convert.ToInt32(cprice - fpay);

                if (numericUpDown1.Value == 2)
                {


                    mpay = (cprice / (2 * 12)) + (cprice * 14 / 1885);

                }
                else if (numericUpDown1.Value == 4)
                {


                    mpay = (cprice / (4 * 12)) + (cprice * ((14 / 1885) * 2));
                }
                else if (numericUpDown1.Value == 6)
                {


                    mpay = (cprice / (6 * 12)) + (cprice * ((14 / 1885) * 4));
                }

                String r = Convert.ToString(mpay);
                MessageBox.Show("The Monthly Payment is : " + r + "JD \n\nAnd the first Payment Is : " + fpay + "JD");
            }
            else
                MessageBox.Show("Put the value of the car Please :) ");
        }

        private void btnTax_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtPrice.TextLength) >= 1)
            {

                Double tpay, cprice;

                cprice = Convert.ToInt32(txtPrice.Text);
                tpay = cprice + (cprice * 12 / 100);


                String r = Convert.ToString(tpay);
                String q = Convert.ToString(cprice);
                MessageBox.Show("The price Cash before Tax is  : " + q + "JD\n\nThe price Cash after Tax is : " + r + "JD");
            }
            else
                MessageBox.Show("Put the value of the car Please :) ");
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The number of years you will take the Installment for \n\'Monthly + Tax( 7% Yearly )\'");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
