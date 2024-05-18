namespace QLTiemVang.GUI
{
    partial class fHome
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
            dgvSP = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSP).BeginInit();
            SuspendLayout();
            // 
            // dgvSP
            // 
            dgvSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSP.Location = new Point(12, 12);
            dgvSP.Name = "dgvSP";
            dgvSP.Size = new Size(776, 426);
            dgvSP.TabIndex = 0;
            // 
            // fHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvSP);
            Name = "fHome";
            Text = "Tên App";
            ((System.ComponentModel.ISupportInitialize)dgvSP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSP;
    }
}