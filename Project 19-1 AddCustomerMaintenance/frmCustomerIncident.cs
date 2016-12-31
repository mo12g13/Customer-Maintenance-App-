using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_19_1_AddCustomerMaintenance
{
    public partial class frmCustomerIncident : Form
    {
        
        public frmCustomerIncident()
        {
            
            InitializeComponent();
        }

        // A form load event that loads the data into the incident form
        private void frmcustomIncident_Load(object sender, EventArgs e)
        {
            
            this.incidentsTableAdapter.Fill(this.techSupport_DataDataSet.Incidents);
            // TODO: This line of code loads data into the 'techSupport_DataDataSet.Customers' table. You can move, or remove it, as needed.
            //this.customersTableAdapter.Fill(this.techSupport_DataDataSet.Customers);

        }

        //A event handler that query the Customer Incident Form
        private void findCustomersToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
               
                int customerIDValue = Convert.ToInt32(customerIDToolStripTextBox.Text);
                
                
                    this.customersTableAdapter.FindCustomers(this.techSupport_DataDataSet.Customers, customerIDValue);
                
                
            }
            catch (FormatException)
            {
                MessageBox.Show("CustomerID must be an integer", "Entry Error");
            }
            catch (SqlException)
            {
                MessageBox.Show("Error connecting to database", "Not Connecting....");
            }

        }
        // An event handler that loads the states when clicked
        private void stateLabel_Click(object sender, EventArgs e)
        {
            frmFindCustomer findCustomer = new frmFindCustomer();
            findCustomer.ShowDialog();
        }

        // A event handler that loads the incident form when the add new incident button is clicked on the customer incident form
        private void btnAddIncident_Click(object sender, EventArgs e)
        {
            frmAddIncidents addIncident = new frmAddIncidents(customerIDTextBox.Text, nameTextBox.Text);
            addIncident.ShowDialog();
        }
    }
}
