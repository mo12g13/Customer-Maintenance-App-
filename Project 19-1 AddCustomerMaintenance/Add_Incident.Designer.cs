namespace Project_19_1_AddCustomerMaintenance
{
    partial class frmAddIncidents
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label nameLabel1;
            System.Windows.Forms.Label customerIDLabel;
            this.techSupport_DataDataSet = new Project_19_1_AddCustomerMaintenance.TechSupport_DataDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new Project_19_1_AddCustomerMaintenance.TechSupport_DataDataSetTableAdapters.ProductsTableAdapter();
            this.tableAdapterManager = new Project_19_1_AddCustomerMaintenance.TechSupport_DataDataSetTableAdapters.TableAdapterManager();
            this.customersTableAdapter = new Project_19_1_AddCustomerMaintenance.TechSupport_DataDataSetTableAdapters.CustomersTableAdapter();
            this.incidentsTableAdapter = new Project_19_1_AddCustomerMaintenance.TechSupport_DataDataSetTableAdapters.IncidentsTableAdapter();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.incidentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.incidentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            nameLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            customerIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.techSupport_DataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(35, 98);
            nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(57, 16);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Product:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(44, 129);
            titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(37, 16);
            titleLabel.TabIndex = 7;
            titleLabel.Text = "Title:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(13, 170);
            descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(79, 16);
            descriptionLabel.TabIndex = 9;
            descriptionLabel.Text = "Description:";
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(44, 55);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(48, 16);
            nameLabel1.TabIndex = 10;
            nameLabel1.Text = "Name:";
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(13, 33);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(84, 16);
            customerIDLabel.TabIndex = 11;
            customerIDLabel.Text = "Customer ID:";
            // 
            // techSupport_DataDataSet
            // 
            this.techSupport_DataDataSet.DataSetName = "TechSupport_DataDataSet";
            this.techSupport_DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.techSupport_DataDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.IncidentsTableAdapter = this.incidentsTableAdapter;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Project_19_1_AddCustomerMaintenance.TechSupport_DataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // incidentsTableAdapter
            // 
            this.incidentsTableAdapter.ClearBeforeFill = true;
            // 
            // nameComboBox
            // 
            this.nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Name", true));
            this.nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.incidentsBindingSource, "ProductCode", true));
            this.nameComboBox.DataSource = this.productsBindingSource;
            this.nameComboBox.DisplayMember = "Name";
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(121, 90);
            this.nameComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(179, 24);
            this.nameComboBox.TabIndex = 4;
            this.nameComboBox.ValueMember = "ProductCode";
            // 
            // incidentsBindingSource
            // 
            this.incidentsBindingSource.DataMember = "FK_Incidents_Products";
            this.incidentsBindingSource.DataSource = this.productsBindingSource;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidentsBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(121, 123);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(179, 22);
            this.titleTextBox.TabIndex = 8;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidentsBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(121, 170);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(277, 96);
            this.descriptionTextBox.TabIndex = 10;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.techSupport_DataDataSet;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(121, 52);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(179, 22);
            this.nameTextBox.TabIndex = 11;
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerID", true));
            this.customerIDTextBox.Location = new System.Drawing.Point(121, 27);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(179, 22);
            this.customerIDTextBox.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(225, 273);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(307, 274);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCacel_Click);
            // 
            // incidentsBindingSource1
            // 
            this.incidentsBindingSource1.DataMember = "FK_Incidents_Customers";
            this.incidentsBindingSource1.DataSource = this.customersBindingSource;
            // 
            // frmAddIncidents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 317);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(nameLabel1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameComboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddIncidents";
            this.Text = "Add Incident";
            this.Load += new System.EventHandler(this.frmAddIncidents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.techSupport_DataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TechSupport_DataDataSet techSupport_DataDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private TechSupport_DataDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private TechSupport_DataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private TechSupport_DataDataSetTableAdapters.IncidentsTableAdapter incidentsTableAdapter;
        private System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.BindingSource incidentsBindingSource;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private TechSupport_DataDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource incidentsBindingSource1;
    }
}