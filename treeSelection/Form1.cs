using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace treeSelection
{
    public partial class Form1 : Form
    {
        string connstr = "server=10.6.0.127;" +
            "port=3306;" +
            "user=PC1;" +
            "password=1111;" +
            "database=trees_zaimov";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string InserSQL = "INSERT INTO trees_zaimov.razred " +
                "(`name`,`name_bg`) " +
                "VALUES (@name,@name_bg)";





            MySqlConnection connect = new MySqlConnection(connstr);
            if (connect.State == 0) connect.Open();
            MessageBox.Show("ti se svurza");


            MySqlCommand query = new MySqlCommand(InserSQL, connect);

            query.Parameters.AddWithValue("@name", textBox1.Text);
            query.Parameters.AddWithValue("@name_bg", textBox2.Text);

            query.ExecuteNonQuery();

            MessageBox.Show("dobaven zapis!!");
            connect.Close();

        }
    }
}
