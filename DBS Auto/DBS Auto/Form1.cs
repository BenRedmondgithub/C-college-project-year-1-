using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBS_Auto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declare and intialize program constants
        const double OIL_CHANGE_COST = 50.00;
        const double LUBE_JOB_COST = 20.00;
        const double RADIATOR_FLUSH_COST = 60.00;
        const double TRANSMISSION_FLUSH_COST = 100.00;
        const double INSPECTION_COST = 10.00;
        const double MUFFLER_REPLACEMENT_COST = 200.00;
        const double TIRE_ROTATION_COST = 30.00;
        const double LABOR_COST_PER_HOUR = 30.00;
        const double TAX_RATE = 0.10;

        // Declare and intialize more constants
        double laborCost = 0.00;
        double partsCost = 0.00;
        double subTotal = 0.00;
        double taxCost = 0.00;
        double finalCost = 0.00;

        // create string to convert into text boxes
        string oilCharge = "Oil Charge" + OIL_CHANGE_COST.ToString("c");
        String lubeChange = "Lube Charge" + LUBE_JOB_COST.ToString("c");
        String RadiatorCharge = "RadiatorCharge" + RADIATOR_FLUSH_COST.ToString("c");
        string TransCharge = "Transmiss Charge" + TRANSMISSION_FLUSH_COST.ToString("c");
        String inspectCharge = "Inspection Charge" + INSPECTION_COST.ToString("c");
        string mufflerCharge = "Muffler Charge" + MUFFLER_REPLACEMENT_COST.ToString("c");
        string tireCharge = "Tire Rotation Charge" + TIRE_ROTATION_COST.ToString("c");
        String partsTotalCharge = "Parts Total Charge";
        string laborTotalCharge = "Labor Total";
        string subTotalCharge = "Sub Total";
        String taxTotalCharge = "Tax Total";
        string finalTotalCharge = "Final Total: ";

        
        private void calculateButton_Click(object sender, EventArgs e)
        {   //reseting the final costs and clearing all items for bill list box
            finalCost = 0.0;
            billListbox.Items.Clear();
            OilLubeCharges();
            FlushCharge();
            MiscCharges();
            PartCharges();
            laborTotalCharges();
            TaxCharge();
            finalTotalCharges();
            displayBill();
        }
       // Method to  calculate oil and lube charges 
        private void OilLubeCharges()
        {
            if (chkOilChange.Checked) 
            {
                subTotal += OIL_CHANGE_COST;
            }
            else if (chkLubeJob.Checked) 
            {
                subTotal += LABOR_COST_PER_HOUR;
            }
        }
        // Method to calculate flush charges
        private void FlushCharge() 
        
        {
            if (chkRadiatorFlush.Checked)
            {
                subTotal += RADIATOR_FLUSH_COST;
            }
           else if (chkTransmissionFlush.Checked)
            {
                subTotal += TRANSMISSION_FLUSH_COST;
            }
        }
        // Method to calculate all Misc charges
        private void MiscCharges() 
        { 

        if (chkInspection.Checked) 
            {
                subTotal += INSPECTION_COST;
            }
        if (chkMufflerReplacement.Checked) 
        {
                subTotal += MUFFLER_REPLACEMENT_COST;
        }

        if (chkTire.Checked) 
            {
                subTotal += TIRE_ROTATION_COST;
            }
        }
        // Method to calculate Part charges
        private void PartCharges () 
        { 
        if (partsTextBox.Text == "") 
            {
                partsTextBox.Text = "0.00";
            }
              try
              {
                string temp = partsTextBox.Text.ToString();
                if (!double.TryParse(temp, out partsCost));

              } catch(Exception ex)
            {
                MessageBox.Show("Error. Setting Part to 0\n");

            }

        }
        // Mothod to calculate Labor total
        private void laborTotalCharges()
        {
            if (laborTextBox.Text == "") 
            {
                laborTextBox.Text = "0.00";
            }
            try 
                
            { string temp = laborTextBox.Text.ToString();
              if (!double.TryParse(temp, out laborCost));
            
            } 
            
            catch (Exception ex) 
            {
                MessageBox.Show("error please select labor");
            }
                finally 
            {
                subTotal += LABOR_COST_PER_HOUR;
                laborTextBox.Text = LABOR_COST_PER_HOUR.ToString();
            } 

        }
        // Method to calculate Tax charges
        private void TaxCharge()
        {
            taxCost = subTotal * TAX_RATE;
        }
        //Method to calculate Total cost
        private void finalTotalCharges() 
        {
            finalCost = subTotal + taxCost;
        }
        // Method to display the bill
        private void displayBill() 
        
        {
            DisplayOilLubecharges();
            DisplayFlushCharges();
            DisplayMiscCharges();
            DisplayPartsandLaborCharges();
            DisplaysubtaxFinaltotal();

        }
        // Method to Display oil and lube charges
        private void DisplayOilLubecharges () 
        { 
      
            if (chkOilChange.Checked) 
            {
                billListbox.Items.Add(oilCharge);
            }
            else if (chkLubeJob.Checked) 
            {
                billListbox.Items.Add(lubeChange);
            }

        }
        // Method to Display Flush charges
        private void DisplayFlushCharges() 
        
        { 
         if (chkRadiatorFlush.Checked) 
            {
                billListbox.Items.Add(RADIATOR_FLUSH_COST);
            }

         if (chkTransmissionFlush.Checked) 
            {
                billListbox.Items.Add(TRANSMISSION_FLUSH_COST);
            }
        }
        // Method to Display Misc charges
        private void DisplayMiscCharges () 
        { 
        if (chkInspection.Checked) 
            {
                billListbox.Items.Add(INSPECTION_COST);
            }
        if (chkMufflerReplacement.Checked) 
            {
                billListbox.Items.Add(MUFFLER_REPLACEMENT_COST);
            }
        if (chkTire.Checked)
            {
                billListbox.Items.Add(TIRE_ROTATION_COST);
            }
        }
        // Method to Display Parts and Labor charges
        private void DisplayPartsandLaborCharges() 
        
        {
            billListbox.Items.Add(partsTotalCharge + partsCost.ToString("c"));
            billListbox.Items.Add(laborCost + laborCost.ToString("c"));
        }
        // Method to Display sub tax Final total charges
        private void DisplaysubtaxFinaltotal() 
        
        { 
            billListbox.Items.Add(subTotalCharge + subTotal.ToString("c"));
            billListbox.Items.Add(taxTotalCharge + taxCost.ToString("c"));
            billListbox.Items.Add(finalTotalCharge + finalCost.ToString("c"));
        
        }
        // Clear all items from the bill list box
        private void clearButton_Click(object sender, EventArgs e)
        {
            clearall();

            billListbox.Items.Clear();
        }
        // Method to clear all input fields
        private void clearall() 
        {
            ClearOilLubeBox();
            ClearFlushes();
            ClearMicsBox();
            ClearpartsandlaborBox();
        }
        // Method to clear oil and lube checkboxes
        private void ClearOilLubeBox()
        {
            chkOilChange.Checked = false;
            chkLubeJob.Checked = false;
        }
        // Method to cleal Flushes checkboxes
        private void ClearFlushes() 
        { 
            chkRadiatorFlush.Checked = false;
            chkTransmissionFlush.Checked = false;
        }
        // Method to clear Misc checkboxes
        private void ClearMicsBox()
        {
            chkInspection.Checked = false;
            chkMufflerReplacement.Checked = false;
            chkTire.Checked = false;
        }
        // Method to clear parts and labor checkboxes
        private void ClearpartsandlaborBox() 
        { 
            partsTextBox.Text = " ";
            laborTextBox.Text = " ";
        }
        // Method to clear all items from bill listbox
        private void ClearBill() 
        {
        billListbox.Items.Clear();
            subTotal = 0.0;
            taxCost = 0.0;
            finalCost = 0.0;
        }
        // To close the program (no method needed)
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
