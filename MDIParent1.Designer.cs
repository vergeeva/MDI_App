
namespace WindowsFormsApp1
{
    partial class MDIParent1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.актыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.материальныеЦенностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.планToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расчетСуммАмортизационныхОтчисленийToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ведомостьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.exampleBaseDataSet = new WindowsFormsApp1.ExampleBaseDataSet();
            this.view_АктыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_АктыTableAdapter = new WindowsFormsApp1.ExampleBaseDataSetTableAdapters.View_АктыTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.ExampleBaseDataSetTableAdapters.TableAdapterManager();
            this.view_ВедомостьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_ВедомостьTableAdapter = new WindowsFormsApp1.ExampleBaseDataSetTableAdapters.View_ВедомостьTableAdapter();
            this.view_МатериалыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_МатериалыTableAdapter = new WindowsFormsApp1.ExampleBaseDataSetTableAdapters.View_МатериалыTableAdapter();
            this.view_ПланBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_ПланTableAdapter = new WindowsFormsApp1.ExampleBaseDataSetTableAdapters.View_ПланTableAdapter();
            this.view_РасчетСуммыАмортОтчисленийBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_РасчетСуммыАмортОтчисленийTableAdapter = new WindowsFormsApp1.ExampleBaseDataSetTableAdapters.View_РасчетСуммыАмортОтчисленийTableAdapter();
            this.StoredProcedures = new WindowsFormsApp1.ExampleBaseDataSetTableAdapters.QueriesTableAdapter();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exampleBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_АктыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ВедомостьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_МатериалыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ПланBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_РасчетСуммыАмортОтчисленийBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.windowsMenu,
            this.отчетыToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(15, 4, 0, 4);
            this.menuStrip.Size = new System.Drawing.Size(1693, 44);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.актыToolStripMenuItem,
            this.материальныеЦенностиToolStripMenuItem,
            this.планToolStripMenuItem});
            this.fileMenu.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(126, 36);
            this.fileMenu.Text = "&Таблицы";
            this.fileMenu.Click += new System.EventHandler(this.fileMenu_Click);
            // 
            // актыToolStripMenuItem
            // 
            this.актыToolStripMenuItem.Name = "актыToolStripMenuItem";
            this.актыToolStripMenuItem.Size = new System.Drawing.Size(381, 36);
            this.актыToolStripMenuItem.Text = "Акты";
            this.актыToolStripMenuItem.Click += new System.EventHandler(this.актыToolStripMenuItem_Click);
            // 
            // материальныеЦенностиToolStripMenuItem
            // 
            this.материальныеЦенностиToolStripMenuItem.Name = "материальныеЦенностиToolStripMenuItem";
            this.материальныеЦенностиToolStripMenuItem.Size = new System.Drawing.Size(381, 36);
            this.материальныеЦенностиToolStripMenuItem.Text = "Материальные ценности";
            this.материальныеЦенностиToolStripMenuItem.Click += new System.EventHandler(this.материальныеЦенностиToolStripMenuItem_Click);
            // 
            // планToolStripMenuItem
            // 
            this.планToolStripMenuItem.Name = "планToolStripMenuItem";
            this.планToolStripMenuItem.Size = new System.Drawing.Size(381, 36);
            this.планToolStripMenuItem.Text = "План";
            this.планToolStripMenuItem.Click += new System.EventHandler(this.планToolStripMenuItem_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem,
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
            this.windowsMenu.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(85, 36);
            this.windowsMenu.Text = "&Окна";
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(333, 36);
            this.newWindowToolStripMenuItem.Text = "&Новое окно";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(333, 36);
            this.cascadeToolStripMenuItem.Text = "&Каскадом";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(333, 36);
            this.tileVerticalToolStripMenuItem.Text = "С&лева направо";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(333, 36);
            this.tileHorizontalToolStripMenuItem.Text = "С&верху вниз";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(333, 36);
            this.closeAllToolStripMenuItem.Text = "&Закрыть все";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(333, 36);
            this.arrangeIconsToolStripMenuItem.Text = "&Упорядочить значки";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.расчетСуммАмортизационныхОтчисленийToolStripMenuItem1,
            this.ведомостьToolStripMenuItem1});
            this.отчетыToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(111, 36);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // расчетСуммАмортизационныхОтчисленийToolStripMenuItem1
            // 
            this.расчетСуммАмортизационныхОтчисленийToolStripMenuItem1.Name = "расчетСуммАмортизационныхОтчисленийToolStripMenuItem1";
            this.расчетСуммАмортизационныхОтчисленийToolStripMenuItem1.Size = new System.Drawing.Size(588, 36);
            this.расчетСуммАмортизационныхОтчисленийToolStripMenuItem1.Text = "Расчет сумм амортизационных отчислений";
            this.расчетСуммАмортизационныхОтчисленийToolStripMenuItem1.Click += new System.EventHandler(this.расчетСуммАмортизационныхОтчисленийToolStripMenuItem1_Click);
            // 
            // ведомостьToolStripMenuItem1
            // 
            this.ведомостьToolStripMenuItem1.Name = "ведомостьToolStripMenuItem1";
            this.ведомостьToolStripMenuItem1.Size = new System.Drawing.Size(588, 36);
            this.ведомостьToolStripMenuItem1.Text = "Ведомость";
            this.ведомостьToolStripMenuItem1.Click += new System.EventHandler(this.ведомостьToolStripMenuItem1_Click);
            // 
            // exampleBaseDataSet
            // 
            this.exampleBaseDataSet.DataSetName = "ExampleBaseDataSet";
            this.exampleBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_АктыBindingSource
            // 
            this.view_АктыBindingSource.DataMember = "View_Акты";
            this.view_АктыBindingSource.DataSource = this.exampleBaseDataSet;
            // 
            // view_АктыTableAdapter
            // 
            this.view_АктыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.ExampleBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // view_ВедомостьBindingSource
            // 
            this.view_ВедомостьBindingSource.DataMember = "View_Ведомость";
            this.view_ВедомостьBindingSource.DataSource = this.exampleBaseDataSet;
            // 
            // view_ВедомостьTableAdapter
            // 
            this.view_ВедомостьTableAdapter.ClearBeforeFill = true;
            // 
            // view_МатериалыBindingSource
            // 
            this.view_МатериалыBindingSource.DataMember = "View_Материалы";
            this.view_МатериалыBindingSource.DataSource = this.exampleBaseDataSet;
            // 
            // view_МатериалыTableAdapter
            // 
            this.view_МатериалыTableAdapter.ClearBeforeFill = true;
            // 
            // view_ПланBindingSource
            // 
            this.view_ПланBindingSource.DataMember = "View_План";
            this.view_ПланBindingSource.DataSource = this.exampleBaseDataSet;
            // 
            // view_ПланTableAdapter
            // 
            this.view_ПланTableAdapter.ClearBeforeFill = true;
            // 
            // view_РасчетСуммыАмортОтчисленийBindingSource
            // 
            this.view_РасчетСуммыАмортОтчисленийBindingSource.DataMember = "View_РасчетСуммыАмортОтчислений";
            this.view_РасчетСуммыАмортОтчисленийBindingSource.DataSource = this.exampleBaseDataSet;
            // 
            // view_РасчетСуммыАмортОтчисленийTableAdapter
            // 
            this.view_РасчетСуммыАмортОтчисленийTableAdapter.ClearBeforeFill = true;
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1693, 881);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "MDIParent1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Материальные ценности";
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exampleBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_АктыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ВедомостьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_МатериалыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ПланBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_РасчетСуммыАмортОтчисленийBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem актыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem материальныеЦенностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem планToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расчетСуммАмортизационныхОтчисленийToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ведомостьToolStripMenuItem1;
        public ExampleBaseDataSet exampleBaseDataSet;
        public System.Windows.Forms.BindingSource view_АктыBindingSource;
        public ExampleBaseDataSetTableAdapters.View_АктыTableAdapter view_АктыTableAdapter;
        public ExampleBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.BindingSource view_ВедомостьBindingSource;
        public ExampleBaseDataSetTableAdapters.View_ВедомостьTableAdapter view_ВедомостьTableAdapter;
        public System.Windows.Forms.BindingSource view_МатериалыBindingSource;
        public ExampleBaseDataSetTableAdapters.View_МатериалыTableAdapter view_МатериалыTableAdapter;
        public System.Windows.Forms.BindingSource view_ПланBindingSource;
        public ExampleBaseDataSetTableAdapters.View_ПланTableAdapter view_ПланTableAdapter;
        public System.Windows.Forms.BindingSource view_РасчетСуммыАмортОтчисленийBindingSource;
        public ExampleBaseDataSetTableAdapters.View_РасчетСуммыАмортОтчисленийTableAdapter view_РасчетСуммыАмортОтчисленийTableAdapter;
        public ExampleBaseDataSetTableAdapters.QueriesTableAdapter StoredProcedures;
    }
}



