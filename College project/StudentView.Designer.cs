namespace College_project
{
    partial class StudentView
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.messageListBox = new System.Windows.Forms.ListView();
            this.Message = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataGridViewStudentGrades = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentGrades)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usernameLabel.Location = new System.Drawing.Point(929, 9);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(70, 26);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(781, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Logged in as:";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(548, 617);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(117, 45);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(395, 617);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(117, 45);
            this.logoutButton.TabIndex = 7;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(174, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "News";
            // 
            // messageListBox
            // 
            this.messageListBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Message,
            this.Date});
            this.messageListBox.Enabled = false;
            this.messageListBox.GridLines = true;
            this.messageListBox.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.messageListBox.Location = new System.Drawing.Point(12, 154);
            this.messageListBox.Name = "messageListBox";
            this.messageListBox.Size = new System.Drawing.Size(400, 419);
            this.messageListBox.TabIndex = 9;
            this.messageListBox.TileSize = new System.Drawing.Size(250, 30);
            this.messageListBox.UseCompatibleStateImageBehavior = false;
            this.messageListBox.View = System.Windows.Forms.View.List;
            this.messageListBox.VirtualListSize = 4;
            // 
            // Message
            // 
            this.Message.Width = 300;
            // 
            // Date
            // 
            this.Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridViewStudentGrades
            // 
            this.dataGridViewStudentGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentGrades.Location = new System.Drawing.Point(473, 154);
            this.dataGridViewStudentGrades.Name = "dataGridViewStudentGrades";
            this.dataGridViewStudentGrades.ReadOnly = true;
            this.dataGridViewStudentGrades.Size = new System.Drawing.Size(544, 419);
            this.dataGridViewStudentGrades.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(699, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "My Grades";
            // 
            // StudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 674);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewStudentGrades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.messageListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.label1);
            this.Name = "StudentView";
            this.Text = "StudentView";
            this.Load += new System.EventHandler(this.StudentView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentGrades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView messageListBox;
        private System.Windows.Forms.ColumnHeader Message;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.DataGridView dataGridViewStudentGrades;
        private System.Windows.Forms.Label label3;
    }
}