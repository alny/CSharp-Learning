namespace FormUI
{
    partial class Dashboard
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
            this.peopleFoundListBox = new System.Windows.Forms.ListBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.firstNameInsText = new System.Windows.Forms.TextBox();
            this.lastNameInsText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailInsText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneInsText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.insertRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // peopleFoundListBox
            // 
            this.peopleFoundListBox.FormattingEnabled = true;
            this.peopleFoundListBox.Location = new System.Drawing.Point(12, 64);
            this.peopleFoundListBox.Name = "peopleFoundListBox";
            this.peopleFoundListBox.Size = new System.Drawing.Size(224, 147);
            this.peopleFoundListBox.TabIndex = 0;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(112, 21);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(124, 20);
            this.lastNameText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(15, 236);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(57, 13);
            this.label33.TabIndex = 4;
            this.label33.Text = "First Name";
            // 
            // firstNameInsText
            // 
            this.firstNameInsText.Location = new System.Drawing.Point(112, 236);
            this.firstNameInsText.Name = "firstNameInsText";
            this.firstNameInsText.Size = new System.Drawing.Size(124, 20);
            this.firstNameInsText.TabIndex = 5;
            // 
            // lastNameInsText
            // 
            this.lastNameInsText.Location = new System.Drawing.Point(112, 274);
            this.lastNameInsText.Name = "lastNameInsText";
            this.lastNameInsText.Size = new System.Drawing.Size(124, 20);
            this.lastNameInsText.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // emailInsText
            // 
            this.emailInsText.Location = new System.Drawing.Point(112, 309);
            this.emailInsText.Name = "emailInsText";
            this.emailInsText.Size = new System.Drawing.Size(124, 20);
            this.emailInsText.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email Address";
            // 
            // phoneInsText
            // 
            this.phoneInsText.Location = new System.Drawing.Point(112, 347);
            this.phoneInsText.Name = "phoneInsText";
            this.phoneInsText.Size = new System.Drawing.Size(124, 20);
            this.phoneInsText.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Phone Number";
            // 
            // insertRecord
            // 
            this.insertRecord.Location = new System.Drawing.Point(15, 400);
            this.insertRecord.Name = "insertRecord";
            this.insertRecord.Size = new System.Drawing.Size(75, 23);
            this.insertRecord.TabIndex = 12;
            this.insertRecord.Text = "Insert";
            this.insertRecord.UseVisualStyleBackColor = true;
            this.insertRecord.Click += new System.EventHandler(this.insertRecord_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 448);
            this.Controls.Add(this.insertRecord);
            this.Controls.Add(this.phoneInsText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailInsText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastNameInsText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstNameInsText);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.peopleFoundListBox);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox peopleFoundListBox;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox firstNameInsText;
        private System.Windows.Forms.TextBox lastNameInsText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailInsText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phoneInsText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button insertRecord;
    }
}

