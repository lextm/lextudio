﻿namespace Zayko.Dialogs.UnhandledExceptionDlg
{
    partial class UnhandledExDlgForm
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
            if(disposing && (components != null))
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
        	this.panelTop = new System.Windows.Forms.Panel();
        	this.labelTitle = new System.Windows.Forms.Label();
        	this.panelDevider = new System.Windows.Forms.Panel();
        	this.labelExceptionDate = new System.Windows.Forms.Label();
        	this.labelCaption = new System.Windows.Forms.Label();
        	this.labelDescription = new System.Windows.Forms.Label();
        	this.buttonNotSend = new System.Windows.Forms.Button();
        	this.buttonSend = new System.Windows.Forms.Button();
        	this.labelLinkTitle = new System.Windows.Forms.Label();
        	this.linkLabelData = new System.Windows.Forms.LinkLabel();
        	this.checkBoxRestart = new System.Windows.Forms.CheckBox();
        	this.btnIgnore = new System.Windows.Forms.Button();
        	this.panelTop.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// panelTop
        	// 
        	this.panelTop.BackColor = System.Drawing.SystemColors.Window;
        	this.panelTop.Controls.Add(this.labelTitle);
        	this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
        	this.panelTop.Location = new System.Drawing.Point(0, 0);
        	this.panelTop.Name = "panelTop";
        	this.panelTop.Size = new System.Drawing.Size(412, 63);
        	this.panelTop.TabIndex = 0;
        	// 
        	// labelTitle
        	// 
        	this.labelTitle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.labelTitle.Location = new System.Drawing.Point(13, 13);
        	this.labelTitle.Name = "labelTitle";
        	this.labelTitle.Size = new System.Drawing.Size(387, 44);
        	this.labelTitle.TabIndex = 0;
        	this.labelTitle.Text = "\"{0}\" encountered a problem and needed to close";
        	// 
        	// panelDevider
        	// 
        	this.panelDevider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.panelDevider.Dock = System.Windows.Forms.DockStyle.Top;
        	this.panelDevider.Location = new System.Drawing.Point(0, 63);
        	this.panelDevider.Name = "panelDevider";
        	this.panelDevider.Size = new System.Drawing.Size(412, 2);
        	this.panelDevider.TabIndex = 1;
        	// 
        	// labelExceptionDate
        	// 
        	this.labelExceptionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.labelExceptionDate.Location = new System.Drawing.Point(12, 68);
        	this.labelExceptionDate.Name = "labelExceptionDate";
        	this.labelExceptionDate.Size = new System.Drawing.Size(384, 23);
        	this.labelExceptionDate.TabIndex = 2;
        	this.labelExceptionDate.Text = "This error occured on {0}";
        	// 
        	// labelCaption
        	// 
        	this.labelCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.labelCaption.Location = new System.Drawing.Point(13, 91);
        	this.labelCaption.Name = "labelCaption";
        	this.labelCaption.Size = new System.Drawing.Size(387, 23);
        	this.labelCaption.TabIndex = 3;
        	this.labelCaption.Text = "Please tell Us about this problem";
        	// 
        	// labelDescription
        	// 
        	this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
        	this.labelDescription.Location = new System.Drawing.Point(12, 114);
        	this.labelDescription.Name = "labelDescription";
        	this.labelDescription.Size = new System.Drawing.Size(387, 29);
        	this.labelDescription.TabIndex = 4;
        	this.labelDescription.Text = "We have created an error report that you can send us. We will treat this report a" +
        	"s confidential and anonymous.";
        	// 
        	// buttonNotSend
        	// 
        	this.buttonNotSend.DialogResult = System.Windows.Forms.DialogResult.OK;
        	this.buttonNotSend.Location = new System.Drawing.Point(325, 198);
        	this.buttonNotSend.Name = "buttonNotSend";
        	this.buttonNotSend.Size = new System.Drawing.Size(75, 23);
        	this.buttonNotSend.TabIndex = 6;
        	this.buttonNotSend.Text = "&Don\'t send";
        	this.buttonNotSend.UseVisualStyleBackColor = true;
        	this.buttonNotSend.Click += new System.EventHandler(this.ButtonNotSendClick);
        	// 
        	// buttonSend
        	// 
        	this.buttonSend.DialogResult = System.Windows.Forms.DialogResult.OK;
        	this.buttonSend.Location = new System.Drawing.Point(212, 198);
        	this.buttonSend.Name = "buttonSend";
        	this.buttonSend.Size = new System.Drawing.Size(107, 23);
        	this.buttonSend.TabIndex = 7;
        	this.buttonSend.Text = "&Send Error Report";
        	this.buttonSend.UseVisualStyleBackColor = true;
        	this.buttonSend.Click += new System.EventHandler(this.ButtonSendClick);
        	// 
        	// labelLinkTitle
        	// 
        	this.labelLinkTitle.AutoSize = true;
        	this.labelLinkTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
        	this.labelLinkTitle.Location = new System.Drawing.Point(13, 143);
        	this.labelLinkTitle.Name = "labelLinkTitle";
        	this.labelLinkTitle.Size = new System.Drawing.Size(243, 13);
        	this.labelLinkTitle.TabIndex = 7;
        	this.labelLinkTitle.Text = "To see what data this error report contains, please";
        	// 
        	// linkLabelData
        	// 
        	this.linkLabelData.AutoSize = true;
        	this.linkLabelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
        	this.linkLabelData.Location = new System.Drawing.Point(262, 143);
        	this.linkLabelData.Name = "linkLabelData";
        	this.linkLabelData.Size = new System.Drawing.Size(56, 13);
        	this.linkLabelData.TabIndex = 8;
        	this.linkLabelData.TabStop = true;
        	this.linkLabelData.Text = "click here.";
        	this.linkLabelData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelDataLinkClicked);
        	// 
        	// checkBoxRestart
        	// 
        	this.checkBoxRestart.AutoSize = true;
        	this.checkBoxRestart.Checked = true;
        	this.checkBoxRestart.CheckState = System.Windows.Forms.CheckState.Checked;
        	this.checkBoxRestart.Location = new System.Drawing.Point(16, 168);
        	this.checkBoxRestart.Name = "checkBoxRestart";
        	this.checkBoxRestart.Size = new System.Drawing.Size(87, 17);
        	this.checkBoxRestart.TabIndex = 5;
        	this.checkBoxRestart.Text = "&Restart \"{0}\"";
        	this.checkBoxRestart.UseVisualStyleBackColor = true;
        	// 
        	// btnIgnore
        	// 
        	this.btnIgnore.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        	this.btnIgnore.Location = new System.Drawing.Point(131, 198);
        	this.btnIgnore.Name = "btnIgnore";
        	this.btnIgnore.Size = new System.Drawing.Size(75, 23);
        	this.btnIgnore.TabIndex = 9;
        	this.btnIgnore.Text = "Ignore";
        	this.btnIgnore.UseVisualStyleBackColor = true;
        	// 
        	// UnhandledExDlgForm
        	// 
        	this.AcceptButton = this.buttonNotSend;
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.CancelButton = this.buttonNotSend;
        	this.ClientSize = new System.Drawing.Size(412, 233);
        	this.ControlBox = false;
        	this.Controls.Add(this.btnIgnore);
        	this.Controls.Add(this.checkBoxRestart);
        	this.Controls.Add(this.linkLabelData);
        	this.Controls.Add(this.labelLinkTitle);
        	this.Controls.Add(this.buttonSend);
        	this.Controls.Add(this.buttonNotSend);
        	this.Controls.Add(this.labelDescription);
        	this.Controls.Add(this.labelCaption);
        	this.Controls.Add(this.labelExceptionDate);
        	this.Controls.Add(this.panelDevider);
        	this.Controls.Add(this.panelTop);
        	this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        	this.MaximizeBox = false;
        	this.MinimizeBox = false;
        	this.Name = "UnhandledExDlgForm";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "UnhandledExDlgForm";
        	this.TopMost = true;
        	this.Load += new System.EventHandler(this.UnhandledExDlgForm_Load);
        	this.panelTop.ResumeLayout(false);
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.Button btnIgnore;

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelDevider;
        private System.Windows.Forms.Label labelExceptionDate;
        private System.Windows.Forms.Label labelCaption;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonNotSend;
        internal System.Windows.Forms.Label labelTitle;
        internal System.Windows.Forms.CheckBox checkBoxRestart;
        internal System.Windows.Forms.Label labelLinkTitle;
        internal System.Windows.Forms.LinkLabel linkLabelData;
        internal System.Windows.Forms.Button buttonSend;
    }
}