using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greeting
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			TxtGreeting.Text = "Best wishes to " + TxtFirstName.Text +
				" " + TxtLastName.Text + " !"+
			Environment.NewLine + "Telephone: " + TxtPhoneNumber.Text;
			//"\r\n"+"Telephone: "+ Txt.PhoneNumber.Text;
		}

		private void TxtGreeting_TextChanged(object sender, EventArgs e)
		{

		}

		private void BtnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void TxtLastName_TextChanged(object sender, EventArgs e)
		{

		}

		private void TxtPhoneNumber_TextChanged(object sender, EventArgs e)
		{

		}

		private void TxtFirstName_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
