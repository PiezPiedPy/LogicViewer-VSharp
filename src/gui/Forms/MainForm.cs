﻿/*
  Copyright© (c) 2018 S.Gray, (aka PiezPiedPy).

  This file is part of LogicViewer-VSharp.
  LogicViewer-VSharp is available under the terms of GPL-3.0-or-later.
  See the COPYRIGHTS.md file for more details.

  LogicViewer-VSharp is free software: you can redistribute it and/or modify
  it under the terms of the GNU General Public License as published by
  the Free Software Foundation, either version 3 of the License, or
  (at your option) any later version.

  LogicViewer-VSharp is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

  You should have received a copy of the GNU General Public License
  along with LogicViewer-VSharp.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Windows.Forms;

namespace LogicViewer_GUI.Forms
{
    public partial class MainForm: Form
    {

        private AboutBox about_box;

        public MainForm()
        {
            InitializeComponent();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (about_box = new AboutBox())
                about_box.ShowDialog(this);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (StatusStrip.Visible)
                StatusStrip.Hide();
            else
                StatusStrip.Show();
        }

        private void StandardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (StandardToolStrip.Visible)
                StandardToolStrip.Hide();
            else
                StandardToolStrip.Show();
        }

        private void ViewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ViewToolStrip.Visible)
                ViewToolStrip.Hide();
            else
                ViewToolStrip.Show();
        }

        private void ToolsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ToolsToolStrip.Visible)
                ToolsToolStrip.Hide();
            else
                ToolsToolStrip.Show();
        }
    }
}
