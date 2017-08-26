namespace CRM.Desktop.Views.Forms
{
    partial class FAddClient
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
            this.name = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.zipCode = new System.Windows.Forms.Label();
            this.State = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.website = new System.Windows.Forms.Label();
            this.notes = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(13, 25);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Location = new System.Drawing.Point(12, 75);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(24, 13);
            this.city.TabIndex = 1;
            this.city.Text = "City";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(13, 48);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(45, 13);
            this.address.TabIndex = 2;
            this.address.Text = "Address";
            // 
            // zipCode
            // 
            this.zipCode.AutoSize = true;
            this.zipCode.Location = new System.Drawing.Point(13, 103);
            this.zipCode.Name = "zipCode";
            this.zipCode.Size = new System.Drawing.Size(50, 13);
            this.zipCode.TabIndex = 3;
            this.zipCode.Text = "Zip Code";
            // 
            // State
            // 
            this.State.AutoSize = true;
            this.State.Location = new System.Drawing.Point(13, 133);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(32, 13);
            this.State.TabIndex = 4;
            this.State.Text = "State";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone Number";
            // 
            // website
            // 
            this.website.AutoSize = true;
            this.website.Location = new System.Drawing.Point(13, 191);
            this.website.Name = "website";
            this.website.Size = new System.Drawing.Size(46, 13);
            this.website.TabIndex = 6;
            this.website.Text = "Website";
            // 
            // notes
            // 
            this.notes.AutoSize = true;
            this.notes.Location = new System.Drawing.Point(13, 213);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(35, 13);
            this.notes.TabIndex = 7;
            this.notes.Text = "Notes";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(12, 247);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(100, 23);
            this.Add.TabIndex = 9;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(119, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 20);
            this.txtName.TabIndex = 11;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(118, 51);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(181, 20);
            this.txtAddress.TabIndex = 12;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(118, 77);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(181, 20);
            this.txtCity.TabIndex = 13;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(118, 103);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(181, 20);
            this.txtZipCode.TabIndex = 14;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(118, 130);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(181, 20);
            this.txtState.TabIndex = 15;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(118, 156);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(181, 20);
            this.txtPhoneNumber.TabIndex = 16;
            // 
            // txtWebsite
            // 
            this.txtWebsite.Location = new System.Drawing.Point(118, 184);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(181, 20);
            this.txtWebsite.TabIndex = 17;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(118, 210);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(181, 20);
            this.txtNotes.TabIndex = 18;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(211, 247);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(99, 23);
            this.cancel.TabIndex = 19;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(119, 247);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(86, 23);
            this.Update.TabIndex = 20;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Visible = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // FAddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(311, 282);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtWebsite);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.website);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.State);
            this.Controls.Add(this.zipCode);
            this.Controls.Add(this.address);
            this.Controls.Add(this.city);
            this.Controls.Add(this.name);
            this.Name = "FAddClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.Load += new System.EventHandler(this.FAddClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label zipCode;
        private System.Windows.Forms.Label State;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label website;
        private System.Windows.Forms.Label notes;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtWebsite;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button Update;
    }
}