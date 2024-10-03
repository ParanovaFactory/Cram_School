using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cram_School
{
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=predator;Initial Catalog=CramSchool;Integrated Security=True;TrustServerCertificate=True"); 

        void list()
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Execute list", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        void lectureList()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from TblLecture", connection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            cmbLecture.ValueMember = "lectureId";
            cmbLecture.DisplayMember = "lectureName";
            cmbLecture.DataSource = dt;
        }

        void studentList()
        {
            cmbStudent.Items.Clear();
            connection.Open();
            SqlCommand cmd = new SqlCommand("select stdName + ' ' + stdSurname from TblStudent",connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                cmbStudent.Items.Add(reader.GetString(0));
            }
            connection.Close();
        }

        void clear()
        {
            txtName.Clear();
            txtStudent.Clear();
            txtPicture.Clear();
            mskClass.Clear();
            mskPhone.Clear();
            txtMail.Clear();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            lectureList();
            studentList();
            list();
        }

        private void cmbLecture_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTeacher.Items.Clear();
            connection.Open();
            SqlCommand cmd = new SqlCommand("select thcName + ' ' + thcSurname from TblTeacher where thcLecture = @p1", connection);
            cmd.Parameters.AddWithValue("@p1", cmbLecture.SelectedValue);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbTeacher.Items.Add(dr.GetString(0));
            }
            connection.Close();
        }

        byte tchId;

        private void btnSave_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into TblSchedule (lecture,teacher,courseDate,courseHour,student) values (@p1,@p2,@p3,@p4,@p5)", connection);
            cmd.Parameters.AddWithValue("@p1", cmbLecture.SelectedValue);
            cmd.Parameters.AddWithValue("@p2", tchId);
            cmd.Parameters.AddWithValue("@p3", mskDate.Text);
            cmd.Parameters.AddWithValue("@p4", mskHour.Text);
            cmd.Parameters.AddWithValue("@p5", 0);
            cmd.ExecuteNonQuery();
            connection.Close();
            list();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("update TblSchedule set student = @p2, courseStatus = @p3 where courseId = @p1", connection);
            cmd.Parameters.AddWithValue("@p1", lblId.Text);
            cmd.Parameters.AddWithValue("@p2", 0);
            cmd.Parameters.AddWithValue("@p3", 0);
            cmd.ExecuteNonQuery();
            connection.Close();
            list();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtLecture.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTeacher.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtStudent.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            mskDate2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            mskHour2.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void cmbTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("select thcId from TblTeacher where thcName + ' ' + thcSurname = @p1", connection);
            sqlCommand.Parameters.AddWithValue("@p1", cmbTeacher.Text);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                tchId = reader.GetByte(0);
            }
            connection.Close();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("update TblSchedule set student = @p2, courseStatus = @p3 where courseId = @p1", connection);
            cmd.Parameters.AddWithValue("@p1", lblId.Text);
            cmd.Parameters.AddWithValue("@p2", cmbStudent.SelectedIndex);
            cmd.Parameters.AddWithValue("@p3", 1);
            cmd.ExecuteNonQuery();
            connection.Close();
            lectureList();
            studentList();
            list();
        }

        private void btnStdSave_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into TblStudent (stdName,stdSurname,stdPicture,stdClass,stdPhone,stdMail) values (@p1,@p2,@p3,@p4,@p5,@p6)",connection);
            cmd.Parameters.AddWithValue("@p1", txtName.Text);
            cmd.Parameters.AddWithValue("@p2", txtSurname.Text);
            cmd.Parameters.AddWithValue("@p3", txtPicture.Text);
            cmd.Parameters.AddWithValue("@p4", mskClass.Text);
            cmd.Parameters.AddWithValue("@p5", mskPhone.Text);
            cmd.Parameters.AddWithValue("@p6", txtMail.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            studentList();
            clear();
        }
    }
}
