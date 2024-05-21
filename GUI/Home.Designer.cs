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
            dgvSP.Location = new Point(14, 16);
            dgvSP.Margin = new Padding(3, 4, 3, 4);
            dgvSP.Name = "dgvSP";
            dgvSP.RowHeadersWidth = 51;
            dgvSP.Size = new Size(887, 568);
            dgvSP.TabIndex = 0;
            dgvSP.CellContentClick += dgvSP_CellContentClick;
            // 
            // fHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(914, 600);
            Controls.Add(dgvSP);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fHome";
            Text = "Tên App";
            FormClosing += fHome_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dgvSP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSP;
    }
}