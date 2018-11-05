using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Name_Generator_Winform
{
    public partial class Form1 : Form
    {
        public string[] FirstNames = {"Milan", "Josh", "Daniel", "Mason", "Max", "Levi" };

        public string[] LastNames = { "Bryant", "James", "Iverson", "O'Neal", "Durant", "Jordan" };

        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            int indexFirstName = rand.Next(FirstNames.Length);
            int indexLastName = rand.Next(LastNames.Length);

            this.txtbox_FirstName.Text = FirstNames[indexFirstName];
            this.txtbox_LastName.Text = LastNames[indexLastName];
        }
    }
}
