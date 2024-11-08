namespace Proyecto
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label1.Location = new Point(86, 65);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 0;
            label1.Text = "DDD";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(112, 9);
            label2.Name = "label2";
            label2.Size = new Size(158, 41);
            label2.TabIndex = 1;
            label2.Text = "Faltannn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(76, 113);
            label3.Name = "label3";
            label3.Size = new Size(212, 24);
            label3.TabIndex = 2;
            label3.Text = "Para Que LLegueeee";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(51, 137);
            label4.Name = "label4";
            label4.Size = new Size(279, 41);
            label4.TabIndex = 3;
            label4.Text = "Diciembreeeeee";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(93, 50);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 4;
            label5.Text = "Días";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(131, 50);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 5;
            label6.Text = "Horas";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(174, 50);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 6;
            label7.Text = "Minutos";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(229, 50);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 7;
            label8.Text = "Segundos";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label9.Location = new Point(134, 65);
            label9.Name = "label9";
            label9.Size = new Size(31, 20);
            label9.TabIndex = 8;
            label9.Text = "HH";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label10.Location = new Point(181, 65);
            label10.Name = "label10";
            label10.Size = new Size(37, 20);
            label10.TabIndex = 9;
            label10.Text = "MM";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label11.Location = new Point(245, 65);
            label11.Name = "label11";
            label11.Size = new Size(25, 20);
            label11.TabIndex = 10;
            label11.Text = "SS";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 194);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Cuenta Regresiva";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}
