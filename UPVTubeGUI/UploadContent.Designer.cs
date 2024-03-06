namespace UPVTubeGUI
{
    partial class UploadContent
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
            this.label1 = new System.Windows.Forms.Label();
            this.titleTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.descTextbox = new System.Windows.Forms.TextBox();
            this.URITextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.publicButton = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.subjectsListView = new System.Windows.Forms.ListView();
            this.deleteSubject = new System.Windows.Forms.Button();
            this.subjectsComboBox = new System.Windows.Forms.ComboBox();
            this.addSubject = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(204, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 58);
            this.label1.TabIndex = 9;
            this.label1.Text = "Upload content...";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // titleTextbox
            // 
            this.titleTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleTextbox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.titleTextbox.Location = new System.Drawing.Point(188, 92);
            this.titleTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.titleTextbox.Name = "titleTextbox";
            this.titleTextbox.Size = new System.Drawing.Size(511, 22);
            this.titleTextbox.TabIndex = 10;
            this.titleTextbox.TextChanged += new System.EventHandler(this.titleTextbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Title";
            // 
            // descTextbox
            // 
            this.descTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descTextbox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.descTextbox.Location = new System.Drawing.Point(188, 128);
            this.descTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descTextbox.Multiline = true;
            this.descTextbox.Name = "descTextbox";
            this.descTextbox.Size = new System.Drawing.Size(511, 59);
            this.descTextbox.TabIndex = 12;
            this.descTextbox.TextChanged += new System.EventHandler(this.descTextbox_TextChanged);
            // 
            // URITextbox
            // 
            this.URITextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.URITextbox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.URITextbox.Location = new System.Drawing.Point(188, 274);
            this.URITextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.URITextbox.Name = "URITextbox";
            this.URITextbox.Size = new System.Drawing.Size(251, 22);
            this.URITextbox.TabIndex = 13;
            this.URITextbox.TextChanged += new System.EventHandler(this.URITextbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "URI";
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.Teal;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.confirmButton.Location = new System.Drawing.Point(631, 375);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(81, 36);
            this.confirmButton.TabIndex = 16;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancelButton.Location = new System.Drawing.Point(525, 375);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(83, 36);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "Public";
            // 
            // publicButton
            // 
            this.publicButton.AutoSize = true;
            this.publicButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.publicButton.Location = new System.Drawing.Point(188, 321);
            this.publicButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.publicButton.Name = "publicButton";
            this.publicButton.Size = new System.Drawing.Size(17, 16);
            this.publicButton.TabIndex = 19;
            this.publicButton.TabStop = true;
            this.publicButton.UseVisualStyleBackColor = true;
            this.publicButton.CheckedChanged += new System.EventHandler(this.publicButton_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 29);
            this.label6.TabIndex = 21;
            this.label6.Text = "Subject";
            // 
            // subjectsListView
            // 
            this.subjectsListView.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.subjectsListView.GridLines = true;
            this.subjectsListView.HideSelection = false;
            this.subjectsListView.Location = new System.Drawing.Point(475, 228);
            this.subjectsListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subjectsListView.MultiSelect = false;
            this.subjectsListView.Name = "subjectsListView";
            this.subjectsListView.Size = new System.Drawing.Size(224, 112);
            this.subjectsListView.TabIndex = 23;
            this.subjectsListView.UseCompatibleStateImageBehavior = false;
            this.subjectsListView.SelectedIndexChanged += new System.EventHandler(this.subjectsListView_SelectedIndexChanged);
            // 
            // deleteSubject
            // 
            this.deleteSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSubject.Location = new System.Drawing.Point(121, 375);
            this.deleteSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteSubject.Name = "deleteSubject";
            this.deleteSubject.Size = new System.Drawing.Size(131, 36);
            this.deleteSubject.TabIndex = 25;
            this.deleteSubject.Text = "Delete Subject";
            this.deleteSubject.UseVisualStyleBackColor = true;
            this.deleteSubject.Click += new System.EventHandler(this.deleteSubject_Click);
            // 
            // subjectsComboBox
            // 
            this.subjectsComboBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.subjectsComboBox.FormattingEnabled = true;
            this.subjectsComboBox.Location = new System.Drawing.Point(188, 228);
            this.subjectsComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.subjectsComboBox.Name = "subjectsComboBox";
            this.subjectsComboBox.Size = new System.Drawing.Size(183, 24);
            this.subjectsComboBox.TabIndex = 27;
            this.subjectsComboBox.SelectedIndexChanged += new System.EventHandler(this.newSelectedSubject);
            this.subjectsComboBox.TextChanged += new System.EventHandler(this.checkNewSubject);
            // 
            // addSubject
            // 
            this.addSubject.BackColor = System.Drawing.Color.Teal;
            this.addSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSubject.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addSubject.Location = new System.Drawing.Point(379, 224);
            this.addSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addSubject.Name = "addSubject";
            this.addSubject.Size = new System.Drawing.Size(61, 31);
            this.addSubject.TabIndex = 28;
            this.addSubject.Text = "Add";
            this.addSubject.UseVisualStyleBackColor = false;
            this.addSubject.Click += new System.EventHandler(this.addSubjectToContentSubjects);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(480, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 29);
            this.label7.TabIndex = 29;
            this.label7.Text = "Selected Subjects";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.checkSubjects);
            // 
            // UploadContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addSubject);
            this.Controls.Add(this.subjectsComboBox);
            this.Controls.Add(this.deleteSubject);
            this.Controls.Add(this.subjectsListView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.publicButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.URITextbox);
            this.Controls.Add(this.descTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titleTextbox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UploadContent";
            this.Text = "UPVTubeApp";
            this.Load += new System.EventHandler(this.UploadContent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titleTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descTextbox;
        private System.Windows.Forms.TextBox URITextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton publicButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView subjectsListView;
        private System.Windows.Forms.Button deleteSubject;
        private System.Windows.Forms.ComboBox subjectsComboBox;
        private System.Windows.Forms.Button addSubject;
        private System.Windows.Forms.Label label7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
    }
}