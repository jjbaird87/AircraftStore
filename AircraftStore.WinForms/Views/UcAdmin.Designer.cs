namespace AircraftStore.WinForms.Views
{
    partial class UcAdmin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.entityBindingNavigator1 = new EFWinforms.EntityBindingNavigator();
            this.entityDataSource1 = new EFWinforms.EntityDataSource(this.components);
            this.aircraftDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryOfOriginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cruisingSpeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zfwDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enginesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoUrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabinPhotoUrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cockpitPhotoUrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moreInfoUrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewManufacturers = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.entityBindingNavigator2 = new EFWinforms.EntityBindingNavigator();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.entityBindingNavigator3 = new EFWinforms.EntityBindingNavigator();
            this.dataGridViewTypes = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.chkListRoles = new System.Windows.Forms.CheckedListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.aspNetRolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aspNetRolesTableAdapter = new AircraftStore.WinForms.AirplaneStoreDataSetTableAdapters.AspNetRolesTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aircraftDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManufacturers)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypes)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aspNetRolesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1167, 751);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.entityBindingNavigator1);
            this.tabPage1.Controls.Add(this.aircraftDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1159, 725);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Aircraft";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // entityBindingNavigator1
            // 
            this.entityBindingNavigator1.DataMember = "Aircraft";
            this.entityBindingNavigator1.DataSource = this.entityDataSource1;
            this.entityBindingNavigator1.Location = new System.Drawing.Point(3, 3);
            this.entityBindingNavigator1.Name = "entityBindingNavigator1";
            this.entityBindingNavigator1.Size = new System.Drawing.Size(1153, 25);
            this.entityBindingNavigator1.TabIndex = 2;
            this.entityBindingNavigator1.Text = "entityBindingNavigator1";
            this.entityBindingNavigator1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.entityBindingNavigator1_ItemClicked);
            // 
            // entityDataSource1
            // 
            this.entityDataSource1.DbContextType = typeof(AircraftStore.Dal.Context.AirplaneStoreContext);
            this.entityDataSource1.DataError += new System.EventHandler<EFWinforms.DataErrorEventArgs>(this.entityDataSource1_DataError);
            // 
            // aircraftDataGridView
            // 
            this.aircraftDataGridView.AutoGenerateColumns = false;
            this.entityDataSource1.SetAutoLookup(this.aircraftDataGridView, true);
            this.aircraftDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aircraftDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.manufacturerIdDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.typeIdDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.countryOfOriginDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.paxDataGridViewTextBoxColumn,
            this.rangeDataGridViewTextBoxColumn,
            this.cruisingSpeedDataGridViewTextBoxColumn,
            this.zfwDataGridViewTextBoxColumn,
            this.enginesDataGridViewTextBoxColumn,
            this.photoUrlDataGridViewTextBoxColumn,
            this.cabinPhotoUrlDataGridViewTextBoxColumn,
            this.cockpitPhotoUrlDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.moreInfoUrlDataGridViewTextBoxColumn});
            this.aircraftDataGridView.DataMember = "Aircraft";
            this.aircraftDataGridView.DataSource = this.entityDataSource1;
            this.aircraftDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aircraftDataGridView.Location = new System.Drawing.Point(3, 31);
            this.aircraftDataGridView.Name = "aircraftDataGridView";
            this.aircraftDataGridView.Size = new System.Drawing.Size(1153, 691);
            this.aircraftDataGridView.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Aircraft Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // manufacturerIdDataGridViewTextBoxColumn
            // 
            this.manufacturerIdDataGridViewTextBoxColumn.DataPropertyName = "ManufacturerId";
            this.manufacturerIdDataGridViewTextBoxColumn.HeaderText = "ManufacturerId";
            this.manufacturerIdDataGridViewTextBoxColumn.Name = "manufacturerIdDataGridViewTextBoxColumn";
            this.manufacturerIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            // 
            // typeIdDataGridViewTextBoxColumn
            // 
            this.typeIdDataGridViewTextBoxColumn.DataPropertyName = "TypeId";
            this.typeIdDataGridViewTextBoxColumn.HeaderText = "TypeId";
            this.typeIdDataGridViewTextBoxColumn.Name = "typeIdDataGridViewTextBoxColumn";
            this.typeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // countryOfOriginDataGridViewTextBoxColumn
            // 
            this.countryOfOriginDataGridViewTextBoxColumn.DataPropertyName = "CountryOfOrigin";
            this.countryOfOriginDataGridViewTextBoxColumn.HeaderText = "Country Of Origin";
            this.countryOfOriginDataGridViewTextBoxColumn.Name = "countryOfOriginDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // paxDataGridViewTextBoxColumn
            // 
            this.paxDataGridViewTextBoxColumn.DataPropertyName = "Pax";
            this.paxDataGridViewTextBoxColumn.HeaderText = "Passengers";
            this.paxDataGridViewTextBoxColumn.Name = "paxDataGridViewTextBoxColumn";
            // 
            // rangeDataGridViewTextBoxColumn
            // 
            this.rangeDataGridViewTextBoxColumn.DataPropertyName = "Range";
            this.rangeDataGridViewTextBoxColumn.HeaderText = "Range";
            this.rangeDataGridViewTextBoxColumn.Name = "rangeDataGridViewTextBoxColumn";
            // 
            // cruisingSpeedDataGridViewTextBoxColumn
            // 
            this.cruisingSpeedDataGridViewTextBoxColumn.DataPropertyName = "CruisingSpeed";
            this.cruisingSpeedDataGridViewTextBoxColumn.HeaderText = "Passengers";
            this.cruisingSpeedDataGridViewTextBoxColumn.Name = "cruisingSpeedDataGridViewTextBoxColumn";
            // 
            // zfwDataGridViewTextBoxColumn
            // 
            this.zfwDataGridViewTextBoxColumn.DataPropertyName = "Zfw";
            this.zfwDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.zfwDataGridViewTextBoxColumn.Name = "zfwDataGridViewTextBoxColumn";
            // 
            // enginesDataGridViewTextBoxColumn
            // 
            this.enginesDataGridViewTextBoxColumn.DataPropertyName = "Engines";
            this.enginesDataGridViewTextBoxColumn.HeaderText = "Engines";
            this.enginesDataGridViewTextBoxColumn.Name = "enginesDataGridViewTextBoxColumn";
            // 
            // photoUrlDataGridViewTextBoxColumn
            // 
            this.photoUrlDataGridViewTextBoxColumn.DataPropertyName = "PhotoUrl";
            this.photoUrlDataGridViewTextBoxColumn.HeaderText = "PhotoUrl";
            this.photoUrlDataGridViewTextBoxColumn.Name = "photoUrlDataGridViewTextBoxColumn";
            // 
            // cabinPhotoUrlDataGridViewTextBoxColumn
            // 
            this.cabinPhotoUrlDataGridViewTextBoxColumn.DataPropertyName = "CabinPhotoUrl";
            this.cabinPhotoUrlDataGridViewTextBoxColumn.HeaderText = "CabinPhotoUrl";
            this.cabinPhotoUrlDataGridViewTextBoxColumn.Name = "cabinPhotoUrlDataGridViewTextBoxColumn";
            // 
            // cockpitPhotoUrlDataGridViewTextBoxColumn
            // 
            this.cockpitPhotoUrlDataGridViewTextBoxColumn.DataPropertyName = "CockpitPhotoUrl";
            this.cockpitPhotoUrlDataGridViewTextBoxColumn.HeaderText = "CockpitPhotoUrl";
            this.cockpitPhotoUrlDataGridViewTextBoxColumn.Name = "cockpitPhotoUrlDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // moreInfoUrlDataGridViewTextBoxColumn
            // 
            this.moreInfoUrlDataGridViewTextBoxColumn.DataPropertyName = "MoreInfoUrl";
            this.moreInfoUrlDataGridViewTextBoxColumn.HeaderText = "More Info";
            this.moreInfoUrlDataGridViewTextBoxColumn.Name = "moreInfoUrlDataGridViewTextBoxColumn";
            // 
            // dataGridViewManufacturers
            // 
            this.dataGridViewManufacturers.AutoGenerateColumns = false;
            this.entityDataSource1.SetAutoLookup(this.dataGridViewManufacturers, true);
            this.dataGridViewManufacturers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManufacturers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1});
            this.dataGridViewManufacturers.DataMember = "AircraftManufacturers";
            this.dataGridViewManufacturers.DataSource = this.entityDataSource1;
            this.dataGridViewManufacturers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewManufacturers.Location = new System.Drawing.Point(3, 31);
            this.dataGridViewManufacturers.Name = "dataGridViewManufacturers";
            this.dataGridViewManufacturers.Size = new System.Drawing.Size(1153, 691);
            this.dataGridViewManufacturers.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.entityBindingNavigator2);
            this.tabPage2.Controls.Add(this.dataGridViewManufacturers);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1159, 725);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Aircraft Manufacturers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // entityBindingNavigator2
            // 
            this.entityBindingNavigator2.DataMember = "AircraftManufacturers";
            this.entityBindingNavigator2.DataSource = this.entityDataSource1;
            this.entityBindingNavigator2.Location = new System.Drawing.Point(3, 3);
            this.entityBindingNavigator2.Name = "entityBindingNavigator2";
            this.entityBindingNavigator2.Size = new System.Drawing.Size(1153, 25);
            this.entityBindingNavigator2.TabIndex = 1;
            this.entityBindingNavigator2.Text = "entityBindingNavigator2";
            this.entityBindingNavigator2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.entityBindingNavigator2_ItemClicked);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.entityBindingNavigator3);
            this.tabPage3.Controls.Add(this.dataGridViewTypes);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1159, 725);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Aircraft Types";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // entityBindingNavigator3
            // 
            this.entityBindingNavigator3.DataMember = "AircraftTypes";
            this.entityBindingNavigator3.DataSource = this.entityDataSource1;
            this.entityBindingNavigator3.Location = new System.Drawing.Point(3, 3);
            this.entityBindingNavigator3.Name = "entityBindingNavigator3";
            this.entityBindingNavigator3.Size = new System.Drawing.Size(1153, 25);
            this.entityBindingNavigator3.TabIndex = 1;
            this.entityBindingNavigator3.Text = "entityBindingNavigator3";
            this.entityBindingNavigator3.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.entityBindingNavigator3_ItemClicked);
            // 
            // dataGridViewTypes
            // 
            this.dataGridViewTypes.AutoGenerateColumns = false;
            this.dataGridViewTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn2});
            this.dataGridViewTypes.DataMember = "AircraftTypes";
            this.dataGridViewTypes.DataSource = this.entityDataSource1;
            this.dataGridViewTypes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewTypes.Location = new System.Drawing.Point(3, 31);
            this.dataGridViewTypes.Name = "dataGridViewTypes";
            this.dataGridViewTypes.Size = new System.Drawing.Size(1153, 691);
            this.dataGridViewTypes.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridViewUsers);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1159, 725);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Users";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUsers.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.Size = new System.Drawing.Size(1153, 719);
            this.dataGridViewUsers.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.chkListRoles);
            this.tabPage5.Controls.Add(this.button2);
            this.tabPage5.Controls.Add(this.cmbUsers);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1159, 725);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Role Assignment";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // chkListRoles
            // 
            this.chkListRoles.FormattingEnabled = true;
            this.chkListRoles.Location = new System.Drawing.Point(32, 139);
            this.chkListRoles.Name = "chkListRoles";
            this.chkListRoles.Size = new System.Drawing.Size(504, 139);
            this.chkListRoles.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(504, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbUsers
            // 
            this.cmbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(32, 102);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(504, 21);
            this.cmbUsers.TabIndex = 6;
            this.cmbUsers.SelectedIndexChanged += new System.EventHandler(this.cmbUsers_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "User:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Role Assignment:";
            // 
            // aspNetRolesTableAdapter
            // 
            this.aspNetRolesTableAdapter.ClearBeforeFill = true;
            // 
            // UcAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "UcAdmin";
            this.Size = new System.Drawing.Size(1167, 751);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aircraftDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManufacturers)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypes)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aspNetRolesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.DataGridView aircraftDataGridView;
        private EFWinforms.EntityBindingNavigator entityBindingNavigator1;
        private EFWinforms.EntityDataSource entityDataSource1;
        private EFWinforms.EntityBindingNavigator entityBindingNavigator2;
        private System.Windows.Forms.DataGridView dataGridViewManufacturers;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryOfOriginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cruisingSpeedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zfwDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enginesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoUrlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabinPhotoUrlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cockpitPhotoUrlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moreInfoUrlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private EFWinforms.EntityBindingNavigator entityBindingNavigator3;
        private System.Windows.Forms.DataGridView dataGridViewTypes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn emailConfirmedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordHashDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn securityStampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn phoneNumberConfirmedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn twoFactorEnabledDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lockoutEndDateUtcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn lockoutEnabledDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessFailedCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn3;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.BindingSource aspNetRolesBindingSource;
        private AirplaneStoreDataSetTableAdapters.AspNetRolesTableAdapter aspNetRolesTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chkListRoles;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
    }
}
