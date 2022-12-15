namespace Prog_lab3
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
            this.result = new System.Windows.Forms.TextBox();
            this.dataDaysTextBox = new System.Windows.Forms.TextBox();
            this.startDate = new System.Windows.Forms.TextBox();
            this.plusDaysButton = new System.Windows.Forms.RadioButton();
            this.minusDaysButton = new System.Windows.Forms.RadioButton();
            this.equalityCheckButton = new System.Windows.Forms.RadioButton();
            this.unEqualityCheckButton = new System.Windows.Forms.RadioButton();
            this.plusLabel = new System.Windows.Forms.Label();
            this.minusLabel = new System.Windows.Forms.Label();
            this.equalityCheckLabel = new System.Windows.Forms.Label();
            this.unEqualityCheckLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.dataDaysLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.changeOperationLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.equalityResultLabel = new System.Windows.Forms.Label();
            this.equalityResult = new System.Windows.Forms.TextBox();
            this.dataDateLabel = new System.Windows.Forms.Label();
            this.dataDateTextBox = new System.Windows.Forms.TextBox();
            this.changeEqualityOperationLabel = new System.Windows.Forms.Label();
            this.equalityStartButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.Enabled = false;
            this.result.Location = new System.Drawing.Point(89, 124);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(139, 20);
            this.result.TabIndex = 0;
            // 
            // dataDaysTextBox
            // 
            this.dataDaysTextBox.Location = new System.Drawing.Point(98, 87);
            this.dataDaysTextBox.Name = "dataDaysTextBox";
            this.dataDaysTextBox.Size = new System.Drawing.Size(130, 20);
            this.dataDaysTextBox.TabIndex = 1;
            this.dataDaysTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DataDaysTextBox_KeyPress);
            // 
            // startDate
            // 
            this.startDate.Enabled = false;
            this.startDate.Location = new System.Drawing.Point(118, 19);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(110, 20);
            this.startDate.TabIndex = 2;
            // 
            // plusDaysButton
            // 
            this.plusDaysButton.AutoSize = true;
            this.plusDaysButton.Location = new System.Drawing.Point(140, 54);
            this.plusDaysButton.Name = "plusDaysButton";
            this.plusDaysButton.Size = new System.Drawing.Size(14, 13);
            this.plusDaysButton.TabIndex = 3;
            this.plusDaysButton.UseVisualStyleBackColor = true;
            // 
            // minusDaysButton
            // 
            this.minusDaysButton.AutoSize = true;
            this.minusDaysButton.Location = new System.Drawing.Point(160, 54);
            this.minusDaysButton.Name = "minusDaysButton";
            this.minusDaysButton.Size = new System.Drawing.Size(14, 13);
            this.minusDaysButton.TabIndex = 4;
            this.minusDaysButton.UseVisualStyleBackColor = true;
            // 
            // equalityCheckButton
            // 
            this.equalityCheckButton.AutoSize = true;
            this.equalityCheckButton.Location = new System.Drawing.Point(141, 25);
            this.equalityCheckButton.Name = "equalityCheckButton";
            this.equalityCheckButton.Size = new System.Drawing.Size(14, 13);
            this.equalityCheckButton.TabIndex = 5;
            this.equalityCheckButton.UseVisualStyleBackColor = true;
            // 
            // unEqualityCheckButton
            // 
            this.unEqualityCheckButton.AutoSize = true;
            this.unEqualityCheckButton.Location = new System.Drawing.Point(160, 25);
            this.unEqualityCheckButton.Name = "unEqualityCheckButton";
            this.unEqualityCheckButton.Size = new System.Drawing.Size(14, 13);
            this.unEqualityCheckButton.TabIndex = 6;
            this.unEqualityCheckButton.UseVisualStyleBackColor = true;
            // 
            // plusLabel
            // 
            this.plusLabel.AutoSize = true;
            this.plusLabel.Location = new System.Drawing.Point(141, 70);
            this.plusLabel.Name = "plusLabel";
            this.plusLabel.Size = new System.Drawing.Size(13, 13);
            this.plusLabel.TabIndex = 7;
            this.plusLabel.Text = "+";
            // 
            // minusLabel
            // 
            this.minusLabel.AutoSize = true;
            this.minusLabel.Location = new System.Drawing.Point(161, 70);
            this.minusLabel.Name = "minusLabel";
            this.minusLabel.Size = new System.Drawing.Size(10, 13);
            this.minusLabel.TabIndex = 8;
            this.minusLabel.Text = "-";
            // 
            // equalityCheckLabel
            // 
            this.equalityCheckLabel.AutoSize = true;
            this.equalityCheckLabel.Location = new System.Drawing.Point(138, 41);
            this.equalityCheckLabel.Name = "equalityCheckLabel";
            this.equalityCheckLabel.Size = new System.Drawing.Size(19, 13);
            this.equalityCheckLabel.TabIndex = 9;
            this.equalityCheckLabel.Text = "==";
            // 
            // unEqualityCheckLabel
            // 
            this.unEqualityCheckLabel.AutoSize = true;
            this.unEqualityCheckLabel.Location = new System.Drawing.Point(158, 41);
            this.unEqualityCheckLabel.Name = "unEqualityCheckLabel";
            this.unEqualityCheckLabel.Size = new System.Drawing.Size(16, 13);
            this.unEqualityCheckLabel.TabIndex = 10;
            this.unEqualityCheckLabel.Text = "!=";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(21, 22);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(91, 13);
            this.startDateLabel.TabIndex = 11;
            this.startDateLabel.Text = "Начальная дата:";
            // 
            // dataDaysLabel
            // 
            this.dataDaysLabel.AutoSize = true;
            this.dataDaysLabel.Location = new System.Drawing.Point(21, 90);
            this.dataDaysLabel.Name = "dataDaysLabel";
            this.dataDaysLabel.Size = new System.Drawing.Size(71, 13);
            this.dataDaysLabel.TabIndex = 12;
            this.dataDaysLabel.Text = "Кол-во дней:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(21, 127);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resultLabel.Size = new System.Drawing.Size(62, 13);
            this.resultLabel.TabIndex = 13;
            this.resultLabel.Text = "Результат:";
            // 
            // changeOperationLabel
            // 
            this.changeOperationLabel.AutoSize = true;
            this.changeOperationLabel.Location = new System.Drawing.Point(21, 54);
            this.changeOperationLabel.Name = "changeOperationLabel";
            this.changeOperationLabel.Size = new System.Drawing.Size(113, 13);
            this.changeOperationLabel.TabIndex = 14;
            this.changeOperationLabel.Text = "Выберите операцию:";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(180, 49);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(48, 23);
            this.startButton.TabIndex = 15;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton);
            // 
            // equalityResultLabel
            // 
            this.equalityResultLabel.AutoSize = true;
            this.equalityResultLabel.Location = new System.Drawing.Point(21, 101);
            this.equalityResultLabel.Name = "equalityResultLabel";
            this.equalityResultLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.equalityResultLabel.Size = new System.Drawing.Size(62, 13);
            this.equalityResultLabel.TabIndex = 17;
            this.equalityResultLabel.Text = "Результат:";
            // 
            // equalityResult
            // 
            this.equalityResult.Enabled = false;
            this.equalityResult.Location = new System.Drawing.Point(89, 98);
            this.equalityResult.Name = "equalityResult";
            this.equalityResult.Size = new System.Drawing.Size(139, 20);
            this.equalityResult.TabIndex = 16;
            // 
            // dataDateLabel
            // 
            this.dataDateLabel.AutoSize = true;
            this.dataDateLabel.Location = new System.Drawing.Point(21, 64);
            this.dataDateLabel.Name = "dataDateLabel";
            this.dataDateLabel.Size = new System.Drawing.Size(77, 13);
            this.dataDateLabel.TabIndex = 19;
            this.dataDateLabel.Text = "Введите дату:";
            // 
            // dataDateTextBox
            // 
            this.dataDateTextBox.Location = new System.Drawing.Point(104, 61);
            this.dataDateTextBox.Name = "dataDateTextBox";
            this.dataDateTextBox.Size = new System.Drawing.Size(124, 20);
            this.dataDateTextBox.TabIndex = 18;
            this.dataDateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DataDataTextBox_KeyPress);
            // 
            // changeEqualityOperationLabel
            // 
            this.changeEqualityOperationLabel.AutoSize = true;
            this.changeEqualityOperationLabel.Location = new System.Drawing.Point(21, 25);
            this.changeEqualityOperationLabel.Name = "changeEqualityOperationLabel";
            this.changeEqualityOperationLabel.Size = new System.Drawing.Size(113, 13);
            this.changeEqualityOperationLabel.TabIndex = 20;
            this.changeEqualityOperationLabel.Text = "Выберите операцию:";
            // 
            // equalityStartButton
            // 
            this.equalityStartButton.Location = new System.Drawing.Point(180, 20);
            this.equalityStartButton.Name = "equalityStartButton";
            this.equalityStartButton.Size = new System.Drawing.Size(48, 23);
            this.equalityStartButton.TabIndex = 21;
            this.equalityStartButton.Text = "Старт";
            this.equalityStartButton.UseVisualStyleBackColor = true;
            this.equalityStartButton.Click += new System.EventHandler(this.EqualityStartButton);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.changeEqualityOperationLabel);
            this.groupBox1.Controls.Add(this.equalityStartButton);
            this.groupBox1.Controls.Add(this.equalityCheckButton);
            this.groupBox1.Controls.Add(this.unEqualityCheckButton);
            this.groupBox1.Controls.Add(this.dataDateLabel);
            this.groupBox1.Controls.Add(this.equalityCheckLabel);
            this.groupBox1.Controls.Add(this.dataDateTextBox);
            this.groupBox1.Controls.Add(this.unEqualityCheckLabel);
            this.groupBox1.Controls.Add(this.equalityResultLabel);
            this.groupBox1.Controls.Add(this.equalityResult);
            this.groupBox1.Location = new System.Drawing.Point(12, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 134);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Проверка на равенство";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.startDateLabel);
            this.groupBox2.Controls.Add(this.result);
            this.groupBox2.Controls.Add(this.startButton);
            this.groupBox2.Controls.Add(this.dataDaysTextBox);
            this.groupBox2.Controls.Add(this.changeOperationLabel);
            this.groupBox2.Controls.Add(this.startDate);
            this.groupBox2.Controls.Add(this.resultLabel);
            this.groupBox2.Controls.Add(this.plusDaysButton);
            this.groupBox2.Controls.Add(this.dataDaysLabel);
            this.groupBox2.Controls.Add(this.minusDaysButton);
            this.groupBox2.Controls.Add(this.plusLabel);
            this.groupBox2.Controls.Add(this.minusLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 159);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сложение/вычитание";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 321);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox dataDaysTextBox;
        private System.Windows.Forms.TextBox startDate;
        private System.Windows.Forms.RadioButton plusDaysButton;
        private System.Windows.Forms.RadioButton minusDaysButton;
        private System.Windows.Forms.RadioButton equalityCheckButton;
        private System.Windows.Forms.RadioButton unEqualityCheckButton;
        private System.Windows.Forms.Label plusLabel;
        private System.Windows.Forms.Label minusLabel;
        private System.Windows.Forms.Label equalityCheckLabel;
        private System.Windows.Forms.Label unEqualityCheckLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label dataDaysLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label changeOperationLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label equalityResultLabel;
        private System.Windows.Forms.TextBox equalityResult;
        private System.Windows.Forms.Label dataDateLabel;
        private System.Windows.Forms.TextBox dataDateTextBox;
        private System.Windows.Forms.Label changeEqualityOperationLabel;
        private System.Windows.Forms.Button equalityStartButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

