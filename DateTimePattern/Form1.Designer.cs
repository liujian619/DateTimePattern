namespace DateTimePattern
{
	partial class Form1
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.cmb = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txt = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lbl = new System.Windows.Forms.Label();
			this.ckb = new System.Windows.Forms.CheckBox();
			this.ckbEnable = new System.Windows.Forms.CheckBox();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// cmb
			// 
			this.cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmb.FormattingEnabled = true;
			this.cmb.IntegralHeight = false;
			this.cmb.Location = new System.Drawing.Point(75, 17);
			this.cmb.MaxDropDownItems = 10;
			this.cmb.Name = "cmb";
			this.cmb.Size = new System.Drawing.Size(171, 27);
			this.cmb.TabIndex = 1;
			this.cmb.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "格式：";
			// 
			// txt
			// 
			this.txt.BackColor = System.Drawing.Color.Wheat;
			this.txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt.Location = new System.Drawing.Point(75, 59);
			this.txt.Name = "txt";
			this.txt.ReadOnly = true;
			this.txt.Size = new System.Drawing.Size(171, 25);
			this.txt.TabIndex = 3;
			this.txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(18, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(107, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "当前时间显示：";
			// 
			// lbl
			// 
			this.lbl.BackColor = System.Drawing.Color.Wheat;
			this.lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lbl.Location = new System.Drawing.Point(75, 124);
			this.lbl.Name = "lbl";
			this.lbl.Size = new System.Drawing.Size(171, 109);
			this.lbl.TabIndex = 6;
			this.lbl.Text = "\r\n";
			// 
			// ckb
			// 
			this.ckb.AutoSize = true;
			this.ckb.Checked = true;
			this.ckb.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ckb.Location = new System.Drawing.Point(131, 97);
			this.ckb.Name = "ckb";
			this.ckb.Size = new System.Drawing.Size(84, 24);
			this.ckb.TabIndex = 5;
			this.ckb.Text = "本地格式";
			this.ckb.UseVisualStyleBackColor = true;
			this.ckb.CheckedChanged += new System.EventHandler(this.ckb_CheckedChanged);
			// 
			// ckbEnable
			// 
			this.ckbEnable.AutoSize = true;
			this.ckbEnable.Location = new System.Drawing.Point(12, 59);
			this.ckbEnable.Name = "ckbEnable";
			this.ckbEnable.Size = new System.Drawing.Size(54, 24);
			this.ckbEnable.TabIndex = 2;
			this.ckbEnable.Text = "edit";
			this.ckbEnable.UseVisualStyleBackColor = true;
			this.ckbEnable.CheckedChanged += new System.EventHandler(this.ckbEnable_CheckedChanged);
			// 
			// toolTip
			// 
			this.toolTip.AutoPopDelay = 5000;
			this.toolTip.InitialDelay = 100;
			this.toolTip.ReshowDelay = 100;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(265, 242);
			this.Controls.Add(this.ckbEnable);
			this.Controls.Add(this.ckb);
			this.Controls.Add(this.lbl);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmb);
			this.Font = new System.Drawing.Font("微软雅黑", 10F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "时间日期格式";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmb;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbl;
		private System.Windows.Forms.CheckBox ckb;
		private System.Windows.Forms.CheckBox ckbEnable;
		private System.Windows.Forms.ToolTip toolTip;
	}
}

