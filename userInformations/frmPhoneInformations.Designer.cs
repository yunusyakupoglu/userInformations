
namespace userInformations
{
    partial class frmPhoneInformations
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
            this.btnPhoneSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.cmbPhoneType = new System.Windows.Forms.ComboBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPhoneSave
            // 
            this.btnPhoneSave.Location = new System.Drawing.Point(261, 256);
            this.btnPhoneSave.Name = "btnPhoneSave";
            this.btnPhoneSave.Size = new System.Drawing.Size(125, 49);
            this.btnPhoneSave.TabIndex = 13;
            this.btnPhoneSave.Text = "Save Phone";
            this.btnPhoneSave.UseVisualStyleBackColor = true;
            this.btnPhoneSave.Click += new System.EventHandler(this.btnPhoneSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Phone Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Phone Type";
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Location = new System.Drawing.Point(138, 183);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(72, 24);
            this.cbActive.TabIndex = 10;
            this.cbActive.Text = "Active";
            this.cbActive.UseVisualStyleBackColor = true;
            // 
            // cmbPhoneType
            // 
            this.cmbPhoneType.FormattingEnabled = true;
            this.cmbPhoneType.Location = new System.Drawing.Point(138, 86);
            this.cmbPhoneType.Name = "cmbPhoneType";
            this.cmbPhoneType.Size = new System.Drawing.Size(248, 28);
            this.cmbPhoneType.TabIndex = 9;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(138, 135);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(248, 27);
            this.txtPhoneNumber.TabIndex = 8;
            // 
            // frmPhoneInformations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 355);
            this.Controls.Add(this.btnPhoneSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbActive);
            this.Controls.Add(this.cmbPhoneType);
            this.Controls.Add(this.txtPhoneNumber);
            this.Name = "frmPhoneInformations";
            this.Text = "frmPhoneInformations";
            this.Load += new System.EventHandler(this.frmPhoneInformations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPhoneSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.ComboBox cmbPhoneType;
        private System.Windows.Forms.TextBox txtPhoneNumber;
    }
}