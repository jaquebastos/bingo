/*
 * Created by SharpDevelop.
 * User: RM20222930090
 * Date: 17/05/2023
 * Time: 14:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace bingo_teste
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		int num=0;
		string val;
		
		void Button76Click(object sender, EventArgs e)
		{
			Button[] bot = {button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32, button33, button34, button35, button36, button37, button38, button39, button40, button41, button42, button43, button44, button45, button46, button47, button48, button49, button50, button51, button52, button53, button54, button55, button56, button57, button58, button59, button60, button61, button62, button63, button64, button65, button66, button67, button68, button69, button70, button71, button72, button73, button74, button75};
		
			for(int n=0; n < 75; n++)
			{
				if(val != "" && val == bot[n].Text)
					{
						bot[n].BackColor = Color.LightGreen;
					}
			}

			button77.Visible = true;
			Random rnd = new Random();
			Button bt=(sender as Button);
			num = rnd.Next(0, listBox1.Items.Count);
			val = listBox1.Items[num].ToString();
			listBox1.Items.RemoveAt(num);
			
			for(int n=0; n < 75; n++)
			{
				if(bot[n].Text == val.ToString())
				{
					pictureBox1.Load(val + ".png");
					bot[n].BackColor = Color.Yellow;
				}
			}
			
			if(listBox1.Items.Count == 0)
			{
				button76.Visible = false;
			}
		}
		
		void Button77Click(object sender, EventArgs e)
		{
			//Application.Restart();
			
			num = 0;
			val = "";
			Button[] bot = {button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32, button33, button34, button35, button36, button37, button38, button39, button40, button41, button42, button43, button44, button45, button46, button47, button48, button49, button50, button51, button52, button53, button54, button55, button56, button57, button58, button59, button60, button61, button62, button63, button64, button65, button66, button67, button68, button69, button70, button71, button72, button73, button74, button75};
			button77.Visible = false;
			button76.Visible = true;
			pictureBox1.Load("BINGO.png");
			listBox1.Items.Clear();		
			
			for (int reset=0; reset < 75; reset++)
				{
					bot[reset].BackColor = Color.FromArgb(233, 234, 236);
					listBox1.Items.Add(reset+1);
				}
		}
	}
}
