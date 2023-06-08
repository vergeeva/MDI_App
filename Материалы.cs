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
    public partial class Материалы : Form
    {
        bool insert = false; //если не добавление, то обновление
        private readonly MDIParent1 MainForm; //Объект для доступа к главной форме
        public Материалы(MDIParent1 form)
        {
            InitializeComponent();
            MainForm = form;
        }

        private void Материалы_Load(object sender, EventArgs e)
        {
            // Подключение биндинга к гриду
            TableMaterials.DataSource = MainForm.view_МатериалыBindingSource;
            // Подключение биндинга к навигатору
            bindingNavigator1.BindingSource = MainForm.view_МатериалыBindingSource;
            //подключение к тестовому полю
            textBox1.DataBindings.Add("Text", MainForm.view_МатериалыBindingSource, "Наименование",
                true, DataSourceUpdateMode.OnPropertyChanged);
            // Выравние колонок по содержимому
            TableMaterials.AutoResizeColumns();
            // Скрытие поля айдишника
            TableMaterials.Columns[0].Visible = false;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                insert = true;
                MainForm.view_МатериалыBindingSource.AddNew();
                TableMaterials.Rows[TableMaterials.Rows.Count - 1].Selected = true;
            }
            catch (Exception)
            {
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            string name = "";
            try
            {
                int id;
                DataRowView dt;

                dt = (DataRowView)MainForm.view_МатериалыBindingSource.Current;
                id = (int)dt["Код_марки"];
                name = (string)dt["Наименование"];

                MainForm.StoredProcedures.Delete_Материал(id);
                MainForm.view_МатериалыTableAdapter.Fill(MainForm.exampleBaseDataSet.View_Материалы);
            }
            catch (Exception)
            {

                MessageBox.Show(String.Format("Нельзя удалить товар '{0}' в связи с целостностью данных", name), "Произошла ошибка удаления");
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (insert)
                {
                    if (textBox1.Text != "")
                    {
                        //добавление товара
                        MainForm.StoredProcedures.Insert_Материал(textBox1.Text);
                        insert = false;
                    }
                }
                else
                {
                    //обновление данных
                    if (textBox1.Text != "")
                    {
                        //добавление товара
                        int id;
                        DataRowView dt;

                        dt = (DataRowView)MainForm.view_МатериалыBindingSource.Current;
                        id = (int)dt["Код_марки"];
                        MainForm.StoredProcedures.Update_Материал(id, textBox1.Text);
                    }
                }
                MainForm.view_МатериалыTableAdapter.Fill(MainForm.exampleBaseDataSet.View_Материалы);
                TableMaterials.AutoResizeColumns();
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка сохранения, скорее всего данные не соответствуют условиям", "Произошла ошибка сохранения данных");
            }
        }
    }
}
