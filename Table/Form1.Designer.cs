namespace Table
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvBooks = new DataGridView();
            label1 = new Label();
            btnLoad = new Button();
            btnSave = new Button();
            BookID = new DataGridViewTextBoxColumn();
            BookTitle = new DataGridViewTextBoxColumn();
            BookAuthor = new DataGridViewTextBoxColumn();
            BookYear = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Columns.AddRange(new DataGridViewColumn[] { BookID, BookTitle, BookAuthor, BookYear });
            dgvBooks.Location = new Point(23, 72);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowTemplate.Height = 25;
            dgvBooks.Size = new Size(657, 365);
            dgvBooks.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(263, 18);
            label1.Name = "label1";
            label1.Size = new Size(167, 28);
            label1.TabIndex = 1;
            label1.Text = "Popular Books";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(23, 454);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(104, 454);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // BookID
            // 
            BookID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            BookID.Frozen = true;
            BookID.HeaderText = "BookID";
            BookID.Name = "BookID";
            BookID.Width = 50;
            // 
            // BookTitle
            // 
            BookTitle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BookTitle.HeaderText = "Title";
            BookTitle.Name = "BookTitle";
            // 
            // BookAuthor
            // 
            BookAuthor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BookAuthor.HeaderText = "Author";
            BookAuthor.Name = "BookAuthor";
            // 
            // BookYear
            // 
            BookYear.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BookYear.HeaderText = "Publication";
            BookYear.Name = "BookYear";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 489);
            Controls.Add(btnSave);
            Controls.Add(btnLoad);
            Controls.Add(label1);
            Controls.Add(dgvBooks);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBooks;
        private Label label1;
        private Button btnLoad;
        private Button btnSave;
        private DataGridViewTextBoxColumn BookID;
        private DataGridViewTextBoxColumn BookTitle;
        private DataGridViewTextBoxColumn BookAuthor;
        private DataGridViewTextBoxColumn BookYear;
    }
}