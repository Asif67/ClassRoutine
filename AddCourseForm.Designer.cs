namespace NWUClassRoutine
{
    partial class AddCourseForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.routineInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classRoutineDataSet = new NWUClassRoutine.ClassRoutineDataSet();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_New = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TeacherInitials = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseCreditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preferredTimeSlot1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preferredTimeSlot2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preferredTimeSlot3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.routineInfoTableAdapter = new NWUClassRoutine.ClassRoutineDataSetTableAdapters.RoutineInfoTableAdapter();
            this.Btn_ViewRoutine = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routineInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classRoutineDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox9);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 260);
            this.panel1.TabIndex = 0;
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.routineInfoBindingSource, "CourseCredit", true));
            this.textBox9.Location = new System.Drawing.Point(181, 228);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(160, 20);
            this.textBox9.TabIndex = 1;
            // 
            // routineInfoBindingSource
            // 
            this.routineInfoBindingSource.DataMember = "RoutineInfo";
            this.routineInfoBindingSource.DataSource = this.classRoutineDataSet;
            // 
            // classRoutineDataSet
            // 
            this.classRoutineDataSet.DataSetName = "ClassRoutineDataSet";
            this.classRoutineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Credit:";
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.routineInfoBindingSource, "TeacherStatus", true));
            this.textBox8.Location = new System.Drawing.Point(181, 200);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(160, 20);
            this.textBox8.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Teacher Status:";
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.routineInfoBindingSource, "PreferredTimeSlot3", true));
            this.textBox7.Location = new System.Drawing.Point(181, 174);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(160, 20);
            this.textBox7.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Preferred Time Slot 3:";
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.routineInfoBindingSource, "PreferredTimeSlot2", true));
            this.textBox6.Location = new System.Drawing.Point(181, 148);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(160, 20);
            this.textBox6.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Preferred Time Slot 2:";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.routineInfoBindingSource, "PreferredTimeSlot1", true));
            this.textBox5.Location = new System.Drawing.Point(181, 122);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(160, 20);
            this.textBox5.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Preferred Time Slot 1:";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.routineInfoBindingSource, "CourseCode", true));
            this.textBox4.Location = new System.Drawing.Point(181, 96);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(160, 20);
            this.textBox4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Course Code:";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.routineInfoBindingSource, "CourseTitle", true));
            this.textBox3.Location = new System.Drawing.Point(181, 70);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(160, 20);
            this.textBox3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Coursse Title:";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.routineInfoBindingSource, "TeacherInitials", true));
            this.textBox2.Location = new System.Drawing.Point(181, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Teacher Initial:";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.routineInfoBindingSource, "TeacherName", true));
            this.textBox1.Location = new System.Drawing.Point(181, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher Name:";
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(295, 278);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(75, 23);
            this.Btn_Save.TabIndex = 2;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_New
            // 
            this.Btn_New.Location = new System.Drawing.Point(12, 278);
            this.Btn_New.Name = "Btn_New";
            this.Btn_New.Size = new System.Drawing.Size(75, 23);
            this.Btn_New.TabIndex = 2;
            this.Btn_New.Text = "New";
            this.Btn_New.UseVisualStyleBackColor = true;
            this.Btn_New.Click += new System.EventHandler(this.Btn_New_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(410, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 246);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeacherInitials,
            this.courseCodeDataGridViewTextBoxColumn,
            this.courseCreditDataGridViewTextBoxColumn,
            this.preferredTimeSlot1DataGridViewTextBoxColumn,
            this.preferredTimeSlot2DataGridViewTextBoxColumn,
            this.preferredTimeSlot3DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.routineInfoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(452, 246);
            this.dataGridView1.TabIndex = 0;
            // 
            // TeacherInitials
            // 
            this.TeacherInitials.DataPropertyName = "TeacherInitials";
            this.TeacherInitials.HeaderText = "TeacherInitials";
            this.TeacherInitials.Name = "TeacherInitials";
            // 
            // courseCodeDataGridViewTextBoxColumn
            // 
            this.courseCodeDataGridViewTextBoxColumn.DataPropertyName = "CourseCode";
            this.courseCodeDataGridViewTextBoxColumn.HeaderText = "CourseCode";
            this.courseCodeDataGridViewTextBoxColumn.Name = "courseCodeDataGridViewTextBoxColumn";
            // 
            // courseCreditDataGridViewTextBoxColumn
            // 
            this.courseCreditDataGridViewTextBoxColumn.DataPropertyName = "CourseCredit";
            this.courseCreditDataGridViewTextBoxColumn.HeaderText = "CourseCredit";
            this.courseCreditDataGridViewTextBoxColumn.Name = "courseCreditDataGridViewTextBoxColumn";
            // 
            // preferredTimeSlot1DataGridViewTextBoxColumn
            // 
            this.preferredTimeSlot1DataGridViewTextBoxColumn.DataPropertyName = "PreferredTimeSlot1";
            this.preferredTimeSlot1DataGridViewTextBoxColumn.HeaderText = "PreferredTimeSlot1";
            this.preferredTimeSlot1DataGridViewTextBoxColumn.Name = "preferredTimeSlot1DataGridViewTextBoxColumn";
            // 
            // preferredTimeSlot2DataGridViewTextBoxColumn
            // 
            this.preferredTimeSlot2DataGridViewTextBoxColumn.DataPropertyName = "PreferredTimeSlot2";
            this.preferredTimeSlot2DataGridViewTextBoxColumn.HeaderText = "PreferredTimeSlot2";
            this.preferredTimeSlot2DataGridViewTextBoxColumn.Name = "preferredTimeSlot2DataGridViewTextBoxColumn";
            // 
            // preferredTimeSlot3DataGridViewTextBoxColumn
            // 
            this.preferredTimeSlot3DataGridViewTextBoxColumn.DataPropertyName = "PreferredTimeSlot3";
            this.preferredTimeSlot3DataGridViewTextBoxColumn.HeaderText = "PreferredTimeSlot3";
            this.preferredTimeSlot3DataGridViewTextBoxColumn.Name = "preferredTimeSlot3DataGridViewTextBoxColumn";
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Location = new System.Drawing.Point(786, 278);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.Btn_Edit.TabIndex = 4;
            this.Btn_Edit.Text = "Edit";
            this.Btn_Edit.UseVisualStyleBackColor = true;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // routineInfoTableAdapter
            // 
            this.routineInfoTableAdapter.ClearBeforeFill = true;
            // 
            // Btn_ViewRoutine
            // 
            this.Btn_ViewRoutine.Location = new System.Drawing.Point(410, 276);
            this.Btn_ViewRoutine.Name = "Btn_ViewRoutine";
            this.Btn_ViewRoutine.Size = new System.Drawing.Size(88, 23);
            this.Btn_ViewRoutine.TabIndex = 5;
            this.Btn_ViewRoutine.Text = "View Routine";
            this.Btn_ViewRoutine.UseVisualStyleBackColor = true;
            this.Btn_ViewRoutine.Click += new System.EventHandler(this.Btn_ViewRoutine_Click);
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 311);
            this.Controls.Add(this.Btn_ViewRoutine);
            this.Controls.Add(this.Btn_Edit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Btn_New);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "AddCourseForm";
            this.Text = "AddCourseForm";
            this.Load += new System.EventHandler(this.AddCourseForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routineInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classRoutineDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_New;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label9;
        private ClassRoutineDataSet classRoutineDataSet;
        private System.Windows.Forms.BindingSource routineInfoBindingSource;
        private ClassRoutineDataSetTableAdapters.RoutineInfoTableAdapter routineInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherInitials;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseCreditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preferredTimeSlot1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preferredTimeSlot2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preferredTimeSlot3DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Btn_ViewRoutine;
    }
}