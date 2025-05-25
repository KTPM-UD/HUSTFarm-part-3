namespace HTQLCN
{
    partial class fAddLivestock
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 61);
            label1.Name = "label1";
            label1.Size = new Size(85, 48);
            label1.TabIndex = 0;
            label1.Text = "Loại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 159);
            label2.Name = "label2";
            label2.Size = new Size(156, 48);
            label2.TabIndex = 1;
            label2.Text = "Giới tính";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 261);
            label3.Name = "label3";
            label3.Size = new Size(177, 48);
            label3.TabIndex = 2;
            label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 369);
            label4.Name = "label4";
            label4.Size = new Size(169, 48);
            label4.TabIndex = 3;
            label4.Text = "Cân nặng";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(237, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(588, 55);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(237, 159);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(588, 55);
            textBox2.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(237, 369);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(588, 55);
            textBox4.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(76, 503);
            button1.Name = "button1";
            button1.Size = new Size(225, 69);
            button1.TabIndex = 9;
            button1.Text = "Lưu";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(438, 503);
            button2.Name = "button2";
            button2.Size = new Size(225, 69);
            button2.TabIndex = 10;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(237, 261);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(588, 55);
            dateTimePicker1.TabIndex = 11;
            // 
            // fAddLivestock
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 638);
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
            Name = "fAddLivestock";
            Text = "Form thêm vật nuôi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private DateTimePicker dateTimePicker1;
    }
}