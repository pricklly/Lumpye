/*
 * Создано в SharpDevelop.
 * Пользователь: pricklly
 * Дата: 07.04.2024
 * Время: 11:30
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace Lumpye
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.RichTextBox rtb;
		private System.Windows.Forms.ListBox lb;
		private System.Windows.Forms.ProgressBar pb1;
		private System.Windows.Forms.ProgressBar pb2;
		private System.Windows.Forms.TextBox tb;
		private System.Windows.Forms.Button bt;
		private System.Windows.Forms.Button button1;
		
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
			this.rtb = new System.Windows.Forms.RichTextBox();
			this.lb = new System.Windows.Forms.ListBox();
			this.pb1 = new System.Windows.Forms.ProgressBar();
			this.pb2 = new System.Windows.Forms.ProgressBar();
			this.tb = new System.Windows.Forms.TextBox();
			this.bt = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// rtb
			// 
			this.rtb.Location = new System.Drawing.Point(1, 3);
			this.rtb.Name = "rtb";
			this.rtb.Size = new System.Drawing.Size(297, 216);
			this.rtb.TabIndex = 0;
			this.rtb.Text = "";
			// 
			// lb
			// 
			this.lb.FormattingEnabled = true;
			this.lb.Location = new System.Drawing.Point(325, 73);
			this.lb.Name = "lb";
			this.lb.Size = new System.Drawing.Size(141, 95);
			this.lb.TabIndex = 1;
			// 
			// pb1
			// 
			this.pb1.Location = new System.Drawing.Point(319, 193);
			this.pb1.Maximum = 10;
			this.pb1.Name = "pb1";
			this.pb1.Size = new System.Drawing.Size(147, 26);
			this.pb1.Step = 1;
			this.pb1.TabIndex = 2;
			// 
			// pb2
			// 
			this.pb2.Location = new System.Drawing.Point(320, 44);
			this.pb2.Maximum = 10;
			this.pb2.Name = "pb2";
			this.pb2.Size = new System.Drawing.Size(146, 23);
			this.pb2.Step = 1;
			this.pb2.TabIndex = 3;
			this.pb2.Visible = false;
			// 
			// tb
			// 
			this.tb.Location = new System.Drawing.Point(1, 244);
			this.tb.Name = "tb";
			this.tb.Size = new System.Drawing.Size(297, 20);
			this.tb.TabIndex = 4;
			// 
			// bt
			// 
			this.bt.Location = new System.Drawing.Point(220, 285);
			this.bt.Name = "bt";
			this.bt.Size = new System.Drawing.Size(78, 29);
			this.bt.TabIndex = 5;
			this.bt.Text = "Push";
			this.bt.UseVisualStyleBackColor = true;
			this.bt.Click += new System.EventHandler(this.BtClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(383, 285);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(72, 29);
			this.button1.TabIndex = 6;
			this.button1.Text = "Reset";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(490, 336);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.bt);
			this.Controls.Add(this.tb);
			this.Controls.Add(this.pb2);
			this.Controls.Add(this.pb1);
			this.Controls.Add(this.lb);
			this.Controls.Add(this.rtb);
			this.Name = "MainForm";
			this.Text = "Lumpye";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
