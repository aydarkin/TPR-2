namespace TPR_2
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
            this.treeView = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbProb = new System.Windows.Forms.RadioButton();
            this.rbOr = new System.Windows.Forms.RadioButton();
            this.rbAnd = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRootName = new System.Windows.Forms.TextBox();
            this.cbRootType = new System.Windows.Forms.ComboBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.tbFAL = new System.Windows.Forms.TextBox();
            this.tbCalc = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.импортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOcenka = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudCost = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView.Location = new System.Drawing.Point(16, 108);
            this.treeView.Margin = new System.Windows.Forms.Padding(4);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(528, 491);
            this.treeView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbProb);
            this.groupBox1.Controls.Add(this.rbOr);
            this.groupBox1.Controls.Add(this.rbAnd);
            this.groupBox1.Location = new System.Drawing.Point(16, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(283, 59);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "События";
            // 
            // rbProb
            // 
            this.rbProb.AutoSize = true;
            this.rbProb.Checked = true;
            this.rbProb.Location = new System.Drawing.Point(168, 23);
            this.rbProb.Margin = new System.Windows.Forms.Padding(4);
            this.rbProb.Name = "rbProb";
            this.rbProb.Size = new System.Drawing.Size(98, 21);
            this.rbProb.TabIndex = 2;
            this.rbProb.TabStop = true;
            this.rbProb.Text = "Иниц. соб.";
            this.rbProb.UseVisualStyleBackColor = true;
            // 
            // rbOr
            // 
            this.rbOr.AutoSize = true;
            this.rbOr.Location = new System.Drawing.Point(81, 23);
            this.rbOr.Margin = new System.Windows.Forms.Padding(4);
            this.rbOr.Name = "rbOr";
            this.rbOr.Size = new System.Drawing.Size(59, 21);
            this.rbOr.TabIndex = 1;
            this.rbOr.Text = "ИЛИ";
            this.rbOr.UseVisualStyleBackColor = true;
            // 
            // rbAnd
            // 
            this.rbAnd.AutoSize = true;
            this.rbAnd.Location = new System.Drawing.Point(8, 23);
            this.rbAnd.Margin = new System.Windows.Forms.Padding(4);
            this.rbAnd.Name = "rbAnd";
            this.rbAnd.Size = new System.Drawing.Size(39, 21);
            this.rbAnd.TabIndex = 0;
            this.rbAnd.Text = "И";
            this.rbAnd.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 62);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(428, 62);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(608, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название конечного события";
            // 
            // tbRootName
            // 
            this.tbRootName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRootName.Location = new System.Drawing.Point(612, 65);
            this.tbRootName.Margin = new System.Windows.Forms.Padding(4);
            this.tbRootName.Name = "tbRootName";
            this.tbRootName.Size = new System.Drawing.Size(377, 22);
            this.tbRootName.TabIndex = 4;
            this.tbRootName.Text = "Конечное событие";
            this.tbRootName.TextChanged += new System.EventHandler(this.tbRootName_TextChanged);
            // 
            // cbRootType
            // 
            this.cbRootType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRootType.FormattingEnabled = true;
            this.cbRootType.Items.AddRange(new object[] {
            "И",
            "ИЛИ"});
            this.cbRootType.Location = new System.Drawing.Point(611, 95);
            this.cbRootType.Margin = new System.Windows.Forms.Padding(4);
            this.cbRootType.Name = "cbRootType";
            this.cbRootType.Size = new System.Drawing.Size(160, 24);
            this.cbRootType.TabIndex = 6;
            this.cbRootType.SelectedIndexChanged += new System.EventHandler(this.cbRootType_SelectedIndexChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalc.Location = new System.Drawing.Point(612, 199);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(379, 28);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "Расчет";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // tbFAL
            // 
            this.tbFAL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFAL.Location = new System.Drawing.Point(612, 269);
            this.tbFAL.Margin = new System.Windows.Forms.Padding(4);
            this.tbFAL.Multiline = true;
            this.tbFAL.Name = "tbFAL";
            this.tbFAL.ReadOnly = true;
            this.tbFAL.Size = new System.Drawing.Size(377, 112);
            this.tbFAL.TabIndex = 8;
            // 
            // tbCalc
            // 
            this.tbCalc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCalc.Location = new System.Drawing.Point(612, 420);
            this.tbCalc.Margin = new System.Windows.Forms.Padding(4);
            this.tbCalc.Multiline = true;
            this.tbCalc.Name = "tbCalc";
            this.tbCalc.ReadOnly = true;
            this.tbCalc.Size = new System.Drawing.Size(377, 115);
            this.tbCalc.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.импортToolStripMenuItem,
            this.экспортToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1007, 30);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // импортToolStripMenuItem
            // 
            this.импортToolStripMenuItem.Name = "импортToolStripMenuItem";
            this.импортToolStripMenuItem.Size = new System.Drawing.Size(81, 26);
            this.импортToolStripMenuItem.Text = "Открыть";
            this.импортToolStripMenuItem.Click += new System.EventHandler(this.импортToolStripMenuItem_Click);
            // 
            // экспортToolStripMenuItem
            // 
            this.экспортToolStripMenuItem.Name = "экспортToolStripMenuItem";
            this.экспортToolStripMenuItem.Size = new System.Drawing.Size(97, 26);
            this.экспортToolStripMenuItem.Text = "Сохранить";
            this.экспортToolStripMenuItem.Click += new System.EventHandler(this.экспортToolStripMenuItem_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            this.ofd.Filter = "Txt |*.txt";
            // 
            // sfd
            // 
            this.sfd.Filter = "Txt |*.txt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(609, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Функция алгебры логики";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(612, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Вероятностная функция";
            // 
            // lblOcenka
            // 
            this.lblOcenka.AutoSize = true;
            this.lblOcenka.Location = new System.Drawing.Point(612, 582);
            this.lblOcenka.Name = "lblOcenka";
            this.lblOcenka.Size = new System.Drawing.Size(113, 17);
            this.lblOcenka.TabIndex = 12;
            this.lblOcenka.Text = "Оценка риска: -";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(609, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Стоимость";
            // 
            // nudCost
            // 
            this.nudCost.DecimalPlaces = 2;
            this.nudCost.Location = new System.Drawing.Point(611, 157);
            this.nudCost.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudCost.Name = "nudCost";
            this.nudCost.Size = new System.Drawing.Size(160, 22);
            this.nudCost.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 615);
            this.Controls.Add(this.nudCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblOcenka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCalc);
            this.Controls.Add(this.tbFAL);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.cbRootType);
            this.Controls.Add(this.tbRootName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Логико-вероятностный метод";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbProb;
        private System.Windows.Forms.RadioButton rbOr;
        private System.Windows.Forms.RadioButton rbAnd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRootName;
        private System.Windows.Forms.ComboBox cbRootType;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox tbFAL;
        private System.Windows.Forms.TextBox tbCalc;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem импортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOcenka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudCost;
    }
}

