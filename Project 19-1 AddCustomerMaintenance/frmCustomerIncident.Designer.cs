namespace Project_19_1_AddCustomerMaintenance
{
    partial class frmCustomerIncident
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label emailLabel;
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techSupport_DataDataSet = new Project_19_1_AddCustomerMaintenance.TechSupport_DataDataSet();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.incidentsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incidentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.findCustomersToolStrip = new System.Windows.Forms.ToolStrip();
            this.customerIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.customerIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.findCustomersToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.customersTableAdapter = new Project_19_1_AddCustomerMaintenance.TechSupport_DataDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new Project_19_1_AddCustomerMaintenance.TechSupport_DataDataSetTableAdapters.TableAdapterManager();
            this.incidentsTableAdapter = new Project_19_1_AddCustomerMaintenance.TechSupport_DataDataSetTableAdapters.IncidentsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            customerIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupport_DataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsBindingSource)).BeginInit();
            this.findCustomersToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(27, 53);
            customerIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(96, 18);
            customerIDLabel.TabIndex = 1;
            customerIDLabel.Text = "Customer ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(27, 89);
            nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(52, 18);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(27, 125);
            addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(66, 18);
            addressLabel.TabIndex = 5;
            addressLabel.Text = "Address:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(27, 161);
            cityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(107, 18);
            cityLabel.TabIndex = 7;
            cityLabel.Text = "City, State, Zip:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(24, 204);
            phoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(55, 18);
            phoneLabel.TabIndex = 13;
            phoneLabel.Text = "Phone:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(24, 238);
            emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(49, 18);
            emailLabel.TabIndex = 15;
            emailLabel.Text = "Email:";
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerID", true));
            this.customerIDTextBox.Location = new System.Drawing.Point(138, 48);
            this.customerIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.ReadOnly = true;
            this.customerIDTextBox.Size = new System.Drawing.Size(97, 24);
            this.customerIDTextBox.TabIndex = 2;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.techSupport_DataDataSet;
            // 
            // techSupport_DataDataSet
            // 
            this.techSupport_DataDataSet.DataSetName = "TechSupport_DataDataSet";
            this.techSupport_DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(138, 84);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(358, 24);
            this.nameTextBox.TabIndex = 4;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(138, 120);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ReadOnly = true;
            this.addressTextBox.Size = new System.Drawing.Size(358, 24);
            this.addressTextBox.TabIndex = 6;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(138, 161);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.ReadOnly = true;
            this.cityTextBox.Size = new System.Drawing.Size(174, 24);
            this.cityTextBox.TabIndex = 8;
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "State", true));
            this.stateTextBox.Location = new System.Drawing.Point(320, 161);
            this.stateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.ReadOnly = true;
            this.stateTextBox.Size = new System.Drawing.Size(44, 24);
            this.stateTextBox.TabIndex = 10;
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "ZipCode", true));
            this.zipCodeTextBox.Location = new System.Drawing.Point(372, 161);
            this.zipCodeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.ReadOnly = true;
            this.zipCodeTextBox.Size = new System.Drawing.Size(124, 24);
            this.zipCodeTextBox.TabIndex = 12;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(138, 193);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.ReadOnly = true;
            this.phoneTextBox.Size = new System.Drawing.Size(184, 24);
            this.phoneTextBox.TabIndex = 14;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(138, 232);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(358, 24);
            this.emailTextBox.TabIndex = 16;
            // 
            // incidentsDataGridView
            // 
            this.incidentsDataGridView.AutoGenerateColumns = false;
            this.incidentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incidentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.incidentsDataGridView.DataSource = this.incidentsBindingSource;
            this.incidentsDataGridView.Location = new System.Drawing.Point(27, 263);
            this.incidentsDataGridView.Name = "incidentsDataGridView";
            this.incidentsDataGridView.Size = new System.Drawing.Size(573, 128);
            this.incidentsDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IncidentID";
            this.dataGridViewTextBoxColumn1.HeaderText = "IncidentID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CustomerID";
            this.dataGridViewTextBoxColumn2.HeaderText = "CustomerID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ProductCode";
            this.dataGridViewTextBoxColumn3.HeaderText = "ProductCode";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DateOpened";
            this.dataGridViewTextBoxColumn4.HeaderText = "DateOpened";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DateClosed";
            this.dataGridViewTextBoxColumn7.HeaderText = "DateClosed";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn5.HeaderText = "Title";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn6.HeaderText = "Description";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // incidentsBindingSource
            // 
            this.incidentsBindingSource.DataMember = "FK_Incidents_Customers";
            this.incidentsBindingSource.DataSource = this.customersBindingSource;
            // 
            // findCustomersToolStrip
            // 
            this.findCustomersToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerIDToolStripLabel,
            this.customerIDToolStripTextBox,
            this.findCustomersToolStripButton,
            this.toolStripLabel1});
            this.findCustomersToolStrip.Location = new System.Drawing.Point(0, 0);
            this.findCustomersToolStrip.Name = "findCustomersToolStrip";
            this.findCustomersToolStrip.Size = new System.Drawing.Size(622, 27);
            this.findCustomersToolStrip.TabIndex = 17;
            this.findCustomersToolStrip.Text = "findCustomersToolStrip";
            // 
            // customerIDToolStripLabel
            // 
            this.customerIDToolStripLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDToolStripLabel.Name = "customerIDToolStripLabel";
            this.customerIDToolStripLabel.Size = new System.Drawing.Size(90, 24);
            this.customerIDToolStripLabel.Text = "CustomerID:";
            // 
            // customerIDToolStripTextBox
            // 
            this.customerIDToolStripTextBox.Name = "customerIDToolStripTextBox";
            this.customerIDToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // findCustomersToolStripButton
            // 
            this.findCustomersToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.findCustomersToolStripButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findCustomersToolStripButton.Name = "findCustomersToolStripButton";
            this.findCustomersToolStripButton.Size = new System.Drawing.Size(41, 24);
            this.findCustomersToolStripButton.Text = "Find";
            this.findCustomersToolStripButton.Click += new System.EventHandler(this.findCustomersToolStripButton_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(111, 24);
            this.toolStripLabel1.Text = "Search By State";
            this.toolStripLabel1.Click += new System.EventHandler(this.stateLabel_Click);
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.IncidentsTableAdapter = this.incidentsTableAdapter;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project_19_1_AddCustomerMaintenance.TechSupport_DataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // incidentsTableAdapter
            // 
            this.incidentsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(436, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 32);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add New Incident";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAddIncident_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Momo Johnson Project 19-1";
            // 
            // frmCustomerIncident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.findCustomersToolStrip);
            this.Controls.Add(this.incidentsDataGridView);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(this.zipCodeTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCustomerIncident";
            this.Text = "Customer Incidents";
            this.Load += new System.EventHandler(this.frmcustomIncident_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupport_DataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsBindingSource)).EndInit();
            this.findCustomersToolStrip.ResumeLayout(false);
            this.findCustomersToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TechSupport_DataDataSet techSupport_DataDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private TechSupport_DataDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private TechSupport_DataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private TechSupport_DataDataSetTableAdapters.IncidentsTableAdapter incidentsTableAdapter;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.BindingSource incidentsBindingSource;
        private System.Windows.Forms.DataGridView incidentsDataGridView;
        private System.Windows.Forms.ToolStrip findCustomersToolStrip;
        private System.Windows.Forms.ToolStripLabel customerIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox customerIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton findCustomersToolStripButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label1;
    }
}

