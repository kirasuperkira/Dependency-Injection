namespace laba1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.btnShowHistogram = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speciality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAddStudent.Location = new System.Drawing.Point(51, 247);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(210, 43);
            this.btnAddStudent.TabIndex = 0;
            this.btnAddStudent.Text = "Добавить студента";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnRemoveStudent.Location = new System.Drawing.Point(51, 349);
            this.btnRemoveStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(210, 43);
            this.btnRemoveStudent.TabIndex = 1;
            this.btnRemoveStudent.Text = "Удалить студента";
            this.btnRemoveStudent.UseVisualStyleBackColor = false;
            this.btnRemoveStudent.Click += new System.EventHandler(this.btnRemoveStudent_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.EditButton.Location = new System.Drawing.Point(51, 298);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(210, 43);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Изменить данные студента";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // btnShowHistogram
            // 
            this.btnShowHistogram.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnShowHistogram.Location = new System.Drawing.Point(51, 400);
            this.btnShowHistogram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowHistogram.Name = "btnShowHistogram";
            this.btnShowHistogram.Size = new System.Drawing.Size(210, 45);
            this.btnShowHistogram.TabIndex = 3;
            this.btnShowHistogram.Text = "Гистограмма (распределение по специальностям)";
            this.btnShowHistogram.UseVisualStyleBackColor = false;
            this.btnShowHistogram.Click += new System.EventHandler(this.btnShowHistogram_Click);
            // 
            // dgvStudents
            // 
            this.dgvStudents.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Speciality,
            this.Group,
            this.Id});
            this.dgvStudents.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvStudents.Location = new System.Drawing.Point(48, 79);
            this.dgvStudents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.Size = new System.Drawing.Size(399, 106);
            this.dgvStudents.TabIndex = 4;
            // 
            // Name
            // 
            this.Name.HeaderText = "Имя";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 140;
            // 
            // Speciality
            // 
            this.Speciality.HeaderText = "Специальность";
            this.Speciality.MinimumWidth = 6;
            this.Speciality.Name = "Speciality";
            this.Speciality.Width = 125;
            // 
            // Group
            // 
            this.Group.HeaderText = "Группа";
            this.Group.MinimumWidth = 6;
            this.Group.Name = "Group";
            this.Group.Width = 80;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Список студентов:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Выберете действие:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 589);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.btnShowHistogram);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.btnRemoveStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "DecanatPRO";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnRemoveStudent;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button btnShowHistogram;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speciality;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

