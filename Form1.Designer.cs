namespace newport
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ConnectButton = new System.Windows.Forms.Button();
            this.StepBox = new System.Windows.Forms.TextBox();
            this.PlusButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.DeviceBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PosBox = new System.Windows.Forms.TextBox();
            this.AdressBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(12, 12);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(294, 54);
            this.ConnectButton.TabIndex = 0;
            this.ConnectButton.Text = "CONNECT";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // StepBox
            // 
            this.StepBox.Location = new System.Drawing.Point(12, 87);
            this.StepBox.Name = "StepBox";
            this.StepBox.Size = new System.Drawing.Size(89, 20);
            this.StepBox.TabIndex = 1;
            // 
            // PlusButton
            // 
            this.PlusButton.Location = new System.Drawing.Point(120, 84);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(75, 23);
            this.PlusButton.TabIndex = 2;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Location = new System.Drawing.Point(217, 84);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(75, 23);
            this.MinusButton.TabIndex = 3;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // DeviceBox
            // 
            this.DeviceBox.Location = new System.Drawing.Point(12, 148);
            this.DeviceBox.Name = "DeviceBox";
            this.DeviceBox.Size = new System.Drawing.Size(89, 20);
            this.DeviceBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "deviceNumber";
            // 
            // PosBox
            // 
            this.PosBox.Location = new System.Drawing.Point(206, 148);
            this.PosBox.Name = "PosBox";
            this.PosBox.Size = new System.Drawing.Size(100, 20);
            this.PosBox.TabIndex = 6;
            // 
            // AdressBox
            // 
            this.AdressBox.Location = new System.Drawing.Point(110, 148);
            this.AdressBox.Name = "AdressBox";
            this.AdressBox.Size = new System.Drawing.Size(88, 20);
            this.AdressBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Adress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Position";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(294, 60);
            this.button1.TabIndex = 10;
            this.button1.Text = "DISCONNECT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 246);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AdressBox);
            this.Controls.Add(this.PosBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeviceBox);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.StepBox);
            this.Controls.Add(this.ConnectButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox StepBox;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.TextBox DeviceBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PosBox;
        private System.Windows.Forms.TextBox AdressBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

