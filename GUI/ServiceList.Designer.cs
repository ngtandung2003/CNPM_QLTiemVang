namespace QLTiemVang.GUI
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            colSTT = new DataGridViewTextBoxColumn();
            colSoPhieu = new DataGridViewTextBoxColumn();
            colNgayLap = new DataGridViewTextBoxColumn();
            colKhachHang = new DataGridViewTextBoxColumn();
            colTongTien = new DataGridViewTextBoxColumn();
            colTraTruoc = new DataGridViewTextBoxColumn();
            colConLai = new DataGridViewTextBoxColumn();
            colTinhTrang = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colSTT, colSoPhieu, colNgayLap, colKhachHang, colTongTien, colTraTruoc, colConLai, colTinhTrang });
            dataGridView1.Location = new Point(0, 52);
            dataGridView1.Margin = new Padding(3, 43, 3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1213, 406);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(268, 10);
            label1.Name = "label1";
            label1.Size = new Size(690, 37);
            label1.TabIndex = 1;
            label1.Text = "DANH SÁCH PHIẾU DỊCH VỤ";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // colSTT
            // 
            colSTT.FillWeight = 34.0319F;
            colSTT.HeaderText = "STT";
            colSTT.MinimumWidth = 6;
            colSTT.Name = "colSTT";
            // 
            // colSoPhieu
            // 
            colSoPhieu.FillWeight = 77.61651F;
            colSoPhieu.HeaderText = "Số phiếu";
            colSoPhieu.MinimumWidth = 6;
            colSoPhieu.Name = "colSoPhieu";
            // 
            // colNgayLap
            // 
            colNgayLap.FillWeight = 77.61651F;
            colNgayLap.HeaderText = "Ngày lập";
            colNgayLap.MinimumWidth = 6;
            colNgayLap.Name = "colNgayLap";
            // 
            // colKhachHang
            // 
            colKhachHang.FillWeight = 100.616508F;
            colKhachHang.HeaderText = "Khách hàng";
            colKhachHang.MinimumWidth = 6;
            colKhachHang.Name = "colKhachHang";
            // 
            // colTongTien
            // 
            colTongTien.FillWeight = 77.61651F;
            colTongTien.HeaderText = "Tổng tiền";
            colTongTien.MinimumWidth = 6;
            colTongTien.Name = "colTongTien";
            // 
            // colTraTruoc
            // 
            colTraTruoc.FillWeight = 77.61651F;
            colTraTruoc.HeaderText = "Trả trước";
            colTraTruoc.MinimumWidth = 6;
            colTraTruoc.Name = "colTraTruoc";
            // 
            // colConLai
            // 
            colConLai.FillWeight = 77.61651F;
            colConLai.HeaderText = "Còn lại";
            colConLai.MinimumWidth = 6;
            colConLai.Name = "colConLai";
            // 
            // colTinhTrang
            // 
            colTinhTrang.FillWeight = 77.61651F;
            colTinhTrang.HeaderText = "Tình trạng";
            colTinhTrang.MinimumWidth = 6;
            colTinhTrang.Name = "colTinhTrang";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 458);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Lusso Jewelry";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private DataGridViewTextBoxColumn colSTT;
        private DataGridViewTextBoxColumn colSoPhieu;
        private DataGridViewTextBoxColumn colNgayLap;
        private DataGridViewTextBoxColumn colKhachHang;
        private DataGridViewTextBoxColumn colTongTien;
        private DataGridViewTextBoxColumn colTraTruoc;
        private DataGridViewTextBoxColumn colConLai;
        private DataGridViewTextBoxColumn colTinhTrang;
    }
}