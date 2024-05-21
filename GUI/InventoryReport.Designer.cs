namespace QLTiemVang.GUI
{
    partial class InventoryReport
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
            dataGridView1 = new DataGridView();
            label2 = new Label();
            ColSTT = new DataGridViewTextBoxColumn();
            colSanPham = new DataGridViewTextBoxColumn();
            colTonDau = new DataGridViewTextBoxColumn();
            colSoLuongMuaVao = new DataGridViewTextBoxColumn();
            colSoLuongBanRa = new DataGridViewTextBoxColumn();
            colTonCuoi = new DataGridViewTextBoxColumn();
            colDonViTinh = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(176, 9);
            label1.Name = "label1";
            label1.Size = new Size(731, 37);
            label1.TabIndex = 2;
            label1.Text = "DANH SÁCH PHIẾU DỊCH VỤ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColSTT, colSanPham, colTonDau, colSoLuongMuaVao, colSoLuongBanRa, colTonCuoi, colDonViTinh });
            dataGridView1.Location = new Point(0, 89);
            dataGridView1.Margin = new Padding(3, 43, 3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1083, 364);
            dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(362, 48);
            label2.Name = "label2";
            label2.Size = new Size(353, 28);
            label2.TabIndex = 4;
            label2.Text = "Tháng:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // ColSTT
            // 
            ColSTT.FillWeight = 34.0319F;
            ColSTT.HeaderText = "STT";
            ColSTT.MinimumWidth = 6;
            ColSTT.Name = "ColSTT";
            // 
            // colSanPham
            // 
            colSanPham.FillWeight = 64.0319F;
            colSanPham.HeaderText = "Sản phẩm";
            colSanPham.MinimumWidth = 6;
            colSanPham.Name = "colSanPham";
            // 
            // colTonDau
            // 
            colTonDau.FillWeight = 34.0319F;
            colTonDau.HeaderText = "Tồn đầu";
            colTonDau.MinimumWidth = 6;
            colTonDau.Name = "colTonDau";
            // 
            // colSoLuongMuaVao
            // 
            colSoLuongMuaVao.FillWeight = 64.0319F;
            colSoLuongMuaVao.HeaderText = "Số lượng mua vào";
            colSoLuongMuaVao.MinimumWidth = 6;
            colSoLuongMuaVao.Name = "colSoLuongMuaVao";
            // 
            // colSoLuongBanRa
            // 
            colSoLuongBanRa.FillWeight = 64.0319F;
            colSoLuongBanRa.HeaderText = "Số lượng bán ra";
            colSoLuongBanRa.MinimumWidth = 6;
            colSoLuongBanRa.Name = "colSoLuongBanRa";
            // 
            // colTonCuoi
            // 
            colTonCuoi.FillWeight = 34.0319F;
            colTonCuoi.HeaderText = "Tồn cuối";
            colTonCuoi.MinimumWidth = 6;
            colTonCuoi.Name = "colTonCuoi";
            // 
            // colDonViTinh
            // 
            colDonViTinh.FillWeight = 34.0319F;
            colDonViTinh.HeaderText = "Đơn vị tính";
            colDonViTinh.MinimumWidth = 6;
            colDonViTinh.Name = "colDonViTinh";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 450);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private DataGridViewTextBoxColumn ColSTT;
        private DataGridViewTextBoxColumn colSanPham;
        private DataGridViewTextBoxColumn colTonDau;
        private DataGridViewTextBoxColumn colSoLuongMuaVao;
        private DataGridViewTextBoxColumn colSoLuongBanRa;
        private DataGridViewTextBoxColumn colTonCuoi;
        private DataGridViewTextBoxColumn colDonViTinh;
    }
}