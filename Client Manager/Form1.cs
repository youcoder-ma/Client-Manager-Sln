using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Client_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string conString = ConfigurationManager.ConnectionStrings["consql"].ConnectionString;
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = conString;


            String query = "SELECT * FROM Clients";
            SqlCommand cmd = new SqlCommand(query,con);

            if (con.State == ConnectionState.Open || con.State == ConnectionState.Broken)
                con.Close();
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.HasRows)
            {
                this.dgvclients.Rows.Clear();
                while (rd.Read())
                {
                    this.dgvclients.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4]);
                }
            }
            else
                MessageBox.Show("No client Found");
            con.Close();
        }

        private void addclient_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkInfo())
                {
                    MessageBox.Show("Please fill all required fields");
                    return;
                }
                    

                //Insert into Clients values ('', '', '', '');
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string query = "Insert into Clients values('" + this.fninput.Text.Trim().ToUpper() + "', '" + this.lninput.Text.Trim().ToUpper() + "', '" + this.addressinput.Text.Trim().ToLower() + "', '" + this.cityinput.Text.Trim().ToUpper() + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    if (con.State == ConnectionState.Open)
                        con.Close();

                    con.Open();
                    int a = cmd.ExecuteNonQuery();
                    MessageBox.Show(a + " line affected");
                    button1_Click(sender, e);
                    con.Close();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                    MessageBox.Show("Last Name duplicated");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            this.dgvclients.ReadOnly = true;
        }

        private bool checkInfo()
        {
            if(this.fninput.Text.Trim().ToUpper().Equals(string.Empty) ||
                this.lninput.Text.Trim().ToUpper().Equals(string.Empty) ||
                this.addressinput.Text.ToLower().Equals(string.Empty) ||
                this.cityinput.Text.Trim().ToUpper().Equals(string.Empty))
            {
                return false;
            }
            return true;
        }

        int id, position=-1;

        

        private void dgvclients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            position = this.dgvclients.CurrentRow.Index;
            id = int.Parse(this.dgvclients.Rows[position].Cells[0].Value.ToString());

            this.fninput.Text = this.dgvclients.Rows[position].Cells[1].Value.ToString();
            this.lninput.Text = this.dgvclients.Rows[position].Cells[2].Value.ToString();
            this.addressinput.Text = this.dgvclients.Rows[position].Cells[3].Value.ToString();
            this.cityinput.Text = this.dgvclients.Rows[position].Cells[4].Value.ToString();
        }

        private void bynDelete_Click(object sender, EventArgs e)
        {
            if(position == -1)
            {
                MessageBox.Show("Please select a line");
                return;
            }
            using(SqlConnection con = new SqlConnection(conString))
            {

                DialogResult dialog = MessageBox.Show("Are you sure you want to delete this client?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.No)
                    return;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Delete from Clients Where ID = @id";
                cmd.Parameters.AddWithValue("@id", id);
                if(con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                cmd.ExecuteNonQuery();
                this.dgvclients.Rows.RemoveAt(position);
                MessageBox.Show("Deleted Successfully");
                con.Close();
            }
        }
    }
}
