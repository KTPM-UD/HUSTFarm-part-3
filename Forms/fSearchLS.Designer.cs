namespace GiaoDien.Forms
{
    partial class fSearchLS
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
            tbSearchLS = new TextBox();
            SuspendLayout();
            // 
            // btnSearchform
            // 
            btnSearchform.Anchor = AnchorStyles.None;
            btnSearchform.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearchform.Image = Properties.Resources.search_60dp;
            btnSearchform.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearchform.Location = new Point(292, 126);
            btnSearchform.Name = "btnSearchform";
            btnSearchform.Padding = new Padding(20, 0, 0, 0);
            btnSearchform.Size = new Size(322, 81);
            btnSearchform.TabIndex = 0;
            btnSearchform.Text = "Tìm kiếm";
            btnSearchform.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearchform.UseVisualStyleBackColor = true;
            btnSearchform.Click += btnSearchform_Click;
            // 
            // tbSearchLS
            // 
            tbSearchLS.Anchor = AnchorStyles.None;
            tbSearchLS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSearchLS.Location = new Point(56, 25);
            tbSearchLS.Name = "tbSearchLS";
            tbSearchLS.PlaceholderText = "Nhập ID vật nuôi";
            tbSearchLS.Size = new Size(821, 71);
            tbSearchLS.TabIndex = 1;
            tbSearchLS.TextChanged += tbSearchLS_TextChanged;
            // 
            // fSearchLS
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 234);
            Controls.Add(tbSearchLS);
            Controls.Add(btnSearchform);
            Name = "fSearchLS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form tìm kiếm vật nuôi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearchform;
        private TextBox tbSearchLS;
    }
}