namespace ResponsiGrandiv
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            namaKarLb = new Label();
            deptLb = new Label();
            logoPB = new PictureBox();
            namaKar_TB = new TextBox();
            HR_RB = new RadioButton();
            ENG_RB = new RadioButton();
            DEV_RB = new RadioButton();
            PM_RB = new RadioButton();
            FIN_RB = new RadioButton();
            insertBt = new Button();
            editBt = new Button();
            deleteBt = new Button();
            deptList = new ListBox();
            dgvDataTable = new DataGridView();
            karTerpilih_lb = new Label();
            karTerpilih_dynamicLb = new Label();
            jabatanBt = new Button();
            ((System.ComponentModel.ISupportInitialize)logoPB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDataTable).BeginInit();
            SuspendLayout();
            // 
            // namaKarLb
            // 
            namaKarLb.AutoSize = true;
            namaKarLb.Location = new Point(12, 78);
            namaKarLb.Name = "namaKarLb";
            namaKarLb.Size = new Size(93, 15);
            namaKarLb.TabIndex = 0;
            namaKarLb.Text = "Nama Karyawan";
            // 
            // deptLb
            // 
            deptLb.AutoSize = true;
            deptLb.Location = new Point(12, 113);
            deptLb.Name = "deptLb";
            deptLb.Size = new Size(72, 15);
            deptLb.TabIndex = 1;
            deptLb.Text = "Departemen";
            // 
            // logoPB
            // 
            logoPB.Image = Properties.Resources.microsoft;
            logoPB.Location = new Point(15, 12);
            logoPB.Name = "logoPB";
            logoPB.Size = new Size(209, 50);
            logoPB.SizeMode = PictureBoxSizeMode.StretchImage;
            logoPB.TabIndex = 2;
            logoPB.TabStop = false;
            // 
            // namaKar_TB
            // 
            namaKar_TB.Location = new Point(129, 75);
            namaKar_TB.Name = "namaKar_TB";
            namaKar_TB.Size = new Size(245, 23);
            namaKar_TB.TabIndex = 3;
            // 
            // HR_RB
            // 
            HR_RB.AutoSize = true;
            HR_RB.Location = new Point(129, 113);
            HR_RB.Name = "HR_RB";
            HR_RB.Size = new Size(41, 19);
            HR_RB.TabIndex = 4;
            HR_RB.TabStop = true;
            HR_RB.Text = "HR";
            HR_RB.UseVisualStyleBackColor = true;
            // 
            // ENG_RB
            // 
            ENG_RB.AutoSize = true;
            ENG_RB.Location = new Point(176, 113);
            ENG_RB.Name = "ENG_RB";
            ENG_RB.Size = new Size(48, 19);
            ENG_RB.TabIndex = 5;
            ENG_RB.TabStop = true;
            ENG_RB.Text = "ENG";
            ENG_RB.UseVisualStyleBackColor = true;
            // 
            // DEV_RB
            // 
            DEV_RB.AutoSize = true;
            DEV_RB.Location = new Point(230, 113);
            DEV_RB.Name = "DEV_RB";
            DEV_RB.Size = new Size(46, 19);
            DEV_RB.TabIndex = 6;
            DEV_RB.TabStop = true;
            DEV_RB.Text = "DEV";
            DEV_RB.UseVisualStyleBackColor = true;
            // 
            // PM_RB
            // 
            PM_RB.AutoSize = true;
            PM_RB.Location = new Point(282, 113);
            PM_RB.Name = "PM_RB";
            PM_RB.Size = new Size(43, 19);
            PM_RB.TabIndex = 7;
            PM_RB.TabStop = true;
            PM_RB.Text = "PM";
            PM_RB.UseVisualStyleBackColor = true;
            // 
            // FIN_RB
            // 
            FIN_RB.AutoSize = true;
            FIN_RB.Location = new Point(331, 113);
            FIN_RB.Name = "FIN_RB";
            FIN_RB.Size = new Size(43, 19);
            FIN_RB.TabIndex = 8;
            FIN_RB.TabStop = true;
            FIN_RB.Text = "FIN";
            FIN_RB.UseVisualStyleBackColor = true;
            // 
            // insertBt
            // 
            insertBt.Location = new Point(80, 149);
            insertBt.Name = "insertBt";
            insertBt.Size = new Size(75, 23);
            insertBt.TabIndex = 9;
            insertBt.Text = "Insert";
            insertBt.UseVisualStyleBackColor = true;
            insertBt.Click += insertBt_Click;
            // 
            // editBt
            // 
            editBt.Location = new Point(181, 149);
            editBt.Name = "editBt";
            editBt.Size = new Size(75, 23);
            editBt.TabIndex = 10;
            editBt.Text = "Edit";
            editBt.UseVisualStyleBackColor = true;
            editBt.Click += editBt_Click;
            // 
            // deleteBt
            // 
            deleteBt.Location = new Point(282, 149);
            deleteBt.Name = "deleteBt";
            deleteBt.Size = new Size(75, 23);
            deleteBt.TabIndex = 11;
            deleteBt.Text = "Delete";
            deleteBt.UseVisualStyleBackColor = true;
            deleteBt.Click += deleteBt_Click;
            // 
            // deptList
            // 
            deptList.BackColor = SystemColors.Control;
            deptList.FormattingEnabled = true;
            deptList.ItemHeight = 15;
            deptList.Location = new Point(469, 78);
            deptList.Name = "deptList";
            deptList.Size = new Size(283, 94);
            deptList.TabIndex = 12;
            // 
            // dgvDataTable
            // 
            dgvDataTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataTable.Location = new Point(12, 232);
            dgvDataTable.Name = "dgvDataTable";
            dgvDataTable.RowTemplate.Height = 25;
            dgvDataTable.Size = new Size(776, 206);
            dgvDataTable.TabIndex = 13;
            dgvDataTable.CellClick += dgvDataTable_CellClick;
            // 
            // karTerpilih_lb
            // 
            karTerpilih_lb.AutoSize = true;
            karTerpilih_lb.Location = new Point(12, 195);
            karTerpilih_lb.Name = "karTerpilih_lb";
            karTerpilih_lb.Size = new Size(105, 15);
            karTerpilih_lb.TabIndex = 14;
            karTerpilih_lb.Text = "Karyawan Terpilih: ";
            // 
            // karTerpilih_dynamicLb
            // 
            karTerpilih_dynamicLb.AutoSize = true;
            karTerpilih_dynamicLb.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            karTerpilih_dynamicLb.Location = new Point(123, 195);
            karTerpilih_dynamicLb.Name = "karTerpilih_dynamicLb";
            karTerpilih_dynamicLb.Size = new Size(90, 15);
            karTerpilih_dynamicLb.TabIndex = 15;
            karTerpilih_dynamicLb.Text = "belum memilih";
            // 
            // jabatanBt
            // 
            jabatanBt.FlatStyle = FlatStyle.Flat;
            jabatanBt.Location = new Point(640, 187);
            jabatanBt.Name = "jabatanBt";
            jabatanBt.Size = new Size(112, 23);
            jabatanBt.TabIndex = 16;
            jabatanBt.Text = "Kelola Jabatan";
            jabatanBt.UseVisualStyleBackColor = true;
            jabatanBt.Click += jabatanBt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(jabatanBt);
            Controls.Add(karTerpilih_dynamicLb);
            Controls.Add(karTerpilih_lb);
            Controls.Add(dgvDataTable);
            Controls.Add(deptList);
            Controls.Add(deleteBt);
            Controls.Add(editBt);
            Controls.Add(insertBt);
            Controls.Add(FIN_RB);
            Controls.Add(PM_RB);
            Controls.Add(DEV_RB);
            Controls.Add(ENG_RB);
            Controls.Add(HR_RB);
            Controls.Add(namaKar_TB);
            Controls.Add(logoPB);
            Controls.Add(deptLb);
            Controls.Add(namaKarLb);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)logoPB).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDataTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label namaKarLb;
        private Label deptLb;
        private PictureBox logoPB;
        private TextBox namaKar_TB;
        private RadioButton HR_RB;
        private RadioButton ENG_RB;
        private RadioButton DEV_RB;
        private RadioButton PM_RB;
        private RadioButton FIN_RB;
        private Button insertBt;
        private Button editBt;
        private Button deleteBt;
        private ListBox deptList;
        private DataGridView dgvDataTable;
        private Label karTerpilih_lb;
        private Label karTerpilih_dynamicLb;
        private Button jabatanBt;
    }
}
