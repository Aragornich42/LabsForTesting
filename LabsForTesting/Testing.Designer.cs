namespace LabsForTesting
{
    partial class Testing
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
            this.inputLabel = new System.Windows.Forms.Label();
            this.inputField = new System.Windows.Forms.TextBox();
            this.inputButton = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.maxRadioButton = new System.Windows.Forms.RadioButton();
            this.minRadioButton = new System.Windows.Forms.RadioButton();
            this.startButton = new System.Windows.Forms.Button();
            this.elemCountLbl = new System.Windows.Forms.Label();
            this.elemCountField = new System.Windows.Forms.TextBox();
            this.maxOrMinLbl = new System.Windows.Forms.Label();
            this.maxOrMin = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.restart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputLabel.Location = new System.Drawing.Point(12, 9);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(311, 24);
            this.inputLabel.TabIndex = 0;
            this.inputLabel.Text = "Введите новый элемент массива";
            // 
            // inputField
            // 
            this.inputField.Location = new System.Drawing.Point(16, 36);
            this.inputField.Name = "inputField";
            this.inputField.Size = new System.Drawing.Size(307, 20);
            this.inputField.TabIndex = 1;
            // 
            // inputButton
            // 
            this.inputButton.Location = new System.Drawing.Point(16, 62);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(197, 38);
            this.inputButton.TabIndex = 2;
            this.inputButton.Text = "Вставить";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(16, 106);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(307, 353);
            this.listView.TabIndex = 3;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // maxRadioButton
            // 
            this.maxRadioButton.AutoSize = true;
            this.maxRadioButton.Location = new System.Drawing.Point(16, 465);
            this.maxRadioButton.Name = "maxRadioButton";
            this.maxRadioButton.Size = new System.Drawing.Size(150, 17);
            this.maxRadioButton.TabIndex = 4;
            this.maxRadioButton.TabStop = true;
            this.maxRadioButton.Text = "Максимальный элемент";
            this.maxRadioButton.UseVisualStyleBackColor = true;
            // 
            // minRadioButton
            // 
            this.minRadioButton.AutoSize = true;
            this.minRadioButton.Location = new System.Drawing.Point(16, 488);
            this.minRadioButton.Name = "minRadioButton";
            this.minRadioButton.Size = new System.Drawing.Size(144, 17);
            this.minRadioButton.TabIndex = 5;
            this.minRadioButton.TabStop = true;
            this.minRadioButton.Text = "Минимальный элемент";
            this.minRadioButton.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(16, 511);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(307, 54);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Запуск!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // elemCountLbl
            // 
            this.elemCountLbl.AutoSize = true;
            this.elemCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.elemCountLbl.Location = new System.Drawing.Point(16, 572);
            this.elemCountLbl.Name = "elemCountLbl";
            this.elemCountLbl.Size = new System.Drawing.Size(166, 20);
            this.elemCountLbl.TabIndex = 7;
            this.elemCountLbl.Text = "Искомых элементов:";
            // 
            // elemCountField
            // 
            this.elemCountField.Enabled = false;
            this.elemCountField.Location = new System.Drawing.Point(189, 571);
            this.elemCountField.Name = "elemCountField";
            this.elemCountField.Size = new System.Drawing.Size(134, 20);
            this.elemCountField.TabIndex = 8;
            // 
            // maxOrMinLbl
            // 
            this.maxOrMinLbl.AutoSize = true;
            this.maxOrMinLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxOrMinLbl.Location = new System.Drawing.Point(16, 597);
            this.maxOrMinLbl.Name = "maxOrMinLbl";
            this.maxOrMinLbl.Size = new System.Drawing.Size(128, 20);
            this.maxOrMinLbl.TabIndex = 9;
            this.maxOrMinLbl.Text = "Максимальный:";
            // 
            // maxOrMin
            // 
            this.maxOrMin.Enabled = false;
            this.maxOrMin.Location = new System.Drawing.Point(20, 620);
            this.maxOrMin.Name = "maxOrMin";
            this.maxOrMin.Size = new System.Drawing.Size(303, 20);
            this.maxOrMin.TabIndex = 10;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(20, 702);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(303, 34);
            this.exit.TabIndex = 11;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // restart
            // 
            this.restart.Enabled = false;
            this.restart.Location = new System.Drawing.Point(20, 658);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(303, 38);
            this.restart.TabIndex = 12;
            this.restart.Text = "Рестарт";
            this.restart.UseVisualStyleBackColor = true;
            // 
            // Testing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 748);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.maxOrMin);
            this.Controls.Add(this.maxOrMinLbl);
            this.Controls.Add(this.elemCountField);
            this.Controls.Add(this.elemCountLbl);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.minRadioButton);
            this.Controls.Add(this.maxRadioButton);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.inputButton);
            this.Controls.Add(this.inputField);
            this.Controls.Add(this.inputLabel);
            this.Name = "Testing";
            this.Text = "Testing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.TextBox inputField;
        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.RadioButton maxRadioButton;
        private System.Windows.Forms.RadioButton minRadioButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label elemCountLbl;
        private System.Windows.Forms.TextBox elemCountField;
        private System.Windows.Forms.Label maxOrMinLbl;
        private System.Windows.Forms.TextBox maxOrMin;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button restart;
    }
}

