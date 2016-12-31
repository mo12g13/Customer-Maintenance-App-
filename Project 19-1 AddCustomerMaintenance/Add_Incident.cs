using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_19_1_AddCustomerMaintenance
{
    public partial class frmAddIncidents : Form
    {
        string customerNameValue;
        string customerIDValue;
        //A event handler for the Add Incident that sets the CustomerID and Customer name
        public frmAddIncidents(string customerID, string customerName)
        {
            InitializeComponent();
            customerIDValue= customerID;
            customerNameValue = customerName;
        }

       // A form loads event that adds set CustomerId and name of the client
        private void frmAddIncidents_Load(object sender, EventArgs e)
        {
            customerIDTextBox.Text = customerIDValue;
            nameTextBox.Text = customerNameValue;

            //// TODO: This line of code loads data into the 'techSupport_DataDataSet.Customers' table. You can move, or remove it, as needed.
            //this.customersTableAdapter.Fill(this.techSupport_DataDataSet.Customers);
            //// TODO: This line of code loads data into the 'techSupport_DataDataSet.Incidents' table. You can move, or remove it, as needed.
           //this.incidentsTableAdapter.Fill(this.techSupport_DataDataSet.Incidents);
            // TODO: This line of code loads data into the 'techSupport_DataDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.techSupport_DataDataSet.Products);

        }

        // The cancel button of the add Incident form
        private void btnCacel_Click(object sender, EventArgs e)
        {
            this.incidentsBindingSource.CancelEdit();//Cancel the edit
            this.Close(); // Close the form
        }

        //The add button of the incident form
        //Add button not adding record to the database
        //TODO I need to work on getting the add button to add record to the database
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.incidentsBindingSource.AddNew();
            this.tableAdapterManager.UpdateAll(techSupport_DataDataSet);
          
        }
    }
}
