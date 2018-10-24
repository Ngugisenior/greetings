namespace Greeting
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.TxtFirstName = new System.Windows.Forms.TextBox();
			this.TxtLastName = new System.Windows.Forms.TextBox();
			this.TxtPhoneNumber = new System.Windows.Forms.TextBox();
			this.TxtGreeting = new System.Windows.Forms.TextBox();
			this.BtnGreeting = new System.Windows.Forms.Button();
			this.BtnClose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(55, 131);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Last Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(55, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "First name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(55, 200);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Phone Number";
			// 
			// TxtFirstName
			// 
			this.TxtFirstName.Location = new System.Drawing.Point(323, 51);
			this.TxtFirstName.Name = "TxtFirstName";
			this.TxtFirstName.Size = new System.Drawing.Size(100, 20);
			this.TxtFirstName.TabIndex = 3;
			this.TxtFirstName.TextChanged += new System.EventHandler(this.TxtFirstName_TextChanged);
			// 
			// TxtLastName
			// 
			this.TxtLastName.Location = new System.Drawing.Point(323, 123);
			this.TxtLastName.Name = "TxtLastName";
			this.TxtLastName.Size = new System.Drawing.Size(100, 20);
			this.TxtLastName.TabIndex = 4;
			this.TxtLastName.TextChanged += new System.EventHandler(this.TxtLastName_TextChanged);
			// 
			// TxtPhoneNumber
			// 
			this.TxtPhoneNumber.Location = new System.Drawing.Point(323, 200);
			this.TxtPhoneNumber.Name = "TxtPhoneNumber";
			this.TxtPhoneNumber.Size = new System.Drawing.Size(100, 20);
			this.TxtPhoneNumber.TabIndex = 5;
			this.TxtPhoneNumber.TextChanged += new System.EventHandler(this.TxtPhoneNumber_TextChanged);
			// 
			// TxtGreeting
			// 
			this.TxtGreeting.BackColor = System.Drawing.Color.YellowGreen;
			this.TxtGreeting.Location = new System.Drawing.Point(102, 276);
			this.TxtGreeting.Multiline = true;
			this.TxtGreeting.Name = "TxtGreeting";
			this.TxtGreeting.Size = new System.Drawing.Size(365, 98);
			this.TxtGreeting.TabIndex = 6;
			this.TxtGreeting.TextChanged += new System.EventHandler(this.TxtGreeting_TextChanged);
			// 
			// BtnGreeting
			// 
			this.BtnGreeting.Location = new System.Drawing.Point(169, 410);
			this.BtnGreeting.Name = "BtnGreeting";
			this.BtnGreeting.Size = new System.Drawing.Size(75, 23);
			this.BtnGreeting.TabIndex = 7;
			this.BtnGreeting.Text = "Greeting";
			this.BtnGreeting.UseVisualStyleBackColor = true;
			this.BtnGreeting.Click += new System.EventHandler(this.button1_Click);
			// 
			// BtnClose
			// 
			this.BtnClose.Location = new System.Drawing.Point(441, 410);
			this.BtnClose.Name = "BtnClose";
			this.BtnClose.Size = new System.Drawing.Size(75, 23);
			this.BtnClose.TabIndex = 8;
			this.BtnClose.Text = "close";
			this.BtnClose.UseVisualStyleBackColor = true;
			this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.BtnClose);
			this.Controls.Add(this.BtnGreeting);
			this.Controls.Add(this.TxtGreeting);
			this.Controls.Add(this.TxtPhoneNumber);
			this.Controls.Add(this.TxtLastName);
			this.Controls.Add(this.TxtFirstName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Greeting";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TxtFirstName;
		private System.Windows.Forms.TextBox TxtLastName;
		private System.Windows.Forms.TextBox TxtPhoneNumber;
		private System.Windows.Forms.TextBox TxtGreeting;
		private System.Windows.Forms.Button BtnGreeting;
		private System.Windows.Forms.Button BtnClose;
	}
}

