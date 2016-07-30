namespace bario2
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panelScan = new System.Windows.Forms.Panel();
            this.buttonScan = new System.Windows.Forms.Button();
            this.textBoxSerialScan = new System.Windows.Forms.TextBox();
            this.textBoxWeightScan = new System.Windows.Forms.TextBox();
            this.labelSerialScan = new System.Windows.Forms.Label();
            this.labelWeightScan = new System.Windows.Forms.Label();
            this.labelScan = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.textBoxPortion = new System.Windows.Forms.TextBox();
            this.labelPortion = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxCapacityNow = new System.Windows.Forms.TextBox();
            this.textBoxCapacityFull = new System.Windows.Forms.TextBox();
            this.textBoxWeightNow = new System.Windows.Forms.TextBox();
            this.textBoxWeightFull = new System.Windows.Forms.TextBox();
            this.textBoxWeightEmpty = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxSerial = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelCapacityNow = new System.Windows.Forms.Label();
            this.labelCapacityFull = new System.Windows.Forms.Label();
            this.labelWeightNow = new System.Windows.Forms.Label();
            this.labelWeightFull = new System.Windows.Forms.Label();
            this.labelWeightEmpty = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelSerial = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAdd = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewStat = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelScan.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStat)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(6, 6);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(925, 632);
            this.dataGridView.TabIndex = 0;
            // 
            // panelScan
            // 
            this.panelScan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelScan.Controls.Add(this.buttonScan);
            this.panelScan.Controls.Add(this.textBoxSerialScan);
            this.panelScan.Controls.Add(this.textBoxWeightScan);
            this.panelScan.Controls.Add(this.labelSerialScan);
            this.panelScan.Controls.Add(this.labelWeightScan);
            this.panelScan.Controls.Add(this.labelScan);
            this.panelScan.Location = new System.Drawing.Point(937, 64);
            this.panelScan.Name = "panelScan";
            this.panelScan.Size = new System.Drawing.Size(232, 124);
            this.panelScan.TabIndex = 1;
            // 
            // buttonScan
            // 
            this.buttonScan.Location = new System.Drawing.Point(56, 90);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(100, 23);
            this.buttonScan.TabIndex = 5;
            this.buttonScan.Text = "Сканировать";
            this.buttonScan.UseVisualStyleBackColor = true;
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
            // 
            // textBoxSerialScan
            // 
            this.textBoxSerialScan.Location = new System.Drawing.Point(56, 64);
            this.textBoxSerialScan.Name = "textBoxSerialScan";
            this.textBoxSerialScan.Size = new System.Drawing.Size(100, 20);
            this.textBoxSerialScan.TabIndex = 4;
            // 
            // textBoxWeightScan
            // 
            this.textBoxWeightScan.Location = new System.Drawing.Point(56, 37);
            this.textBoxWeightScan.Name = "textBoxWeightScan";
            this.textBoxWeightScan.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeightScan.TabIndex = 3;
            // 
            // labelSerialScan
            // 
            this.labelSerialScan.AutoSize = true;
            this.labelSerialScan.Location = new System.Drawing.Point(21, 67);
            this.labelSerialScan.Name = "labelSerialScan";
            this.labelSerialScan.Size = new System.Drawing.Size(29, 13);
            this.labelSerialScan.TabIndex = 2;
            this.labelSerialScan.Text = "Код:";
            // 
            // labelWeightScan
            // 
            this.labelWeightScan.AutoSize = true;
            this.labelWeightScan.Location = new System.Drawing.Point(4, 40);
            this.labelWeightScan.Name = "labelWeightScan";
            this.labelWeightScan.Size = new System.Drawing.Size(46, 13);
            this.labelWeightScan.TabIndex = 1;
            this.labelWeightScan.Text = "Вес, гр:";
            // 
            // labelScan
            // 
            this.labelScan.AutoSize = true;
            this.labelScan.Location = new System.Drawing.Point(12, 11);
            this.labelScan.Name = "labelScan";
            this.labelScan.Size = new System.Drawing.Size(123, 13);
            this.labelScan.TabIndex = 0;
            this.labelScan.Text = "Сканировать позицию:";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(937, 6);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(106, 23);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Подключиться";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1125, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(937, 35);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(106, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panelAdd
            // 
            this.panelAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAdd.Controls.Add(this.textBoxPortion);
            this.panelAdd.Controls.Add(this.labelPortion);
            this.panelAdd.Controls.Add(this.buttonAdd);
            this.panelAdd.Controls.Add(this.textBoxPrice);
            this.panelAdd.Controls.Add(this.textBoxCapacityNow);
            this.panelAdd.Controls.Add(this.textBoxCapacityFull);
            this.panelAdd.Controls.Add(this.textBoxWeightNow);
            this.panelAdd.Controls.Add(this.textBoxWeightFull);
            this.panelAdd.Controls.Add(this.textBoxWeightEmpty);
            this.panelAdd.Controls.Add(this.textBoxType);
            this.panelAdd.Controls.Add(this.textBoxSerial);
            this.panelAdd.Controls.Add(this.textBoxName);
            this.panelAdd.Controls.Add(this.labelPrice);
            this.panelAdd.Controls.Add(this.labelCapacityNow);
            this.panelAdd.Controls.Add(this.labelCapacityFull);
            this.panelAdd.Controls.Add(this.labelWeightNow);
            this.panelAdd.Controls.Add(this.labelWeightFull);
            this.panelAdd.Controls.Add(this.labelWeightEmpty);
            this.panelAdd.Controls.Add(this.labelType);
            this.panelAdd.Controls.Add(this.labelSerial);
            this.panelAdd.Controls.Add(this.labelName);
            this.panelAdd.Controls.Add(this.labelAdd);
            this.panelAdd.Location = new System.Drawing.Point(937, 194);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(232, 329);
            this.panelAdd.TabIndex = 5;
            // 
            // textBoxPortion
            // 
            this.textBoxPortion.Location = new System.Drawing.Point(125, 270);
            this.textBoxPortion.Name = "textBoxPortion";
            this.textBoxPortion.Size = new System.Drawing.Size(100, 20);
            this.textBoxPortion.TabIndex = 25;
            // 
            // labelPortion
            // 
            this.labelPortion.AutoSize = true;
            this.labelPortion.Location = new System.Drawing.Point(23, 273);
            this.labelPortion.Name = "labelPortion";
            this.labelPortion.Size = new System.Drawing.Size(96, 13);
            this.labelPortion.TabIndex = 24;
            this.labelPortion.Text = "Размер порц, мл:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(150, 296);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(125, 244);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 23;
            // 
            // textBoxCapacityNow
            // 
            this.textBoxCapacityNow.Location = new System.Drawing.Point(125, 218);
            this.textBoxCapacityNow.Name = "textBoxCapacityNow";
            this.textBoxCapacityNow.Size = new System.Drawing.Size(100, 20);
            this.textBoxCapacityNow.TabIndex = 22;
            // 
            // textBoxCapacityFull
            // 
            this.textBoxCapacityFull.Location = new System.Drawing.Point(125, 192);
            this.textBoxCapacityFull.Name = "textBoxCapacityFull";
            this.textBoxCapacityFull.Size = new System.Drawing.Size(100, 20);
            this.textBoxCapacityFull.TabIndex = 21;
            // 
            // textBoxWeightNow
            // 
            this.textBoxWeightNow.Location = new System.Drawing.Point(125, 166);
            this.textBoxWeightNow.Name = "textBoxWeightNow";
            this.textBoxWeightNow.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeightNow.TabIndex = 20;
            // 
            // textBoxWeightFull
            // 
            this.textBoxWeightFull.Location = new System.Drawing.Point(125, 140);
            this.textBoxWeightFull.Name = "textBoxWeightFull";
            this.textBoxWeightFull.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeightFull.TabIndex = 19;
            // 
            // textBoxWeightEmpty
            // 
            this.textBoxWeightEmpty.Location = new System.Drawing.Point(125, 114);
            this.textBoxWeightEmpty.Name = "textBoxWeightEmpty";
            this.textBoxWeightEmpty.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeightEmpty.TabIndex = 18;
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(125, 88);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(100, 20);
            this.textBoxType.TabIndex = 17;
            // 
            // textBoxSerial
            // 
            this.textBoxSerial.Location = new System.Drawing.Point(125, 62);
            this.textBoxSerial.Name = "textBoxSerial";
            this.textBoxSerial.Size = new System.Drawing.Size(100, 20);
            this.textBoxSerial.TabIndex = 16;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(125, 36);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 6;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(60, 247);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(59, 13);
            this.labelPrice.TabIndex = 15;
            this.labelPrice.Text = "Цена, руб:";
            // 
            // labelCapacityNow
            // 
            this.labelCapacityNow.AutoSize = true;
            this.labelCapacityNow.Location = new System.Drawing.Point(7, 221);
            this.labelCapacityNow.Name = "labelCapacityNow";
            this.labelCapacityNow.Size = new System.Drawing.Size(112, 13);
            this.labelCapacityNow.TabIndex = 14;
            this.labelCapacityNow.Text = "Емкость сейчас, мл:";
            // 
            // labelCapacityFull
            // 
            this.labelCapacityFull.AutoSize = true;
            this.labelCapacityFull.Location = new System.Drawing.Point(18, 195);
            this.labelCapacityFull.Name = "labelCapacityFull";
            this.labelCapacityFull.Size = new System.Drawing.Size(101, 13);
            this.labelCapacityFull.TabIndex = 13;
            this.labelCapacityFull.Text = "Емкость полн, мл:";
            // 
            // labelWeightNow
            // 
            this.labelWeightNow.AutoSize = true;
            this.labelWeightNow.Location = new System.Drawing.Point(35, 169);
            this.labelWeightNow.Name = "labelWeightNow";
            this.labelWeightNow.Size = new System.Drawing.Size(84, 13);
            this.labelWeightNow.TabIndex = 12;
            this.labelWeightNow.Text = "Вес сейчас, гр:";
            // 
            // labelWeightFull
            // 
            this.labelWeightFull.AutoSize = true;
            this.labelWeightFull.Location = new System.Drawing.Point(34, 143);
            this.labelWeightFull.Name = "labelWeightFull";
            this.labelWeightFull.Size = new System.Drawing.Size(85, 13);
            this.labelWeightFull.TabIndex = 11;
            this.labelWeightFull.Text = "Вес полной, гр:";
            // 
            // labelWeightEmpty
            // 
            this.labelWeightEmpty.AutoSize = true;
            this.labelWeightEmpty.Location = new System.Drawing.Point(36, 117);
            this.labelWeightEmpty.Name = "labelWeightEmpty";
            this.labelWeightEmpty.Size = new System.Drawing.Size(83, 13);
            this.labelWeightEmpty.TabIndex = 10;
            this.labelWeightEmpty.Text = "Вес пустой, гр:";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(90, 91);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(29, 13);
            this.labelType.TabIndex = 9;
            this.labelType.Text = "Тип:";
            // 
            // labelSerial
            // 
            this.labelSerial.AutoSize = true;
            this.labelSerial.Location = new System.Drawing.Point(90, 65);
            this.labelSerial.Name = "labelSerial";
            this.labelSerial.Size = new System.Drawing.Size(29, 13);
            this.labelSerial.TabIndex = 8;
            this.labelSerial.Text = "Код:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(59, 39);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(60, 13);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Название:";
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Location = new System.Drawing.Point(12, 12);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(107, 13);
            this.labelAdd.TabIndex = 6;
            this.labelAdd.Text = "Добавить позицию:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1125, 35);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(44, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.Location = new System.Drawing.Point(937, 530);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(232, 108);
            this.listBoxLog.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1184, 672);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView);
            this.tabPage1.Controls.Add(this.listBoxLog);
            this.tabPage1.Controls.Add(this.panelScan);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.buttonConnect);
            this.tabPage1.Controls.Add(this.panelAdd);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.buttonSave);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1176, 646);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Главная";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewStat);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1176, 646);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Статистика";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewStat
            // 
            this.dataGridViewStat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewStat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStat.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewStat.Name = "dataGridViewStat";
            this.dataGridViewStat.Size = new System.Drawing.Size(786, 634);
            this.dataGridViewStat.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 696);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bario";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panelScan.ResumeLayout(false);
            this.panelScan.PerformLayout();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panelScan;
        private System.Windows.Forms.Button buttonScan;
        private System.Windows.Forms.TextBox textBoxSerialScan;
        private System.Windows.Forms.TextBox textBoxWeightScan;
        private System.Windows.Forms.Label labelSerialScan;
        private System.Windows.Forms.Label labelWeightScan;
        private System.Windows.Forms.Label labelScan;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxCapacityNow;
        private System.Windows.Forms.TextBox textBoxCapacityFull;
        private System.Windows.Forms.TextBox textBoxWeightNow;
        private System.Windows.Forms.TextBox textBoxWeightFull;
        private System.Windows.Forms.TextBox textBoxWeightEmpty;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxSerial;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelCapacityNow;
        private System.Windows.Forms.Label labelCapacityFull;
        private System.Windows.Forms.Label labelWeightNow;
        private System.Windows.Forms.Label labelWeightFull;
        private System.Windows.Forms.Label labelWeightEmpty;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelSerial;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBoxPortion;
        private System.Windows.Forms.Label labelPortion;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewStat;
    }
}

