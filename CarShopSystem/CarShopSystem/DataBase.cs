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
    public partial class DataBase : UserControl
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LENOVO\Desktop\Database1.accdb");

        int count = 0;

        public DataBase()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.TextLength) >= 1)

            {


                con.Open();

                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into table1 values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";


                MessageBox.Show("Data inserted successfully");

            }
            else
                MessageBox.Show("Fill all the TextBoxs above Please");
            
        }

        private void btnView_Click(object sender, EventArgs e)
        {

            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from table1";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();

        }

      

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.TextLength) >=1)
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete FROM table1 WHERE CarId= " + textBox1.Text + " ";
                cmd.ExecuteNonQuery();

                con.Close();

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";

                MessageBox.Show("Data deleted successfully");
            }
            else
                MessageBox.Show("Please Put The Car ID First");

        }






        private void btnUpdate_Click(object sender, EventArgs e)
        {

            con.Open();

            OleDbCommand cmd = con.CreateCommand();

            string sql = "UPDATE table1 SET CarId= @CarId, CarManufacturer = @CarManufacturer, CarModel = @CarModel ,CarModelYear = @CarModelYear ,CarColor = @CarColor ,CarPrice = @CarPrice ,CarStock=@CarStock where CarId= @CarId";
            cmd = new OleDbCommand(sql, con);

            cmd.Parameters.Add("@CarId", textBox1.Text);
            cmd.Parameters.Add("@CarManufacturer", textBox2.Text);
            cmd.Parameters.Add("@CarModel", textBox3.Text);
            cmd.Parameters.Add("@CarModelYear", textBox4.Text);
            cmd.Parameters.Add("@CarColor", textBox5.Text);
            cmd.Parameters.Add("@CarPrice", textBox6.Text);
            cmd.Parameters.Add("@CarStock", textBox7.Text);



            cmd.ExecuteNonQuery();

            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";

            MessageBox.Show("Data updated successfully");

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

            count = 0;
            con.Open();

            OleDbCommand cmd = con.CreateCommand();

            // have to delete the parameters that you dont want in the sreach or make an if statment to sort it out

            string sql = "select * from table1 where CarId= @CarId and CarManufacturer = @CarManufacturer and CarModel = @CarModel ";
            cmd = new OleDbCommand(sql, con);

            cmd.Parameters.Add("@CarId", textBox1.Text);
            cmd.Parameters.Add("@CarManufacturer", textBox2.Text);
            cmd.Parameters.Add("@CarModel", textBox3.Text);
            cmd.Parameters.Add("@CarModelYear", textBox4.Text);
            cmd.Parameters.Add("@CarColor", textBox5.Text);
            cmd.Parameters.Add("@CarPrice", textBox6.Text);
            cmd.Parameters.Add("@CarStock", textBox7.Text);

            cmd.ExecuteNonQuery();



            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);

            count = Convert.ToInt32(dt.Rows.Count.ToString());


            dataGridView1.DataSource = dt;

            if (count == 0)
            {
                MessageBox.Show("Result is not found in the database", "Checked");
            }
            else
            {
                MessageBox.Show("Result is in the database", "Checked");
            }



            con.Close();





        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            con.Open();

            OleDbCommand cmd = con.CreateCommand();


            string sql = "select * from table1 where  CarManufacturer = '" + textBox8.Text + "' or CarManufacturer like '%" + textBox8.Text + "%' ";
            cmd = new OleDbCommand(sql, con);

            cmd.Parameters.Add("@CarId", textBox1.Text);
            cmd.Parameters.Add("@CarManufacturer", textBox2.Text);
            cmd.Parameters.Add("@CarModel", textBox3.Text);
            cmd.Parameters.Add("@CarModelYear", textBox4.Text);
            cmd.Parameters.Add("@CarColor", textBox5.Text);
            cmd.Parameters.Add("@CarPrice", textBox6.Text);
            cmd.Parameters.Add("@CarStock", textBox7.Text);

            cmd.ExecuteNonQuery();



            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);




            dataGridView1.DataSource = dt;



            con.Close();


        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();


            string sql = "select * from table1 where  CarModel = '" + textBox9.Text + "' or CarModel like '%" + textBox9.Text + "%' ";
            cmd = new OleDbCommand(sql, con);

            cmd.Parameters.Add("@CarId", textBox1.Text);
            cmd.Parameters.Add("@CarManufacturer", textBox2.Text);
            cmd.Parameters.Add("@CarModel", textBox3.Text);
            cmd.Parameters.Add("@CarModelYear", textBox4.Text);
            cmd.Parameters.Add("@CarColor", textBox5.Text);
            cmd.Parameters.Add("@CarPrice", textBox6.Text);
            cmd.Parameters.Add("@CarStock", textBox7.Text);

            cmd.ExecuteNonQuery();

            

            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);




            dataGridView1.DataSource = dt;



            con.Close();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

            con.Open();

            OleDbCommand cmd = con.CreateCommand();


            string sql = "select * from table1 where  CarColor = '" + textBox11.Text + "' or CarColor like '%" + textBox11.Text + "%' ";
            cmd = new OleDbCommand(sql, con);

            cmd.Parameters.Add("@CarId", textBox1.Text);
            cmd.Parameters.Add("@CarManufacturer", textBox2.Text);
            cmd.Parameters.Add("@CarModel", textBox3.Text);
            cmd.Parameters.Add("@CarModelYear", textBox4.Text);
            cmd.Parameters.Add("@CarColor", textBox5.Text);
            cmd.Parameters.Add("@CarPrice", textBox6.Text);
            cmd.Parameters.Add("@CarStock", textBox7.Text);

            cmd.ExecuteNonQuery();



            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);




            dataGridView1.DataSource = dt;



            con.Close();

        }

        private void DataBase_Load(object sender, EventArgs e)
        {

        }
    }
}
