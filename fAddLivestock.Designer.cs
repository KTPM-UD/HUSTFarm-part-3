namespace HTQLCN
{
    partial class fAddLivestock
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label1 - Loại
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 61);
            label1.Name = "label1";
            label1.Size = new Size(85, 48);
            label1.TabIndex = 0;
            label1.Text = "Loại";
            // 
            // label2 - Giới tính
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 139);
            label2.Name = "label2";
            label2.Size = new Size(156, 48);
            label2.TabIndex = 1;
            label2.Text = "Giới tính";
            // 
            // label3 - Ngày sinh
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 309);
            label3.Name = "label3";
            label3.Size = new Size(177, 48);
            label3.TabIndex = 2;
            label3.Text = "Ngày sinh";
            // 
            // label4 - Cân nặng
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 387);
            label4.Name = "label4";
            label4.Size = new Size(169, 48);
            label4.TabIndex = 3;
            label4.Text = "Cân nặng";
            // 
            // label5 - Tên giống
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 219);
            label5.Name = "label5";
            label5.Size = new Size(180, 48);
            label5.TabIndex = 4;
            label5.Text = "Tên giống";
            // 
            // label6 - ID vật nuôi
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 465);
            label6.Name = "label6";
            label6.Size = new Size(182, 48);
            label6.TabIndex = 5;
            label6.Text = "ID vật nuôi";
            // 
            // label7 - Tên chuồng
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 543);
            label7.Name = "label7";
            label7.Size = new Size(200, 48);
            label7.TabIndex = 6;
            label7.Text = "Tên chuồng";
            // 
            // textBox1 - Loại
            textBox1.Location = new Point(237, 61);
            textBox1.Size = new Size(588, 55);
            textBox1.TabIndex = 7;
            // 
            // textBox2 - Giới tính
            textBox2.Location = new Point(237, 139);
            textBox2.Size = new Size(588, 55);
            textBox2.TabIndex = 8;
            // 
            // textBox3 - Tên giống
            textBox3.Location = new Point(237, 219);
            textBox3.Size = new Size(588, 55);
            textBox3.TabIndex = 9;
            // 
            // textBox4 - Cân nặng
            textBox4.Location = new Point(237, 387);
            textBox4.Size = new Size(588, 55);
            textBox4.TabIndex = 10;
            // 
            // textBox5 - ID vật nuôi
            textBox5.Location = new Point(237, 465);
            textBox5.Size = new Size(588, 55);
            textBox5.TabIndex = 11;
            // 
            // textBox6 - Tên chuồng
            textBox6.Location = new Point(237, 543);
            textBox6.Size = new Size(588, 55);
            textBox6.TabIndex = 12;
            // 
            // dateTimePicker1 - Ngày sinh
            dateTimePicker1.Location = new Point(237, 309);
            dateTimePicker1.Size = new Size(588, 55);
            dateTimePicker1.TabIndex = 13;
            // 
            // button1 - Lưu
            button1.Location = new Point(76, 630);
            button1.Size = new Size(225, 69);
            button1.Text = "Lưu";
            button1.TabIndex = 14;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2 - Hủy
            button2.Location = new Point(438, 630);
            button2.Size = new Size(225, 69);
            button2.Text = "Hủy";
            button2.TabIndex = 15;
            button2.UseVisualStyleBackColor = true;

            // 
            // fAddLivestock
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 750);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(button2);
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
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button1;
        private Button button2;
        private DateTimePicker dateTimePicker1;
    }
}
