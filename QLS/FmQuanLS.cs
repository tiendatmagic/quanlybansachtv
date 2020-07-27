using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLS.Class;

namespace QLS
{
    public partial class FmQuanLS : Form
    {
        public FmQuanLS()
        {
            InitializeComponent();
        }
        DataTable tblCL;
        private void FmQuanLS_Load(object sender, EventArgs e)
        {

            Functions.Connect();
            Loadbang();
            Load_Treeview();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("Bạn có muốn thoát chương trình?", "Thoát chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (D == DialogResult.Yes)
            {
                this.Close();//thoát Form
                Application.Exit();//Thoát ứng dụng
            }
        }
        private void Loadbang()
        {
            string sql;
            sql = "SELECT * FROM Sach";
            tblCL = Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dataGridView1.DataSource = tblCL; //Nguồn dữ liệu            
            dataGridView1.Columns[0].HeaderText = "Mã sách";
            dataGridView1.Columns[1].HeaderText = "Tên sách";
            dataGridView1.Columns[2].HeaderText = "Số lượng";
            dataGridView1.Columns[3].HeaderText = "Đơn giá";
            dataGridView1.Columns[4].HeaderText = "Thành Tiền";
            dataGridView1.Columns[5].HeaderText = "Nhà xuất bản";
            dataGridView1.Columns[0].Width = 120;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].Width = 120;
            dataGridView1.Columns[4].Width = 120;
            dataGridView1.Columns[5].Width = 120;
            dataGridView1.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp}
        }
        
            private void Load_Treeview()
            {
            string sql1;
            DataTable dt_tg;
            sql1 = "SELECT * FROM TacGia";
            dt_tg = Functions.GetDataToTable(sql1);
            tviewTacgia.Nodes.Clear();
           
            if (dt_tg.Rows.Count > 0)
            {
                for (int i = 0; i < dt_tg.Rows.Count; i++)
                {
                    TreeNode node = new TreeNode();
                    node.Text = dt_tg.Rows[i]["TenTacGia"].ToString();//lấy column tên tác giả từ table TACGIA


                    string sql2;
                    DataTable dt_sach;
                    sql2 = "SELECT * FROM Sach";
                    dt_sach = Functions.GetDataToTable(sql2);
                   
                    if (dt_sach.Rows.Count > 0)
                    {
                        for (int j = 0; j < dt_sach.Rows.Count; j++)
                        {
                            node.Nodes.Add(dt_sach.Rows[j]["Ten"].ToString());//lấy column tên sách từ table SACH }
                        }
                        tviewTacgia.Nodes.Add(node);
                    }
                }
            }
        }
            private void buttonThem_Click(object sender, EventArgs e)
            {
                buttonThem.Enabled = true;
                buttonThem.Enabled = false;
                buttonLuu.Enabled = true;
                textBoxMaSach.ReadOnly = false;
                textBoxTenSach.ReadOnly = false;
                textBoxSoLuong.ReadOnly = false;
                textBoxDonGia.ReadOnly = false;
                textBoxMaSach.Focus();
                textBoxNXB.Enabled = true;

                ResetValue();
            }
            private void ResetValue()
            {
                textBoxMaSach.Text = "";
                textBoxTenSach.Text = "";
                textBoxSoLuong.Text = "";
                textBoxDonGia.Text = "";
            }

            private void buttonLuu_Click(object sender, EventArgs e)
            {
                string sql;
                if (textBoxMaSach.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập Mã Sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxMaSach.Focus();
                    return;
                }
                if (textBoxTenSach.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxTenSach.Focus();
                    return;
                }
                if (textBoxSoLuong.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập Số Lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxSoLuong.Focus();
                    return;
                }
                if (textBoxDonGia.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập Đơn Giá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxDonGia.Focus();
                    return;
                }
                if (textBoxNXB.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập Nhà Xuất Bản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxNXB.Focus();
                    return;
                }

                sql = "Select MaSach From Sach where MaSach=N'" + textBoxMaSach.Text.Trim() + "'";
                if (Class.Functions.CheckKey(sql))
                {
                    MessageBox.Show("Bạn đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxMaSach.Focus();
                    return;
                }
                sql = "INSERT INTO Sach (MaSach,Ten,SoLuong,DonGia,MaNXB) VALUES(N'" +
                    textBoxMaSach.Text + "',N'" +
                    textBoxTenSach.Text + "',N'" +
                    textBoxSoLuong.Text + "',N'" +
                    textBoxDonGia.Text + "',N'" +
                    textBoxNXB.Text + "')";
                Functions.RunSQL(sql);
                Loadbang();
                ResetValue();
                buttonThem.Enabled = true;
                buttonLuu.Enabled = true;
            }
            private void dataGridView1_Click(object sender, EventArgs e)
            {
                if (buttonThem.Enabled == false)
                {
                    MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxMaSach.Focus();
                    return;
                }
                if (tblCL.Rows.Count == 0) //Nếu không có dữ liệu
                {
                    MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                textBoxMaSach.Text = dataGridView1.CurrentRow.Cells["MaSach"].Value.ToString();
                textBoxTenSach.Text = dataGridView1.CurrentRow.Cells["Ten"].Value.ToString();
                textBoxSoLuong.Text = dataGridView1.CurrentRow.Cells["SoLuong"].Value.ToString();
                textBoxDonGia.Text = dataGridView1.CurrentRow.Cells["DonGia"].Value.ToString();
                textBoxNXB.Text = dataGridView1.CurrentRow.Cells["MaNXB"].Value.ToString();
                buttonThem.Enabled = true;

            }
    }
}