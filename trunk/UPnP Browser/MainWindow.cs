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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UPNPLib;


namespace UPnP_Browser
{
    
    public partial class frmMainWindow : Form
    {
        private DeviceCollector _col;
        
        public frmMainWindow()
        {
            InitializeComponent();
        }

        private void frmMainWindow_Load(object sender, EventArgs e)
        {

            _col = new DeviceCollector();

            _col.DeviceAdded +=new DeviceCollector.DeviceAddedEventHandler(this.DeviceAdded);
            _col.SearchCompleted += new DeviceCollector.SearchCompletedEventHandler(this.SearchCompleted);

            toolStripProgressBar.Style = ProgressBarStyle.Marquee;
        }

        public void  DeviceAdded( UPnPDevice device )
        {
            TreeNode newnode = treeDevices.Nodes[0].Nodes.Add(device.UniqueDeviceName, device.FriendlyName);
            newnode.ToolTipText = device.Description;
            
            if (device.HasChildren)
            {
                UPnPDevices childdevices = device.Children;

                foreach (UPnPDevice child in childdevices)
                {
                    newnode.Nodes.Add(child.UniqueDeviceName, child.FriendlyName).ToolTipText = child.Description;
                }
            }

            if (treeDevices.Nodes[0].IsExpanded != true)
                treeDevices.Nodes[0].Expand();
        }

        public void SearchCompleted()
        {
            toolStripProgressBar.Style = ProgressBarStyle.Blocks;
        }

        public void DeviceRemoved(string sUDN )
        {
            treeDevices.Nodes[sUDN].Remove();
        }

        private void treeDevices_AfterSelect(object sender, TreeViewEventArgs e)
        {
            toolStripProgressBar.Style = ProgressBarStyle.Marquee;

            UPnPDeviceFinderClass finder = new UPnPDeviceFinderClass();
            UPnPDevice device = finder.FindByUDN(e.Node.Name);

            if (device != null)
            {
                //
                // Populate the Device tab
                //
                
                txtFriendlyName.Text = device.FriendlyName;
                txtUniqueDeviceName.Text = device.UniqueDeviceName;
                txtDescription.Text = device.Description;
                txtManuFacturerName.Text = device.ManufacturerName;
                txtType.Text = device.Type;

                string sImageUrl = device.IconURL("image/jpeg", 150, 150, 32);

                if (sImageUrl != null)
                {
                    pictureBoxDevice.LoadAsync(sImageUrl);
                    pictureBoxDevice.Visible = true;
                }
                else
                    pictureBoxDevice.Visible = false;
                
                //
                // Populate the Services tab
                //

                listViewServices.Items.Clear();
                
                UPnPServices services = device.Services;

                if (services != null)
                {
                    foreach (UPnPService service in services)
                    {
                        ListViewItem item = new ListViewItem();

                        item.Text = service.Id;
                        item.Tag = service.Id;
                        item.SubItems.Add(service.ServiceTypeIdentifier);

                        listViewServices.Items.Add(item);
                    }
                }
                

                //
                // Populate the document tab
                //

                webBrowserDocument.Url = new Uri(((IUPnPDeviceDocumentAccess)device).GetDocumentURL());
                
                tabControl.Visible = true;
            }

            toolStripProgressBar.Style = ProgressBarStyle.Blocks;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox dialog = new AboutBox();
            dialog.ShowDialog(this);
        }

    }
}