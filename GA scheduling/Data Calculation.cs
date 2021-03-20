using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GA_scheduling
{
	public partial class MainForm : Form
	{	
		/// <summary>
		/// Первая дата семестра
		/// </summary>
		public DateTime Firts_Date = new DateTime();
		
		/// <summary>
		/// Последняя дата семестра
		/// </summary>
		public DateTime Last_Date = new DateTime();
		
		/// <summary>
		/// Список всех учебных дней семестра (по дням недели)
		/// </summary>
		public List<List<DateTime>> Study_Days = new List<List<DateTime>>();
		
		/// <summary>
		/// Список Понедельников семестра
		/// </summary>
		public List<DateTime> Mondeys = new List<DateTime>();
		
		/// <summary>
		/// Список Вторников семестра
		/// </summary>
		public List<DateTime> Tuesdays = new List<DateTime>();
		
		/// <summary>
		/// Список Сред семестра
		/// </summary>
		public List<DateTime> Wednesdays = new List<DateTime>();
		
		/// <summary>
		/// Список Четвергов семестра
		/// </summary>
		public List<DateTime> Thursdays = new List<DateTime>();
		
		/// <summary>
		/// Список Пятниц семестра
		/// </summary>
		public List<DateTime> Fridays = new List<DateTime>();
		
		/// <summary>
		/// Список Суббот семестра
		/// </summary>
		public List<DateTime> Saturdays = new List<DateTime>();
		
		
		
		/// <summary>
		/// Вычисление дат начала и окончания семестра
		/// </summary>
		public void Date_Find () {
			int sem = Convert.ToInt16(Current_Sem.Text);
			
			if (sem == 1) {
				Firts_Date = new DateTime (Convert.ToInt32(Current_Year.Text), 09,01);
				Last_Date = new DateTime (Convert.ToInt32(Current_Year.Text), 12,31);
			}
			else {
				Firts_Date = new DateTime (Convert.ToInt32(Current_Year.Text), 02,01);
				Last_Date = new DateTime (Convert.ToInt32(Current_Year.Text), 05,31);
			}
			
			Days_Push();
		}
		
		
		/// <summary>
		/// Заполнение списка учебных дней датами
		/// </summary>
		public void Days_Push () {
			
			DateTime Current_Day = Firts_Date;
			
			while (Current_Day < Last_Date) {
				
				if (Current_Day.DayOfWeek.ToString() == "Monday") {
					Mondeys.Add(Current_Day);
				}
				
				if (Current_Day.DayOfWeek.ToString() == "Tuesday") {
					Tuesdays.Add(Current_Day);
				}
				
				if (Current_Day.DayOfWeek.ToString() == "Wednesday") {
					Wednesdays.Add(Current_Day);
				}
				
				if (Current_Day.DayOfWeek.ToString() == "Thursday") {
					Thursdays.Add(Current_Day);
				}
				
				if (Current_Day.DayOfWeek.ToString() == "Friday") {
					Fridays.Add(Current_Day);
				}
				
				if (Current_Day.DayOfWeek.ToString() == "Saturday") {
					Saturdays.Add(Current_Day);
				}
				
				
				Current_Day = Current_Day.Date.AddDays(1);
			}
			
			Study_Days.Add(Mondeys);
			Study_Days.Add(Tuesdays);
			Study_Days.Add(Wednesdays);
			Study_Days.Add(Thursdays);
			Study_Days.Add(Fridays);
			Study_Days.Add(Saturdays);
			
		}
	}
	
}
              