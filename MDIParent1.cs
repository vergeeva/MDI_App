using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MDIParent1 : Form
    {

        public MDIParent1()
        {
            InitializeComponent();
        }
        public bool RunFilter(BindingSource binding, string value, string field)//биндинг, значение фильтра, поле для фильтрации
        {//задать фильтр таблице
            try
            {
                if (value == "" && field == "")
                {//если поле и значение не указано
                    binding.Filter = "";//присваиваем пустой фильтр
                    return true;//фильтр сработал, возвращаем
                }
                if (int.TryParse(value, out _))
                {//если число
                    binding.Filter = String.Format("[{0}] = {1}", field, value);
                }
                else
                {//если пользователь использует знаки
                    if (value[0] == '<' || value[0] == '>' || value[0] == '=')
                    {
                        if ((int.TryParse(value.Substring(1), out _)) || (value[1] == '=' && int.TryParse(value.Substring(2), out _)))
                        {//для чисел
                            binding.Filter = String.Format("[{0}] {1}", field, value);
                        }
                        else if (DateTime.TryParse(value.Substring(1), out _))
                        {//если знак однозначный для даты
                            char mark = value[0];
                            value = Convert.ToDateTime(value.Substring(1)).ToString().Replace('.', '-');
                            binding.Filter = String.Format("[{0}] {1}'{2}'", field, mark, value);
                        }
                        else if (value[1] == '=' && DateTime.TryParse(value.Substring(2), out _))
                        {//если знак из двух знаков для даты
                            string mark = value.Substring(0, 2);
                            //конвертируем дату, так как для сравнения формат даты немного другой
                            value = Convert.ToDateTime(value.Substring(2)).ToString().Replace('.', '-');
                            binding.Filter = String.Format("[{0}] {1}'{2}'", field, mark, value);
                        }
                    }
                    else
                    {//для строк
                        if (value[value.Length - 1] == '*')
                        {//если есть звездочка
                            binding.Filter = String.Format("[{0}] like '{1}'", field, value);
                        }
                        else if (DateTime.TryParse(value, out _))
                        {//если дата без знаков
                            //конвертируем дату, так как для сравнения формат даты немного другой
                            value = Convert.ToDateTime(value).ToString().Replace('.', '-');
                            binding.Filter = String.Format("[{0}] = '{1}'", field, value);
                        }
                        else
                        {//если строка без звездочки
                            binding.Filter = String.Format("[{0}] like '{1}*'", field, value);
                        }
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void fileMenu_Click(object sender, EventArgs e)
        {

        }

        private void актыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new Акты(this);
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void материальныеЦенностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new Материалы(this)
            {
                MdiParent = this
            };
            childForm.Show();
        }

        private void планToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new План();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void расчетСуммАмортизационныхОтчисленийToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void расчетСуммАмортизационныхОтчисленийToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form childForm = new Отчет_отчислений();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void ведомостьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form childForm = new Ведомость();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "exampleBaseDataSet.View_РасчетСуммыАмортОтчислений". При необходимости она может быть перемещена или удалена.
            this.view_РасчетСуммыАмортОтчисленийTableAdapter.Fill(this.exampleBaseDataSet.View_РасчетСуммыАмортОтчислений);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "exampleBaseDataSet.View_План". При необходимости она может быть перемещена или удалена.
            this.view_ПланTableAdapter.Fill(this.exampleBaseDataSet.View_План);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "exampleBaseDataSet.View_Материалы". При необходимости она может быть перемещена или удалена.
            this.view_МатериалыTableAdapter.Fill(this.exampleBaseDataSet.View_Материалы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "exampleBaseDataSet.View_Ведомость". При необходимости она может быть перемещена или удалена.
            this.view_ВедомостьTableAdapter.Fill(this.exampleBaseDataSet.View_Ведомость);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "exampleBaseDataSet.View_Акты". При необходимости она может быть перемещена или удалена.
            this.view_АктыTableAdapter.Fill(this.exampleBaseDataSet.View_Акты);
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
