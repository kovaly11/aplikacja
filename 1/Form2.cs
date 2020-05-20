using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Forms;


namespace _1
{
    public partial class Form2 : MetroForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Count cnt = new Count();
            if (Ubutton.Checked)
            {               
                Double.TryParse(Usd.Text, out double temp);
                cnt.temp = temp;
                Pln.Text = cnt.UsdToPln().ToString(); 
                Eur.Text = cnt.UsdToEUR().ToString(); 
            }
            if (Ebutton.Checked)
            {
                Double.TryParse(Eur.Text, out double temp);
                cnt.temp = temp;
                Pln.Text = cnt.EURToPln().ToString(); 
                Usd.Text = cnt.EURToUsd().ToString();
            }

            if (Pbutton.Checked)
            {
                Double.TryParse(Pln.Text, out double temp);
                cnt.temp = temp;
                Usd.Text = cnt.PlnToUSD().ToString();
                Eur.Text = cnt.PlnToEUR().ToString();
            }


        }
    }
    }
