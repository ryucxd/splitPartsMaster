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

namespace splitPartsMaster
{
    public partial class frmMain : Form
    {
        List<string> foundDupes = new List<string>();  //use this for filtering the where statement on door_allocation
        List<string> highlightDupes = new List<string>();
        public int skipConfirmBox { get; set; }
        public frmMain()
        {
            InitializeComponent();
            skipConfirmBox = 0;
            fillGrids();
        }

        private void fillGrids()
        {
            //first up is split parts

            using (SqlConnection conn = new SqlConnection(CONNECT.ConnectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM dbo.bending_split_parts_allocation WHERE  isComplete = 0 and cast(doorID as nvarchar(max)) LIKE '%" + txtDoorID.Text + "%' order by doorID, partName";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvSplitParts.DataSource = dt;
                }

                sql = "SELECT * FROM dbo.door_allocation WHERE operation_date > '20210101' AND department = 'Bending' AND cast(door_id as nvarchar(max)) LIKE '%" + txtDoorID.Text + "%'";
                if (foundDupes.Count > 0)
                    sql = sql + " and (";
                for (int i = 0; i < foundDupes.Count; i++)
                {
                    sql = sql + " door_id = " + foundDupes[i] + "  OR";
                }
                if (foundDupes.Count > 0)
                {
                    sql = sql.Substring(0,sql.Length - 3);
                    sql = sql + ")";
                }
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvDoorAllocation.DataSource = dt; 

                }
                if (foundDupes.Count > 0)
                {
                    //paint the grid
                    List<string> alreadyHighlighted = new List<string>(); //this is to stop double highlighting
                    foreach (DataGridViewRow row in dgvSplitParts.Rows)
                    {
                        string temp = row.Cells[1].Value.ToString() + " " + row.Cells[2].Value.ToString();
                        if (highlightDupes.Contains(temp) == true)
                        {
                            if (alreadyHighlighted.Contains(temp) == false)
                            {
                                row.DefaultCellStyle.BackColor = Color.CornflowerBlue;
                                alreadyHighlighted.Add(temp);
                            }
                        }
                    }
                }

                conn.Close();

            }
            foreach (DataGridViewColumn col in dgvSplitParts.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dgvSplitParts.Columns[dgvSplitParts.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //other dgv doesnt need this because theres 100s of columns
        }

        private void checkDupes()
        {
            //check splitparts for dupes
            foundDupes.Clear(); //wipe the list ready for new ones
            highlightDupes.Clear();
            List<string> check = new List<string>();

            foreach (DataGridViewRow row in dgvSplitParts.Rows)
            {
                string temp = row.Cells[1].Value.ToString() + " " + row.Cells[2].Value.ToString();
                if (check.Contains(temp) == true)
                {
                    row.DefaultCellStyle.BackColor = Color.CornflowerBlue;
                    dgvSplitParts.Rows[1].DefaultCellStyle.BackColor = Color.CornflowerBlue;
                    foundDupes.Add(row.Cells[1].Value.ToString()); //this will filter door_allocation later
                    highlightDupes.Add(temp); //for colouring the first dgv
                }
                else
                    check.Add(temp);
            }
            if (foundDupes.Count > 0)
            {
                fillGrids();
                MessageBox.Show("Found " + foundDupes.Count() + " duplicates! Please double check these before deleting.", "Duplicates found!", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("No duplicates found!", "Bending looks good!", MessageBoxButtons.OK);


        }

        private void txtDoorID_TextChanged(object sender, EventArgs e)
        {
            fillGrids();
        }

        private void dgvSplitParts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSplitParts.Rows[e.RowIndex].DefaultCellStyle.BackColor == Color.CornflowerBlue)
                dgvSplitParts.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Empty;
            else
                dgvSplitParts.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.CornflowerBlue;
        }

        private void dgvDoorAllocation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDoorAllocation.Rows[e.RowIndex].DefaultCellStyle.BackColor == Color.CornflowerBlue)
                dgvDoorAllocation.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Empty;
            else
                dgvDoorAllocation.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.CornflowerBlue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (skipConfirmBox == 0)
            {
                skipConfirmBox = -1;
                MessageBox.Show("**PLEASE CHECK THE OTHER TAB BEFORE HITTING DELETE**", "!!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = "";
            using (SqlConnection conn = new SqlConnection(CONNECT.ConnectionString))
            {
                conn.Open();
                foreach (DataGridViewRow row in dgvSplitParts.Rows)
                {
                    //split parts allocation 
                    if (row.DefaultCellStyle.BackColor == Color.CornflowerBlue)
                    {
                        sql = "DELETE FROM dbo.bending_split_parts_allocation WHERE id = " + row.Cells[0].Value.ToString();
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                //door allocation
                foreach (DataGridViewRow row in dgvDoorAllocation.Rows)
                {
                    //split parts allocation 
                    if (row.DefaultCellStyle.BackColor == Color.CornflowerBlue)
                    {
                        sql = "DELETE FROM dbo.door_allocation WHERE id = " + row.Cells[0].Value.ToString();
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                conn.Close();
            }
            foundDupes.Clear();
            highlightDupes.Clear();
            MessageBox.Show("Rows removed!", "");
            fillGrids();
        }

        private void btnDupe_Click(object sender, EventArgs e)
        {
            checkDupes();
        }
    }
}
