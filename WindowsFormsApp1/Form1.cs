using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)

        {
           
          
            bool status = Validate_prüfen(textBox1.Text, textBox2.Text);
            Console.WriteLine(status);
        

        }
        private bool Validate_prüfen(String Username, String Passwort)
        {
            String UserEmail = "12@34.com";
            String UserPasswort = "1234";
            textBox1.Clear();
            textBox2.Clear();
            Console.WriteLine(Username + Passwort);

            if (UserEmail == Username && UserPasswort == Passwort) return true;
            
            else return false;
        }


    }
}

