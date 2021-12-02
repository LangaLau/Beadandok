
namespace ExcelExport
{
    partial class Form1
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
            this.flatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.realEstateDataSet = new ExcelExport.RealEstateDataSet();
            this.flatTableAdapter = new ExcelExport.RealEstateDataSetTableAdapters.FlatTableAdapter();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfRoomsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elevatorDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.districtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sideDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flatSKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.flatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realEstateDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // flatBindingSource
            // 
            this.flatBindingSource.DataMember = "Flat";
            this.flatBindingSource.DataSource = this.realEstateDataSet;
            // 
            // realEstateDataSet
            // 
            this.realEstateDataSet.DataSetName = "RealEstateDataSet";
            this.realEstateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flatTableAdapter
            // 
            this.flatTableAdapter.ClearBeforeFill = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 60;
            // 
            // floorAreaDataGridViewTextBoxColumn
            // 
            this.floorAreaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.floorAreaDataGridViewTextBoxColumn.DataPropertyName = "FloorArea";
            this.floorAreaDataGridViewTextBoxColumn.HeaderText = "FloorArea";
            this.floorAreaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.floorAreaDataGridViewTextBoxColumn.Name = "floorAreaDataGridViewTextBoxColumn";
            this.floorAreaDataGridViewTextBoxColumn.Width = 81;
            // 
            // numberOfRoomsDataGridViewTextBoxColumn
            // 
            this.numberOfRoomsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numberOfRoomsDataGridViewTextBoxColumn.DataPropertyName = "NumberOfRooms";
            this.numberOfRoomsDataGridViewTextBoxColumn.HeaderText = "NumberOfRooms";
            this.numberOfRoomsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberOfRoomsDataGridViewTextBoxColumn.Name = "numberOfRoomsDataGridViewTextBoxColumn";
            this.numberOfRoomsDataGridViewTextBoxColumn.Width = 117;
            // 
            // elevatorDataGridViewCheckBoxColumn
            // 
            this.elevatorDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.elevatorDataGridViewCheckBoxColumn.DataPropertyName = "Elevator";
            this.elevatorDataGridViewCheckBoxColumn.HeaderText = "Elevator";
            this.elevatorDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.elevatorDataGridViewCheckBoxColumn.Name = "elevatorDataGridViewCheckBoxColumn";
            this.elevatorDataGridViewCheckBoxColumn.Width = 52;
            // 
            // districtDataGridViewTextBoxColumn
            // 
            this.districtDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.districtDataGridViewTextBoxColumn.DataPropertyName = "District";
            this.districtDataGridViewTextBoxColumn.HeaderText = "District";
            this.districtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.districtDataGridViewTextBoxColumn.Name = "districtDataGridViewTextBoxColumn";
            this.districtDataGridViewTextBoxColumn.Width = 68;
            // 
            // sideDataGridViewTextBoxColumn
            // 
            this.sideDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sideDataGridViewTextBoxColumn.DataPropertyName = "Side";
            this.sideDataGridViewTextBoxColumn.HeaderText = "Side";
            this.sideDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sideDataGridViewTextBoxColumn.Name = "sideDataGridViewTextBoxColumn";
            this.sideDataGridViewTextBoxColumn.Width = 57;
            // 
            // vendorDataGridViewTextBoxColumn
            // 
            this.vendorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.vendorDataGridViewTextBoxColumn.DataPropertyName = "Vendor";
            this.vendorDataGridViewTextBoxColumn.HeaderText = "Vendor";
            this.vendorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vendorDataGridViewTextBoxColumn.Name = "vendorDataGridViewTextBoxColumn";
            this.vendorDataGridViewTextBoxColumn.Width = 70;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.Width = 61;
            // 
            // flatSKDataGridViewTextBoxColumn
            // 
            this.flatSKDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.flatSKDataGridViewTextBoxColumn.DataPropertyName = "FlatSK";
            this.flatSKDataGridViewTextBoxColumn.HeaderText = "FlatSK";
            this.flatSKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.flatSKDataGridViewTextBoxColumn.Name = "flatSKDataGridViewTextBoxColumn";
            this.flatSKDataGridViewTextBoxColumn.ReadOnly = true;
            this.flatSKDataGridViewTextBoxColumn.Width = 67;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flatSKDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.vendorDataGridViewTextBoxColumn,
            this.sideDataGridViewTextBoxColumn,
            this.districtDataGridViewTextBoxColumn,
            this.elevatorDataGridViewCheckBoxColumn,
            this.numberOfRoomsDataGridViewTextBoxColumn,
            this.floorAreaDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.flatBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 47;
            this.dataGridView1.Size = new System.Drawing.Size(763, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realEstateDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource flatBindingSource;
        private RealEstateDataSet realEstateDataSet;
        private RealEstateDataSetTableAdapters.FlatTableAdapter flatTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfRoomsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn elevatorDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn districtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sideDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flatSKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

