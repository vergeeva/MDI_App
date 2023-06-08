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
    public partial class Акты : Form
    {
        bool insert = false; //если не добавление, то обновление
        private readonly MDIParent1 MainForm; //Объект для доступа к главной форме
        public Акты(MDIParent1 form)
        {
            InitializeComponent();
            MainForm = form;
        }

        private void Акты_Load(object sender, EventArgs e)
        {


        }
    }
}
