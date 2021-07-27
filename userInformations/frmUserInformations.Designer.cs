
namespace userInformations
{
    partial class frmUserInformations
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.btnUserSave = new System.Windows.Forms.Button();
            this.btnPhoneOperations = new System.Windows.Forms.Button();
            this.btnMailInformations = new System.Windows.Forms.Button();
            this.dvPhone = new System.Windows.Forms.DataGridView();
            this.dvMail = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvMail)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(204, 27);
            this.txtName.TabIndex = 0;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(130, 66);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(204, 27);
            this.txtSurname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gender";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(130, 120);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(63, 24);
            this.rbMale.TabIndex = 5;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(253, 119);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(78, 24);
            this.rbFemale.TabIndex = 6;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // btnUserSave
            // 
            this.btnUserSave.Location = new System.Drawing.Point(208, 187);
            this.btnUserSave.Name = "btnUserSave";
            this.btnUserSave.Size = new System.Drawing.Size(123, 60);
            this.btnUserSave.TabIndex = 7;
            this.btnUserSave.Text = "Save User";
            this.btnUserSave.UseVisualStyleBackColor = true;
            this.btnUserSave.Click += new System.EventHandler(this.btnUserSave_Click);
            // 
            // btnPhoneOperations
            // 
            this.btnPhoneOperations.Location = new System.Drawing.Point(892, 17);
            this.btnPhoneOperations.Name = "btnPhoneOperations";
            this.btnPhoneOperations.Size = new System.Drawing.Size(198, 43);
            this.btnPhoneOperations.TabIndex = 8;
            this.btnPhoneOperations.Text = "Phone Operations";
            this.btnPhoneOperations.UseVisualStyleBackColor = true;
            this.btnPhoneOperations.Click += new System.EventHandler(this.btnPhoneOperations_Click);
            // 
            // btnMailInformations
            // 
            this.btnMailInformations.Location = new System.Drawing.Point(892, 258);
            this.btnMailInformations.Name = "btnMailInformations";
            this.btnMailInformations.Size = new System.Drawing.Size(198, 43);
            this.btnMailInformations.TabIndex = 9;
            this.btnMailInformations.Text = "Mail Operations";
            this.btnMailInformations.UseVisualStyleBackColor = true;
            this.btnMailInformations.Click += new System.EventHandler(this.btnMailInformations_Click);
            // 
            // dvPhone
            // 
            this.dvPhone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvPhone.Location = new System.Drawing.Point(373, 71);
            this.dvPhone.Name = "dvPhone";
            this.dvPhone.RowHeadersWidth = 51;
            this.dvPhone.RowTemplate.Height = 29;
            this.dvPhone.Size = new System.Drawing.Size(717, 176);
            this.dvPhone.TabIndex = 10;
            this.dvPhone.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvPhone_CellDoubleClick);
            // 
            // dvMail
            // 
            this.dvMail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvMail.Location = new System.Drawing.Point(373, 312);
            this.dvMail.Name = "dvMail";
            this.dvMail.RowHeadersWidth = 51;
            this.dvMail.RowTemplate.Height = 29;
            this.dvMail.Size = new System.Drawing.Size(717, 176);
            this.dvMail.TabIndex = 11;
            this.dvMail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvMail_CellDoubleClick);
            // 
            // frmUserInformations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 500);
            this.Controls.Add(this.dvMail);
            this.Controls.Add(this.dvPhone);
            this.Controls.Add(this.btnMailInformations);
            this.Controls.Add(this.btnPhoneOperations);
            this.Controls.Add(this.btnUserSave);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Name = "frmUserInformations";
            this.Text = "frmUserInformations";
            this.Load += new System.EventHandler(this.frmUserInformations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvMail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Button btnUserSave;
        private System.Windows.Forms.Button btnPhoneOperations;
        private System.Windows.Forms.Button btnMailInformations;
        private System.Windows.Forms.DataGridView dvPhone;
        private System.Windows.Forms.DataGridView dvMail;
        public System.Windows.Forms.TextBox txtName;
    }
}