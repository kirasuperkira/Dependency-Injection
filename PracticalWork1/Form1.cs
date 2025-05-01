using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BusinessLogic;
using Ninject;

namespace laba1
{
    public partial class Form1: Form
    {
        private readonly IStudentLogic logic;

        public Form1()
        {
            //Для управления зависимостями через Ninject создаю объект Ninject.IKernel с помощью встроенной реализации этого интерфейса - класса StandardKernel
            IKernel ninjectKernel = new StandardKernel(new SimpleConfigModule());
            logic = ninjectKernel.Get<IStudentLogic>();

            InitializeComponent();
            UpdateStudentList();
        }

        /// <summary>
        /// Изменение студента
        /// </summary>
        private void UpdateStudentList()
        {
            dgvStudents.Rows.Clear();
            var students = logic.GetAllStudents();
            if (students != null)
            {
                foreach (var student in students)
                {
                    dgvStudents.Rows.Add(student["Name"], student["Speciality"], student["Group"], student["Id"].ToString());
                }
            }
        }

        /// <summary>
        /// Добавление студента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Form settingsForm = new Form();
            settingsForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            settingsForm.Text = "Добавить студента";
            settingsForm.Size = new Size(300, 210);
            settingsForm.MaximizeBox = false;

            Label nameLabel = new Label();
            nameLabel.Text = "Имя студента: ";
            nameLabel.Location = new Point(20, 20);

            System.Windows.Forms.TextBox nameTextBox = new System.Windows.Forms.TextBox();
            nameTextBox.Location = new Point(120, 20);

            Label specLabel = new Label();
            specLabel.Text = "Специальность студента: ";
            specLabel.Location = new Point(20, 50);

            System.Windows.Forms.TextBox specTextBox = new System.Windows.Forms.TextBox();
            specTextBox.Location = new Point(120, 50);

            Label groupLabel = new Label();
            groupLabel.Text = "Группа студента: ";
            groupLabel.Location = new Point(20, 80);

            System.Windows.Forms.TextBox groupTextBox = new System.Windows.Forms.TextBox();
            groupTextBox.Location = new Point(120, 80);

            Button addBut = new Button();
            addBut.Location = new Point(10, 110);
            addBut.Text = "Добавить студента";

            addBut.Click += (s, args) => {

                logic.AddStudent(nameTextBox.Text, specTextBox.Text, groupTextBox.Text);
                UpdateStudentList();
                settingsForm.Close();
            };

            settingsForm.Controls.Add(nameLabel);
            settingsForm.Controls.Add(nameTextBox);
            settingsForm.Controls.Add(specLabel);
            settingsForm.Controls.Add(specTextBox);
            settingsForm.Controls.Add(groupLabel);
            settingsForm.Controls.Add(groupTextBox);
            settingsForm.Controls.Add(addBut);

            settingsForm.ShowDialog();
        }

        /// <summary>
        /// Удаление студента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                //Получение Id выбранного студента
                int id;
                if (int.TryParse(dgvStudents.SelectedRows[0].Cells["Id"].Value?.ToString(), out id))
                {
                    if (logic.DeleteStudent(id.ToString()))
                    {
                        UpdateStudentList();
                    }
                    else
                    {
                        MessageBox.Show("Студент c данным идентификатором отсутсвует в списке.");
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка получения данных о студенте с данным идентификатором.");
                }
            }
            else
            {
                MessageBox.Show("Ввеедите идентификатор студента, которого вы хотите удалить.");
            }
        }

        /// <summary>
        /// Изменение студента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count == 1)
            {
                string id = dgvStudents.SelectedRows[0].Cells["Id"].Value.ToString();

                Form updata = new Form() { Text = "Изменение данных о студенте", Size = new Size(320, 210), MaximizeBox = false };
                TextBox updname = new TextBox() { Location = new Point(110, 10), Text = dgvStudents.SelectedRows[0].Cells["Name"].Value.ToString() };
                Label upnamelb = new Label() { Location = new Point(10, 10), Text = "Новое имя студента: " };
                TextBox updspec = new TextBox() { Location = new Point(110, 40), Text = dgvStudents.SelectedRows[0].Cells["Speciality"].Value.ToString() };
                Label upspeclb = new Label() { Location = new Point(10, 40), Text = "Новая специальность студента: " };
                TextBox updgroup = new TextBox() { Location = new Point(110, 70) , Text = dgvStudents.SelectedRows[0].Cells["Group"].Value.ToString() };
                Label upgrouplb = new Label() { Location = new Point(10, 70), Text = "Новая группа студента: " };
                Button editBut = new Button() { Location = new Point(10, 100), Text = "Обновить данные о студенте" };

                updata.Controls.Add(updname);
                updata.Controls.Add(updspec);
                updata.Controls.Add(updgroup);
                updata.Controls.Add(editBut);
                updata.Controls.Add(upgrouplb);
                updata.Controls.Add(upspeclb);
                updata.Controls.Add(upnamelb);

                string newName = updname.Text;
                string newSpeciality = updspec.Text;
                string newGroup = updgroup.Text;

                editBut.Click += (s, args) =>
                {

                    logic.EditStudent(id, updname.Text, updspec.Text, updgroup.Text);
                    UpdateStudentList();
                    updata.Close();
                };
                updata.ShowDialog();
            }
        }

        /// <summary>
        /// Получить гистограмму (распределение по специальностям)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowHistogram_Click(object sender, EventArgs e)
        {
            var histogram = logic.GetSpecialityHistogram();

            Form histogramForm = new Form();
            histogramForm.Text = "Распределение студентов по специальностям";

            Chart chart = new Chart();
            chart.Dock = DockStyle.Fill;

            Series series = new Series("SpecialityHistogram");
            series.ChartType = SeriesChartType.Column;

            foreach (var speciality in histogram)
            {
                series.Points.AddXY(speciality.Key, speciality.Value);
            }

            chart.Series.Add(series);
            chart.ChartAreas.Add(new ChartArea());

            histogramForm.Controls.Add(chart);
            histogramForm.ShowDialog();
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }
    }
}