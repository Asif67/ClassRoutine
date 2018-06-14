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
            this.rowNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termSectionDepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalRoutineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classRoutineDataSet = new NWUClassRoutine.ClassRoutineDataSet();
            this.finalRoutineTableAdapter = new NWUClassRoutine.ClassRoutineDataSetTableAdapters.FinalRoutineTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalRoutineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classRoutineDataSet)).BeginInit();
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
            // 
            // Btn_Generate
            // 
            this.Btn_Generate.Location = new System.Drawing.Point(434, 6);
            this.Btn_Generate.Name = "Btn_Generate";
            this.Btn_Generate.Size = new System.Drawing.Size(182, 48);
            this.Btn_Generate.TabIndex = 0;
            this.Btn_Generate.Text = "Generate";
            this.Btn_Generate.UseVisualStyleBackColor = true;
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.roomNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.finalRoutineBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(944, 393);
            this.dataGridView1.TabIndex = 1;
            // 
            // rowNumberDataGridViewTextBoxColumn
            // 
            this.rowNumberDataGridViewTextBoxColumn.DataPropertyName = "RowNumber";
            this.rowNumberDataGridViewTextBoxColumn.HeaderText = "RowNumber";
            this.rowNumberDataGridViewTextBoxColumn.Name = "rowNumberDataGridViewTextBoxColumn";
            // 
            // termSectionDepartmentDataGridViewTextBoxColumn
            // 
            this.termSectionDepartmentDataGridViewTextBoxColumn.DataPropertyName = "Term&Section&Department";
            this.termSectionDepartmentDataGridViewTextBoxColumn.HeaderText = "Term&Section&Department";
            this.termSectionDepartmentDataGridViewTextBoxColumn.Name = "termSectionDepartmentDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "8:00-9:15";
            this.dataGridViewTextBoxColumn1.HeaderText = "8:00-9:15";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "9:15-10:30";
            this.dataGridViewTextBoxColumn2.HeaderText = "9:15-10:30";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "10:45-12:00";
            this.dataGridViewTextBoxColumn3.HeaderText = "10:45-12:00";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "12:00-1:15";
            this.dataGridViewTextBoxColumn4.HeaderText = "12:00-1:15";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "2:00-3:15";
            this.dataGridViewTextBoxColumn5.HeaderText = "2:00-3:15";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "3:15-4:30";
            this.dataGridViewTextBoxColumn6.HeaderText = "3:15-4:30";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // roomNoDataGridViewTextBoxColumn
            // 
            this.roomNoDataGridViewTextBoxColumn.DataPropertyName = "RoomNo";
            this.roomNoDataGridViewTextBoxColumn.HeaderText = "RoomNo";
            this.roomNoDataGridViewTextBoxColumn.Name = "roomNoDataGridViewTextBoxColumn";
            // 
            // finalRoutineBindingSource
            // 
            this.finalRoutineBindingSource.DataMember = "FinalRoutine";
            this.finalRoutineBindingSource.DataSource = this.classRoutineDataSet;
            // 
            // classRoutineDataSet
            // 
            this.classRoutineDataSet.DataSetName = "ClassRoutineDataSet";
            this.classRoutineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // finalRoutineTableAdapter
            // 
            this.finalRoutineTableAdapter.ClearBeforeFill = true;
            // 
            // Routine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 465);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_MakePdf);
            this.Controls.Add(this.Btn_Generate);
            this.Controls.Add(this.Btn_ViewRoutine);
            this.MaximizeBox = false;
            this.Name = "Routine";
            this.Text = "Routine";
            this.Load += new System.EventHandler(this.Routine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalRoutineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classRoutineDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_ViewRoutine;
        private System.Windows.Forms.Button Btn_Generate;
        private System.Windows.Forms.Button Btn_MakePdf;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ClassRoutineDataSet classRoutineDataSet;
        private System.Windows.Forms.BindingSource finalRoutineBindingSource;
        private ClassRoutineDataSetTableAdapters.FinalRoutineTableAdapter finalRoutineTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn termSectionDepartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNoDataGridViewTextBoxColumn;
    }
}