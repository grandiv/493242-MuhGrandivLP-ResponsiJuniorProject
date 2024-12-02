using Npgsql;
using System.Data;

namespace ResponsiGrandiv
{
    public partial class Form1 : Form
    {
        string connString = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=ResponsiGrandiv";
        NpgsqlConnection conn;
        string sql;
        NpgsqlCommand cmd;

        public DataTable dt;
        private DataGridViewRow row;

        public DataGridViewRow Row { get => row; set => row = value; }

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            conn = new NpgsqlConnection(connString);
            try
            {
                conn.Open();

                sql = @"SELECT k.id_kar, k.nama_kar, k.id_dept, d.nama_dept 
                       FROM karyawan k 
                       JOIN departemen d ON k.id_dept = d.id_dept";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvDataTable.DataSource = dt;

                sql = "SELECT id_dept, nama_dept FROM departemen";
                cmd = new NpgsqlCommand(sql, conn);
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    deptList.Items.Clear();
                    while (reader.Read())
                    {
                        deptList.Items.Add(reader["id_dept"].ToString() + " - " + reader["nama_dept"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void InsertData()
        {
            string nama = namaKar_TB.Text;
            string id_dept = "";

            if (HR_RB.Checked)
            {
                id_dept = "HR";
            }
            else if (ENG_RB.Checked)
            {
                id_dept = "ENG";
            }
            else if (DEV_RB.Checked)
            {
                id_dept = "DEV";
            }
            else if (PM_RB.Checked)
            {
                id_dept = "PM";
            }
            else if (FIN_RB.Checked)
            {
                id_dept = "FIN";
            }

            if (id_dept == "")
            {
                MessageBox.Show("Pilih departemen terlebih dahulu");
                return;
            }

            if (nama == "")
            {
                MessageBox.Show("Nama tidak boleh kosong");
                return;
            }
            try
            {
                conn = new NpgsqlConnection(connString);
                conn.Open();
                sql = "SELECT * FROM add_karyawan(:_nama, :_id_dept)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nama", nama);
                cmd.Parameters.AddWithValue("_id_dept", id_dept);
                int statusCode = (int)cmd.ExecuteScalar();
                if (statusCode == 201)
                {
                    MessageBox.Show("Data berhasil ditambahkan", "Info");
                    LoadData();
                    return;
                }
                else if (statusCode == 409)
                {
                    throw new Exception("Data sudah ada");
                }
                else
                {
                    MessageBox.Show("Data gagal ditambahkan");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
            finally { conn.Close(); }
        }

        private void EditData()
        {
            if (Row == null)
            {
                MessageBox.Show("Pilih data untuk diedit");
                return;
            }
            try
            {
                string nama = namaKar_TB.Text;
                string id_dept = "";

                if (HR_RB.Checked) id_dept = "HR";
                else if (ENG_RB.Checked) id_dept = "ENG";
                else if (DEV_RB.Checked) id_dept = "DEV";
                else if (PM_RB.Checked) id_dept = "PM";
                else if (FIN_RB.Checked) id_dept = "FIN";

                if (id_dept == "")
                {
                    MessageBox.Show("Pilih departemen terlebih dahulu");
                    return;
                }

                if (nama == "")
                {
                    MessageBox.Show("Nama tidak boleh kosong");
                    return;
                }

                conn = new NpgsqlConnection(connString);
                conn.Open();
                sql = "SELECT * FROM edit_karyawan(:_id_kar, :_nama, :_id_dept)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id_kar", Row.Cells["id_kar"].Value.ToString());
                cmd.Parameters.AddWithValue("_nama", nama);
                cmd.Parameters.AddWithValue("_id_dept", id_dept);

                int statusCode = (int)cmd.ExecuteScalar();

                if (statusCode == 200)
                {
                    MessageBox.Show("Data berhasil diubah", "Info");
                    LoadData();
                    return;
                }
                if (statusCode == 404)
                {
                    throw new Exception(nama + " tidak ditemukan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        private void DeleteData()
        {
            if (Row == null)
            {
                MessageBox.Show("Pilih karyawan untuk dihapus");
                return;
            }
            try
            {
                MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.No)
                {
                    return;
                }
                try
                {
                    conn = new NpgsqlConnection(connString);
                    conn.Open();
                    sql = "SELECT * FROM delete_karyawan(:_id_karyawan)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id_karyawan", Row.Cells["id_kar"].Value.ToString());

                    int statusCode = (int)cmd.ExecuteScalar();

                    if (statusCode == 200)
                    {
                        MessageBox.Show("Data berhasil dihapus");
                        LoadData();
                        return;
                    }
                    if (statusCode == 404)
                    {
                        throw new Exception("Data tidak ditemukan");
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void insertBt_Click(object sender, EventArgs e)
        {
            InsertData();
        }

        private void editBt_Click(object sender, EventArgs e)
        {
            EditData();
        }

        private void deleteBt_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void dgvDataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Row = dgvDataTable.Rows[e.RowIndex];
                karTerpilih_dynamicLb.Text = Row.Cells["id_kar"].Value.ToString();
                namaKar_TB.Text = Row.Cells["nama_kar"].Value.ToString();
                string id_dept = Row.Cells["id_dept"].Value.ToString();

                switch (id_dept)
                {
                    case "HR": HR_RB.Checked = true; break;
                    case "ENG": ENG_RB.Checked = true; break;
                    case "DEV": DEV_RB.Checked = true; break;
                    case "PM": PM_RB.Checked = true; break;
                    case "FIN": FIN_RB.Checked = true; break;
                    default: throw new Exception("An error occurred");
                }
            }
        }
    }
}
