namespace NWUClassRoutine
{
    partial class Routine
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
            this.Btn_ViewRoutine = new System.Windows.Forms.Button();
            this.Btn_Generate = new System.Windows.Forms.Button();
            this.Btn_MakePdf = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.routineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nWUClassRoutineDataSet = new NWUClassRoutine.NWUClassRoutineDataSet();
            this.routineTableAdapter = new NWUClassRoutine.NWUClassRoutineDataSetTableAdapters.RoutineTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rowNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termSectionDepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monday800915DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monday9151030DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monday10451200DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monday1200115DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monday200315DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monday315430DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuesday800915DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuesday9151030DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuesday10451200DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuesday1200115DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuesday200315DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuesday315430DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wednesday800915DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wednesday9151030DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wednesday10451200DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wednesday1200115DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wednesday200315DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wednesday315430DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thursday800915DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thursday9151030DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thursday10451200DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thursday1200115DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thursday200315DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thursday315430DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.friday800915DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.friday9151030DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.friday10451200DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.friday1200115DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.friday200315DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.friday315430DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saturday800915DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saturday9151030DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saturday10451200DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saturday1200115DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saturday200315DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saturday315430DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWUClassRoutineDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_ViewRoutine
            // 
            this.Btn_ViewRoutine.Location = new System.Drawing.Point(29, 6);
            this.Btn_ViewRoutine.Name = "Btn_ViewRoutine";
            this.Btn_ViewRoutine.Size = new System.Drawing.Size(137, 48);
            this.Btn_ViewRoutine.TabIndex = 0;
            this.Btn_ViewRoutine.Text = "View Routine";
            this.Btn_ViewRoutine.UseVisualStyleBackColor = true;
            this.Btn_ViewRoutine.Click += new System.EventHandler(this.Btn_ViewRoutine_Click);
            // 
            // Btn_Generate
            // 
            this.Btn_Generate.Location = new System.Drawing.Point(434, 6);
            this.Btn_Generate.Name = "Btn_Generate";
            this.Btn_Generate.Size = new System.Drawing.Size(182, 48);
            this.Btn_Generate.TabIndex = 0;
            this.Btn_Generate.Text = "Generate";
            this.Btn_Generate.UseVisualStyleBackColor = true;
            this.Btn_Generate.Click += new System.EventHandler(this.Btn_Generate_Click);
            // 
            // Btn_MakePdf
            // 
            this.Btn_MakePdf.Location = new System.Drawing.Point(811, 6);
            this.Btn_MakePdf.Name = "Btn_MakePdf";
            this.Btn_MakePdf.Size = new System.Drawing.Size(162, 48);
            this.Btn_MakePdf.TabIndex = 0;
            this.Btn_MakePdf.Text = "Make PDF";
            this.Btn_MakePdf.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowNumberDataGridViewTextBoxColumn,
            this.termSectionDepartmentDataGridViewTextBoxColumn,
            this.monday800915DataGridViewTextBoxColumn,
            this.monday9151030DataGridViewTextBoxColumn,
            this.monday10451200DataGridViewTextBoxColumn,
            this.monday1200115DataGridViewTextBoxColumn,
            this.monday200315DataGridViewTextBoxColumn,
            this.monday315430DataGridViewTextBoxColumn,
            this.tuesday800915DataGridViewTextBoxColumn,
            this.tuesday9151030DataGridViewTextBoxColumn,
            this.tuesday10451200DataGridViewTextBoxColumn,
            this.tuesday1200115DataGridViewTextBoxColumn,
            this.tuesday200315DataGridViewTextBoxColumn,
            this.tuesday315430DataGridViewTextBoxColumn,
            this.wednesday800915DataGridViewTextBoxColumn,
            this.wednesday9151030DataGridViewTextBoxColumn,
            this.wednesday10451200DataGridViewTextBoxColumn,
            this.wednesday1200115DataGridViewTextBoxColumn,
            this.wednesday200315DataGridViewTextBoxColumn,
            this.wednesday315430DataGridViewTextBoxColumn,
            this.thursday800915DataGridViewTextBoxColumn,
            this.thursday9151030DataGridViewTextBoxColumn,
            this.thursday10451200DataGridViewTextBoxColumn,
            this.thursday1200115DataGridViewTextBoxColumn,
            this.thursday200315DataGridViewTextBoxColumn,
            this.thursday315430DataGridViewTextBoxColumn,
            this.friday800915DataGridViewTextBoxColumn,
            this.friday9151030DataGridViewTextBoxColumn,
            this.friday10451200DataGridViewTextBoxColumn,
            this.friday1200115DataGridViewTextBoxColumn,
            this.friday200315DataGridViewTextBoxColumn,
            this.friday315430DataGridViewTextBoxColumn,
            this.saturday800915DataGridViewTextBoxColumn,
            this.saturday9151030DataGridViewTextBoxColumn,
            this.saturday10451200DataGridViewTextBoxColumn,
            this.saturday1200115DataGridViewTextBoxColumn,
            this.saturday200315DataGridViewTextBoxColumn,
            this.saturday315430DataGridViewTextBoxColumn,
            this.roomNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.routineBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(944, 377);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // routineBindingSource
            // 
            this.routineBindingSource.DataMember = "Routine";
            this.routineBindingSource.DataSource = this.nWUClassRoutineDataSet;
            // 
            // nWUClassRoutineDataSet
            // 
            this.nWUClassRoutineDataSet.DataSetName = "NWUClassRoutineDataSet";
            this.nWUClassRoutineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // routineTableAdapter
            // 
            this.routineTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(29, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 377);
            this.panel1.TabIndex = 2;
            // 
            // rowNumberDataGridViewTextBoxColumn
            // 
            this.rowNumberDataGridViewTextBoxColumn.DataPropertyName = "RowNumber";
            this.rowNumberDataGridViewTextBoxColumn.HeaderText = "RowNumber";
            this.rowNumberDataGridViewTextBoxColumn.Name = "rowNumberDataGridViewTextBoxColumn";
            // 
            // termSectionDepartmentDataGridViewTextBoxColumn
            // 
            this.termSectionDepartmentDataGridViewTextBoxColumn.DataPropertyName = "[Term&Section&Department]";
            this.termSectionDepartmentDataGridViewTextBoxColumn.HeaderText = "[Term&Section&Department]";
            this.termSectionDepartmentDataGridViewTextBoxColumn.Name = "termSectionDepartmentDataGridViewTextBoxColumn";
            // 
            // monday800915DataGridViewTextBoxColumn
            // 
            this.monday800915DataGridViewTextBoxColumn.DataPropertyName = "[Monday 8:00-9:15]";
            this.monday800915DataGridViewTextBoxColumn.HeaderText = "[Monday 8:00-9:15]";
            this.monday800915DataGridViewTextBoxColumn.Name = "monday800915DataGridViewTextBoxColumn";
            // 
            // monday9151030DataGridViewTextBoxColumn
            // 
            this.monday9151030DataGridViewTextBoxColumn.DataPropertyName = "[Monday 9:15-10:30]";
            this.monday9151030DataGridViewTextBoxColumn.HeaderText = "[Monday 9:15-10:30]";
            this.monday9151030DataGridViewTextBoxColumn.Name = "monday9151030DataGridViewTextBoxColumn";
            // 
            // monday10451200DataGridViewTextBoxColumn
            // 
            this.monday10451200DataGridViewTextBoxColumn.DataPropertyName = "[Monday 10:45-12:00]";
            this.monday10451200DataGridViewTextBoxColumn.HeaderText = "[Monday 10:45-12:00]";
            this.monday10451200DataGridViewTextBoxColumn.Name = "monday10451200DataGridViewTextBoxColumn";
            // 
            // monday1200115DataGridViewTextBoxColumn
            // 
            this.monday1200115DataGridViewTextBoxColumn.DataPropertyName = "[Monday 12:00-1:15]";
            this.monday1200115DataGridViewTextBoxColumn.HeaderText = "[Monday 12:00-1:15]";
            this.monday1200115DataGridViewTextBoxColumn.Name = "monday1200115DataGridViewTextBoxColumn";
            // 
            // monday200315DataGridViewTextBoxColumn
            // 
            this.monday200315DataGridViewTextBoxColumn.DataPropertyName = "[Monday 2:00-3:15]";
            this.monday200315DataGridViewTextBoxColumn.HeaderText = "[Monday 2:00-3:15]";
            this.monday200315DataGridViewTextBoxColumn.Name = "monday200315DataGridViewTextBoxColumn";
            // 
            // monday315430DataGridViewTextBoxColumn
            // 
            this.monday315430DataGridViewTextBoxColumn.DataPropertyName = "[Monday 3:15-4:30]";
            this.monday315430DataGridViewTextBoxColumn.HeaderText = "[Monday 3:15-4:30]";
            this.monday315430DataGridViewTextBoxColumn.Name = "monday315430DataGridViewTextBoxColumn";
            // 
            // tuesday800915DataGridViewTextBoxColumn
            // 
            this.tuesday800915DataGridViewTextBoxColumn.DataPropertyName = "[Tuesday 8:00-9:15]";
            this.tuesday800915DataGridViewTextBoxColumn.HeaderText = "[Tuesday 8:00-9:15]";
            this.tuesday800915DataGridViewTextBoxColumn.Name = "tuesday800915DataGridViewTextBoxColumn";
            // 
            // tuesday9151030DataGridViewTextBoxColumn
            // 
            this.tuesday9151030DataGridViewTextBoxColumn.DataPropertyName = "[Tuesday 9:15-10:30]";
            this.tuesday9151030DataGridViewTextBoxColumn.HeaderText = "[Tuesday 9:15-10:30]";
            this.tuesday9151030DataGridViewTextBoxColumn.Name = "tuesday9151030DataGridViewTextBoxColumn";
            // 
            // tuesday10451200DataGridViewTextBoxColumn
            // 
            this.tuesday10451200DataGridViewTextBoxColumn.DataPropertyName = "[Tuesday 10:45-12:00]";
            this.tuesday10451200DataGridViewTextBoxColumn.HeaderText = "[Tuesday 10:45-12:00]";
            this.tuesday10451200DataGridViewTextBoxColumn.Name = "tuesday10451200DataGridViewTextBoxColumn";
            // 
            // tuesday1200115DataGridViewTextBoxColumn
            // 
            this.tuesday1200115DataGridViewTextBoxColumn.DataPropertyName = "[Tuesday 12:00-1:15]";
            this.tuesday1200115DataGridViewTextBoxColumn.HeaderText = "[Tuesday 12:00-1:15]";
            this.tuesday1200115DataGridViewTextBoxColumn.Name = "tuesday1200115DataGridViewTextBoxColumn";
            // 
            // tuesday200315DataGridViewTextBoxColumn
            // 
            this.tuesday200315DataGridViewTextBoxColumn.DataPropertyName = "[Tuesday 2:00-3:15]";
            this.tuesday200315DataGridViewTextBoxColumn.HeaderText = "[Tuesday 2:00-3:15]";
            this.tuesday200315DataGridViewTextBoxColumn.Name = "tuesday200315DataGridViewTextBoxColumn";
            // 
            // tuesday315430DataGridViewTextBoxColumn
            // 
            this.tuesday315430DataGridViewTextBoxColumn.DataPropertyName = "[Tuesday 3:15-4:30]";
            this.tuesday315430DataGridViewTextBoxColumn.HeaderText = "[Tuesday 3:15-4:30]";
            this.tuesday315430DataGridViewTextBoxColumn.Name = "tuesday315430DataGridViewTextBoxColumn";
            // 
            // wednesday800915DataGridViewTextBoxColumn
            // 
            this.wednesday800915DataGridViewTextBoxColumn.DataPropertyName = "[Wednesday 8:00-9:15]";
            this.wednesday800915DataGridViewTextBoxColumn.HeaderText = "[Wednesday 8:00-9:15]";
            this.wednesday800915DataGridViewTextBoxColumn.Name = "wednesday800915DataGridViewTextBoxColumn";
            // 
            // wednesday9151030DataGridViewTextBoxColumn
            // 
            this.wednesday9151030DataGridViewTextBoxColumn.DataPropertyName = "[Wednesday 9:15-10:30]";
            this.wednesday9151030DataGridViewTextBoxColumn.HeaderText = "[Wednesday 9:15-10:30]";
            this.wednesday9151030DataGridViewTextBoxColumn.Name = "wednesday9151030DataGridViewTextBoxColumn";
            // 
            // wednesday10451200DataGridViewTextBoxColumn
            // 
            this.wednesday10451200DataGridViewTextBoxColumn.DataPropertyName = "[Wednesday 10:45-12:00]";
            this.wednesday10451200DataGridViewTextBoxColumn.HeaderText = "[Wednesday 10:45-12:00]";
            this.wednesday10451200DataGridViewTextBoxColumn.Name = "wednesday10451200DataGridViewTextBoxColumn";
            // 
            // wednesday1200115DataGridViewTextBoxColumn
            // 
            this.wednesday1200115DataGridViewTextBoxColumn.DataPropertyName = "[Wednesday 12:00-1:15]";
            this.wednesday1200115DataGridViewTextBoxColumn.HeaderText = "[Wednesday 12:00-1:15]";
            this.wednesday1200115DataGridViewTextBoxColumn.Name = "wednesday1200115DataGridViewTextBoxColumn";
            // 
            // wednesday200315DataGridViewTextBoxColumn
            // 
            this.wednesday200315DataGridViewTextBoxColumn.DataPropertyName = "[Wednesday 2:00-3:15]";
            this.wednesday200315DataGridViewTextBoxColumn.HeaderText = "[Wednesday 2:00-3:15]";
            this.wednesday200315DataGridViewTextBoxColumn.Name = "wednesday200315DataGridViewTextBoxColumn";
            // 
            // wednesday315430DataGridViewTextBoxColumn
            // 
            this.wednesday315430DataGridViewTextBoxColumn.DataPropertyName = "[Wednesday 3:15-4:30]";
            this.wednesday315430DataGridViewTextBoxColumn.HeaderText = "[Wednesday 3:15-4:30]";
            this.wednesday315430DataGridViewTextBoxColumn.Name = "wednesday315430DataGridViewTextBoxColumn";
            // 
            // thursday800915DataGridViewTextBoxColumn
            // 
            this.thursday800915DataGridViewTextBoxColumn.DataPropertyName = "[Thursday 8:00-9:15]";
            this.thursday800915DataGridViewTextBoxColumn.HeaderText = "[Thursday 8:00-9:15]";
            this.thursday800915DataGridViewTextBoxColumn.Name = "thursday800915DataGridViewTextBoxColumn";
            // 
            // thursday9151030DataGridViewTextBoxColumn
            // 
            this.thursday9151030DataGridViewTextBoxColumn.DataPropertyName = "[Thursday 9:15-10:30]";
            this.thursday9151030DataGridViewTextBoxColumn.HeaderText = "[Thursday 9:15-10:30]";
            this.thursday9151030DataGridViewTextBoxColumn.Name = "thursday9151030DataGridViewTextBoxColumn";
            // 
            // thursday10451200DataGridViewTextBoxColumn
            // 
            this.thursday10451200DataGridViewTextBoxColumn.DataPropertyName = "[Thursday 10:45-12:00]";
            this.thursday10451200DataGridViewTextBoxColumn.HeaderText = "[Thursday 10:45-12:00]";
            this.thursday10451200DataGridViewTextBoxColumn.Name = "thursday10451200DataGridViewTextBoxColumn";
            // 
            // thursday1200115DataGridViewTextBoxColumn
            // 
            this.thursday1200115DataGridViewTextBoxColumn.DataPropertyName = "[Thursday 12:00-1:15]";
            this.thursday1200115DataGridViewTextBoxColumn.HeaderText = "[Thursday 12:00-1:15]";
            this.thursday1200115DataGridViewTextBoxColumn.Name = "thursday1200115DataGridViewTextBoxColumn";
            // 
            // thursday200315DataGridViewTextBoxColumn
            // 
            this.thursday200315DataGridViewTextBoxColumn.DataPropertyName = "[Thursday 2:00-3:15]";
            this.thursday200315DataGridViewTextBoxColumn.HeaderText = "[Thursday 2:00-3:15]";
            this.thursday200315DataGridViewTextBoxColumn.Name = "thursday200315DataGridViewTextBoxColumn";
            // 
            // thursday315430DataGridViewTextBoxColumn
            // 
            this.thursday315430DataGridViewTextBoxColumn.DataPropertyName = "[Thursday 3:15-4:30]";
            this.thursday315430DataGridViewTextBoxColumn.HeaderText = "[Thursday 3:15-4:30]";
            this.thursday315430DataGridViewTextBoxColumn.Name = "thursday315430DataGridViewTextBoxColumn";
            // 
            // friday800915DataGridViewTextBoxColumn
            // 
            this.friday800915DataGridViewTextBoxColumn.DataPropertyName = "[Friday 8:00-9:15]";
            this.friday800915DataGridViewTextBoxColumn.HeaderText = "[Friday 8:00-9:15]";
            this.friday800915DataGridViewTextBoxColumn.Name = "friday800915DataGridViewTextBoxColumn";
            // 
            // friday9151030DataGridViewTextBoxColumn
            // 
            this.friday9151030DataGridViewTextBoxColumn.DataPropertyName = "[Friday 9:15-10:30]";
            this.friday9151030DataGridViewTextBoxColumn.HeaderText = "[Friday 9:15-10:30]";
            this.friday9151030DataGridViewTextBoxColumn.Name = "friday9151030DataGridViewTextBoxColumn";
            // 
            // friday10451200DataGridViewTextBoxColumn
            // 
            this.friday10451200DataGridViewTextBoxColumn.DataPropertyName = "[Friday 10:45-12:00]";
            this.friday10451200DataGridViewTextBoxColumn.HeaderText = "[Friday 10:45-12:00]";
            this.friday10451200DataGridViewTextBoxColumn.Name = "friday10451200DataGridViewTextBoxColumn";
            // 
            // friday1200115DataGridViewTextBoxColumn
            // 
            this.friday1200115DataGridViewTextBoxColumn.DataPropertyName = "[Friday 12:00-1:15]";
            this.friday1200115DataGridViewTextBoxColumn.HeaderText = "[Friday 12:00-1:15]";
            this.friday1200115DataGridViewTextBoxColumn.Name = "friday1200115DataGridViewTextBoxColumn";
            // 
            // friday200315DataGridViewTextBoxColumn
            // 
            this.friday200315DataGridViewTextBoxColumn.DataPropertyName = "[Friday 2:00-3:15]";
            this.friday200315DataGridViewTextBoxColumn.HeaderText = "[Friday 2:00-3:15]";
            this.friday200315DataGridViewTextBoxColumn.Name = "friday200315DataGridViewTextBoxColumn";
            // 
            // friday315430DataGridViewTextBoxColumn
            // 
            this.friday315430DataGridViewTextBoxColumn.DataPropertyName = "[Friday 3:15-4:30]";
            this.friday315430DataGridViewTextBoxColumn.HeaderText = "[Friday 3:15-4:30]";
            this.friday315430DataGridViewTextBoxColumn.Name = "friday315430DataGridViewTextBoxColumn";
            // 
            // saturday800915DataGridViewTextBoxColumn
            // 
            this.saturday800915DataGridViewTextBoxColumn.DataPropertyName = "[Saturday 8:00-9:15]";
            this.saturday800915DataGridViewTextBoxColumn.HeaderText = "[Saturday 8:00-9:15]";
            this.saturday800915DataGridViewTextBoxColumn.Name = "saturday800915DataGridViewTextBoxColumn";
            // 
            // saturday9151030DataGridViewTextBoxColumn
            // 
            this.saturday9151030DataGridViewTextBoxColumn.DataPropertyName = "[Saturday 9:15-10:30]";
            this.saturday9151030DataGridViewTextBoxColumn.HeaderText = "[Saturday 9:15-10:30]";
            this.saturday9151030DataGridViewTextBoxColumn.Name = "saturday9151030DataGridViewTextBoxColumn";
            // 
            // saturday10451200DataGridViewTextBoxColumn
            // 
            this.saturday10451200DataGridViewTextBoxColumn.DataPropertyName = "[Saturday 10:45-12:00]";
            this.saturday10451200DataGridViewTextBoxColumn.HeaderText = "[Saturday 10:45-12:00]";
            this.saturday10451200DataGridViewTextBoxColumn.Name = "saturday10451200DataGridViewTextBoxColumn";
            // 
            // saturday1200115DataGridViewTextBoxColumn
            // 
            this.saturday1200115DataGridViewTextBoxColumn.DataPropertyName = "[Saturday 12:00-1:15]";
            this.saturday1200115DataGridViewTextBoxColumn.HeaderText = "[Saturday 12:00-1:15]";
            this.saturday1200115DataGridViewTextBoxColumn.Name = "saturday1200115DataGridViewTextBoxColumn";
            // 
            // saturday200315DataGridViewTextBoxColumn
            // 
            this.saturday200315DataGridViewTextBoxColumn.DataPropertyName = "[Saturday 2:00-3:15]";
            this.saturday200315DataGridViewTextBoxColumn.HeaderText = "[Saturday 2:00-3:15]";
            this.saturday200315DataGridViewTextBoxColumn.Name = "saturday200315DataGridViewTextBoxColumn";
            // 
            // saturday315430DataGridViewTextBoxColumn
            // 
            this.saturday315430DataGridViewTextBoxColumn.DataPropertyName = "[Saturday 3:15-4:30]";
            this.saturday315430DataGridViewTextBoxColumn.HeaderText = "[Saturday 3:15-4:30]";
            this.saturday315430DataGridViewTextBoxColumn.Name = "saturday315430DataGridViewTextBoxColumn";
            // 
            // roomNoDataGridViewTextBoxColumn
            // 
            this.roomNoDataGridViewTextBoxColumn.DataPropertyName = "RoomNo";
            this.roomNoDataGridViewTextBoxColumn.HeaderText = "RoomNo";
            this.roomNoDataGridViewTextBoxColumn.Name = "roomNoDataGridViewTextBoxColumn";
            // 
            // Routine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(999, 465);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_MakePdf);
            this.Controls.Add(this.Btn_Generate);
            this.Controls.Add(this.Btn_ViewRoutine);
            this.Name = "Routine";
            this.Text = "Routine";
            this.Load += new System.EventHandler(this.Routine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWUClassRoutineDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_ViewRoutine;
        private System.Windows.Forms.Button Btn_Generate;
        private System.Windows.Forms.Button Btn_MakePdf;
        private System.Windows.Forms.DataGridView dataGridView1;
        private NWUClassRoutineDataSet nWUClassRoutineDataSet;
        private System.Windows.Forms.BindingSource routineBindingSource;
        private NWUClassRoutineDataSetTableAdapters.RoutineTableAdapter routineTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn termSectionDepartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monday800915DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monday9151030DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monday10451200DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monday1200115DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monday200315DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monday315430DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuesday800915DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuesday9151030DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuesday10451200DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuesday1200115DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuesday200315DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuesday315430DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wednesday800915DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wednesday9151030DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wednesday10451200DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wednesday1200115DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wednesday200315DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wednesday315430DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thursday800915DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thursday9151030DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thursday10451200DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thursday1200115DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thursday200315DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thursday315430DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn friday800915DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn friday9151030DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn friday10451200DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn friday1200115DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn friday200315DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn friday315430DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saturday800915DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saturday9151030DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saturday10451200DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saturday1200115DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saturday200315DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saturday315430DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNoDataGridViewTextBoxColumn;
    }
}