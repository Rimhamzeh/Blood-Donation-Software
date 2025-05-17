namespace Blood_Donation_Application
{
    partial class Donor_Details
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bloodDonationdbDataSet = new Blood_Donation_Application.BloodDonationdbDataSet();
            this.newDonorTableAdapter = new Blood_Donation_Application.BloodDonationdbDataSetTableAdapters.newDonorTableAdapter();
            this.donorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fathernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mothernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodDonationdbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 37);
            this.label1.TabIndex = 58;
            this.label1.Text = "All Donor Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.donorIdDataGridViewTextBoxColumn,
            this.donornameDataGridViewTextBoxColumn,
            this.fathernameDataGridViewTextBoxColumn,
            this.mothernameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.rhDataGridViewTextBoxColumn,
            this.bloodGroupDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.addresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1155, 448);
            this.dataGridView1.TabIndex = 59;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "newDonor";
            this.bindingSource1.DataSource = this.bloodDonationdbDataSet;
            // 
            // bloodDonationdbDataSet
            // 
            this.bloodDonationdbDataSet.DataSetName = "BloodDonationdbDataSet";
            this.bloodDonationdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newDonorTableAdapter
            // 
            this.newDonorTableAdapter.ClearBeforeFill = true;
            // 
            // donorIdDataGridViewTextBoxColumn
            // 
            this.donorIdDataGridViewTextBoxColumn.DataPropertyName = "donorId";
            this.donorIdDataGridViewTextBoxColumn.HeaderText = "donorId";
            this.donorIdDataGridViewTextBoxColumn.Name = "donorIdDataGridViewTextBoxColumn";
            this.donorIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // donornameDataGridViewTextBoxColumn
            // 
            this.donornameDataGridViewTextBoxColumn.DataPropertyName = "donorname";
            this.donornameDataGridViewTextBoxColumn.HeaderText = "donorname";
            this.donornameDataGridViewTextBoxColumn.Name = "donornameDataGridViewTextBoxColumn";
            // 
            // fathernameDataGridViewTextBoxColumn
            // 
            this.fathernameDataGridViewTextBoxColumn.DataPropertyName = "fathername";
            this.fathernameDataGridViewTextBoxColumn.HeaderText = "fathername";
            this.fathernameDataGridViewTextBoxColumn.Name = "fathernameDataGridViewTextBoxColumn";
            // 
            // mothernameDataGridViewTextBoxColumn
            // 
            this.mothernameDataGridViewTextBoxColumn.DataPropertyName = "mothername";
            this.mothernameDataGridViewTextBoxColumn.HeaderText = "mothername";
            this.mothernameDataGridViewTextBoxColumn.Name = "mothernameDataGridViewTextBoxColumn";
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "dateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "dateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "mobile";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // rhDataGridViewTextBoxColumn
            // 
            this.rhDataGridViewTextBoxColumn.DataPropertyName = "Rh";
            this.rhDataGridViewTextBoxColumn.HeaderText = "Rh";
            this.rhDataGridViewTextBoxColumn.Name = "rhDataGridViewTextBoxColumn";
            // 
            // bloodGroupDataGridViewTextBoxColumn
            // 
            this.bloodGroupDataGridViewTextBoxColumn.DataPropertyName = "bloodGroup";
            this.bloodGroupDataGridViewTextBoxColumn.HeaderText = "bloodGroup";
            this.bloodGroupDataGridViewTextBoxColumn.Name = "bloodGroupDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "city";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // addresDataGridViewTextBoxColumn
            // 
            this.addresDataGridViewTextBoxColumn.DataPropertyName = "addres";
            this.addresDataGridViewTextBoxColumn.HeaderText = "addres";
            this.addresDataGridViewTextBoxColumn.Name = "addresDataGridViewTextBoxColumn";
            // 
            // Donor_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Blood_Donation_Application.Properties.Resources.all_page_background_image;
            this.ClientSize = new System.Drawing.Size(1179, 534);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Donor_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donor_Details";
            this.Load += new System.EventHandler(this.Donor_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodDonationdbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private BloodDonationdbDataSet bloodDonationdbDataSet;
        private BloodDonationdbDataSetTableAdapters.newDonorTableAdapter newDonorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fathernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mothernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addresDataGridViewTextBoxColumn;
    }
}