/*
 * Created by SharpDevelop.
 * User: MAPK
 * Date: 31.10.2020
 * Time: 15:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GA_scheduling
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.Calculate_Test_Button = new System.Windows.Forms.Button();
			this.Current_Sem = new System.Windows.Forms.NumericUpDown();
			this.Current_Year = new System.Windows.Forms.NumericUpDown();
			this.label_1 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.Current_Sem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Current_Year)).BeginInit();
			this.SuspendLayout();
			// 
			// Calculate_Test_Button
			// 
			this.Calculate_Test_Button.Location = new System.Drawing.Point(96, 278);
			this.Calculate_Test_Button.Name = "Calculate_Test_Button";
			this.Calculate_Test_Button.Size = new System.Drawing.Size(91, 55);
			this.Calculate_Test_Button.TabIndex = 0;
			this.Calculate_Test_Button.Text = "Go";
			this.Calculate_Test_Button.UseVisualStyleBackColor = true;
			this.Calculate_Test_Button.Click += new System.EventHandler(this.Calculate_Test_ButtonClick);
			// 
			// Current_Sem
			// 
			this.Current_Sem.Location = new System.Drawing.Point(637, 12);
			this.Current_Sem.Maximum = new decimal(new int[] {
									2,
									0,
									0,
									0});
			this.Current_Sem.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.Current_Sem.Name = "Current_Sem";
			this.Current_Sem.Size = new System.Drawing.Size(33, 20);
			this.Current_Sem.TabIndex = 1;
			this.Current_Sem.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// Current_Year
			// 
			this.Current_Year.Location = new System.Drawing.Point(452, 12);
			this.Current_Year.Maximum = new decimal(new int[] {
									2030,
									0,
									0,
									0});
			this.Current_Year.Minimum = new decimal(new int[] {
									2020,
									0,
									0,
									0});
			this.Current_Year.Name = "Current_Year";
			this.Current_Year.Size = new System.Drawing.Size(120, 20);
			this.Current_Year.TabIndex = 2;
			this.Current_Year.Value = new decimal(new int[] {
									2020,
									0,
									0,
									0});
			// 
			// label_1
			// 
			this.label_1.Location = new System.Drawing.Point(418, 14);
			this.label_1.Name = "label_1";
			this.label_1.Size = new System.Drawing.Size(28, 18);
			this.label_1.TabIndex = 3;
			this.label_1.Text = "Год";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(578, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 18);
			this.label1.TabIndex = 4;
			this.label1.Text = "Семестр";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(293, 278);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "label2";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(682, 369);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label_1);
			this.Controls.Add(this.Current_Year);
			this.Controls.Add(this.Current_Sem);
			this.Controls.Add(this.Calculate_Test_Button);
			this.Name = "MainForm";
			this.Text = "GA scheduling";
			((System.ComponentModel.ISupportInitialize)(this.Current_Sem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Current_Year)).EndInit();
			this.ResumeLayout(false);
		}
		public System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label_1;
		private System.Windows.Forms.NumericUpDown Current_Year;
		private System.Windows.Forms.NumericUpDown Current_Sem;
		private System.Windows.Forms.Button Calculate_Test_Button;
	}
}
