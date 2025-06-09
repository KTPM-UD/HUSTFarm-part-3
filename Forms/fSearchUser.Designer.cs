namespace GiaoDien.Forms
{
    partial class fSearchUser
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
            tbSearchUser = new TextBox();
            btnSearchUSER = new Button();
            SuspendLayout();
            // 
            // tbSearchUser
            // 
            tbSearchUser.Anchor = AnchorStyles.None;
            tbSearchUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSearchUser.Location = new Point(56, 24);
            tbSearchUser.Name = "tbSearchUser";
            tbSearchUser.PlaceholderText = "Nhập ID người dùng";
            tbSearchUser.Size = new Size(821, 71);
            tbSearchUser.TabIndex = 3;
            // 
            // btnSearchUSER
            // 
            btnSearchUSER.Anchor = AnchorStyles.None;
            btnSearchUSER.AutoSize = true;
            btnSearchUSER.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSearchUSER.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearchUSER.Image = Properties.Resources.search_60dp;
            btnSearchUSER.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearchUSER.Location = new Point(287, 127);
            btnSearchUSER.Name = "btnSearchUSER";
            btnSearchUSER.Padding = new Padding(20, 0, 0, 0);
            btnSearchUSER.Size = new Size(312, 75);
            btnSearchUSER.TabIndex = 2;
            btnSearchUSER.Text = "Tìm kiếm";
            btnSearchUSER.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearchUSER.UseVisualStyleBackColor = true;
            btnSearchUSER.Click += btnSearchUSER_Click;
            // 
            // fSearchUser
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 234);
            Controls.Add(tbSearchUser);
            Controls.Add(btnSearchUSER);
            Name = "fSearchUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form tìm kiếm người dùng";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbSearchUser;
        private Button btnSearchUSER;
    }
}