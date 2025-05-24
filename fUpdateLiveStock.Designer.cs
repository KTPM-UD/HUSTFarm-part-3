namespace HTQLCN
{
    partial class fUpdateLiveStock
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
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            button1 = new Button();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(241, 250);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(588, 55);
            dateTimePicker1.TabIndex = 21;
            // 
            // button2
            // 
            button2.Location = new Point(442, 492);
            button2.Name = "button2";
            button2.Size = new Size(225, 69);
            button2.TabIndex = 20;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(80, 492);
            button1.Name = "button1";
            button1.Size = new Size(225, 69);
            button1.TabIndex = 19;
            button1.Text = "Lưu";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(241, 358);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(588, 55);
            textBox4.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(241, 148);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(588, 55);
            textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(241, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(588, 55);
            textBox1.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 358);
            label4.Name = "label4";
            label4.Size = new Size(169, 48);
            label4.TabIndex = 15;
            label4.Text = "Cân nặng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 250);
            label3.Name = "label3";
            label3.Size = new Size(177, 48);
            label3.TabIndex = 14;
            label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 148);
            label2.Name = "label2";
            label2.Size = new Size(156, 48);
            label2.TabIndex = 13;
            label2.Text = "Giới tính";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 50);
            label1.Name = "label1";
            label1.Size = new Size(85, 48);
            label1.TabIndex = 12;
            label1.Text = "Loại";
            // 
            // fUpdateLiveStock
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 619);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fUpdateLiveStock";
            Text = "fUpdateLiveStock";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button button2;
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}