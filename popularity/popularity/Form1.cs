using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace popularity
{
    public partial class PopulationForm : Form
    {
        public PopulationForm()
        {
            InitializeComponent();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Calulatebutton_Click(object sender, EventArgs e)
        {   
            // start of declary variable using doubles 
            double Orgen, IncreasePer, Days;

            //connect the variable that we just make to the textboxs and give them >= 1.0
            if (double.TryParse(organismsTextbox.Text, out Orgen) &&
                double.TryParse(dailyTextBox.Text, out IncreasePer) &&
                double.TryParse(daysTextBox.Text, out Days) &&
                Orgen >= 1.0 &&
                IncreasePer >= 1.0 &&
                Days >= 1.0) 
            {
                // create an other variable to hold the increase Amount for every day
                double increaseAmount;
                //convert the IncreasePer into a decimal
                IncreasePer = IncreasePer / 100;

                for (int day = 1; day <= Days; day++)
                {   //add a heading to the listbox
                    sumlistbox.Items.Add(day + " | " + Orgen);

                    increaseAmount = Orgen * IncreasePer;
                    // Calculate the next day's population based on the daily increase
                    Orgen += increaseAmount;
                }
            }
            else 
            {   // use message box to tell users if data is entered correctly 
                MessageBox.Show("The data entered is invaild");
            }
        }
        // clear out all Items is lisbox and textboxes
        private void clearButton_Click(object sender, EventArgs e)
        {
            sumlistbox.Items.Clear();

            organismsTextbox.Text = string.Empty;
            
            dailyTextBox.Text = string.Empty;
            
            daysTextBox.Text = string.Empty;
        }
    }
}
