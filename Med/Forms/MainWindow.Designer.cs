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
            butDel = new Button();
            menuStrip1 = new MenuStrip();
            accName = new ToolStripTextBox();
            searchValues = new TextBox();
            butSearch = new Button();
            butAdd = new Button();
            butEdit = new Button();
            label1 = new Label();
            searchPole = new ComboBox();
            label2 = new Label();
            tabControl1 = new TabControl();
            tab1 = new TabPage();
            dataGridView1 = new DataGridView();
            tab2 = new TabPage();
            dataGridView2 = new DataGridView();
            tab3 = new TabPage();
            dataGridView3 = new DataGridView();
            tab4 = new TabPage();
            dataGridView4 = new DataGridView();
            tab5 = new TabPage();
            dataGridView5 = new DataGridView();
            tab6 = new TabPage();
            dataGridView6 = new DataGridView();
            tab7 = new TabPage();
            dataGridView7 = new DataGridView();
            tab8 = new TabPage();
            dataGridView8 = new DataGridView();
            filtrValues = new TextBox();
            butFiltrAdd = new Button();
            filtrPole = new ComboBox();
            filtrList = new ListBox();
            butFilrtClear = new Button();
            butFiltrDel = new Button();
            butFiltrSearch = new Button();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tab3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tab4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            tab5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            tab6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).BeginInit();
            tab7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView7).BeginInit();
            tab8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView8).BeginInit();
            SuspendLayout();
            // 
            // butDel
            // 
            butDel.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butDel.Location = new Point(12, 33);
            butDel.Name = "butDel";
            butDel.Size = new Size(92, 32);
            butDel.TabIndex = 1;
            butDel.Text = "Удалить";
            butDel.UseVisualStyleBackColor = true;
            butDel.Click += butDel_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { accName });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1079, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // accName
            // 
            accName.BorderStyle = BorderStyle.None;
            accName.Enabled = false;
            accName.Name = "accName";
            accName.Size = new Size(150, 20);
            // 
            // searchValues
            // 
            searchValues.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchValues.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            searchValues.Location = new Point(807, 137);
            searchValues.Name = "searchValues";
            searchValues.Size = new Size(202, 26);
            searchValues.TabIndex = 3;
            // 
            // butSearch
            // 
            butSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            butSearch.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butSearch.Location = new Point(934, 107);
            butSearch.Name = "butSearch";
            butSearch.Size = new Size(75, 28);
            butSearch.TabIndex = 4;
            butSearch.Text = "Поиск";
            butSearch.UseVisualStyleBackColor = true;
            butSearch.Click += butSearch_Click;
            // 
            // butAdd
            // 
            butAdd.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butAdd.Location = new Point(110, 33);
            butAdd.Name = "butAdd";
            butAdd.Size = new Size(92, 32);
            butAdd.TabIndex = 5;
            butAdd.Text = "Добавить";
            butAdd.UseVisualStyleBackColor = true;
            butAdd.Click += butAdd_Click;
            // 
            // butEdit
            // 
            butEdit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butEdit.Location = new Point(208, 33);
            butEdit.Name = "butEdit";
            butEdit.Size = new Size(92, 32);
            butEdit.TabIndex = 6;
            butEdit.Text = "Изменить";
            butEdit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(807, 70);
            label1.Name = "label1";
            label1.Size = new Size(54, 19);
            label1.TabIndex = 8;
            label1.Text = "Поиск";
            // 
            // searchPole
            // 
            searchPole.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchPole.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            searchPole.FormattingEnabled = true;
            searchPole.Location = new Point(807, 108);
            searchPole.Name = "searchPole";
            searchPole.Size = new Size(121, 27);
            searchPole.TabIndex = 9;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(807, 173);
            label2.Name = "label2";
            label2.Size = new Size(64, 19);
            label2.TabIndex = 10;
            label2.Text = "Фильтр";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tab1);
            tabControl1.Controls.Add(tab2);
            tabControl1.Controls.Add(tab3);
            tabControl1.Controls.Add(tab4);
            tabControl1.Controls.Add(tab5);
            tabControl1.Controls.Add(tab6);
            tabControl1.Controls.Add(tab7);
            tabControl1.Controls.Add(tab8);
            tabControl1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.ImeMode = ImeMode.NoControl;
            tabControl1.Location = new Point(12, 71);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(789, 505);
            tabControl1.TabIndex = 14;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tab1
            // 
            tab1.Controls.Add(dataGridView1);
            tab1.Location = new Point(4, 28);
            tab1.Name = "tab1";
            tab1.Padding = new Padding(3);
            tab1.Size = new Size(781, 473);
            tab1.TabIndex = 0;
            tab1.Text = "Журнал";
            tab1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(781, 473);
            dataGridView1.TabIndex = 0;
            // 
            // tab2
            // 
            tab2.Controls.Add(dataGridView2);
            tab2.Location = new Point(4, 28);
            tab2.Name = "tab2";
            tab2.Padding = new Padding(3);
            tab2.Size = new Size(781, 473);
            tab2.TabIndex = 1;
            tab2.Text = "Клиенты";
            tab2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(781, 473);
            dataGridView2.TabIndex = 1;
            // 
            // tab3
            // 
            tab3.Controls.Add(dataGridView3);
            tab3.Location = new Point(4, 28);
            tab3.Name = "tab3";
            tab3.Size = new Size(781, 473);
            tab3.TabIndex = 2;
            tab3.Text = "Диагнозы";
            tab3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(0, 0);
            dataGridView3.MultiSelect = false;
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.Size = new Size(781, 473);
            dataGridView3.TabIndex = 1;
            // 
            // tab4
            // 
            tab4.Controls.Add(dataGridView4);
            tab4.Location = new Point(4, 28);
            tab4.Name = "tab4";
            tab4.Size = new Size(781, 473);
            tab4.TabIndex = 3;
            tab4.Text = "Работники";
            tab4.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            dataGridView4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(0, 0);
            dataGridView4.MultiSelect = false;
            dataGridView4.Name = "dataGridView4";
            dataGridView4.ReadOnly = true;
            dataGridView4.RowTemplate.Height = 25;
            dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView4.Size = new Size(781, 473);
            dataGridView4.TabIndex = 1;
            // 
            // tab5
            // 
            tab5.Controls.Add(dataGridView5);
            tab5.Location = new Point(4, 28);
            tab5.Name = "tab5";
            tab5.Size = new Size(781, 473);
            tab5.TabIndex = 4;
            tab5.Text = "Аккаунты";
            tab5.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            dataGridView5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(0, 0);
            dataGridView5.MultiSelect = false;
            dataGridView5.Name = "dataGridView5";
            dataGridView5.ReadOnly = true;
            dataGridView5.RowTemplate.Height = 25;
            dataGridView5.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView5.Size = new Size(781, 473);
            dataGridView5.TabIndex = 1;
            // 
            // tab6
            // 
            tab6.Controls.Add(dataGridView6);
            tab6.Location = new Point(4, 28);
            tab6.Name = "tab6";
            tab6.Size = new Size(781, 473);
            tab6.TabIndex = 5;
            tab6.Text = "Должности";
            tab6.UseVisualStyleBackColor = true;
            // 
            // dataGridView6
            // 
            dataGridView6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView6.Location = new Point(0, 0);
            dataGridView6.MultiSelect = false;
            dataGridView6.Name = "dataGridView6";
            dataGridView6.ReadOnly = true;
            dataGridView6.RowTemplate.Height = 25;
            dataGridView6.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView6.Size = new Size(781, 473);
            dataGridView6.TabIndex = 1;
            // 
            // tab7
            // 
            tab7.Controls.Add(dataGridView7);
            tab7.Location = new Point(4, 28);
            tab7.Name = "tab7";
            tab7.Size = new Size(781, 473);
            tab7.TabIndex = 6;
            tab7.Text = "Роли";
            tab7.UseVisualStyleBackColor = true;
            // 
            // dataGridView7
            // 
            dataGridView7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView7.Location = new Point(0, 0);
            dataGridView7.MultiSelect = false;
            dataGridView7.Name = "dataGridView7";
            dataGridView7.ReadOnly = true;
            dataGridView7.RowTemplate.Height = 25;
            dataGridView7.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView7.Size = new Size(781, 473);
            dataGridView7.TabIndex = 1;
            // 
            // tab8
            // 
            tab8.Controls.Add(dataGridView8);
            tab8.Location = new Point(4, 28);
            tab8.Name = "tab8";
            tab8.Size = new Size(781, 473);
            tab8.TabIndex = 7;
            tab8.Text = "Кабинеты";
            tab8.UseVisualStyleBackColor = true;
            // 
            // dataGridView8
            // 
            dataGridView8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView8.Location = new Point(0, 0);
            dataGridView8.MultiSelect = false;
            dataGridView8.Name = "dataGridView8";
            dataGridView8.ReadOnly = true;
            dataGridView8.RowTemplate.Height = 25;
            dataGridView8.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView8.Size = new Size(781, 473);
            dataGridView8.TabIndex = 1;
            // 
            // filtrValues
            // 
            filtrValues.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            filtrValues.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            filtrValues.Location = new Point(807, 235);
            filtrValues.Name = "filtrValues";
            filtrValues.Size = new Size(202, 26);
            filtrValues.TabIndex = 11;
            // 
            // butFiltrAdd
            // 
            butFiltrAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            butFiltrAdd.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butFiltrAdd.Location = new Point(934, 205);
            butFiltrAdd.Name = "butFiltrAdd";
            butFiltrAdd.Size = new Size(75, 28);
            butFiltrAdd.TabIndex = 12;
            butFiltrAdd.Text = "Добавить";
            butFiltrAdd.UseVisualStyleBackColor = true;
            // 
            // filtrPole
            // 
            filtrPole.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            filtrPole.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            filtrPole.FormattingEnabled = true;
            filtrPole.Location = new Point(807, 206);
            filtrPole.Name = "filtrPole";
            filtrPole.Size = new Size(121, 27);
            filtrPole.TabIndex = 13;
            // 
            // filtrList
            // 
            filtrList.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            filtrList.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            filtrList.FormattingEnabled = true;
            filtrList.ItemHeight = 19;
            filtrList.Location = new Point(808, 263);
            filtrList.Name = "filtrList";
            filtrList.Size = new Size(120, 118);
            filtrList.TabIndex = 15;
            // 
            // butFilrtClear
            // 
            butFilrtClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            butFilrtClear.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butFilrtClear.Location = new Point(934, 351);
            butFilrtClear.Name = "butFilrtClear";
            butFilrtClear.Size = new Size(75, 23);
            butFilrtClear.TabIndex = 16;
            butFilrtClear.Text = "Сброс все";
            butFilrtClear.UseVisualStyleBackColor = true;
            // 
            // butFiltrDel
            // 
            butFiltrDel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            butFiltrDel.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butFiltrDel.Location = new Point(934, 322);
            butFiltrDel.Name = "butFiltrDel";
            butFiltrDel.Size = new Size(75, 23);
            butFiltrDel.TabIndex = 17;
            butFiltrDel.Text = "Удалить";
            butFiltrDel.UseVisualStyleBackColor = true;
            // 
            // butFiltrSearch
            // 
            butFiltrSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            butFiltrSearch.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butFiltrSearch.Location = new Point(934, 264);
            butFiltrSearch.Name = "butFiltrSearch";
            butFiltrSearch.Size = new Size(75, 52);
            butFiltrSearch.TabIndex = 18;
            butFiltrSearch.Text = "Поиск по фильтру";
            butFiltrSearch.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 580);
            Controls.Add(butFiltrSearch);
            Controls.Add(butFiltrDel);
            Controls.Add(butFilrtClear);
            Controls.Add(filtrList);
            Controls.Add(tabControl1);
            Controls.Add(filtrPole);
            Controls.Add(butFiltrAdd);
            Controls.Add(filtrValues);
            Controls.Add(label2);
            Controls.Add(searchPole);
            Controls.Add(label1);
            Controls.Add(butEdit);
            Controls.Add(butAdd);
            Controls.Add(butSearch);
            Controls.Add(searchValues);
            Controls.Add(butDel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(819, 444);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainWindow";
            FormClosed += MainWindow_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tab1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tab2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tab3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tab4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            tab5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            tab6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView6).EndInit();
            tab7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView7).EndInit();
            tab8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView8).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private TabPage tab1;
        private TabPage tab2;
        private TabPage tab3;
        private TabPage tab4;
        private TabPage tab5;
        private TabPage tab6;
        private TextBox filtrValues;
        private Button butFiltrAdd;
        private ComboBox filtrPole;
        private ListBox filtrList;
        private TabPage tab7;
        private TabPage tab8;
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