
using System.Windows.Forms;

namespace CRM.Desktop.Views.Forms
{
    partial class FClients
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.dataGridViewContacts = new System.Windows.Forms.DataGridView();
            this.dataGridViewProjects = new System.Windows.Forms.DataGridView();
            this.panelContacts = new System.Windows.Forms.Panel();
            this.deleteContact = new System.Windows.Forms.Button();
            this.updateContact = new System.Windows.Forms.Button();
            this.addContact = new System.Windows.Forms.Button();
            this.additionsForContact = new System.Windows.Forms.Button();
            this.panelProjects = new System.Windows.Forms.Panel();
            this.deleteProject = new System.Windows.Forms.Button();
            this.updateProject = new System.Windows.Forms.Button();
            this.addProject = new System.Windows.Forms.Button();
            this.additionForProjects = new System.Windows.Forms.Button();
            this.bSearchClient = new System.Windows.Forms.Button();
            this.txtSearchContact = new System.Windows.Forms.TextBox();
            this.txtSearchProject = new System.Windows.Forms.TextBox();
            this.bSearchContact = new System.Windows.Forms.Button();
            this.bSearchProject = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bRefresh = new System.Windows.Forms.Button();
            this.bRefreshContacts = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).BeginInit();
            this.panelContacts.SuspendLayout();
            this.panelProjects.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.AllowUserToAddRows = false;
            this.dataGridViewClients.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewClients.MultiSelect = false;
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.ReadOnly = true;
            this.dataGridViewClients.RowHeadersVisible = false;
            this.dataGridViewClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClients.Size = new System.Drawing.Size(454, 218);
            this.dataGridViewClients.TabIndex = 0;
            this.dataGridViewClients.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridClients_CellMouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add client";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(192, 4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(89, 23);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete client";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Visible = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(98, 4);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(89, 23);
            this.Update.TabIndex = 3;
            this.Update.Text = "Update client";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // dataGridViewContacts
            // 
            this.dataGridViewContacts.AllowUserToAddRows = false;
            this.dataGridViewContacts.AllowUserToDeleteRows = false;
            this.dataGridViewContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContacts.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewContacts.MultiSelect = false;
            this.dataGridViewContacts.Name = "dataGridViewContacts";
            this.dataGridViewContacts.RowHeadersVisible = false;
            this.dataGridViewContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewContacts.Size = new System.Drawing.Size(419, 171);
            this.dataGridViewContacts.TabIndex = 5;
            // 
            // dataGridViewProjects
            // 
            this.dataGridViewProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjects.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewProjects.MultiSelect = false;
            this.dataGridViewProjects.Name = "dataGridViewProjects";
            this.dataGridViewProjects.RowHeadersVisible = false;
            this.dataGridViewProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProjects.Size = new System.Drawing.Size(415, 168);
            this.dataGridViewProjects.TabIndex = 7;
            // 
            // panelContacts
            // 
            this.panelContacts.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelContacts.Controls.Add(this.deleteContact);
            this.panelContacts.Controls.Add(this.updateContact);
            this.panelContacts.Controls.Add(this.addContact);
            this.panelContacts.Location = new System.Drawing.Point(16, 241);
            this.panelContacts.Name = "panelContacts";
            this.panelContacts.Size = new System.Drawing.Size(303, 31);
            this.panelContacts.TabIndex = 10;
            this.panelContacts.Visible = false;
            // 
            // deleteContact
            // 
            this.deleteContact.Location = new System.Drawing.Point(197, 3);
            this.deleteContact.Name = "deleteContact";
            this.deleteContact.Size = new System.Drawing.Size(100, 23);
            this.deleteContact.TabIndex = 2;
            this.deleteContact.Text = "Delete contact";
            this.deleteContact.UseVisualStyleBackColor = true;
            this.deleteContact.Click += new System.EventHandler(this.deleteContact_Click);
            // 
            // updateContact
            // 
            this.updateContact.Location = new System.Drawing.Point(85, 4);
            this.updateContact.Name = "updateContact";
            this.updateContact.Size = new System.Drawing.Size(106, 23);
            this.updateContact.TabIndex = 1;
            this.updateContact.Text = "Update contact";
            this.updateContact.UseVisualStyleBackColor = true;
            this.updateContact.Click += new System.EventHandler(this.updateContact_Click);
            // 
            // addContact
            // 
            this.addContact.Location = new System.Drawing.Point(3, 3);
            this.addContact.Name = "addContact";
            this.addContact.Size = new System.Drawing.Size(75, 23);
            this.addContact.TabIndex = 0;
            this.addContact.Text = "Add contact";
            this.addContact.UseVisualStyleBackColor = true;
            this.addContact.Click += new System.EventHandler(this.button2_Click);
            // 
            // additionsForContact
            // 
            this.additionsForContact.Location = new System.Drawing.Point(16, 212);
            this.additionsForContact.Name = "additionsForContact";
            this.additionsForContact.Size = new System.Drawing.Size(118, 23);
            this.additionsForContact.TabIndex = 11;
            this.additionsForContact.Text = "Additions for contacts";
            this.additionsForContact.UseVisualStyleBackColor = true;
            this.additionsForContact.Click += new System.EventHandler(this.additionsForContact_Click);
            // 
            // panelProjects
            // 
            this.panelProjects.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelProjects.Controls.Add(this.deleteProject);
            this.panelProjects.Controls.Add(this.updateProject);
            this.panelProjects.Controls.Add(this.addProject);
            this.panelProjects.Location = new System.Drawing.Point(18, 238);
            this.panelProjects.Name = "panelProjects";
            this.panelProjects.Size = new System.Drawing.Size(303, 31);
            this.panelProjects.TabIndex = 11;
            this.panelProjects.Visible = false;
            // 
            // deleteProject
            // 
            this.deleteProject.Location = new System.Drawing.Point(197, 4);
            this.deleteProject.Name = "deleteProject";
            this.deleteProject.Size = new System.Drawing.Size(100, 23);
            this.deleteProject.TabIndex = 2;
            this.deleteProject.Text = "Delete project";
            this.deleteProject.UseVisualStyleBackColor = true;
            this.deleteProject.Click += new System.EventHandler(this.deleteProject_Click);
            // 
            // updateProject
            // 
            this.updateProject.Location = new System.Drawing.Point(85, 4);
            this.updateProject.Name = "updateProject";
            this.updateProject.Size = new System.Drawing.Size(106, 23);
            this.updateProject.TabIndex = 1;
            this.updateProject.Text = "Update project";
            this.updateProject.UseVisualStyleBackColor = true;
            this.updateProject.Click += new System.EventHandler(this.updateProject_Click);
            // 
            // addProject
            // 
            this.addProject.Location = new System.Drawing.Point(3, 3);
            this.addProject.Name = "addProject";
            this.addProject.Size = new System.Drawing.Size(75, 23);
            this.addProject.TabIndex = 0;
            this.addProject.Text = "Add project";
            this.addProject.UseVisualStyleBackColor = true;
            this.addProject.Click += new System.EventHandler(this.addProject_Click);
            // 
            // additionForProjects
            // 
            this.additionForProjects.Location = new System.Drawing.Point(18, 209);
            this.additionForProjects.Name = "additionForProjects";
            this.additionForProjects.Size = new System.Drawing.Size(114, 23);
            this.additionForProjects.TabIndex = 12;
            this.additionForProjects.Text = "Additions for projects";
            this.additionForProjects.UseVisualStyleBackColor = true;
            this.additionForProjects.Click += new System.EventHandler(this.additionForProjects_Click);
            // 
            // bSearchClient
            // 
            this.bSearchClient.Location = new System.Drawing.Point(243, 236);
            this.bSearchClient.Name = "bSearchClient";
            this.bSearchClient.Size = new System.Drawing.Size(111, 23);
            this.bSearchClient.TabIndex = 13;
            this.bSearchClient.Text = "Search client";
            this.bSearchClient.UseVisualStyleBackColor = true;
            this.bSearchClient.Click += new System.EventHandler(this.txtSearchClient_Click);
            // 
            // txtSearchContact
            // 
            this.txtSearchContact.Location = new System.Drawing.Point(16, 186);
            this.txtSearchContact.Name = "txtSearchContact";
            this.txtSearchContact.Size = new System.Drawing.Size(207, 20);
            this.txtSearchContact.TabIndex = 15;
            // 
            // txtSearchProject
            // 
            this.txtSearchProject.Location = new System.Drawing.Point(18, 183);
            this.txtSearchProject.Name = "txtSearchProject";
            this.txtSearchProject.Size = new System.Drawing.Size(191, 20);
            this.txtSearchProject.TabIndex = 16;
            // 
            // bSearchContact
            // 
            this.bSearchContact.Location = new System.Drawing.Point(229, 183);
            this.bSearchContact.Name = "bSearchContact";
            this.bSearchContact.Size = new System.Drawing.Size(100, 23);
            this.bSearchContact.TabIndex = 17;
            this.bSearchContact.Text = "Search contact";
            this.bSearchContact.UseVisualStyleBackColor = true;
            this.bSearchContact.Click += new System.EventHandler(this.bSearchContact_Click);
            // 
            // bSearchProject
            // 
            this.bSearchProject.Location = new System.Drawing.Point(215, 180);
            this.bSearchProject.Name = "bSearchProject";
            this.bSearchProject.Size = new System.Drawing.Size(100, 23);
            this.bSearchProject.TabIndex = 18;
            this.bSearchProject.Text = "Seach project";
            this.bSearchProject.UseVisualStyleBackColor = true;
            this.bSearchProject.Click += new System.EventHandler(this.bSearchProject_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 236);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 20);
            this.textBox1.TabIndex = 19;
            // 
            // bRefresh
            // 
            this.bRefresh.Location = new System.Drawing.Point(360, 236);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(106, 23);
            this.bRefresh.TabIndex = 20;
            this.bRefresh.Text = "Refresh";
            this.bRefresh.UseVisualStyleBackColor = true;
            this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // bRefreshContacts
            // 
            this.bRefreshContacts.Location = new System.Drawing.Point(335, 183);
            this.bRefreshContacts.Name = "bRefreshContacts";
            this.bRefreshContacts.Size = new System.Drawing.Size(91, 23);
            this.bRefreshContacts.TabIndex = 21;
            this.bRefreshContacts.Text = "Refresh";
            this.bRefreshContacts.UseVisualStyleBackColor = true;
            this.bRefreshContacts.Click += new System.EventHandler(this.bRefreshContacts_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(482, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(439, 301);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewContacts);
            this.tabPage1.Controls.Add(this.bRefreshContacts);
            this.tabPage1.Controls.Add(this.additionsForContact);
            this.tabPage1.Controls.Add(this.panelContacts);
            this.tabPage1.Controls.Add(this.bSearchContact);
            this.tabPage1.Controls.Add(this.txtSearchContact);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(431, 275);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Contacts";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.dataGridViewProjects);
            this.tabPage2.Controls.Add(this.additionForProjects);
            this.tabPage2.Controls.Add(this.bSearchProject);
            this.tabPage2.Controls.Add(this.panelProjects);
            this.tabPage2.Controls.Add(this.txtSearchProject);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(431, 275);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Projects";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(321, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Update);
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Location = new System.Drawing.Point(12, 266);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 30);
            this.panel1.TabIndex = 23;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 309);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(933, 22);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // LabelStatus
            // 
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // FClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(933, 331);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bRefresh);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bSearchClient);
            this.Controls.Add(this.dataGridViewClients);
            this.Name = "FClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.FClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).EndInit();
            this.panelContacts.ResumeLayout(false);
            this.panelProjects.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClients;
        private Button button1;
        private Button Delete;
        private Button Update;
        private DataGridView dataGridViewContacts;
        private DataGridView dataGridViewProjects;
        private Panel panelContacts;
        private Button addContact;
        private Button deleteContact;
        private Button updateContact;
        private Button additionsForContact;
        private Panel panelProjects;
        private Button deleteProject;
        private Button updateProject;
        private Button addProject;
        private Button additionForProjects;
        private Button bSearchClient;
        private TextBox txtSearchContact;
        private TextBox txtSearchProject;
        private Button bSearchContact;
        private Button bSearchProject;
        private TextBox textBox1;
        private Button bRefresh;
        private Button bRefreshContacts;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button2;
        private Panel panel1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel LabelStatus;
    }
}

