namespace OOP_Assignment_1_B231210041
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            adiTextBox = new TextBox();
            cinsTextBox = new TextBox();
            button1 = new Button();
            label7 = new Label();
            yiyecekComboBox = new ComboBox();
            menuListBox = new ListBox();
            tutarLabel = new Label();
            fiyatNumericUpDown = new NumericUpDown();
            kdvOraniNumericUpDown = new NumericUpDown();
            kaloriNumericUpDown = new NumericUpDown();
            silButton = new Button();
            menuOlusturButton = new Button();
            ((System.ComponentModel.ISupportInitialize)fiyatNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kdvOraniNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kaloriNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(14, 65);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(196, 41);
            label1.TabIndex = 0;
            label1.Text = "Yiyecek Türü";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.Location = new Point(14, 158);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 41);
            label2.TabIndex = 1;
            label2.Text = "Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.Location = new Point(14, 238);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(86, 41);
            label3.TabIndex = 2;
            label3.Text = "Cinsi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label4.Location = new Point(14, 322);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(96, 41);
            label4.TabIndex = 3;
            label4.Text = "Fiyatı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label5.Location = new Point(14, 407);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(165, 41);
            label5.TabIndex = 4;
            label5.Text = "KDV Oranı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label6.Location = new Point(14, 487);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(101, 41);
            label6.TabIndex = 5;
            label6.Text = "Kalori";
            // 
            // adiTextBox
            // 
            adiTextBox.Location = new Point(208, 155);
            adiTextBox.Name = "adiTextBox";
            adiTextBox.Size = new Size(355, 47);
            adiTextBox.TabIndex = 6;
            // 
            // cinsTextBox
            // 
            cinsTextBox.Location = new Point(208, 235);
            cinsTextBox.Name = "cinsTextBox";
            cinsTextBox.Size = new Size(355, 47);
            cinsTextBox.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.AliceBlue;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            button1.Location = new Point(273, 547);
            button1.Name = "button1";
            button1.Size = new Size(142, 41);
            button1.TabIndex = 11;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label7.Location = new Point(831, 62);
            label7.Name = "label7";
            label7.Size = new Size(233, 41);
            label7.TabIndex = 12;
            label7.Text = "Sipariş Menüsü";
            // 
            // yiyecekComboBox
            // 
            yiyecekComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            yiyecekComboBox.FormattingEnabled = true;
            yiyecekComboBox.Items.AddRange(new object[] { "Meyve", "Salata", "Tatlı", "İçecek" });
            yiyecekComboBox.Location = new Point(208, 62);
            yiyecekComboBox.Name = "yiyecekComboBox";
            yiyecekComboBox.Size = new Size(355, 49);
            yiyecekComboBox.TabIndex = 13;
            // 
            // menuListBox
            // 
            menuListBox.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            menuListBox.FormattingEnabled = true;
            menuListBox.Location = new Point(606, 107);
            menuListBox.Name = "menuListBox";
            menuListBox.Size = new Size(690, 364);
            menuListBox.TabIndex = 14;
            // 
            // tutarLabel
            // 
            tutarLabel.BackColor = Color.White;
            tutarLabel.BorderStyle = BorderStyle.FixedSingle;
            tutarLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            tutarLabel.Location = new Point(606, 484);
            tutarLabel.Name = "tutarLabel";
            tutarLabel.Size = new Size(690, 48);
            tutarLabel.TabIndex = 15;
            tutarLabel.Text = "Tutar: 0 TL";
            // 
            // fiyatNumericUpDown
            // 
            fiyatNumericUpDown.DecimalPlaces = 2;
            fiyatNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            fiyatNumericUpDown.Location = new Point(208, 320);
            fiyatNumericUpDown.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            fiyatNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            fiyatNumericUpDown.Name = "fiyatNumericUpDown";
            fiyatNumericUpDown.Size = new Size(355, 47);
            fiyatNumericUpDown.TabIndex = 18;
            fiyatNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // kdvOraniNumericUpDown
            // 
            kdvOraniNumericUpDown.DecimalPlaces = 2;
            kdvOraniNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            kdvOraniNumericUpDown.Location = new Point(208, 405);
            kdvOraniNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            kdvOraniNumericUpDown.Name = "kdvOraniNumericUpDown";
            kdvOraniNumericUpDown.Size = new Size(355, 47);
            kdvOraniNumericUpDown.TabIndex = 19;
            kdvOraniNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // kaloriNumericUpDown
            // 
            kaloriNumericUpDown.DecimalPlaces = 2;
            kaloriNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            kaloriNumericUpDown.Location = new Point(208, 485);
            kaloriNumericUpDown.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            kaloriNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            kaloriNumericUpDown.Name = "kaloriNumericUpDown";
            kaloriNumericUpDown.Size = new Size(355, 47);
            kaloriNumericUpDown.TabIndex = 20;
            kaloriNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // silButton
            // 
            silButton.BackColor = Color.AliceBlue;
            silButton.Cursor = Cursors.Hand;
            silButton.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            silButton.Location = new Point(421, 547);
            silButton.Name = "silButton";
            silButton.Size = new Size(142, 41);
            silButton.TabIndex = 21;
            silButton.Text = "Sil";
            silButton.UseVisualStyleBackColor = false;
            silButton.Click += silButton_Click;
            // 
            // menuOlusturButton
            // 
            menuOlusturButton.BackColor = Color.AliceBlue;
            menuOlusturButton.Cursor = Cursors.Hand;
            menuOlusturButton.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            menuOlusturButton.Location = new Point(1075, 547);
            menuOlusturButton.Name = "menuOlusturButton";
            menuOlusturButton.Size = new Size(221, 41);
            menuOlusturButton.TabIndex = 22;
            menuOlusturButton.Text = "Menüyü Oluştur";
            menuOlusturButton.UseVisualStyleBackColor = false;
            menuOlusturButton.Click += menuOlusturButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1320, 615);
            Controls.Add(menuOlusturButton);
            Controls.Add(silButton);
            Controls.Add(kaloriNumericUpDown);
            Controls.Add(kdvOraniNumericUpDown);
            Controls.Add(fiyatNumericUpDown);
            Controls.Add(tutarLabel);
            Controls.Add(menuListBox);
            Controls.Add(yiyecekComboBox);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(cinsTextBox);
            Controls.Add(adiTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " OOP Assignment 1 B231210041";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)fiyatNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)kdvOraniNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)kaloriNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox adiTextBox;
        private TextBox cinsTextBox;
        private Button button1;
        private Label label7;
        private ComboBox yiyecekComboBox;
        private ListBox menuListBox;
        private Label tutarLabel;
        private NumericUpDown fiyatNumericUpDown;
        private NumericUpDown kdvOraniNumericUpDown;
        private NumericUpDown kaloriNumericUpDown;
        private Button silButton;
        private Button menuOlusturButton;
    }
}
