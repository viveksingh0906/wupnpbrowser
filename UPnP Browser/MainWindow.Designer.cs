//
//  Copyright (c) 2007 Jonas Andreasson (jonas.m.andreasson@gmail.com)
//  
//  This file is part of Windows UPnP Browser.
//
//  Windows UPnP Browser is free software; you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation; either version 2 of the License, or
//  (at your option) any later version.
//
//  Windows UPnP Browser is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with Very Simple Winows Syslog Service; if not, write to the Free Software
//  Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
//
//  Subversion information
//
//  $Date$	
//  $Revision$
//  $Author$
//  $HeadURL$
//

namespace UPnP_Browser
{
    partial class frmMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainWindow));
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("UPnP Network");
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeDevices = new System.Windows.Forms.TreeView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageDevice = new System.Windows.Forms.TabPage();
            this.pictureBoxDevice = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtManuFacturerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFriendlyName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUniqueDeviceName = new System.Windows.Forms.TextBox();
            this.tabPageDocument = new System.Windows.Forms.TabPage();
            this.webBrowserDocument = new System.Windows.Forms.WebBrowser();
            this.tabPageServices = new System.Windows.Forms.TabPage();
            this.listViewServices = new System.Windows.Forms.ListView();
            this.columnHeaderServiceId = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderServiceType = new System.Windows.Forms.ColumnHeader();
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageDevice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDevice)).BeginInit();
            this.tabPageDocument.SuspendLayout();
            this.tabPageServices.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(528, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 401);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(528, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "Status Bar";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(85, 17);
            this.toolStripStatusLabel1.Text = "Network activity";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.toolStripProgressBar.Value = 100;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(528, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeDevices);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl);
            this.splitContainer1.Size = new System.Drawing.Size(528, 352);
            this.splitContainer1.SplitterDistance = 176;
            this.splitContainer1.TabIndex = 4;
            // 
            // treeDevices
            // 
            this.treeDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeDevices.HotTracking = true;
            this.treeDevices.Location = new System.Drawing.Point(0, 0);
            this.treeDevices.Name = "treeDevices";
            treeNode3.Name = "root";
            treeNode3.Text = "UPnP Network";
            treeNode3.ToolTipText = "The local network";
            this.treeDevices.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treeDevices.ShowNodeToolTips = true;
            this.treeDevices.ShowRootLines = false;
            this.treeDevices.Size = new System.Drawing.Size(176, 352);
            this.treeDevices.TabIndex = 0;
            this.treeDevices.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeDevices_AfterSelect);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageDevice);
            this.tabControl.Controls.Add(this.tabPageDocument);
            this.tabControl.Controls.Add(this.tabPageServices);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(348, 352);
            this.tabControl.TabIndex = 0;
            this.tabControl.Visible = false;
            // 
            // tabPageDevice
            // 
            this.tabPageDevice.Controls.Add(this.pictureBoxDevice);
            this.tabPageDevice.Controls.Add(this.label5);
            this.tabPageDevice.Controls.Add(this.txtType);
            this.tabPageDevice.Controls.Add(this.label4);
            this.tabPageDevice.Controls.Add(this.txtManuFacturerName);
            this.tabPageDevice.Controls.Add(this.label3);
            this.tabPageDevice.Controls.Add(this.txtDescription);
            this.tabPageDevice.Controls.Add(this.label1);
            this.tabPageDevice.Controls.Add(this.txtFriendlyName);
            this.tabPageDevice.Controls.Add(this.label2);
            this.tabPageDevice.Controls.Add(this.txtUniqueDeviceName);
            this.tabPageDevice.Location = new System.Drawing.Point(4, 22);
            this.tabPageDevice.Name = "tabPageDevice";
            this.tabPageDevice.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDevice.Size = new System.Drawing.Size(340, 326);
            this.tabPageDevice.TabIndex = 0;
            this.tabPageDevice.Text = "Device";
            this.tabPageDevice.UseVisualStyleBackColor = true;
            // 
            // pictureBoxDevice
            // 
            this.pictureBoxDevice.Location = new System.Drawing.Point(182, 170);
            this.pictureBoxDevice.Name = "pictureBoxDevice";
            this.pictureBoxDevice.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxDevice.TabIndex = 17;
            this.pictureBoxDevice.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Device Type";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(84, 55);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(248, 20);
            this.txtType.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Manufacturer";
            // 
            // txtManuFacturerName
            // 
            this.txtManuFacturerName.Location = new System.Drawing.Point(84, 146);
            this.txtManuFacturerName.Name = "txtManuFacturerName";
            this.txtManuFacturerName.ReadOnly = true;
            this.txtManuFacturerName.Size = new System.Drawing.Size(248, 20);
            this.txtManuFacturerName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(84, 81);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(248, 59);
            this.txtDescription.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Device Name";
            // 
            // txtFriendlyName
            // 
            this.txtFriendlyName.Location = new System.Drawing.Point(84, 3);
            this.txtFriendlyName.Name = "txtFriendlyName";
            this.txtFriendlyName.ReadOnly = true;
            this.txtFriendlyName.Size = new System.Drawing.Size(248, 20);
            this.txtFriendlyName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "UDN";
            // 
            // txtUniqueDeviceName
            // 
            this.txtUniqueDeviceName.Location = new System.Drawing.Point(84, 29);
            this.txtUniqueDeviceName.Name = "txtUniqueDeviceName";
            this.txtUniqueDeviceName.ReadOnly = true;
            this.txtUniqueDeviceName.Size = new System.Drawing.Size(248, 20);
            this.txtUniqueDeviceName.TabIndex = 6;
            // 
            // tabPageDocument
            // 
            this.tabPageDocument.Controls.Add(this.webBrowserDocument);
            this.tabPageDocument.Location = new System.Drawing.Point(4, 22);
            this.tabPageDocument.Name = "tabPageDocument";
            this.tabPageDocument.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDocument.Size = new System.Drawing.Size(340, 326);
            this.tabPageDocument.TabIndex = 2;
            this.tabPageDocument.Text = "Document";
            this.tabPageDocument.UseVisualStyleBackColor = true;
            // 
            // webBrowserDocument
            // 
            this.webBrowserDocument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserDocument.Location = new System.Drawing.Point(3, 3);
            this.webBrowserDocument.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserDocument.Name = "webBrowserDocument";
            this.webBrowserDocument.Size = new System.Drawing.Size(334, 320);
            this.webBrowserDocument.TabIndex = 0;
            // 
            // tabPageServices
            // 
            this.tabPageServices.Controls.Add(this.listViewServices);
            this.tabPageServices.Location = new System.Drawing.Point(4, 22);
            this.tabPageServices.Name = "tabPageServices";
            this.tabPageServices.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageServices.Size = new System.Drawing.Size(340, 326);
            this.tabPageServices.TabIndex = 1;
            this.tabPageServices.Text = "Services";
            this.tabPageServices.UseVisualStyleBackColor = true;
            // 
            // listViewServices
            // 
            this.listViewServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderServiceId,
            this.columnHeaderServiceType});
            this.listViewServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewServices.Location = new System.Drawing.Point(3, 3);
            this.listViewServices.MultiSelect = false;
            this.listViewServices.Name = "listViewServices";
            this.listViewServices.ShowGroups = false;
            this.listViewServices.Size = new System.Drawing.Size(334, 320);
            this.listViewServices.TabIndex = 0;
            this.listViewServices.UseCompatibleStateImageBehavior = false;
            this.listViewServices.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderServiceId
            // 
            this.columnHeaderServiceId.Text = "Service ID";
            // 
            // columnHeaderServiceType
            // 
            this.columnHeaderServiceType.Text = "Service Type";
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 423);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainWindow";
            this.Text = "UPnP Browser";
            this.Load += new System.EventHandler(this.frmMainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageDevice.ResumeLayout(false);
            this.tabPageDevice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDevice)).EndInit();
            this.tabPageDocument.ResumeLayout(false);
            this.tabPageServices.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeDevices;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageDevice;
        private System.Windows.Forms.TabPage tabPageServices;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFriendlyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUniqueDeviceName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtManuFacturerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabPage tabPageDocument;
        private System.Windows.Forms.WebBrowser webBrowserDocument;
        private System.Windows.Forms.PictureBox pictureBoxDevice;
        private System.Windows.Forms.ListView listViewServices;
        private System.Windows.Forms.ColumnHeader columnHeaderServiceId;
        private System.Windows.Forms.ColumnHeader columnHeaderServiceType;

    }
}

