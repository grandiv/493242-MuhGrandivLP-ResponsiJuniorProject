using Npgsql;
using System.Data;

namespace ResponsiGrandiv
{
    public partial class Form2 : Form
    {
        string connString = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=ResponsiGrandiv";
        NpgsqlConnection conn;
        string sql;
        NpgsqlCommand cmd;

        public DataTable dt;
        private DataGridViewRow row;

        public DataGridViewRow Row { get => row; set => row = value; }

        public Form2()
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

                sql = @"SELECT id_jabatan, nama_jabatan, salary FROM jabatan";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvDataTable.DataSource = dt;
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
            string namajab = jabatanTb.Text;
            string salary = salaryTb.Text;

            if (namajab == "" || salary == "")
            {
                MessageBox.Show("Nama atau salary tidak boleh kosong");
                return;
            }
            try
            {
                conn = new NpgsqlConnection(connString);
                conn.Open();
                sql = "SELECT * FROM add_jabatan(:_nama, :_salary)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nama", namajab);
                cmd.Parameters.AddWithValue("_salary", salary);
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
                string namajab = jabatanTb.Text;
                string salary = salaryTb.Text;

                if (namajab == "" || salary == "")
                {
                    MessageBox.Show("Nama atau salary tidak boleh kosong");
                    return;
                }

                conn = new NpgsqlConnection(connString);
                conn.Open();
                sql = "SELECT * FROM edit_jabatan(:_id_jabatan, :_nama, :_salary)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id_jabatan", Row.Cells["id_jabatan"].Value.ToString());
                cmd.Parameters.AddWithValue("_nama", namajab);
                cmd.Parameters.AddWithValue("_salary", salary);

                int statusCode = (int)cmd.ExecuteScalar();

                if (statusCode == 200)
                {
                    MessageBox.Show("Data berhasil diubah", "Info");
                    LoadData();
                    return;
                }
                if (statusCode == 404)
                {
                    throw new Exception(namajab + " tidak ditemukan");
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
                MessageBox.Show("Pilih jabatan untuk dihapus");
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
                    sql = "SELECT * FROM delete_jabatan(:_id_jabatan)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id_jabatan", Row.Cells["id_jabatan"].Value.ToString());

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
                jabatanTb.Text = Row.Cells["nama_jab"].Value.ToString();
            }
        }
    }
}
