using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;

namespace DateTimePattern
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			this.cmb.Items.AddRange(FORMAT_DIC.Keys.ToArray());
		}

		static Form1()
		{
			FORMAT_DIC.Add("d", "短日期。");
			FORMAT_DIC.Add("%d", "月中的某一天，一位数的日期没有前导零。" + Desc("d"));
			FORMAT_DIC.Add("dd", "月中的某一天，一位数的日期有一个前导零。");
			FORMAT_DIC.Add("ddd", "周中某天的缩写名称，在AbbreviatedDayNames中定义。");
			FORMAT_DIC.Add("dddd", "周中某天的完整名称，在DayNames中定义。");
			FORMAT_DIC.Add("D", "长日期。");
			FORMAT_DIC.Add("f", "长日期和短时间。");
			FORMAT_DIC.Add("%f", "毫秒的小数精度为1位，其余数字被截断。" + Desc("f"));
			FORMAT_DIC.Add("ff", "毫秒的小数精度为2位，其余数字被截断。");
			FORMAT_DIC.Add("fff", "毫秒的小数精度为3位，其余数字被截断。");
			FORMAT_DIC.Add("ffff", "毫秒的小数精度为4位，其余数字被截断。");
			FORMAT_DIC.Add("fffff", "毫秒的小数精度为5位，其余数字被截断。");
			FORMAT_DIC.Add("ffffff", "毫秒的小数精度为6位，其余数字被截断。");
			FORMAT_DIC.Add("fffffff", "毫秒的小数精度为7位，其余数字被截断。");
			FORMAT_DIC.Add("F", "长日期和长时间。");
			FORMAT_DIC.Add("g", "短日期和短时间。");
			FORMAT_DIC.Add("gg", "时期或纪元，如果要设置格式的日期不具有关联的时期或纪元字符串，则忽略该模式。");
			FORMAT_DIC.Add("G", "短日期和长时间。");
			FORMAT_DIC.Add("%h", "12 小时制的小时，一位数的小时数没有前导零。");
			FORMAT_DIC.Add("hh", "12 小时制的小时，一位数的小时数有前导零。");
			FORMAT_DIC.Add("%H", "24 小时制的小时，一位数的小时数没有前导零。");
			FORMAT_DIC.Add("HH", "24 小时制的小时，一位数的小时数有前导零。");
			FORMAT_DIC.Add("m", "月和日。");
			FORMAT_DIC.Add("%m", "分钟，一位数的分钟数没有前导零。" + Desc("m"));
			FORMAT_DIC.Add("mm", "分钟，一位数的分钟数有一个前导零。");
			FORMAT_DIC.Add("M", "月和日。");
			FORMAT_DIC.Add("%M", "月份数字，一位数的月份没有前导零。" + Desc("M"));
			FORMAT_DIC.Add("MM", "月份数字，一位数的月份有一个前导零。");
			FORMAT_DIC.Add("MMM", "月份的缩写名称，在AbbreviatedMonthNames中定义。");
			FORMAT_DIC.Add("MMMM", "月份的完整名称，在MonthNames中定义。");
			FORMAT_DIC.Add("r", "RFC1123Pattern");
			FORMAT_DIC.Add("R", "RFC1123Pattern");
			FORMAT_DIC.Add("s", "使用当地时间的 SortableDateTimePattern（基于ISO8601）");
			FORMAT_DIC.Add("%s", "秒，一位数的秒数没有前导零。");
			FORMAT_DIC.Add("ss", "秒，一位数的秒数有一个前导零。");
			FORMAT_DIC.Add("t", "短时间。");
			FORMAT_DIC.Add("%t", "在AMDesignator或PMDesignator中定义的AM/PM指示项的第一个字符（如果存在）。" + Desc("t"));
			FORMAT_DIC.Add("tt", "在AMDesignator或PMDesignator中定义的AM/PM指示项（如果存在）。");
			FORMAT_DIC.Add("T", "长时间。");
			FORMAT_DIC.Add("u", "用于显示通用时间的格式。");
			FORMAT_DIC.Add("U", "使用通用时间的完整日期和时间（长日期和长时间）。");
			FORMAT_DIC.Add("y", "年和月。");
			FORMAT_DIC.Add("%y", "不包含纪元的年份，如果不包含纪元的年份小于10，则显示不具有前导零的年份。" + Desc("y"));
			FORMAT_DIC.Add("yy", "不包含纪元的年份，如果不包含纪元的年份小于10，则显示具有前导零的年份。");
			FORMAT_DIC.Add("yyyy", "包括纪元的四位数的年份。");
			FORMAT_DIC.Add("Y", "年和月。");
			FORMAT_DIC.Add("%z", "时区偏移量（“+”或“-”后面仅跟小时）。\n一位数的小时数没有前导零。例如，太平洋标准时间是“-8”。");
			FORMAT_DIC.Add("zz", "时区偏移量（“+”或“-”后面仅跟小时）。\n一位数的小时数有前导零。例如，太平洋标准时间是“-08”。");
			FORMAT_DIC.Add("zzz", "完整时区偏移量（“+”或“-”后面跟有小时和分钟）。\n一位数的小时数和分钟数有前导零。例如，太平洋标准时间是“-08:00”。");
			FORMAT_DIC.Add("额外说明", "额外说明。");
		}

		/// <summary>
		/// 日期时间格式字典。
		/// </summary>
		private static readonly Dictionary<string, string> FORMAT_DIC = new Dictionary<string, string>();

		private static string Desc(string cf)
		{
			return string.Format("{0}(区别于格式{1}，当{2}不是单独出现时可以省略%)。", 
				Environment.NewLine, cf, cf);
		}

		private void cmb_SelectedIndexChanged(object sender, EventArgs e)
		{
			string format = (string)this.cmb.SelectedItem;
			this.txt.Text = format;
			UpdateLabel(format, this.ckb.Checked);
			this.toolTip.SetToolTip(txt, FORMAT_DIC[format]);
		}

		private void ckb_CheckedChanged(object sender, EventArgs e)
		{
			int index = this.cmb.SelectedIndex;
			if (index != -1)
			{
				UpdateLabel(this.cmb.Items[index].ToString(), this.ckb.Checked);
			}
		}

		private void ckbEnable_CheckedChanged(object sender, EventArgs e)
		{
			this.txt.ReadOnly = !this.ckbEnable.Checked;
			this.txt.BackColor = this.txt.ReadOnly ? Color.Wheat : Color.White;
			this.toolTip.Active = this.txt.ReadOnly;
			if (this.txt.ReadOnly && this.cmb.SelectedItem != null)
			{
				this.txt.Text = this.cmb.SelectedItem.ToString();
				UpdateLabel(this.cmb.SelectedItem.ToString(), this.ckb.Checked);
			}
		}

		private void UpdateLabel(string format, bool local)
		{
			if (format.Equals("额外说明"))
			{
				this.lbl.Text = ":    默认时间分隔符；\n" + 
								"/   默认日期分隔符；\n" +
								@"\c 其中c是任意字符。照原义显示字符。若要显示字符'\'，请使用“\\”。";
				return;
			}
			var info = local ? DateTimeFormatInfo.CurrentInfo : DateTimeFormatInfo.InvariantInfo;
			try { this.lbl.Text = DateTime.Now.ToString(format, info); }
			catch (Exception) { this.lbl.Text = "Format Exception"; }
		}

		private void txt_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				UpdateLabel(this.txt.Text, this.ckb.Checked);
				e.Handled = true;
			}
		}
	}
}
/*
 参数format格式详细用法
　格式字符 关联属性/说明
　d ShortDatePattern
　D LongDatePattern
　f 完整日期和时间（长日期和短时间）
　F FullDateTimePattern（长日期和长时间）
　g 常规（短日期和短时间）
　G 常规（短日期和长时间）
　m、M MonthDayPattern
　r、R RFC1123Pattern
　s 使用当地时间的 SortableDateTimePattern（基于ISO8601）
　t ShortTimePattern
　T LongTimePattern
　u UniversalSortableDateTimePattern 用于显示通用时间的格式
　U 使用通用时间的完整日期和时间（长日期和长时间）
　y、Y YearMonthPattern
　C# 日期格式转换
　下表列出了可被合并以构造自定义模式的模式。这些模式是区分大小写的；例如，识别“MM”，但不识别“mm”。如果自定义模式包含空白字符或用单引号括起来的字符，则输出字符串页也将包含这些字符。未定义为格式模式的一部分或未定义为格式字符的字符按其原义复制。
　
　格式模式 说明
　d 月中的某一天。一位数的日期没有前导零。
　dd 月中的某一天。一位数的日期有一个前导零。
　ddd 周中某天的缩写名称，在 AbbreviatedDayNames 中定义。
　dddd 周中某天的完整名称，在 DayNames 中定义。
　M 月份数字。一位数的月份没有前导零。
　MM 月份数字。一位数的月份有一个前导零。
　MMM 月份的缩写名称，在 AbbreviatedMonthNames 中定义。
　MMMM 月份的完整名称，在 MonthNames 中定义。
　y 不包含纪元的年份。如果不包含纪元的年份小于 10，则显示不具有前导零的年份。
　yy 不包含纪元的年份。如果不包含纪元的年份小于 10，则显示具有前导零的年份。
　yyyy 包括纪元的四位数的年份。
　gg 时期或纪元。如果要设置格式的日期不具有关联的时期或纪元字符串，则忽略该模式。
　h 12 小时制的小时。一位数的小时数没有前导零。
　hh 12 小时制的小时。一位数的小时数有前导零。
　H 24 小时制的小时。一位数的小时数没有前导零。
　HH 24 小时制的小时。一位数的小时数有前导零。
　m 分钟。一位数的分钟数没有前导零。
　mm 分钟。一位数的分钟数有一个前导零。
　s 秒。一位数的秒数没有前导零。
　ss 秒。一位数的秒数有一个前导零。
　f 毫秒的小数精度为一位。其余数字被截断。
　ff 毫秒的小数精度为两位。其余数字被截断。
　fff 毫秒的小数精度为三位。其余数字被截断。
　ffff 毫秒的小数精度为四位。其余数字被截断。
　fffff 毫秒的小数精度为五位。其余数字被截断。
　ffffff 毫秒的小数精度为六位。其余数字被截断。
　fffffff 毫秒的小数精度为七位。其余数字被截断。
　t 在 AMDesignator 或 PMDesignator 中定义的 AM/PM 指示项的第一个字符（如果存在）。
　tt 在 AMDesignator 或 PMDesignator 中定义的 AM/PM 指示项（如果存在）。
　z 时区偏移量（“+”或“-”后面仅跟小时）。一位数的小时数没有前导零。例如，太平洋标准时间是“-8”。
　zz 时区偏移量（“+”或“-”后面仅跟小时）。一位数的小时数有前导零。例如，太平洋标准时间是“-08”。
　zzz 完整时区偏移量（“+”或“-”后面跟有小时和分钟）。一位数的小时数和分钟数有前导零。例如，太平洋标准时间是“-08:00”。
　: 在 TimeSeparator 中定义的默认时间分隔符。
　/ 在 DateSeparator 中定义的默认日期分隔符。
　% c 其中 c 是格式模式（如果单独使用）。如果格式模式与原义字符或其他格式模式合并，则可以省略“%”字符。
　\ c 其中 c 是任意字符。照原义显示字符。若要显示反斜杠字符，请使用“\\”。
 
 */
