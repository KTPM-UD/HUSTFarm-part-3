namespace GiaoDien.Forms
{
    partial class fSearchThucAn
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
            btnSearchform = new Button();
            tbSearchThucAn = new TextBox();
            SuspendLayout();
            // 
            // btnSearchform
            // 
            btnSearchform.Anchor = AnchorStyles.None;
            btnSearchform.AutoSize = true;
            btnSearchform.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSearchform.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearchform.Image = Properties.Resources.search_60dp;
            btnSearchform.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearchform.Location = new Point(292, 126);
            btnSearchform.Name = "btnSearchform";
            btnSearchform.Padding = new Padding(10, 0, 0, 0);
            btnSearchform.Size = new Size(265, 66);
            btnSearchform.TabIndex = 0;
            btnSearchform.Text = "Tìm kiếm";
            btnSearchform.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearchform.UseVisualStyleBackColor = true;
            btnSearchform.Click += btnSearchform_Click;
            // 
            // tbSearchThucAn
            // 
            tbSearchThucAn.Anchor = AnchorStyles.None;
            tbSearchThucAn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSearchThucAn.Location = new Point(56, 25);
            tbSearchThucAn.Name = "tbSearchThucAn";
            tbSearchThucAn.PlaceholderText = "Nhập ID hoặc tên thức ăn";
            tbSearchThucAn.Size = new Size(821, 71);
            tbSearchThucAn.TabIndex = 1;
            tbSearchThucAn.TextChanged += tbSearchThucAn_TextChanged;
            // 
            // fSearchThucAn
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 234);
            Controls.Add(tbSearchThucAn);
            Controls.Add(btnSearchform);
            Name = "fSearchThucAn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form tìm kiếm thức ăn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearchform;
        private TextBox tbSearchThucAn;
    }
}
