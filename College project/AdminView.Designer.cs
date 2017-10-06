namespace College_project
{
    partial class AdminView
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
            System.Windows.Forms.Label usernameLabel1;
            this.label1 = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.postMessageTextbox = new System.Windows.Forms.TextBox();
            this.postMessageButton = new System.Windows.Forms.Button();
            this.messageListBox = new System.Windows.Forms.ListView();
            this.Message = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.exitButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addGradeStudentTextbox = new System.Windows.Forms.TextBox();
            this.addGradeSubjectTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addGradeMarkTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addGradeDescriptionTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addGradeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gradesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectDBDataSet = new College_project.projectDBDataSet();
            this.gradesTableAdapter = new College_project.projectDBDataSetTableAdapters.GradesTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tableAdapterManager = new College_project.projectDBDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewStudentGrades = new System.Windows.Forms.DataGridView();
            this.selectStudentTextbox = new System.Windows.Forms.TextBox();
            this.selectStudentButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            usernameLabel1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentGrades)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameLabel1
            // 
            usernameLabel1.AutoSize = true;
            usernameLabel1.Location = new System.Drawing.Point(12, 12);
            usernameLabel1.Name = "usernameLabel1";
            usernameLabel1.Size = new System.Drawing.Size(61, 13);
            usernameLabel1.TabIndex = 13;
            usernameLabel1.Text = "Student ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(957, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logged in as: ";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usernameLabel.Location = new System.Drawing.Point(1093, 9);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(113, 26);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username";
            // 
            // postMessageTextbox
            // 
            this.postMessageTextbox.Location = new System.Drawing.Point(68, 549);
            this.postMessageTextbox.Multiline = true;
            this.postMessageTextbox.Name = "postMessageTextbox";
            this.postMessageTextbox.Size = new System.Drawing.Size(400, 60);
            this.postMessageTextbox.TabIndex = 2;
            // 
            // postMessageButton
            // 
            this.postMessageButton.Location = new System.Drawing.Point(333, 615);
            this.postMessageButton.Name = "postMessageButton";
            this.postMessageButton.Size = new System.Drawing.Size(135, 23);
            this.postMessageButton.TabIndex = 3;
            this.postMessageButton.Text = "Post New Message";
            this.postMessageButton.UseVisualStyleBackColor = true;
            this.postMessageButton.Click += new System.EventHandler(this.postMessageButton_Click);
            // 
            // messageListBox
            // 
            this.messageListBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Message,
            this.Date});
            this.messageListBox.Enabled = false;
            this.messageListBox.GridLines = true;
            this.messageListBox.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.messageListBox.Location = new System.Drawing.Point(68, 87);
            this.messageListBox.Name = "messageListBox";
            this.messageListBox.Size = new System.Drawing.Size(400, 419);
            this.messageListBox.TabIndex = 4;
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
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(669, 676);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(117, 45);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(516, 676);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(117, 45);
            this.logoutButton.TabIndex = 5;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(186, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Message Board";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(712, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Add grade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Student ID*:";
            // 
            // addGradeStudentTextbox
            // 
            this.addGradeStudentTextbox.Location = new System.Drawing.Point(78, 18);
            this.addGradeStudentTextbox.Name = "addGradeStudentTextbox";
            this.addGradeStudentTextbox.Size = new System.Drawing.Size(217, 20);
            this.addGradeStudentTextbox.TabIndex = 11;
            // 
            // addGradeSubjectTextbox
            // 
            this.addGradeSubjectTextbox.Location = new System.Drawing.Point(79, 47);
            this.addGradeSubjectTextbox.Name = "addGradeSubjectTextbox";
            this.addGradeSubjectTextbox.Size = new System.Drawing.Size(217, 20);
            this.addGradeSubjectTextbox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Subject*:";
            // 
            // addGradeMarkTextbox
            // 
            this.addGradeMarkTextbox.Location = new System.Drawing.Point(79, 78);
            this.addGradeMarkTextbox.Name = "addGradeMarkTextbox";
            this.addGradeMarkTextbox.Size = new System.Drawing.Size(39, 20);
            this.addGradeMarkTextbox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Grade*:";
            // 
            // addGradeDescriptionTextbox
            // 
            this.addGradeDescriptionTextbox.Location = new System.Drawing.Point(78, 110);
            this.addGradeDescriptionTextbox.Name = "addGradeDescriptionTextbox";
            this.addGradeDescriptionTextbox.Size = new System.Drawing.Size(217, 20);
            this.addGradeDescriptionTextbox.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Description:";
            // 
            // addGradeButton
            // 
            this.addGradeButton.Location = new System.Drawing.Point(120, 167);
            this.addGradeButton.Name = "addGradeButton";
            this.addGradeButton.Size = new System.Drawing.Size(75, 23);
            this.addGradeButton.TabIndex = 18;
            this.addGradeButton.Text = "Add Grade";
            this.addGradeButton.UseVisualStyleBackColor = true;
            this.addGradeButton.Click += new System.EventHandler(this.addGradeButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.addGradeButton);
            this.panel1.Controls.Add(this.addGradeStudentTextbox);
            this.panel1.Controls.Add(this.addGradeDescriptionTextbox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.addGradeSubjectTextbox);
            this.panel1.Controls.Add(this.addGradeMarkTextbox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(712, 374);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 204);
            this.panel1.TabIndex = 1;
            // 
            // gradesBindingSource
            // 
            this.gradesBindingSource.DataMember = "Grades";
            this.gradesBindingSource.DataSource = this.projectDBDataSet;
            // 
            // projectDBDataSet
            // 
            this.projectDBDataSet.DataSetName = "projectDBDataSet";
            this.projectDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gradesTableAdapter
            // 
            this.gradesTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(515, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(239, 26);
            this.label8.TabIndex = 10;
            this.label8.Text = "Display student grades:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(68, 530);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Type new message:";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GradesTableAdapter = this.gradesTableAdapter;
            this.tableAdapterManager.UpdateOrder = College_project.projectDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridViewStudentGrades
            // 
            this.dataGridViewStudentGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentGrades.Location = new System.Drawing.Point(13, 45);
            this.dataGridViewStudentGrades.Name = "dataGridViewStudentGrades";
            this.dataGridViewStudentGrades.ReadOnly = true;
            this.dataGridViewStudentGrades.Size = new System.Drawing.Size(661, 150);
            this.dataGridViewStudentGrades.TabIndex = 14;
            // 
            // selectStudentTextbox
            // 
            this.selectStudentTextbox.Location = new System.Drawing.Point(76, 9);
            this.selectStudentTextbox.Name = "selectStudentTextbox";
            this.selectStudentTextbox.Size = new System.Drawing.Size(133, 20);
            this.selectStudentTextbox.TabIndex = 15;
            // 
            // selectStudentButton
            // 
            this.selectStudentButton.Location = new System.Drawing.Point(227, 7);
            this.selectStudentButton.Name = "selectStudentButton";
            this.selectStudentButton.Size = new System.Drawing.Size(88, 23);
            this.selectStudentButton.TabIndex = 16;
            this.selectStudentButton.Text = "Select student";
            this.selectStudentButton.UseVisualStyleBackColor = true;
            this.selectStudentButton.Click += new System.EventHandler(this.selectStudentButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.selectStudentButton);
            this.panel2.Controls.Add(usernameLabel1);
            this.panel2.Controls.Add(this.selectStudentTextbox);
            this.panel2.Controls.Add(this.dataGridViewStudentGrades);
            this.panel2.Location = new System.Drawing.Point(515, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(691, 213);
            this.panel2.TabIndex = 17;
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 749);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.messageListBox);
            this.Controls.Add(this.postMessageButton);
            this.Controls.Add(this.postMessageTextbox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.label1);
            this.Name = "AdminView";
            this.Text = "AdminView";
            this.Load += new System.EventHandler(this.AdminView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentGrades)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox postMessageTextbox;
        private System.Windows.Forms.Button postMessageButton;
        private System.Windows.Forms.ListView messageListBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.ColumnHeader Message;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addGradeStudentTextbox;
        private System.Windows.Forms.TextBox addGradeSubjectTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addGradeMarkTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addGradeDescriptionTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addGradeButton;
        private System.Windows.Forms.Panel panel1;
        private projectDBDataSet projectDBDataSet;
        private System.Windows.Forms.BindingSource gradesBindingSource;
        private projectDBDataSetTableAdapters.GradesTableAdapter gradesTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private projectDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridViewStudentGrades;
        private System.Windows.Forms.TextBox selectStudentTextbox;
        private System.Windows.Forms.Button selectStudentButton;
        private System.Windows.Forms.Panel panel2;
    }
}