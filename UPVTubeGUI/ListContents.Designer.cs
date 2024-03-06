namespace UPVTubeGUI
{
    partial class ListContents
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
            this.searchBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.contentGrid = new System.Windows.Forms.DataGridView();
            this.advancedSearch = new System.Windows.Forms.Button();
            this.displayDetailsButton = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.logOutButton = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LinkColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.contentGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.searchBox.Location = new System.Drawing.Point(52, 23);
            this.searchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(361, 38);
            this.searchBox.TabIndex = 0;
            this.searchBox.TextChanged += new System.EventHandler(this.searchTextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(419, 23);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 38);
            this.button2.TabIndex = 6;
            this.button2.Text = "GO";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.startSearch);
            // 
            // contentGrid
            // 
            this.contentGrid.AllowUserToAddRows = false;
            this.contentGrid.AllowUserToDeleteRows = false;
            this.contentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TitleColumn,
            this.AuthorColumn,
            this.DateColumn,
            this.SubjectsColumn,
            this.LinkColumn});
            this.contentGrid.Location = new System.Drawing.Point(52, 82);
            this.contentGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contentGrid.MultiSelect = false;
            this.contentGrid.Name = "contentGrid";
            this.contentGrid.RowHeadersWidth = 51;
            this.contentGrid.RowTemplate.Height = 24;
            this.contentGrid.Size = new System.Drawing.Size(677, 281);
            this.contentGrid.TabIndex = 10;
            this.contentGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contentGrid_CellClick);
            this.contentGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // advancedSearch
            // 
            this.advancedSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.advancedSearch.Location = new System.Drawing.Point(52, 387);
            this.advancedSearch.Margin = new System.Windows.Forms.Padding(4);
            this.advancedSearch.Name = "advancedSearch";
            this.advancedSearch.Size = new System.Drawing.Size(147, 28);
            this.advancedSearch.TabIndex = 11;
            this.advancedSearch.Text = "Advanced Search";
            this.advancedSearch.UseVisualStyleBackColor = true;
            this.advancedSearch.Click += new System.EventHandler(this.advancedSearchClicked);
            // 
            // displayDetailsButton
            // 
            this.displayDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.displayDetailsButton.Location = new System.Drawing.Point(217, 387);
            this.displayDetailsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.displayDetailsButton.Name = "displayDetailsButton";
            this.displayDetailsButton.Size = new System.Drawing.Size(147, 28);
            this.displayDetailsButton.TabIndex = 13;
            this.displayDetailsButton.Text = "Display Details";
            this.displayDetailsButton.UseVisualStyleBackColor = true;
            this.displayDetailsButton.Click += new System.EventHandler(this.displayDetailsButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(654, 23);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(106, 29);
            this.logOutButton.TabIndex = 14;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click_1);
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(654, 387);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(106, 28);
            this.goBackButton.TabIndex = 15;
            this.goBackButton.Text = "Go Back";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 125;
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.MinimumWidth = 6;
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            this.Author.Width = 125;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 125;
            // 
            // TitleColumn
            // 
            this.TitleColumn.HeaderText = "Title";
            this.TitleColumn.MinimumWidth = 6;
            this.TitleColumn.Name = "TitleColumn";
            this.TitleColumn.ReadOnly = true;
            this.TitleColumn.Width = 125;
            // 
            // AuthorColumn
            // 
            this.AuthorColumn.HeaderText = "Author";
            this.AuthorColumn.MinimumWidth = 6;
            this.AuthorColumn.Name = "AuthorColumn";
            this.AuthorColumn.ReadOnly = true;
            this.AuthorColumn.Width = 125;
            // 
            // DateColumn
            // 
            this.DateColumn.HeaderText = "Date";
            this.DateColumn.MinimumWidth = 6;
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.ReadOnly = true;
            this.DateColumn.Width = 125;
            // 
            // SubjectsColumn
            // 
            this.SubjectsColumn.HeaderText = "Subjects";
            this.SubjectsColumn.MinimumWidth = 6;
            this.SubjectsColumn.Name = "SubjectsColumn";
            this.SubjectsColumn.ReadOnly = true;
            this.SubjectsColumn.Width = 125;
            // 
            // LinkColumn
            // 
            this.LinkColumn.HeaderText = "Link";
            this.LinkColumn.MinimumWidth = 6;
            this.LinkColumn.Name = "LinkColumn";
            this.LinkColumn.ReadOnly = true;
            this.LinkColumn.Width = 125;
            // 
            // ListContents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.displayDetailsButton);
            this.Controls.Add(this.advancedSearch);
            this.Controls.Add(this.contentGrid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.searchBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListContents";
            this.Text = "UPVTubeApp";
            this.Load += new System.EventHandler(this.ListContents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contentGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView contentGrid;
        private System.Windows.Forms.Button advancedSearch;
        private System.Windows.Forms.Button displayDetailsButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectsColumn;
        private System.Windows.Forms.DataGridViewLinkColumn LinkColumn;
    }
}