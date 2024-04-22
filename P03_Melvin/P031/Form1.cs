using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P031
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Varaiables
        double TOTAL = 0;
        const decimal DRINKS = 1;
        const double SIDES = 1;
        const double SMALL = 7.25;
        const double MEDIUM = 13.75;
        const double LARGE = 16.50;

        int thinCrust = 0;
        double thickCrust = 1.00;
        double panCrust = 1.50;
        double Toppings = 0.5;




        private void btnOrder_Click(object sender, EventArgs e)
        {
            try
            {

                //PIZZA SIZE
                if (rdoSmlPizza.Checked)
                {
                    TOTAL += SMALL;
                }
                else if (rdoMedPizza.Checked)
                {
                    TOTAL += MEDIUM;
                }
                else if (rdoLrgPizza.Checked)
                {
                    TOTAL += LARGE;
                }

                //CRUST
                if (rdoThin.Checked)
                {
                    TOTAL += thinCrust;
                }
                else if (rdoThick.Checked)
                {
                    TOTAL += thickCrust;
                }
                else if (rdoPan.Checked)
                {
                    TOTAL += panCrust;
                }

                // TOPPINGS
                if (chkBacon.Checked)
                {
                    TOTAL += Toppings;
                }
                if (chkBOlives.Checked)
                {
                    TOTAL += Toppings;
                }
                if (chkGOlives.Checked)
                {
                    TOTAL += Toppings;
                }
                if (chkHamburger.Checked)
                {
                    TOTAL += Toppings;
                }
                if (chkMushrooms.Checked)
                {
                    TOTAL += Toppings;
                }
                if (chkOnions.Checked)
                {
                    TOTAL += Toppings;
                }

                // SIDES
                if (chkCheeseBread.Checked)
                {
                    TOTAL += SIDES;
                }
                if (chkSalad.Checked)
                {
                    TOTAL += SIDES;
                }
                if (chkFriedCheeseSticks.Checked)
                {
                    TOTAL += SIDES;
                }
            }
            catch 
            {
                if (TOTAL < 0)
                {
                    Close();
                }
            }

            var result = MessageBox.Show("Is this what you want ?", "orders", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                label1.Text = "";
                MessageBox.Show("Total:  $" + TOTAL.ToString());
                TOTAL = 0;
            }
            else if(result == DialogResult.No)
            {
                label1.Text = "";
                TOTAL = 0;
            }

        }


        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All ingredients are fresh when the pizza is delivered. If you have any questions about the amount of fat," +
                            " salt, or calories that is in the pizza then you probably should not order one. :)");
        }

    }
}
