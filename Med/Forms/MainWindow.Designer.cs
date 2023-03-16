namespace Med.Forms
{
    partial class MainWindow
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
            this.butDel = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accName = new System.Windows.Forms.ToolStripTextBox();
            this.searchValues = new System.Windows.Forms.TextBox();
            this.butSearch = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.butEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchPole = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabJournal = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabClients = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabDiagnoz = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabWorkers = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tabAccounts = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.tabDoljnosti = new System.Windows.Forms.TabPage();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.tabRole = new System.Windows.Forms.TabPage();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.tabKab = new System.Windows.Forms.TabPage();
            this.dataGridView8 = new System.Windows.Forms.DataGridView();
            this.filtrValues = new System.Windows.Forms.TextBox();
            this.butFiltrAdd = new System.Windows.Forms.Button();
            this.filtrPole = new System.Windows.Forms.ComboBox();
            this.filtrList = new System.Windows.Forms.ListBox();
            this.butFilrtClear = new System.Windows.Forms.Button();
            this.butFiltrDel = new System.Windows.Forms.Button();
            this.butFiltrSearch = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabJournal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabDiagnoz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabWorkers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.tabDoljnosti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.tabRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            this.tabKab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).BeginInit();
            this.SuspendLayout();
            // 
            // butDel
            // 
            this.butDel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butDel.Location = new System.Drawing.Point(12, 33);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(92, 32);
            this.butDel.TabIndex = 1;
            this.butDel.Text = "Удалить";
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accName});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1079, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accName
            // 
            this.accName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.accName.Enabled = false;
            this.accName.Name = "accName";
            this.accName.Size = new System.Drawing.Size(150, 20);
            // 
            // searchValues
            // 
            this.searchValues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchValues.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchValues.Location = new System.Drawing.Point(807, 137);
            this.searchValues.Name = "searchValues";
            this.searchValues.Size = new System.Drawing.Size(202, 26);
            this.searchValues.TabIndex = 3;
            // 
            // butSearch
            // 
            this.butSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butSearch.Location = new System.Drawing.Point(934, 107);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(75, 28);
            this.butSearch.TabIndex = 4;
            this.butSearch.Text = "Поиск";
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // butAdd
            // 
            this.butAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butAdd.Location = new System.Drawing.Point(110, 33);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(92, 32);
            this.butAdd.TabIndex = 5;
            this.butAdd.Text = "Добавить";
            this.butAdd.UseVisualStyleBackColor = true;
            // 
            // butEdit
            // 
            this.butEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butEdit.Location = new System.Drawing.Point(208, 33);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(92, 32);
            this.butEdit.TabIndex = 6;
            this.butEdit.Text = "Изменить";
            this.butEdit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(807, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Поиск";
            // 
            // searchPole
            // 
            this.searchPole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchPole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchPole.FormattingEnabled = true;
            this.searchPole.Location = new System.Drawing.Point(807, 108);
            this.searchPole.Name = "searchPole";
            this.searchPole.Size = new System.Drawing.Size(121, 27);
            this.searchPole.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(807, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Фильтр";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabJournal);
            this.tabControl1.Controls.Add(this.tabClients);
            this.tabControl1.Controls.Add(this.tabDiagnoz);
            this.tabControl1.Controls.Add(this.tabWorkers);
            this.tabControl1.Controls.Add(this.tabAccounts);
            this.tabControl1.Controls.Add(this.tabDoljnosti);
            this.tabControl1.Controls.Add(this.tabRole);
            this.tabControl1.Controls.Add(this.tabKab);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(12, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(789, 505);
            this.tabControl1.TabIndex = 14;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabJournal
            // 
            this.tabJournal.Controls.Add(this.dataGridView1);
            this.tabJournal.Location = new System.Drawing.Point(4, 28);
            this.tabJournal.Name = "tabJournal";
            this.tabJournal.Padding = new System.Windows.Forms.Padding(3);
            this.tabJournal.Size = new System.Drawing.Size(781, 473);
            this.tabJournal.TabIndex = 0;
            this.tabJournal.Text = "Журнал";
            this.tabJournal.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(781, 473);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabClients
            // 
            this.tabClients.Controls.Add(this.dataGridView2);
            this.tabClients.Location = new System.Drawing.Point(4, 28);
            this.tabClients.Name = "tabClients";
            this.tabClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabClients.Size = new System.Drawing.Size(781, 473);
            this.tabClients.TabIndex = 1;
            this.tabClients.Text = "Клиенты";
            this.tabClients.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(781, 473);
            this.dataGridView2.TabIndex = 1;
            // 
            // tabDiagnoz
            // 
            this.tabDiagnoz.Controls.Add(this.dataGridView3);
            this.tabDiagnoz.Location = new System.Drawing.Point(4, 28);
            this.tabDiagnoz.Name = "tabDiagnoz";
            this.tabDiagnoz.Size = new System.Drawing.Size(781, 473);
            this.tabDiagnoz.TabIndex = 2;
            this.tabDiagnoz.Text = "Диагнозы";
            this.tabDiagnoz.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(781, 473);
            this.dataGridView3.TabIndex = 1;
            // 
            // tabWorkers
            // 
            this.tabWorkers.Controls.Add(this.dataGridView4);
            this.tabWorkers.Location = new System.Drawing.Point(4, 28);
            this.tabWorkers.Name = "tabWorkers";
            this.tabWorkers.Size = new System.Drawing.Size(781, 473);
            this.tabWorkers.TabIndex = 3;
            this.tabWorkers.Text = "Работники";
            this.tabWorkers.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(0, 0);
            this.dataGridView4.MultiSelect = false;
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowTemplate.Height = 25;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(781, 473);
            this.dataGridView4.TabIndex = 1;
            // 
            // tabAccounts
            // 
            this.tabAccounts.Controls.Add(this.dataGridView5);
            this.tabAccounts.Location = new System.Drawing.Point(4, 28);
            this.tabAccounts.Name = "tabAccounts";
            this.tabAccounts.Size = new System.Drawing.Size(781, 473);
            this.tabAccounts.TabIndex = 4;
            this.tabAccounts.Text = "Аккаунты";
            this.tabAccounts.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(0, 0);
            this.dataGridView5.MultiSelect = false;
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.RowTemplate.Height = 25;
            this.dataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView5.Size = new System.Drawing.Size(781, 473);
            this.dataGridView5.TabIndex = 1;
            // 
            // tabDoljnosti
            // 
            this.tabDoljnosti.Controls.Add(this.dataGridView6);
            this.tabDoljnosti.Location = new System.Drawing.Point(4, 28);
            this.tabDoljnosti.Name = "tabDoljnosti";
            this.tabDoljnosti.Size = new System.Drawing.Size(781, 473);
            this.tabDoljnosti.TabIndex = 5;
            this.tabDoljnosti.Text = "Должности";
            this.tabDoljnosti.UseVisualStyleBackColor = true;
            // 
            // dataGridView6
            // 
            this.dataGridView6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(0, 0);
            this.dataGridView6.MultiSelect = false;
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.ReadOnly = true;
            this.dataGridView6.RowTemplate.Height = 25;
            this.dataGridView6.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView6.Size = new System.Drawing.Size(781, 473);
            this.dataGridView6.TabIndex = 1;
            // 
            // tabRole
            // 
            this.tabRole.Controls.Add(this.dataGridView7);
            this.tabRole.Location = new System.Drawing.Point(4, 28);
            this.tabRole.Name = "tabRole";
            this.tabRole.Size = new System.Drawing.Size(781, 473);
            this.tabRole.TabIndex = 6;
            this.tabRole.Text = "Роли";
            this.tabRole.UseVisualStyleBackColor = true;
            // 
            // dataGridView7
            // 
            this.dataGridView7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Location = new System.Drawing.Point(0, 0);
            this.dataGridView7.MultiSelect = false;
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.ReadOnly = true;
            this.dataGridView7.RowTemplate.Height = 25;
            this.dataGridView7.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView7.Size = new System.Drawing.Size(781, 473);
            this.dataGridView7.TabIndex = 1;
            // 
            // tabKab
            // 
            this.tabKab.Controls.Add(this.dataGridView8);
            this.tabKab.Location = new System.Drawing.Point(4, 28);
            this.tabKab.Name = "tabKab";
            this.tabKab.Size = new System.Drawing.Size(781, 473);
            this.tabKab.TabIndex = 7;
            this.tabKab.Text = "Кабинеты";
            this.tabKab.UseVisualStyleBackColor = true;
            // 
            // dataGridView8
            // 
            this.dataGridView8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView8.Location = new System.Drawing.Point(0, 0);
            this.dataGridView8.MultiSelect = false;
            this.dataGridView8.Name = "dataGridView8";
            this.dataGridView8.ReadOnly = true;
            this.dataGridView8.RowTemplate.Height = 25;
            this.dataGridView8.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView8.Size = new System.Drawing.Size(781, 473);
            this.dataGridView8.TabIndex = 1;
            // 
            // filtrValues
            // 
            this.filtrValues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filtrValues.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.filtrValues.Location = new System.Drawing.Point(807, 235);
            this.filtrValues.Name = "filtrValues";
            this.filtrValues.Size = new System.Drawing.Size(202, 26);
            this.filtrValues.TabIndex = 11;
            // 
            // butFiltrAdd
            // 
            this.butFiltrAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butFiltrAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butFiltrAdd.Location = new System.Drawing.Point(934, 205);
            this.butFiltrAdd.Name = "butFiltrAdd";
            this.butFiltrAdd.Size = new System.Drawing.Size(75, 28);
            this.butFiltrAdd.TabIndex = 12;
            this.butFiltrAdd.Text = "Добавить";
            this.butFiltrAdd.UseVisualStyleBackColor = true;
            // 
            // filtrPole
            // 
            this.filtrPole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filtrPole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.filtrPole.FormattingEnabled = true;
            this.filtrPole.Location = new System.Drawing.Point(807, 206);
            this.filtrPole.Name = "filtrPole";
            this.filtrPole.Size = new System.Drawing.Size(121, 27);
            this.filtrPole.TabIndex = 13;
            // 
            // filtrList
            // 
            this.filtrList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filtrList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.filtrList.FormattingEnabled = true;
            this.filtrList.ItemHeight = 19;
            this.filtrList.Location = new System.Drawing.Point(808, 263);
            this.filtrList.Name = "filtrList";
            this.filtrList.Size = new System.Drawing.Size(120, 118);
            this.filtrList.TabIndex = 15;
            // 
            // butFilrtClear
            // 
            this.butFilrtClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butFilrtClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butFilrtClear.Location = new System.Drawing.Point(934, 351);
            this.butFilrtClear.Name = "butFilrtClear";
            this.butFilrtClear.Size = new System.Drawing.Size(75, 23);
            this.butFilrtClear.TabIndex = 16;
            this.butFilrtClear.Text = "Сброс все";
            this.butFilrtClear.UseVisualStyleBackColor = true;
            // 
            // butFiltrDel
            // 
            this.butFiltrDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butFiltrDel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butFiltrDel.Location = new System.Drawing.Point(934, 322);
            this.butFiltrDel.Name = "butFiltrDel";
            this.butFiltrDel.Size = new System.Drawing.Size(75, 23);
            this.butFiltrDel.TabIndex = 17;
            this.butFiltrDel.Text = "Удалить";
            this.butFiltrDel.UseVisualStyleBackColor = true;
            // 
            // butFiltrSearch
            // 
            this.butFiltrSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butFiltrSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butFiltrSearch.Location = new System.Drawing.Point(934, 264);
            this.butFiltrSearch.Name = "butFiltrSearch";
            this.butFiltrSearch.Size = new System.Drawing.Size(75, 52);
            this.butFiltrSearch.TabIndex = 18;
            this.butFiltrSearch.Text = "Поиск по фильтру";
            this.butFiltrSearch.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 580);
            this.Controls.Add(this.butFiltrSearch);
            this.Controls.Add(this.butFiltrDel);
            this.Controls.Add(this.butFilrtClear);
            this.Controls.Add(this.filtrList);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.filtrPole);
            this.Controls.Add(this.butFiltrAdd);
            this.Controls.Add(this.filtrValues);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchPole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butEdit);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.searchValues);
            this.Controls.Add(this.butDel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(819, 444);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabJournal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabDiagnoz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabWorkers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabAccounts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.tabDoljnosti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.tabRole.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            this.tabKab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button butDel;
        private MenuStrip menuStrip1;
        private TextBox searchValues;
        private Button butSearch;
        private Button butAdd;
        private Button butEdit;
        private Label label1;
        private ComboBox searchPole;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabJournal;
        private TabPage tabClients;
        private TextBox filtrValues;
        private Button butFiltrAdd;
        private ComboBox filtrPole;
        private ListBox filtrList;
        private TabPage tabDiagnoz;
        private TabPage tabWorkers;
        private TabPage tabAccounts;
        private TabPage tabDoljnosti;
        private TabPage tabRole;
        private TabPage tabKab;
        private Button butFilrtClear;
        private Button butFiltrDel;
        private Button butFiltrSearch;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private DataGridView dataGridView4;
        private DataGridView dataGridView5;
        private DataGridView dataGridView6;
        private DataGridView dataGridView7;
        private DataGridView dataGridView8;
        private ToolStripTextBox accName;
    }
}