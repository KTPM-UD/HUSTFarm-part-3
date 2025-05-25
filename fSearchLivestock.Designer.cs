namespace HTQLCN
{
    partial class fSearchLivestock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSearchLivestock));
            panel1 = new Panel();
            BtnSearchLivestock = new Button();
            TbLivestockSearch = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnSearchLivestock);
            panel1.Controls.Add(TbLivestockSearch);
            panel1.Location = new Point(48, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(907, 223);
            panel1.TabIndex = 3;
            // 
            // BtnSearchLivestock
            // 
            BtnSearchLivestock.Font = new Font("Segoe UI", 12F);
            BtnSearchLivestock.Image = (Image)resources.GetObject("BtnSearchLivestock.Image");
            BtnSearchLivestock.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSearchLivestock.Location = new Point(305, 128);
            BtnSearchLivestock.Name = "BtnSearchLivestock";
            BtnSearchLivestock.Size = new Size(270, 74);
            BtnSearchLivestock.TabIndex = 0;
            BtnSearchLivestock.Tag = "";
            BtnSearchLivestock.Text = "Tìm kiếm";
            BtnSearchLivestock.TextAlign = ContentAlignment.MiddleRight;
            BtnSearchLivestock.UseVisualStyleBackColor = true;
            BtnSearchLivestock.Click += BtnSearchLivestock_Click;
            // 
            // TbLivestockSearch
            // 
            TbLivestockSearch.Font = new Font("Segoe UI", 12F);
            TbLivestockSearch.Location = new Point(3, 30);
            TbLivestockSearch.MaxLength = 50;
            TbLivestockSearch.Name = "TbLivestockSearch";
            TbLivestockSearch.PlaceholderText = "Nhập ID vật nuôi";
            TbLivestockSearch.Size = new Size(898, 71);
            TbLivestockSearch.TabIndex = 1;
            // 
            // fSearchLivestock
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 330);
            Controls.Add(panel1);
            Name = "fSearchLivestock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form tìm kiếm vật nuôi";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnSearchLivestock;
        private TextBox TbLivestockSearch;
    }
}