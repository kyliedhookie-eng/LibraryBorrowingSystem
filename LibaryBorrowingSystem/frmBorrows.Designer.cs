namespace LibaryBorrowingSystem
{
    partial class frmBorrows
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
            this.components = new System.ComponentModel.Container();
            this.lblBooksTitle = new System.Windows.Forms.Label();
            this.txtSearchBooks = new System.Windows.Forms.TextBox();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.bookidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libaryDataSet = new LibaryBorrowingSystem.libaryDataSet();
            this.lblMembersTitle = new System.Windows.Forms.Label();
            this.txtSearchMembers = new System.Windows.Forms.TextBox();
            this.btnManage = new System.Windows.Forms.Button();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.memberidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblDueDateLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMemberIdLabel = new System.Windows.Forms.Label();
            this.lblBookIdLabel = new System.Windows.Forms.Label();
            this.lblBookTitleLabel = new System.Windows.Forms.Label();
            this.lblBorrowDateLabel = new System.Windows.Forms.Label();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.dtpBorrowDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.btnLogBorrow = new System.Windows.Forms.Button();
            this.booksTableAdapter = new LibaryBorrowingSystem.libaryDataSetTableAdapters.booksTableAdapter();
            this.tableAdapterManager = new LibaryBorrowingSystem.libaryDataSetTableAdapters.TableAdapterManager();
            this.membersTableAdapter = new LibaryBorrowingSystem.libaryDataSetTableAdapters.membersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libaryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBooksTitle
            // 
            this.lblBooksTitle.AutoSize = true;
            this.lblBooksTitle.Location = new System.Drawing.Point(12, 31);
            this.lblBooksTitle.Name = "lblBooksTitle";
            this.lblBooksTitle.Size = new System.Drawing.Size(69, 16);
            this.lblBooksTitle.TabIndex = 0;
            this.lblBooksTitle.Text = "Books List";
            // 
            // txtSearchBooks
            // 
            this.txtSearchBooks.Location = new System.Drawing.Point(100, 31);
            this.txtSearchBooks.Name = "txtSearchBooks";
            this.txtSearchBooks.Size = new System.Drawing.Size(653, 22);
            this.txtSearchBooks.TabIndex = 1;
            this.txtSearchBooks.Text = "Search Books";
            this.txtSearchBooks.TextChanged += new System.EventHandler(this.txtSearchBooks_TextChanged);
            this.txtSearchBooks.Enter += new System.EventHandler(this.txtSearchBooks_Enter);
            this.txtSearchBooks.Leave += new System.EventHandler(this.txtSearchBooks_Leave);
            // 
            // dgvBooks
            // 
            this.dgvBooks.AutoGenerateColumns = false;
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookidDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.availableDataGridViewCheckBoxColumn});
            this.dgvBooks.DataSource = this.booksBindingSource;
            this.dgvBooks.Location = new System.Drawing.Point(27, 74);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.RowTemplate.Height = 24;
            this.dgvBooks.Size = new System.Drawing.Size(726, 215);
            this.dgvBooks.TabIndex = 2;
            this.dgvBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellClick);
            this.dgvBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellContentClick);
            // 
            // bookidDataGridViewTextBoxColumn
            // 
            this.bookidDataGridViewTextBoxColumn.DataPropertyName = "book_id";
            this.bookidDataGridViewTextBoxColumn.HeaderText = "book_id";
            this.bookidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookidDataGridViewTextBoxColumn.Name = "bookidDataGridViewTextBoxColumn";
            this.bookidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "author";
            this.authorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "genre";
            this.genreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            // 
            // availableDataGridViewCheckBoxColumn
            // 
            this.availableDataGridViewCheckBoxColumn.DataPropertyName = "available";
            this.availableDataGridViewCheckBoxColumn.HeaderText = "available";
            this.availableDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.availableDataGridViewCheckBoxColumn.Name = "availableDataGridViewCheckBoxColumn";
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "books";
            this.booksBindingSource.DataSource = this.libaryDataSet;
            // 
            // libaryDataSet
            // 
            this.libaryDataSet.DataSetName = "libaryDataSet";
            this.libaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblMembersTitle
            // 
            this.lblMembersTitle.AutoSize = true;
            this.lblMembersTitle.Location = new System.Drawing.Point(12, 324);
            this.lblMembersTitle.Name = "lblMembersTitle";
            this.lblMembersTitle.Size = new System.Drawing.Size(87, 16);
            this.lblMembersTitle.TabIndex = 3;
            this.lblMembersTitle.Text = "Members List";
            // 
            // txtSearchMembers
            // 
            this.txtSearchMembers.Location = new System.Drawing.Point(76, 318);
            this.txtSearchMembers.Name = "txtSearchMembers";
            this.txtSearchMembers.Size = new System.Drawing.Size(506, 22);
            this.txtSearchMembers.TabIndex = 4;
            this.txtSearchMembers.Text = "Search Members";
            this.txtSearchMembers.TextChanged += new System.EventHandler(this.txtSearchMembers_TextChanged);
            this.txtSearchMembers.Enter += new System.EventHandler(this.txtSearchMembers_Enter);
            this.txtSearchMembers.Leave += new System.EventHandler(this.txtSearchMembers_Leave);
            // 
            // btnManage
            // 
            this.btnManage.Location = new System.Drawing.Point(603, 317);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(150, 30);
            this.btnManage.TabIndex = 5;
            this.btnManage.Text = "Manage";
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // dgvMembers
            // 
            this.dgvMembers.AutoGenerateColumns = false;
            this.dgvMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memberidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dgvMembers.DataSource = this.membersBindingSource;
            this.dgvMembers.Location = new System.Drawing.Point(27, 364);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.RowHeadersWidth = 51;
            this.dgvMembers.RowTemplate.Height = 24;
            this.dgvMembers.Size = new System.Drawing.Size(726, 215);
            this.dgvMembers.TabIndex = 6;
            this.dgvMembers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMembers_CellClick);
            // 
            // memberidDataGridViewTextBoxColumn
            // 
            this.memberidDataGridViewTextBoxColumn.DataPropertyName = "member_id";
            this.memberidDataGridViewTextBoxColumn.HeaderText = "member_id";
            this.memberidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberidDataGridViewTextBoxColumn.Name = "memberidDataGridViewTextBoxColumn";
            this.memberidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // membersBindingSource
            // 
            this.membersBindingSource.DataMember = "members";
            this.membersBindingSource.DataSource = this.libaryDataSet;
            // 
            // lblDueDateLabel
            // 
            this.lblDueDateLabel.AutoSize = true;
            this.lblDueDateLabel.Location = new System.Drawing.Point(463, 668);
            this.lblDueDateLabel.Name = "lblDueDateLabel";
            this.lblDueDateLabel.Size = new System.Drawing.Size(64, 16);
            this.lblDueDateLabel.TabIndex = 7;
            this.lblDueDateLabel.Text = "Due Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 668);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name";
            // 
            // lblMemberIdLabel
            // 
            this.lblMemberIdLabel.AutoSize = true;
            this.lblMemberIdLabel.Location = new System.Drawing.Point(24, 668);
            this.lblMemberIdLabel.Name = "lblMemberIdLabel";
            this.lblMemberIdLabel.Size = new System.Drawing.Size(73, 16);
            this.lblMemberIdLabel.TabIndex = 9;
            this.lblMemberIdLabel.Text = "Member ID";
            // 
            // lblBookIdLabel
            // 
            this.lblBookIdLabel.AutoSize = true;
            this.lblBookIdLabel.Location = new System.Drawing.Point(24, 600);
            this.lblBookIdLabel.Name = "lblBookIdLabel";
            this.lblBookIdLabel.Size = new System.Drawing.Size(55, 16);
            this.lblBookIdLabel.TabIndex = 10;
            this.lblBookIdLabel.Text = "Book ID";
            // 
            // lblBookTitleLabel
            // 
            this.lblBookTitleLabel.AutoSize = true;
            this.lblBookTitleLabel.Location = new System.Drawing.Point(182, 600);
            this.lblBookTitleLabel.Name = "lblBookTitleLabel";
            this.lblBookTitleLabel.Size = new System.Drawing.Size(33, 16);
            this.lblBookTitleLabel.TabIndex = 11;
            this.lblBookTitleLabel.Text = "Title";
            // 
            // lblBorrowDateLabel
            // 
            this.lblBorrowDateLabel.AutoSize = true;
            this.lblBorrowDateLabel.Location = new System.Drawing.Point(463, 600);
            this.lblBorrowDateLabel.Name = "lblBorrowDateLabel";
            this.lblBorrowDateLabel.Size = new System.Drawing.Size(81, 16);
            this.lblBorrowDateLabel.TabIndex = 12;
            this.lblBorrowDateLabel.Text = "Borrow Date";
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(27, 635);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.ReadOnly = true;
            this.txtBookId.Size = new System.Drawing.Size(117, 22);
            this.txtBookId.TabIndex = 13;
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(185, 635);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.ReadOnly = true;
            this.txtBookTitle.Size = new System.Drawing.Size(151, 22);
            this.txtBookTitle.TabIndex = 14;
            // 
            // txtMemberId
            // 
            this.txtMemberId.Location = new System.Drawing.Point(27, 707);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.ReadOnly = true;
            this.txtMemberId.Size = new System.Drawing.Size(120, 22);
            this.txtMemberId.TabIndex = 15;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(185, 709);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.ReadOnly = true;
            this.txtMemberName.Size = new System.Drawing.Size(151, 22);
            this.txtMemberName.TabIndex = 16;
            // 
            // dtpBorrowDate
            // 
            this.dtpBorrowDate.Location = new System.Drawing.Point(466, 635);
            this.dtpBorrowDate.Name = "dtpBorrowDate";
            this.dtpBorrowDate.Size = new System.Drawing.Size(287, 22);
            this.dtpBorrowDate.TabIndex = 17;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Location = new System.Drawing.Point(466, 709);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(287, 22);
            this.dtpDueDate.TabIndex = 18;
            // 
            // btnLogBorrow
            // 
            this.btnLogBorrow.Location = new System.Drawing.Point(12, 753);
            this.btnLogBorrow.Name = "btnLogBorrow";
            this.btnLogBorrow.Size = new System.Drawing.Size(749, 43);
            this.btnLogBorrow.TabIndex = 19;
            this.btnLogBorrow.Text = "Log Borrow";
            this.btnLogBorrow.UseVisualStyleBackColor = true;
            this.btnLogBorrow.Click += new System.EventHandler(this.btnLogBorrow_Click);
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.booksTableAdapter = this.booksTableAdapter;
            this.tableAdapterManager.borrowrecordsTableAdapter = null;
            this.tableAdapterManager.membersTableAdapter = this.membersTableAdapter;
            this.tableAdapterManager.UpdateOrder = LibaryBorrowingSystem.libaryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // membersTableAdapter
            // 
            this.membersTableAdapter.ClearBeforeFill = true;
            // 
            // frmBorrows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 808);
            this.Controls.Add(this.btnLogBorrow);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.dtpBorrowDate);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.txtMemberId);
            this.Controls.Add(this.txtBookTitle);
            this.Controls.Add(this.txtBookId);
            this.Controls.Add(this.lblBorrowDateLabel);
            this.Controls.Add(this.lblBookTitleLabel);
            this.Controls.Add(this.lblBookIdLabel);
            this.Controls.Add(this.lblMemberIdLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDueDateLabel);
            this.Controls.Add(this.dgvMembers);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.txtSearchMembers);
            this.Controls.Add(this.lblMembersTitle);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.txtSearchBooks);
            this.Controls.Add(this.lblBooksTitle);
            this.Name = "frmBorrows";
            this.Text = "Libary Borrowing System";
            this.Load += new System.EventHandler(this.frmBorrows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libaryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBooksTitle;
        private System.Windows.Forms.TextBox txtSearchBooks;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Label lblMembersTitle;
        private System.Windows.Forms.TextBox txtSearchMembers;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.Label lblDueDateLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMemberIdLabel;
        private System.Windows.Forms.Label lblBookIdLabel;
        private System.Windows.Forms.Label lblBookTitleLabel;
        private System.Windows.Forms.Label lblBorrowDateLabel;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.DateTimePicker dtpBorrowDate;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Button btnLogBorrow;
        private libaryDataSet libaryDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private libaryDataSetTableAdapters.booksTableAdapter booksTableAdapter;
        private libaryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn availableDataGridViewCheckBoxColumn;
        private libaryDataSetTableAdapters.membersTableAdapter membersTableAdapter;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}

