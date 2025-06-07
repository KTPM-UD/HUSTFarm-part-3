namespace GiaoDien.Forms
{
    partial class FormQLKho
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
            this.dtgvKho = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKho)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvKho
            // 
            this.dtgvKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKho.Location = new System.Drawing.Point(30, 30);
            this.dtgvKho.Name = "dtgvKho";
            this.dtgvKho.RowHeadersWidth = 62;
            this.dtgvKho.RowTemplate.Height = 33;
            this.dtgvKho.Size = new System.Drawing.Size(1000, 400);
            this.dtgvKho.TabIndex = 0;
            this.dtgvKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            // 
            // FormQLKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgvKho);
            this.Name = "FormQLKho";
            this.Text = "Quản lý kho";
            this.Load += new System.EventHandler(this.FormQLKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKho)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvKho;
    }
}
