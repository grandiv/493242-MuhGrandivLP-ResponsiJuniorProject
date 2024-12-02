namespace ResponsiGrandiv
{
    partial class Form2
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
            namajabatanLb = new Label();
            insertBt = new Button();
            editBt = new Button();
            deleteBt = new Button();
            jabatanTb = new TextBox();
            dgvDataTable = new DataGridView();
            pengelolaanLb = new Label();
            salaryLb = new Label();
            salaryTb = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDataTable).BeginInit();
            SuspendLayout();
            // 
            // namajabatanLb
            // 
            namajabatanLb.AutoSize = true;
            namajabatanLb.Location = new Point(248, 85);
            namajabatanLb.Name = "namajabatanLb";
            namajabatanLb.Size = new Size(82, 15);
            namajabatanLb.TabIndex = 0;
            namajabatanLb.Text = "Nama Jabatan";
            // 
            // insertBt
            // 
            insertBt.Location = new Point(255, 177);
            insertBt.Name = "insertBt";
            insertBt.Size = new Size(75, 23);
            insertBt.TabIndex = 1;
            insertBt.Text = "Insert";
            insertBt.UseVisualStyleBackColor = true;
            insertBt.Click += insertBt_Click;
            // 
            // editBt
            // 
            editBt.Location = new Point(356, 177);
            editBt.Name = "editBt";
            editBt.Size = new Size(75, 23);
            editBt.TabIndex = 2;
            editBt.Text = "Edit";
            editBt.UseVisualStyleBackColor = true;
            editBt.Click += editBt_Click;
            // 
            // deleteBt
            // 
            deleteBt.Location = new Point(456, 177);
            deleteBt.Name = "deleteBt";
            deleteBt.Size = new Size(75, 23);
            deleteBt.TabIndex = 3;
            deleteBt.Text = "Delete";
            deleteBt.UseVisualStyleBackColor = true;
            deleteBt.Click += deleteBt_Click;
            // 
            // jabatanTb
            // 
            jabatanTb.Location = new Point(336, 82);
            jabatanTb.Name = "jabatanTb";
            jabatanTb.Size = new Size(195, 23);
            jabatanTb.TabIndex = 4;
            // 
            // dgvDataTable
            // 
            dgvDataTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataTable.Location = new Point(12, 227);
            dgvDataTable.Name = "dgvDataTable";
            dgvDataTable.RowTemplate.Height = 25;
            dgvDataTable.Size = new Size(776, 211);
            dgvDataTable.TabIndex = 5;
            // 
            // pengelolaanLb
            // 
            pengelolaanLb.AutoSize = true;
            pengelolaanLb.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            pengelolaanLb.Location = new Point(273, 33);
            pengelolaanLb.Name = "pengelolaanLb";
            pengelolaanLb.Size = new Size(215, 30);
            pengelolaanLb.TabIndex = 6;
            pengelolaanLb.Text = "Pengelolaan Jabatan";
            // 
            // salaryLb
            // 
            salaryLb.AutoSize = true;
            salaryLb.Location = new Point(248, 120);
            salaryLb.Name = "salaryLb";
            salaryLb.Size = new Size(38, 15);
            salaryLb.TabIndex = 7;
            salaryLb.Text = "Salary";
            // 
            // salaryTb
            // 
            salaryTb.Location = new Point(336, 120);
            salaryTb.Name = "salaryTb";
            salaryTb.Size = new Size(195, 23);
            salaryTb.TabIndex = 8;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(salaryTb);
            Controls.Add(salaryLb);
            Controls.Add(pengelolaanLb);
            Controls.Add(dgvDataTable);
            Controls.Add(jabatanTb);
            Controls.Add(deleteBt);
            Controls.Add(editBt);
            Controls.Add(insertBt);
            Controls.Add(namajabatanLb);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dgvDataTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label namajabatanLb;
        private Button insertBt;
        private Button editBt;
        private Button deleteBt;
        private TextBox jabatanTb;
        private DataGridView dgvDataTable;
        private Label pengelolaanLb;
        private Label salaryLb;
        private TextBox salaryTb;
    }
}