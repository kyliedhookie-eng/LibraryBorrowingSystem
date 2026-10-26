namespace LibaryBorrowingSystem
{
    partial class frmReturns
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
            this.lblReturnMembersTitle = new System.Windows.Forms.Label();
            this.lblReturnBookIdLabel = new System.Windows.Forms.Label();
            this.btnLogReturn = new System.Windows.Forms.Button();
            this.lblReturnMemberIdLabel = new System.Windows.Forms.Label();
            this.lblReturnMemberNameLabel = new System.Windows.Forms.Label();
            this.lblRecordIdLabel = new System.Windows.Forms.Label();
            this.lblReturnDateLabel = new System.Windows.Forms.Label();
            this.lblTotalFines = new System.Windows.Forms.Label();
            this.lblReturnBookTitleLabel = new System.Windows.Forms.Label();
            this.txtRecordId = new System.Windows.Forms.TextBox();
            this.txtReturnMemberName = new System.Windows.Forms.TextBox();
            this.txtReturnBookTitle = new System.Windows.Forms.TextBox();
            this.txtReturnMemberId = new System.Windows.Forms.TextBox();
            this.txtReturnSearchMembers = new System.Windows.Forms.TextBox();
            this.txtReturnBookId = new System.Windows.Forms.TextBox();
            this.dgvReturnMembers = new System.Windows.Forms.DataGridView();
            this.dgvBorrowRecords = new System.Windows.Forms.DataGridView();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.libaryDataSet = new LibaryBorrowingSystem.libaryDataSet();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membersTableAdapter = new LibaryBorrowingSystem.libaryDataSetTableAdapters.membersTableAdapter();
            this.tableAdapterManager = new LibaryBorrowingSystem.libaryDataSetTableAdapters.TableAdapterManager();
            this.memberidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowrecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.borrowrecordsTableAdapter = new LibaryBorrowingSystem.libaryDataSetTableAdapters.borrowrecordsTableAdapter();
            this.transactionidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returndateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libaryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowrecordsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReturnMembersTitle
            // 
            this.lblReturnMembersTitle.AutoSize = true;
            this.lblReturnMembersTitle.Location = new System.Drawing.Point(12, 32);
            this.lblReturnMembersTitle.Name = "lblReturnMembersTitle";
            this.lblReturnMembersTitle.Size = new System.Drawing.Size(87, 16);
            this.lblReturnMembersTitle.TabIndex = 0;
            this.lblReturnMembersTitle.Text = "Members List";
            // 
            // lblReturnBookIdLabel
            // 
            this.lblReturnBookIdLabel.AutoSize = true;
            this.lblReturnBookIdLabel.Location = new System.Drawing.Point(164, 627);
            this.lblReturnBookIdLabel.Name = "lblReturnBookIdLabel";
            this.lblReturnBookIdLabel.Size = new System.Drawing.Size(55, 16);
            this.lblReturnBookIdLabel.TabIndex = 1;
            this.lblReturnBookIdLabel.Text = "Book ID";
            this.lblReturnBookIdLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnLogReturn
            // 
            this.btnLogReturn.Location = new System.Drawing.Point(12, 762);
            this.btnLogReturn.Name = "btnLogReturn";
            this.btnLogReturn.Size = new System.Drawing.Size(776, 34);
            this.btnLogReturn.TabIndex = 6;
            this.btnLogReturn.Text = "Log Return";
            this.btnLogReturn.UseVisualStyleBackColor = true;
            // 
            // lblReturnMemberIdLabel
            // 
            this.lblReturnMemberIdLabel.AutoSize = true;
            this.lblReturnMemberIdLabel.Location = new System.Drawing.Point(12, 314);
            this.lblReturnMemberIdLabel.Name = "lblReturnMemberIdLabel";
            this.lblReturnMemberIdLabel.Size = new System.Drawing.Size(73, 16);
            this.lblReturnMemberIdLabel.TabIndex = 7;
            this.lblReturnMemberIdLabel.Text = "Member ID";
            // 
            // lblReturnMemberNameLabel
            // 
            this.lblReturnMemberNameLabel.AutoSize = true;
            this.lblReturnMemberNameLabel.Location = new System.Drawing.Point(164, 314);
            this.lblReturnMemberNameLabel.Name = "lblReturnMemberNameLabel";
            this.lblReturnMemberNameLabel.Size = new System.Drawing.Size(44, 16);
            this.lblReturnMemberNameLabel.TabIndex = 8;
            this.lblReturnMemberNameLabel.Text = "Name";
            // 
            // lblRecordIdLabel
            // 
            this.lblRecordIdLabel.AutoSize = true;
            this.lblRecordIdLabel.Location = new System.Drawing.Point(12, 627);
            this.lblRecordIdLabel.Name = "lblRecordIdLabel";
            this.lblRecordIdLabel.Size = new System.Drawing.Size(68, 16);
            this.lblRecordIdLabel.TabIndex = 9;
            this.lblRecordIdLabel.Text = "Record ID";
            // 
            // lblReturnDateLabel
            // 
            this.lblReturnDateLabel.AutoSize = true;
            this.lblReturnDateLabel.Location = new System.Drawing.Point(502, 627);
            this.lblReturnDateLabel.Name = "lblReturnDateLabel";
            this.lblReturnDateLabel.Size = new System.Drawing.Size(78, 16);
            this.lblReturnDateLabel.TabIndex = 10;
            this.lblReturnDateLabel.Text = "Return Date";
            // 
            // lblTotalFines
            // 
            this.lblTotalFines.AutoSize = true;
            this.lblTotalFines.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblTotalFines.Location = new System.Drawing.Point(9, 715);
            this.lblTotalFines.Name = "lblTotalFines";
            this.lblTotalFines.Size = new System.Drawing.Size(155, 34);
            this.lblTotalFines.TabIndex = 11;
            this.lblTotalFines.Text = "Total fines owed: \r\nR{total amount in fines}";
            // 
            // lblReturnBookTitleLabel
            // 
            this.lblReturnBookTitleLabel.AutoSize = true;
            this.lblReturnBookTitleLabel.Location = new System.Drawing.Point(322, 627);
            this.lblReturnBookTitleLabel.Name = "lblReturnBookTitleLabel";
            this.lblReturnBookTitleLabel.Size = new System.Drawing.Size(68, 16);
            this.lblReturnBookTitleLabel.TabIndex = 12;
            this.lblReturnBookTitleLabel.Text = "Book Title";
            // 
            // txtRecordId
            // 
            this.txtRecordId.Location = new System.Drawing.Point(12, 675);
            this.txtRecordId.Name = "txtRecordId";
            this.txtRecordId.ReadOnly = true;
            this.txtRecordId.Size = new System.Drawing.Size(100, 22);
            this.txtRecordId.TabIndex = 13;
            // 
            // txtReturnMemberName
            // 
            this.txtReturnMemberName.Location = new System.Drawing.Point(167, 345);
            this.txtReturnMemberName.Name = "txtReturnMemberName";
            this.txtReturnMemberName.ReadOnly = true;
            this.txtReturnMemberName.Size = new System.Drawing.Size(100, 22);
            this.txtReturnMemberName.TabIndex = 14;
            // 
            // txtReturnBookTitle
            // 
            this.txtReturnBookTitle.Location = new System.Drawing.Point(325, 675);
            this.txtReturnBookTitle.Name = "txtReturnBookTitle";
            this.txtReturnBookTitle.ReadOnly = true;
            this.txtReturnBookTitle.Size = new System.Drawing.Size(100, 22);
            this.txtReturnBookTitle.TabIndex = 15;
            this.txtReturnBookTitle.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtReturnMemberId
            // 
            this.txtReturnMemberId.Location = new System.Drawing.Point(12, 345);
            this.txtReturnMemberId.Name = "txtReturnMemberId";
            this.txtReturnMemberId.ReadOnly = true;
            this.txtReturnMemberId.Size = new System.Drawing.Size(100, 22);
            this.txtReturnMemberId.TabIndex = 16;
            // 
            // txtReturnSearchMembers
            // 
            this.txtReturnSearchMembers.Location = new System.Drawing.Point(106, 29);
            this.txtReturnSearchMembers.Name = "txtReturnSearchMembers";
            this.txtReturnSearchMembers.Size = new System.Drawing.Size(646, 22);
            this.txtReturnSearchMembers.TabIndex = 17;
            this.txtReturnSearchMembers.Text = "Search Members";
            // 
            // txtReturnBookId
            // 
            this.txtReturnBookId.Location = new System.Drawing.Point(167, 675);
            this.txtReturnBookId.Name = "txtReturnBookId";
            this.txtReturnBookId.ReadOnly = true;
            this.txtReturnBookId.Size = new System.Drawing.Size(100, 22);
            this.txtReturnBookId.TabIndex = 18;
            // 
            // dgvReturnMembers
            // 
            this.dgvReturnMembers.AutoGenerateColumns = false;
            this.dgvReturnMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReturnMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturnMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memberidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dgvReturnMembers.DataSource = this.membersBindingSource;
            this.dgvReturnMembers.Location = new System.Drawing.Point(15, 81);
            this.dgvReturnMembers.Name = "dgvReturnMembers";
            this.dgvReturnMembers.RowHeadersWidth = 51;
            this.dgvReturnMembers.RowTemplate.Height = 24;
            this.dgvReturnMembers.Size = new System.Drawing.Size(737, 203);
            this.dgvReturnMembers.TabIndex = 19;
            // 
            // dgvBorrowRecords
            // 
            this.dgvBorrowRecords.AutoGenerateColumns = false;
            this.dgvBorrowRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBorrowRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionidDataGridViewTextBoxColumn,
            this.bookidDataGridViewTextBoxColumn,
            this.memberidDataGridViewTextBoxColumn1,
            this.borrowdateDataGridViewTextBoxColumn,
            this.duedateDataGridViewTextBoxColumn,
            this.returndateDataGridViewTextBoxColumn});
            this.dgvBorrowRecords.DataSource = this.borrowrecordsBindingSource;
            this.dgvBorrowRecords.Location = new System.Drawing.Point(15, 395);
            this.dgvBorrowRecords.Name = "dgvBorrowRecords";
            this.dgvBorrowRecords.RowHeadersWidth = 51;
            this.dgvBorrowRecords.RowTemplate.Height = 24;
            this.dgvBorrowRecords.Size = new System.Drawing.Size(740, 201);
            this.dgvBorrowRecords.TabIndex = 20;
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Location = new System.Drawing.Point(505, 675);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(228, 22);
            this.dtpReturnDate.TabIndex = 21;
            // 
            // libaryDataSet
            // 
            this.libaryDataSet.DataSetName = "libaryDataSet";
            this.libaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // membersBindingSource
            // 
            this.membersBindingSource.DataMember = "members";
            this.membersBindingSource.DataSource = this.libaryDataSet;
            // 
            // membersTableAdapter
            // 
            this.membersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.booksTableAdapter = null;
            this.tableAdapterManager.borrowrecordsTableAdapter = this.borrowrecordsTableAdapter;
            this.tableAdapterManager.membersTableAdapter = this.membersTableAdapter;
            this.tableAdapterManager.UpdateOrder = LibaryBorrowingSystem.libaryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // borrowrecordsBindingSource
            // 
            this.borrowrecordsBindingSource.DataMember = "borrowrecords";
            this.borrowrecordsBindingSource.DataSource = this.libaryDataSet;
            // 
            // borrowrecordsTableAdapter
            // 
            this.borrowrecordsTableAdapter.ClearBeforeFill = true;
            // 
            // transactionidDataGridViewTextBoxColumn
            // 
            this.transactionidDataGridViewTextBoxColumn.DataPropertyName = "transaction_id";
            this.transactionidDataGridViewTextBoxColumn.HeaderText = "transaction_id";
            this.transactionidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transactionidDataGridViewTextBoxColumn.Name = "transactionidDataGridViewTextBoxColumn";
            this.transactionidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookidDataGridViewTextBoxColumn
            // 
            this.bookidDataGridViewTextBoxColumn.DataPropertyName = "book_id";
            this.bookidDataGridViewTextBoxColumn.HeaderText = "book_id";
            this.bookidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookidDataGridViewTextBoxColumn.Name = "bookidDataGridViewTextBoxColumn";
            // 
            // memberidDataGridViewTextBoxColumn1
            // 
            this.memberidDataGridViewTextBoxColumn1.DataPropertyName = "member_id";
            this.memberidDataGridViewTextBoxColumn1.HeaderText = "member_id";
            this.memberidDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.memberidDataGridViewTextBoxColumn1.Name = "memberidDataGridViewTextBoxColumn1";
            // 
            // borrowdateDataGridViewTextBoxColumn
            // 
            this.borrowdateDataGridViewTextBoxColumn.DataPropertyName = "borrow_date";
            this.borrowdateDataGridViewTextBoxColumn.HeaderText = "borrow_date";
            this.borrowdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.borrowdateDataGridViewTextBoxColumn.Name = "borrowdateDataGridViewTextBoxColumn";
            // 
            // duedateDataGridViewTextBoxColumn
            // 
            this.duedateDataGridViewTextBoxColumn.DataPropertyName = "due_date";
            this.duedateDataGridViewTextBoxColumn.HeaderText = "due_date";
            this.duedateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.duedateDataGridViewTextBoxColumn.Name = "duedateDataGridViewTextBoxColumn";
            // 
            // returndateDataGridViewTextBoxColumn
            // 
            this.returndateDataGridViewTextBoxColumn.DataPropertyName = "return_date";
            this.returndateDataGridViewTextBoxColumn.HeaderText = "return_date";
            this.returndateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.returndateDataGridViewTextBoxColumn.Name = "returndateDataGridViewTextBoxColumn";
            // 
            // frmReturns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 808);
            this.Controls.Add(this.dtpReturnDate);
            this.Controls.Add(this.dgvBorrowRecords);
            this.Controls.Add(this.dgvReturnMembers);
            this.Controls.Add(this.txtReturnBookId);
            this.Controls.Add(this.txtReturnSearchMembers);
            this.Controls.Add(this.txtReturnMemberId);
            this.Controls.Add(this.txtReturnBookTitle);
            this.Controls.Add(this.txtReturnMemberName);
            this.Controls.Add(this.txtRecordId);
            this.Controls.Add(this.lblReturnBookTitleLabel);
            this.Controls.Add(this.lblTotalFines);
            this.Controls.Add(this.lblReturnDateLabel);
            this.Controls.Add(this.lblRecordIdLabel);
            this.Controls.Add(this.lblReturnMemberNameLabel);
            this.Controls.Add(this.lblReturnMemberIdLabel);
            this.Controls.Add(this.btnLogReturn);
            this.Controls.Add(this.lblReturnBookIdLabel);
            this.Controls.Add(this.lblReturnMembersTitle);
            this.Name = "frmReturns";
            this.Text = "frmReturns";
            this.Load += new System.EventHandler(this.frmReturns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libaryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowrecordsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReturnMembersTitle;
        private System.Windows.Forms.Label lblReturnBookIdLabel;
        private System.Windows.Forms.Button btnLogReturn;
        private System.Windows.Forms.Label lblReturnMemberIdLabel;
        private System.Windows.Forms.Label lblReturnMemberNameLabel;
        private System.Windows.Forms.Label lblRecordIdLabel;
        private System.Windows.Forms.Label lblReturnDateLabel;
        private System.Windows.Forms.Label lblTotalFines;
        private System.Windows.Forms.Label lblReturnBookTitleLabel;
        private System.Windows.Forms.TextBox txtRecordId;
        private System.Windows.Forms.TextBox txtReturnMemberName;
        private System.Windows.Forms.TextBox txtReturnBookTitle;
        private System.Windows.Forms.TextBox txtReturnMemberId;
        private System.Windows.Forms.TextBox txtReturnSearchMembers;
        private System.Windows.Forms.TextBox txtReturnBookId;
        private System.Windows.Forms.DataGridView dgvReturnMembers;
        private System.Windows.Forms.DataGridView dgvBorrowRecords;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private libaryDataSet libaryDataSet;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private libaryDataSetTableAdapters.membersTableAdapter membersTableAdapter;
        private libaryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private libaryDataSetTableAdapters.borrowrecordsTableAdapter borrowrecordsTableAdapter;
        private System.Windows.Forms.BindingSource borrowrecordsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returndateDataGridViewTextBoxColumn;
    }
}