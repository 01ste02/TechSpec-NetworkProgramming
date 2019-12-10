﻿namespace HandleBinaryContactList
{
    partial class Form1
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbxFirstname = new System.Windows.Forms.TextBox();
            this.gbxForm = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.lbxContacts = new System.Windows.Forms.ListBox();
            this.gbxContactList = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveContactListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openContactListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.gbxForm.SuspendLayout();
            this.gbxContactList.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(284, 31);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 18;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Visible = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(403, 31);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbxFirstname
            // 
            this.tbxFirstname.Location = new System.Drawing.Point(72, 13);
            this.tbxFirstname.Name = "tbxFirstname";
            this.tbxFirstname.Size = new System.Drawing.Size(167, 20);
            this.tbxFirstname.TabIndex = 7;
            // 
            // gbxForm
            // 
            this.gbxForm.Controls.Add(this.tbxFirstname);
            this.gbxForm.Controls.Add(this.btnRemove);
            this.gbxForm.Controls.Add(this.lblFirstname);
            this.gbxForm.Controls.Add(this.btnAdd);
            this.gbxForm.Controls.Add(this.lblSurname);
            this.gbxForm.Controls.Add(this.lblPhone);
            this.gbxForm.Controls.Add(this.tbxSurname);
            this.gbxForm.Controls.Add(this.lblEmail);
            this.gbxForm.Controls.Add(this.tbxEmail);
            this.gbxForm.Controls.Add(this.tbxPhone);
            this.gbxForm.Location = new System.Drawing.Point(12, 68);
            this.gbxForm.Name = "gbxForm";
            this.gbxForm.Size = new System.Drawing.Size(257, 180);
            this.gbxForm.TabIndex = 19;
            this.gbxForm.TabStop = false;
            this.gbxForm.Text = "Form";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(164, 146);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(6, 16);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(52, 13);
            this.lblFirstname.TabIndex = 5;
            this.lblFirstname.Text = "Firstname";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(164, 117);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(6, 42);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 6;
            this.lblSurname.Text = "Surname";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(6, 94);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 12;
            this.lblPhone.Text = "Phone";
            // 
            // tbxSurname
            // 
            this.tbxSurname.Location = new System.Drawing.Point(72, 39);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(167, 20);
            this.tbxSurname.TabIndex = 8;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 68);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "E-mail";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(72, 65);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(167, 20);
            this.tbxEmail.TabIndex = 9;
            // 
            // tbxPhone
            // 
            this.tbxPhone.Location = new System.Drawing.Point(72, 91);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(167, 20);
            this.tbxPhone.TabIndex = 10;
            // 
            // lbxContacts
            // 
            this.lbxContacts.FormattingEnabled = true;
            this.lbxContacts.Location = new System.Drawing.Point(6, 19);
            this.lbxContacts.Name = "lbxContacts";
            this.lbxContacts.Size = new System.Drawing.Size(188, 147);
            this.lbxContacts.TabIndex = 0;
            this.lbxContacts.SelectedIndexChanged += new System.EventHandler(this.lbxContacts_SelectedIndexChanged);
            // 
            // gbxContactList
            // 
            this.gbxContactList.Controls.Add(this.lbxContacts);
            this.gbxContactList.Location = new System.Drawing.Point(284, 68);
            this.gbxContactList.Name = "gbxContactList";
            this.gbxContactList.Size = new System.Drawing.Size(200, 180);
            this.gbxContactList.TabIndex = 20;
            this.gbxContactList.TabStop = false;
            this.gbxContactList.Text = "Contact list";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(498, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveContactListToolStripMenuItem,
            this.openContactListToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveContactListToolStripMenuItem
            // 
            this.saveContactListToolStripMenuItem.Name = "saveContactListToolStripMenuItem";
            this.saveContactListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveContactListToolStripMenuItem.Text = "Save Contact List";
            this.saveContactListToolStripMenuItem.Click += new System.EventHandler(this.saveContactFileToolStripMenuItem_Click);
            // 
            // openContactListToolStripMenuItem
            // 
            this.openContactListToolStripMenuItem.Name = "openContactListToolStripMenuItem";
            this.openContactListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openContactListToolStripMenuItem.Text = "Open Contact List";
            this.openContactListToolStripMenuItem.Click += new System.EventHandler(this.openContactFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dlgOpen
            // 
            this.dlgOpen.Filter = "Kontaktfiler|*.OskarContactFile";
            // 
            // dlgSave
            // 
            this.dlgSave.DefaultExt = "OskarContactFile";
            this.dlgSave.FileName = "contacts.OskarContactFile";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 264);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbxForm);
            this.Controls.Add(this.gbxContactList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxForm.ResumeLayout(false);
            this.gbxForm.PerformLayout();
            this.gbxContactList.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbxFirstname;
        private System.Windows.Forms.GroupBox gbxForm;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.ListBox lbxContacts;
        private System.Windows.Forms.GroupBox gbxContactList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveContactListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openContactListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.SaveFileDialog dlgSave;
    }
}

