using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LibaryBorrowingSystem
{
    public partial class frmBorrows : Form
    {
        // Direct connection string using AttachDbFilename for seamless LocalDB access
        private string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\LibaryBorrowingSystem\LibaryBorrowingSystem\libary.mdf;Integrated Security=True";

        public frmBorrows()
        {
            InitializeComponent();
        }

        private void frmBorrows_Load(object sender, EventArgs e)
        {
            if (this.DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            LoadBooks();
            LoadMembers();

            // Set initial placeholder text and styling for search boxes
            SetupSearchPlaceholders();
        }

        // Configures placeholder text behavior for search boxes
        private void SetupSearchPlaceholders()
        {
            if (txtSearchBooks != null && string.IsNullOrEmpty(txtSearchBooks.Text))
            {
                txtSearchBooks.Text = "Search Books";
                txtSearchBooks.ForeColor = Color.Gray;
            }

            if (txtSearchMembers != null && string.IsNullOrEmpty(txtSearchMembers.Text))
            {
                txtSearchMembers.Text = "Search Members";
                txtSearchMembers.ForeColor = Color.Gray;
            }
        }

        // Load books into the grid
        private void LoadBooks()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT book_id, title, author, genre, available FROM books", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvBooks.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading books: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Load members into the grid
        private void LoadMembers()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT member_id, name, email FROM members", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvMembers.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading members: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Safe row click for Books grid
        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBooks.Rows[e.RowIndex];
                txtBookId.Text = row.Cells[0].Value?.ToString();
                txtBookTitle.Text = row.Cells[1].Value?.ToString();
            }
        }

        // Safe row click for Members grid
        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMembers.Rows[e.RowIndex];
                txtMemberId.Text = row.Cells[0].Value?.ToString();
                txtMemberName.Text = row.Cells[1].Value?.ToString();
            }
        }

        // Search Box: Books - Placeholder disappearance on click
        private void txtSearchBooks_Enter(object sender, EventArgs e)
        {
            if (txtSearchBooks.Text == "Search Books")
            {
                txtSearchBooks.Text = "";
                txtSearchBooks.ForeColor = Color.Black;
            }
        }

        // Search Box: Books - Restore placeholder if left empty
        private void txtSearchBooks_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchBooks.Text))
            {
                txtSearchBooks.Text = "Search Books";
                txtSearchBooks.ForeColor = Color.Gray;
            }
        }

        // Search Box: Books - Real-time filtering logic
        private void txtSearchBooks_TextChanged(object sender, EventArgs e)
        {
            if (dgvBooks.DataSource is DataTable dt)
            {
                if (txtSearchBooks.Text == "Search Books" || string.IsNullOrWhiteSpace(txtSearchBooks.Text))
                {
                    dt.DefaultView.RowFilter = "";
                }
                else
                {
                    string filter = txtSearchBooks.Text.Replace("'", "''");
                    dt.DefaultView.RowFilter = string.Format("title LIKE '%{0}%' OR author LIKE '%{0}%' OR genre LIKE '%{0}%'", filter);
                }
            }
        }

        // Search Box: Members - Placeholder disappearance on click
        private void txtSearchMembers_Enter(object sender, EventArgs e)
        {
            if (txtSearchMembers.Text == "Search Members")
            {
                txtSearchMembers.Text = "";
                txtSearchMembers.ForeColor = Color.Black;
            }
        }

        // Search Box: Members - Restore placeholder if left empty
        private void txtSearchMembers_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchMembers.Text))
            {
                txtSearchMembers.Text = "Search Members";
                txtSearchMembers.ForeColor = Color.Gray;
            }
        }

        // Search Box: Members - Real-time filtering logic
        private void txtSearchMembers_TextChanged(object sender, EventArgs e)
        {
            if (dgvMembers.DataSource is DataTable dt)
            {
                if (txtSearchMembers.Text == "Search Members" || string.IsNullOrWhiteSpace(txtSearchMembers.Text))
                {
                    dt.DefaultView.RowFilter = "";
                }
                else
                {
                    string filter = txtSearchMembers.Text.Replace("'", "''");
                    dt.DefaultView.RowFilter = string.Format("name LIKE '%{0}%' OR email LIKE '%{0}%'", filter);
                }
            }
        }

        // Open Returns Form
        private void btnManage_Click(object sender, EventArgs e)
        {
            frmReturns returnsForm = new frmReturns();
            returnsForm.Show();
        }

        // Log Borrow button transaction logic
        private void btnLogBorrow_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBookId.Text) || string.IsNullOrEmpty(txtMemberId.Text))
            {
                MessageBox.Show("Please select both a book and a member before logging a borrow.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int bookId = Convert.ToInt32(txtBookId.Text);
            int memberId = Convert.ToInt32(txtMemberId.Text);
            string borrowDate = dtpBorrowDate.Value.ToString("yyyy-MM-dd");
            string dueDate = dtpDueDate.Value.ToString("yyyy-MM-dd");

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    // Check availability
                    string checkQuery = "SELECT available FROM books WHERE book_id = @bookId";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@bookId", bookId);
                        object result = checkCmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            bool isAvailable = Convert.ToBoolean(result);
                            if (!isAvailable)
                            {
                                MessageBox.Show("This book is currently unavailable and cannot be borrowed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }

                    // Insert borrow record
                    string insertQuery = "INSERT INTO borrowrecords (book_id, member_id, borrow_date, due_date) VALUES (@bookId, @memberId, @borrowDate, @dueDate)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@bookId", bookId);
                        insertCmd.Parameters.AddWithValue("@memberId", memberId);
                        insertCmd.Parameters.AddWithValue("@borrowDate", borrowDate);
                        insertCmd.Parameters.AddWithValue("@dueDate", dueDate);
                        insertCmd.ExecuteNonQuery();
                    }

                    // Update book status to unavailable (0)
                    string updateQuery = "UPDATE books SET available = 0 WHERE book_id = @bookId";
                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@bookId", bookId);
                        updateCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Borrow logged successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBooks();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Left blank intentionally
        }
    }
}