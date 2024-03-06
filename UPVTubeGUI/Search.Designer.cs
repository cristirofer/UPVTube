namespace UPVTubeGUI
{
    partial class Search
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
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.logOutButton = new System.Windows.Forms.Button();
            this.uploadNewContentButton = new System.Windows.Forms.Button();
            this.addReviewToContentButton = new System.Windows.Forms.Button();
            this.advancedSearchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Teal;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchButton.Location = new System.Drawing.Point(542, 212);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(102, 38);
            this.searchButton.TabIndex = 15;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.searchBox.Location = new System.Drawing.Point(212, 212);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(324, 38);
            this.searchBox.TabIndex = 14;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged_1);
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(669, 22);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(106, 29);
            this.logOutButton.TabIndex = 13;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // uploadNewContentButton
            // 
            this.uploadNewContentButton.BackColor = System.Drawing.Color.Teal;
            this.uploadNewContentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadNewContentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadNewContentButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uploadNewContentButton.Location = new System.Drawing.Point(212, 357);
            this.uploadNewContentButton.Name = "uploadNewContentButton";
            this.uploadNewContentButton.Size = new System.Drawing.Size(198, 38);
            this.uploadNewContentButton.TabIndex = 5;
            this.uploadNewContentButton.Text = "Upload new content";
            this.uploadNewContentButton.UseVisualStyleBackColor = false;
            this.uploadNewContentButton.Click += new System.EventHandler(this.uploadNewContentButton_Click);
            // 
            // addReviewToContentButton
            // 
            this.addReviewToContentButton.BackColor = System.Drawing.Color.Teal;
            this.addReviewToContentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addReviewToContentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addReviewToContentButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addReviewToContentButton.Location = new System.Drawing.Point(423, 357);
            this.addReviewToContentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addReviewToContentButton.Name = "addReviewToContentButton";
            this.addReviewToContentButton.Size = new System.Drawing.Size(221, 38);
            this.addReviewToContentButton.TabIndex = 16;
            this.addReviewToContentButton.Text = "Add review to content";
            this.addReviewToContentButton.UseVisualStyleBackColor = false;
            this.addReviewToContentButton.Click += new System.EventHandler(this.addReviewToContentButton_Click);
            // 
            // advancedSearchButton
            // 
            this.advancedSearchButton.BackColor = System.Drawing.Color.Teal;
            this.advancedSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.advancedSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advancedSearchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.advancedSearchButton.Location = new System.Drawing.Point(442, 256);
            this.advancedSearchButton.Name = "advancedSearchButton";
            this.advancedSearchButton.Size = new System.Drawing.Size(202, 38);
            this.advancedSearchButton.TabIndex = 18;
            this.advancedSearchButton.Text = "Advanced Search";
            this.advancedSearchButton.UseVisualStyleBackColor = false;
            this.advancedSearchButton.Click += new System.EventHandler(this.advancedSearchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(223, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 69);
            this.label1.TabIndex = 19;
            this.label1.Text = "UPVTube";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Search by title";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.advancedSearchButton);
            this.Controls.Add(this.addReviewToContentButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.uploadNewContentButton);
            this.Name = "Search";
            this.Text = "UPVTubeApp";
            this.Load += new System.EventHandler(this.Search_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button uploadNewContentButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button addReviewToContentButton;
        private System.Windows.Forms.Button advancedSearchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}