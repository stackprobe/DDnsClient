using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Charlotte
{
	public class Utils
	{
		public static void PostShown(Form f)
		{
			List<Control.ControlCollection> controlTable = new List<Control.ControlCollection>();

			controlTable.Add(f.Controls);

			for (int index = 0; index < controlTable.Count; index++)
			{
				foreach (Control control in controlTable[index])
				{
					GroupBox gb = control as GroupBox;

					if (gb != null)
					{
						controlTable.Add(gb.Controls);
					}
					TextBox tb = control as TextBox;

					if (tb != null)
					{
						if (tb.ContextMenuStrip == null)
						{
							ToolStripMenuItem item = new ToolStripMenuItem();

							item.Text = "項目なし";
							item.Enabled = false;

							ContextMenuStrip menu = new ContextMenuStrip();

							menu.Items.Add(item);

							tb.ContextMenuStrip = menu;
						}
					}
				}
			}
		}
	}
}
