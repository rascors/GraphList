using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			List<int> list = new List<int>();
			list.PushBack(1);
			list.PushBack(2);
			list.PushBack(3);
			list.PushBack(4);
			list.PushBack(5);



			foreach (var item in list)
			{
				dataGridView1.Rows.Add($"{item}");
			}
		}

		
	}
}
