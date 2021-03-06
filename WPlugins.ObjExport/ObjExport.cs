﻿/*
Copyright (C) 2018 Wampa842

This file is part of WPlugins.

WPlugins is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

WPlugins is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with WPlugins.  If not, see <http://www.gnu.org/licenses/>.
*/
using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PEPlugin;
using PEPlugin.Pmx;

namespace WPlugins.ObjExport
{

    public class ObjExport : IPEExportPlugin
	{
		ObjExportForm form;
		string path;

		public void Export(IPXPmx pmx, string path, IPERunArgs args)
		{
			this.path = path;
			try
			{
				form = new ObjExportForm(path, args);
				form.ShowDialog();
				if(form.DialogResult == DialogResult.OK)
				{
					ObjFileExporter exporter = new ObjFileExporter(path, pmx, form.Settings);
					exporter.ProcessPmx();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"{ex}");
			}
		}

		public string Ext => ".obj";

		public string Caption => "Wavefront OBJ (WPlugins ObjExport v" + Common.Info.Version + ")";
	}
}
