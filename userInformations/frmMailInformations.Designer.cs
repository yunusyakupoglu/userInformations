
namespace userInformations
{
    partial class frmMailInformations
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtMailAddress = new System.Windows.Forms.TextBox();
            this.cmbMailType = new System.Windows.Forms.ComboBox();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMailSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtMailAddress
            // 
            this.txtMailAddress.Location = new System.Drawing.Point(142, 109);
            this.txtMailAddress.Name = "txtMailAddress";
            this.txtMailAddress.Size = new System.Drawing.Size(248, 27);
            this.txtMailAddress.TabIndex = 2;
            // 
            // cmbMailType
            // 
            this.cmbMailType.FormattingEnabled = true;
            this.cmbMailType.Location = new System.Drawing.Point(142, 60);
            this.cmbMailType.Name = "cmbMailType";
            this.cmbMailType.Size = new System.Drawing.Size(248, 28);
            this.cmbMailType.TabIndex = 3;
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Location = new System.Drawing.Point(142, 157);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(72, 24);
            this.cbActive.TabIndex = 4;
            this.cbActive.Text = "Active";
            this.cbActive.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mail Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mail Address";
            // 
            // btnMailSave
            // 
            this.btnMailSave.Location = new System.Drawing.Point(265, 230);
            this.btnMailSave.Name = "btnMailSave";
            this.btnMailSave.Size = new System.Drawing.Size(125, 49);
            this.btnMailSave.TabIndex = 7;
            this.btnMailSave.Text = "Save Mail";
            this.btnMailSave.UseVisualStyleBackColor = true;
            this.btnMailSave.Click += new System.EventHandler(this.btnMailSave_Click);
            // 
            // frmMailInformations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 319);
            this.Controls.Add(this.btnMailSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbActive);
            this.Controls.Add(this.cmbMailType);
            this.Controls.Add(this.txtMailAddress);
            this.Name = "frmMailInformations";
            this.Text = "frmMailInformations";
            this.Load += new System.EventHandler(this.frmMailInformations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtMailAddress;
        private System.Windows.Forms.ComboBox cmbMailType;
        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMailSave;
    }
}