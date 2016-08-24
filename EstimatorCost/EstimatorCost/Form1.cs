using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstimatorCost
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;

        public Form1()
        {
            InitializeComponent();

            dinnerParty = new DinnerParty((int)numericUpDown1.Value, cbxHealtyDecoration.Checked, cbxFancyDecoration.Checked);
            DisplayDinnerPartyCost();
        }        

        private void cbxFancyDecoration_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = cbxFancyDecoration.Checked;
            DisplayDinnerPartyCost();
        }

        private void cbxHealtyDecoration_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = cbxHealtyDecoration.Checked;
            DisplayDinnerPartyCost();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // Converte o valor de "numericUpDown" para um int porque é uma propriedade do tipo Int.
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.Cost;
            txtCost.Text = Cost.ToString("c");
        }
    }
}
