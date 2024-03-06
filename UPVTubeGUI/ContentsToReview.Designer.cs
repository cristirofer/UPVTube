namespace UPVTubeGUI
{
    partial class ContentsToReview
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
            this.displayDetailsButton = new System.Windows.Forms.Button();
            this.reviewButton = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.contentGrid = new System.Windows.Forms.DataGridView();
            this.TitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LinkColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.contentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // displayDetailsButton
            // 
            this.displayDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.displayDetailsButton.Location = new System.Drawing.Point(229, 391);
            this.displayDetailsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.displayDetailsButton.Name = "displayDetailsButton";
            this.displayDetailsButton.Size = new System.Drawing.Size(147, 28);
            this.displayDetailsButton.TabIndex = 14;
            this.displayDetailsButton.Text = "Display Details";
            this.displayDetailsButton.UseVisualStyleBackColor = true;
            this.displayDetailsButton.Click += new System.EventHandler(this.displayDetailsButton_Click);
            // 
            // reviewButton
            // 
            this.reviewButton.BackColor = System.Drawing.Color.Teal;
            this.reviewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reviewButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reviewButton.Location = new System.Drawing.Point(576, 386);
            this.reviewButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reviewButton.Name = "reviewButton";
            this.reviewButton.Size = new System.Drawing.Size(164, 38);
            this.reviewButton.TabIndex = 15;
            this.reviewButton.Text = "Review";
            this.reviewButton.UseVisualStyleBackColor = false;
            this.reviewButton.Click += new System.EventHandler(this.reviewButton_Clicked);
            // 
            // goBackButton
            // 
            this.goBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBackButton.Location = new System.Drawing.Point(400, 391);
            this.goBackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(147, 28);
            this.goBackButton.TabIndex = 16;
            this.goBackButton.Text = "Go Back";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // contentGrid
            // 
            this.contentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TitleColumn,
            this.AuthorColumn,
            this.DateColumn,
            this.SubjectsColumn,
            this.LinkColumn});
            this.contentGrid.Location = new System.Drawing.Point(63, 27);
            this.contentGrid.MultiSelect = false;
            this.contentGrid.Name = "contentGrid";
            this.contentGrid.RowHeadersWidth = 51;
            this.contentGrid.RowTemplate.Height = 24;
            this.contentGrid.Size = new System.Drawing.Size(677, 332);
            this.contentGrid.TabIndex = 17;
            this.contentGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contentGrid_CellClick);
            this.contentGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contentGrid_CellContentClick);
            this.contentGrid.Click += new System.EventHandler(this.contentGrid_Click);
            // 
            // TitleColumn
            // 
            this.TitleColumn.HeaderText = "Title";
            this.TitleColumn.MinimumWidth = 6;
            this.TitleColumn.Name = "TitleColumn";
            this.TitleColumn.Width = 125;
            // 
            // AuthorColumn
            // 
            this.AuthorColumn.HeaderText = "Author";
            this.AuthorColumn.MinimumWidth = 6;
            this.AuthorColumn.Name = "AuthorColumn";
            this.AuthorColumn.Width = 125;
            // 
            // DateColumn
            // 
            this.DateColumn.HeaderText = "Date";
            this.DateColumn.MinimumWidth = 6;
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.Width = 125;
            // 
            // SubjectsColumn
            // 
            this.SubjectsColumn.HeaderText = "Subjects";
            this.SubjectsColumn.MinimumWidth = 6;
            this.SubjectsColumn.Name = "SubjectsColumn";
            this.SubjectsColumn.Width = 125;
            // 
            // LinkColumn
            // 
            this.LinkColumn.HeaderText = "Link";
            this.LinkColumn.MinimumWidth = 6;
            this.LinkColumn.Name = "LinkColumn";
            this.LinkColumn.Width = 125;
            // 
            // ContentsToReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contentGrid);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.reviewButton);
            this.Controls.Add(this.displayDetailsButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ContentsToReview";
            this.Text = "UPVTubeApp";
            this.Load += new System.EventHandler(this.ContentsToReview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contentGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button displayDetailsButton;
        private System.Windows.Forms.Button reviewButton;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.DataGridView contentGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectsColumn;
        private System.Windows.Forms.DataGridViewLinkColumn LinkColumn;
    }
}