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
    public partial class frmFindCustomer : Form
    {
        public frmFindCustomer()
        {
            InitializeComponent();
        }

     
        //A form load event loads the find customer form. 
        private void Find_Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'techSupport_DataDataSet.Customers' table. You can move, or remove it, as needed.
        //this.customersTableAdapter.Fill(this.techSupport_DataDataSet.Customers);

        }

        //A event handler that query the customer form by state
        private void findCustomerStateToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                string stateName = stateToolStripTextBox.Text;             
                
                    this.customersTableAdapter.FindCustomerState(this.techSupport_DataDataSet.Customers, stateName);
                
                
            }
            catch (FormatException)
            {
                MessageBox.Show("State name must be a character", "Entry Error");
            }
            catch (SqlException)
            {
                MessageBox.Show("Error connecting to database", "Connection error...");
            }

        }

        //A customer datagridview event that with a double mouse event
        private void customersDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
            if(customersDataGridView.SelectedCells.Count > 0)
            {
                int selectedrowIndex = customersDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectRow = customersDataGridView.Rows[selectedrowIndex];
                string customerID = Convert.ToString(selectRow.Cells[0].Value);
                string customerName = Convert.ToString(selectRow.Cells[2].Value);
               
                frmAddIncidents addIncident = new frmAddIncidents(customerID, customerName);
                addIncident.ShowDialog();
            }               
            


        }
        
        //Ok button that display the incident form when the ok button is clicked
        private void btnOk_Click(object sender, EventArgs e)
        {
            int selectedrowIndex = customersDataGridView.SelectedCells[0].RowIndex;
            DataGridViewRow selectRow = customersDataGridView.Rows[selectedrowIndex];
            string customerID = Convert.ToString(selectRow.Cells[0].Value);
            string customerName = Convert.ToString(selectRow.Cells[2].Value);

            frmAddIncidents addIncident = new frmAddIncidents(customerID, customerName);
            addIncident.ShowDialog();
        }

        //The cancel buttong that cancels the find customer form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            customersBindingSource.CancelEdit();//Cancel the edit and close 
            this.Close();//Clos the form
        }
    }
}
