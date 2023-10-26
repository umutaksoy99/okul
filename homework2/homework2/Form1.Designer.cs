namespace homework2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            adTxt = new TextBox();
            adresTxt = new TextBox();
            yasTxt = new TextBox();
            label6 = new Label();
            Merhaba = new ListBox();
            label5 = new Label();
            mesaiTxt = new TextBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(94, 68);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(92, 113);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 1;
            label2.Text = "Adres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(92, 157);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 2;
            label3.Text = "Yaş";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(192, 361);
            button1.Name = "button1";
            button1.Size = new Size(165, 60);
            button1.TabIndex = 3;
            button1.Text = "Bilgi Yazdır";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // adTxt
            // 
            adTxt.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            adTxt.Location = new Point(221, 61);
            adTxt.Name = "adTxt";
            adTxt.Size = new Size(100, 27);
            adTxt.TabIndex = 5;
            // 
            // adresTxt
            // 
            adresTxt.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            adresTxt.Location = new Point(221, 106);
            adresTxt.Name = "adresTxt";
            adresTxt.Size = new Size(100, 27);
            adresTxt.TabIndex = 6;
            // 
            // yasTxt
            // 
            yasTxt.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            yasTxt.Location = new Point(221, 150);
            yasTxt.Name = "yasTxt";
            yasTxt.Size = new Size(100, 27);
            yasTxt.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(94, 253);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 10;
            label6.Text = "Ünvan";
            // 
            // Merhaba
            // 
            Merhaba.FormattingEnabled = true;
            Merhaba.ItemHeight = 15;
            Merhaba.Location = new Point(410, 83);
            Merhaba.Name = "Merhaba";
            Merhaba.Size = new Size(120, 94);
            Merhaba.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(94, 209);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 15;
            label5.Text = "Mesai";
            // 
            // mesaiTxt
            // 
            mesaiTxt.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            mesaiTxt.Location = new Point(221, 202);
            mesaiTxt.Name = "mesaiTxt";
            mesaiTxt.Size = new Size(100, 27);
            mesaiTxt.TabIndex = 16;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(221, 250);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 28);
            comboBox1.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(563, 477);
            Controls.Add(comboBox1);
            Controls.Add(mesaiTxt);
            Controls.Add(label5);
            Controls.Add(Merhaba);
            Controls.Add(label6);
            Controls.Add(yasTxt);
            Controls.Add(adresTxt);
            Controls.Add(adTxt);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox adTxt;
        private TextBox adresTxt;
        private TextBox yasTxt;
        private Label label6;
        private ListBox Merhaba;
        private Label label5;
        private TextBox mesaiTxt;
        private ComboBox comboBox1;
    }
}