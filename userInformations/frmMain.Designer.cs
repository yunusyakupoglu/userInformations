
namespace userInformations
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvUserList = new System.Windows.Forms.DataGridView();
            this.btnUserOperations = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUserList
            // 
            this.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserList.Location = new System.Drawing.Point(12, 12);
            this.dgvUserList.Name = "dgvUserList";
            this.dgvUserList.RowHeadersWidth = 51;
            this.dgvUserList.RowTemplate.Height = 29;
            this.dgvUserList.Size = new System.Drawing.Size(776, 303);
            this.dgvUserList.TabIndex = 0;
            this.dgvUserList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserList_CellDoubleClick);
            // 
            // btnUserOperations
            // 
            this.btnUserOperations.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnUserOperations.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnUserOperations.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUserOperations.Location = new System.Drawing.Point(562, 321);
            this.btnUserOperations.Name = "btnUserOperations";
            this.btnUserOperations.Size = new System.Drawing.Size(226, 79);
            this.btnUserOperations.TabIndex = 1;
            this.btnUserOperations.Text = "User Operations";
            this.btnUserOperations.UseVisualStyleBackColor = false;
            this.btnUserOperations.Click += new System.EventHandler(this.btnUserOperations_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 410);
            this.Controls.Add(this.btnUserOperations);
            this.Controls.Add(this.dgvUserList);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUserOperations;
        public System.Windows.Forms.DataGridView dgvUserList;
    }
}

