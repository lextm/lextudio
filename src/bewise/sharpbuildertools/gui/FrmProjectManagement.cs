using System;
using System.IO;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using EV.Windows.Forms;
using Borland.Studio.ToolsAPI;
using BeWise.Common.Utils;

namespace BeWise.SharpBuilderTools.Gui {

	class FrmProjectManagement : Form {
        // *************************************************************************
        //                              Constructor
        // *************************************************************************
		internal FrmProjectManagement() {
            InitializeComponent();

            new ListViewSortManager(ListView,
                                    new Type[] {
                                        typeof(ListViewTextSort),
                                        typeof(ListViewTextSort)
                                    });
        }

        protected override void Dispose (bool disposing) {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        // *************************************************************************
        //                              Private
        // *************************************************************************
        private System.ComponentModel.Container components = null;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private Vista_Api.ListView ListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btUp;
        private System.Windows.Forms.Button btDown;

#region Windows Form Designer generated code

        private void InitializeComponent()
		{
			this.btOk = new System.Windows.Forms.Button();
			this.btCancel = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lblSubTitle = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.ListView = new Vista_Api.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.label1 = new System.Windows.Forms.Label();
			this.btUp = new System.Windows.Forms.Button();
			this.btDown = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btOk
			// 
			this.btOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btOk.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btOk.Location = new System.Drawing.Point(376, 336);
			this.btOk.Name = "btOk";
			this.btOk.TabIndex = 1;
			this.btOk.Text = "Ok";
			this.btOk.Click += new System.EventHandler(this.btOk_Click);
			// 
			// btCancel
			// 
			this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btCancel.Location = new System.Drawing.Point(456, 336);
			this.btCancel.Name = "btCancel";
			this.btCancel.TabIndex = 2;
			this.btCancel.Text = "Cancel";
			this.btCancel.Click += new System.EventHandler(this.btOk_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(0, 320);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(544, 8);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			// 
			// lblSubTitle
			// 
			this.lblSubTitle.BackColor = System.Drawing.Color.White;
			this.lblSubTitle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubTitle.ForeColor = System.Drawing.Color.Black;
			this.lblSubTitle.Location = new System.Drawing.Point(24, 24);
			this.lblSubTitle.Name = "lblSubTitle";
			this.lblSubTitle.Size = new System.Drawing.Size(536, 32);
			this.lblSubTitle.TabIndex = 4;
			this.lblSubTitle.Text = "Change the order of the project. All the projects must be saved  " +  
				"before and the project group  will be reopened";
			// 
			// lblTitle
			// 
			this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lblTitle.BackColor = System.Drawing.Color.White;
			this.lblTitle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.Black;
			this.lblTitle.Location = new System.Drawing.Point(0, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(536, 24);
			this.lblTitle.TabIndex = 3;
			this.lblTitle.Text = "    Project Order";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(0, 52);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(544, 8);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			// 
			// Vista_Api.ListView
			// 
			this.ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
						| System.Windows.Forms.AnchorStyles.Left) 
						| System.Windows.Forms.AnchorStyles.Right)));
			this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
						this.columnHeader1,
						this.columnHeader2});
			this.ListView.FullRowSelect = true;
			this.ListView.HideSelection = false;
			this.ListView.Location = new System.Drawing.Point(8, 72);
			this.ListView.Name = "Vista_Api.ListView";
			this.ListView.Size = new System.Drawing.Size(464, 240);
			this.ListView.TabIndex = 7;
			this.ListView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Path";
			this.columnHeader1.Width = 285;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "File name";
			this.columnHeader2.Width = 160;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
						| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(0, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(544, 32);
			this.label1.TabIndex = 8;
			// 
			// btUp
			// 
			this.btUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btUp.Location = new System.Drawing.Point(480, 80);
			this.btUp.Name = "btUp";
			this.btUp.Size = new System.Drawing.Size(48, 23);
			this.btUp.TabIndex = 9;
			this.btUp.Text = "Up";
			this.btUp.Click += new System.EventHandler(this.btUp_Click);
			// 
			// btDown
			// 
			this.btDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btDown.Location = new System.Drawing.Point(480, 112);
			this.btDown.Name = "btDown";
			this.btDown.Size = new System.Drawing.Size(48, 23);
			this.btDown.TabIndex = 10;
			this.btDown.Text = "Down";
			this.btDown.Click += new System.EventHandler(this.btDown_Click);
			// 
			// FrmProjectManagement
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(536, 366);
			this.Controls.Add(this.btDown);
			this.Controls.Add(this.btUp);
			this.Controls.Add(this.ListView);
			this.Controls.Add(this.lblSubTitle);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btCancel);
			this.Controls.Add(this.btOk);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MinimumSize = new System.Drawing.Size(544, 216);
			this.Name = "FrmProjectManagement";
			this.Load += new System.EventHandler(this.FrmProjectManagement_Load);
			this.ResumeLayout(false);
		}
#endregion

        private void btOk_Click(object sender, System.EventArgs e) {
            Close();
        }

        private void FrmProjectManagement_Load(object sender, System.EventArgs e) {
            ListView.Items.Clear();

            IOTAProjectGroup _ProjectGroup = OTAUtils.GetCurrentProjectGroup();

            for (int i= 0; i < _ProjectGroup.ProjectCount; i++) {
                IOTAProject _Project = _ProjectGroup[i];

                ListViewItem _ListViewItem = new ListViewItem();
                _ListViewItem.Text = Path.GetDirectoryName(_Project.FileName);
                _ListViewItem.SubItems.Add(Path.GetFileName(_Project.FileName));
                _ListViewItem.Tag = _Project;

                ListView.Items.Add(_ListViewItem);
            }
        }

        // *************************************************************************
        //                              Public
        // *************************************************************************

        //internal string[] ProjectFileNames {
        //    get {
        //        ArrayList _List = new ArrayList();
        //        foreach(ListViewItem _ListViewItem in ListView.Items) {
        //            _List.Add((_ListViewItem.Tag as IOTAProject).FileName);
        //        }

        //        return (string[]) _List.ToArray(typeof(string));
        //    }
        //}

        private ListViewItem GetSelectedListViewItem() {
            if (ListView.SelectedItems.Count > 0) {
                return ListView.SelectedItems[0];
            }

            return null;
        }

        private void btDown_Click(object sender, System.EventArgs e) {
            ListViewItem _ListViewItem = GetSelectedListViewItem();

            if (_ListViewItem != null && _ListViewItem.Index < ListView.Items.Count -1) {
                int _Index = _ListViewItem.Index + 1;
                _ListViewItem.Remove();
                ListView.Items.Insert(_Index, _ListViewItem);
            }
        }

        private void btUp_Click(object sender, System.EventArgs e) {
            ListViewItem _ListViewItem = GetSelectedListViewItem();

            if (_ListViewItem != null && _ListViewItem.Index > 0) {
                int _Index = _ListViewItem.Index - 1;
                _ListViewItem.Remove();
                ListView.Items.Insert(_Index, _ListViewItem);
            }
        }
   }
}
