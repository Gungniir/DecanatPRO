using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using Model;
using ZedGraph;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ListView = System.Windows.Forms.ListView;

namespace DecanatPRO
{
    public partial class FromMain : Form
    {
        private readonly Logic _logic;

        public FromMain(Logic logic)
        {
            _logic = logic;
            InitializeComponent();
            InitStudentsLists();
        }

        private void InitStudentsLists()
        {
            listViewStudents.Clear();
            
            ColumnHeader headerName = new ColumnHeader();
            headerName.Text = "Имя";
            headerName.Width = 120;
            listViewStudents.Columns.Add(headerName);
            ColumnHeader headerSpec = new ColumnHeader();
            headerSpec.Text = "Специальность";
            headerSpec.Width = 120;
            listViewStudents.Columns.Add(headerSpec);
            ColumnHeader headerGroup = new ColumnHeader();
            headerGroup.Text = "Группа";
            headerGroup.Width = 60;
            listViewStudents.Columns.Add(headerGroup);
        }

        private void ReloadStudentsList()
        {
            listViewStudents.Items.Clear();

            List<Student> students = _logic.ShowTable();

            foreach (Student student in students)
            {
                ListViewItem item = new ListViewItem(student.Name);
                item.SubItems.Add(student.Speciality);
                item.SubItems.Add(student.Group);
            
                listViewStudents.Items.Add(item);
            }
        }

        private void ReloadZedGraph()
        {
            var groups = _logic.ShowGist();

            if (!groups.Any())
            {
                return;
            }

            GraphPane pane = zedGraph.GraphPane;

            pane.CurveList.Clear();

            string[] names = groups.Select(group => group.Key).ToArray();
            double[] values = groups.Select(group => Convert.ToDouble(group.Count())).ToArray();

            BarItem curve = pane.AddBar("Гистограмма", null, values, Color.Blue);

            // Настроим ось X так, чтобы она отображала текстовые данные
            pane.XAxis.Type = AxisType.Text;

            // Уставим для оси наши подписи
            pane.XAxis.Scale.TextLabels = names;

            // Вызываем метод AxisChange (), чтобы обновить данные об осях.
            zedGraph.AxisChange();

            // Обновляем график
            zedGraph.Invalidate();
        }

        private void buttonFill_Click(object sender, EventArgs e)
        {
            _logic.FillStudents();
            ReloadStudentsList();
            ReloadZedGraph();
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            FormAddStudent formAddStudent = new FormAddStudent(_logic);

            formAddStudent.Show();
            Hide();
            formAddStudent.Closed += (o, args) => Show();
            formAddStudent.Closed += (o, args) => ReloadStudentsList();
            formAddStudent.Closed += (o, args) => ReloadZedGraph();
        }

        private void listViewStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDelete.Enabled = listViewStudents.SelectedItems.Count > 0;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = listViewStudents.SelectedItems;

            foreach (ListViewItem item in selected)
            {
                _logic.DeleteStudent(item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text);
            }

            buttonDelete.Enabled = false;
            ReloadStudentsList();
            ReloadZedGraph();
        }
    }
}
