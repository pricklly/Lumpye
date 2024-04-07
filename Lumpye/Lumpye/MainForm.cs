/*
 * Создано в SharpDevelop.
 * Пользователь: pricklly
 * Дата: 07.04.2024
 * Время: 11:30
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lumpye
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		 int cout=0;
		 Random rnd;
		public MainForm()
		{
			
			
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtClick(object sender, EventArgs e)
		{
			rnd=new Random();
			if (pb1.Value<=pb1.Maximum)
			{
			pb1.Value=pb1.Value+rnd.Next(3);
			}
			lb.Items.Add(rnd.Next(1000000));
			rtb.AppendText(tb.Text+"\n");
			cout=pb1.Value;
			if (cout==10)
			{
				pb2.Visible=true;
				while (pb2.Value<=10)
				{
					pb2.Value=pb2.Value+rnd.Next(2);
				}
			}
		}
		void Button1Click(object sender, EventArgs e)
		{
			cout=0;
			pb2.Visible=false;
		}
	}
}
