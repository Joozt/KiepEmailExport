namespace KiepEmailExport
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dtpBegin = new System.Windows.Forms.DateTimePicker();
            this.dtpEind = new System.Windows.Forms.DateTimePicker();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblBegindatum = new System.Windows.Forms.Label();
            this.lblEindatum = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.chkStarredComment = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // dtpBegin
            // 
            this.dtpBegin.Location = new System.Drawing.Point(15, 25);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.Size = new System.Drawing.Size(217, 20);
            this.dtpBegin.TabIndex = 0;
            // 
            // dtpEind
            // 
            this.dtpEind.Location = new System.Drawing.Point(15, 80);
            this.dtpEind.Name = "dtpEind";
            this.dtpEind.Size = new System.Drawing.Size(217, 20);
            this.dtpEind.TabIndex = 1;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(157, 167);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Start";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblBegindatum
            // 
            this.lblBegindatum.AutoSize = true;
            this.lblBegindatum.Location = new System.Drawing.Point(12, 9);
            this.lblBegindatum.Name = "lblBegindatum";
            this.lblBegindatum.Size = new System.Drawing.Size(56, 13);
            this.lblBegindatum.TabIndex = 4;
            this.lblBegindatum.Text = "Start date:";
            // 
            // lblEindatum
            // 
            this.lblEindatum.AutoSize = true;
            this.lblEindatum.Location = new System.Drawing.Point(12, 64);
            this.lblEindatum.Name = "lblEindatum";
            this.lblEindatum.Size = new System.Drawing.Size(53, 13);
            this.lblEindatum.TabIndex = 5;
            this.lblEindatum.Text = "End date:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 148);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 13);
            this.lblInfo.TabIndex = 3;
            // 
            // chkStarredComment
            // 
            this.chkStarredComment.AutoSize = true;
            this.chkStarredComment.Checked = true;
            this.chkStarredComment.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStarredComment.Location = new System.Drawing.Point(15, 118);
            this.chkStarredComment.Name = "chkStarredComment";
            this.chkStarredComment.Size = new System.Drawing.Size(99, 17);
            this.chkStarredComment.TabIndex = 6;
            this.chkStarredComment.Text = "Filter comments";
            this.chkStarredComment.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 199);
            this.Controls.Add(this.chkStarredComment);
            this.Controls.Add(this.lblEindatum);
            this.Controls.Add(this.lblBegindatum);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.dtpEind);
            this.Controls.Add(this.dtpBegin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KiepEmailExport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpBegin;
        private System.Windows.Forms.DateTimePicker dtpEind;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblBegindatum;
        private System.Windows.Forms.Label lblEindatum;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.CheckBox chkStarredComment;

    }
}

