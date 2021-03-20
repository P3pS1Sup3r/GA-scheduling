using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace GA_scheduling
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
		}
		
		
		
		void Calculate_Test_ButtonClick(object sender, EventArgs e)
		{
			// some Function
			Date_Find();
			Firts_Date = Firts_Date.Date.AddDays(1);
			label2.Text=Firts_Date.ToString();
		}
	}
}
