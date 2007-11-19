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
using System.Windows.Forms;

using UPNPLib;

namespace UPnP_Browser
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //TestFunc();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMainWindow());
        }

    }
}