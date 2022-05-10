using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //variable declarations
            double fatConsumed;
            double carbohydratesConsumed;
            double caloriesFromFat, caloriesFromCarbohydrates;
            //get the fat grams consumed, display error message if invalid input is entered
            if (!(Double.TryParse(txtFatConsumed.Text, out fatConsumed)))
            {
                MessageBox.Show("Invalid input for fat grams consumed.", "Input Error");
                txtFatConsumed.Focus();
            }
            //get the carbohydrates grams consumed, display error message if invalid input is entered
            else if (!(Double.TryParse(txtCrabsConsumed.Text, out carbohydratesConsumed)))
            {
                MessageBox.Show("Invalid input for fat grams consumed.", "Input Error");
            }
            //if inputs are valid perform the caluclations
            else
            {
                //calculate the calories from fat
                caloriesFromFat = fatConsumed * 9;
                //calculate the calories from carbohydrates
                caloriesFromCarbohydrates = carbohydratesConsumed * 4;
                //display result
                lblCalories.Text = "Calories from Fat = " + caloriesFromFat + "\nCalories from Carbohydrates = " + caloriesFromCarbohydrates;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the application when exit button is clicked
            this.Close();
        }
    }
}