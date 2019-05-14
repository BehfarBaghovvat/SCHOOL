﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mbb.Windows.Forms
{
	public class MessagesBox
	{
		#region Static Constructor Message
		static MessagesBox()
		{

		}
		#endregion /Static Constructor Message

		#region Message
		public static void Message(string message)
		{
			System.Windows.Forms.MessageBox.Show(text: message);
		}

		public static void Message(string message, string caption)
		{
			System.Windows.Forms.MessageBox.Show(
				text: message,
				caption: caption,
				buttons: System.Windows.Forms.MessageBoxButtons.OK);
		}
		#endregion /Message

		#region InformationMessage
		public static void InformationMessage(string text)
		{
			System.Windows.Forms.MessageBox.Show(
				text: text,
				caption: "توضیح",
				buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
				icon: System.Windows.Forms.MessageBoxIcon.Information,
				defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
				options: System.Windows.Forms.MessageBoxOptions.RightAlign |
				System.Windows.Forms.MessageBoxOptions.RtlReading);
		}

		public static void InformationMessage(string text, string caption)
		{
			System.Windows.Forms.MessageBox.Show(
				text: text,
				caption: caption,
				buttons: System.Windows.Forms.MessageBoxButtons.OK,
				icon: System.Windows.Forms.MessageBoxIcon.Information,
				defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1,
				options: System.Windows.Forms.MessageBoxOptions.RightAlign |
				System.Windows.Forms.MessageBoxOptions.RtlReading);
		}
		#endregion /InformationMessage

		#region QuestionMessage
		public static void QuestionMessage(string text)
		{
			System.Windows.Forms.MessageBox.Show(
				text: text,
				caption: "پرسش",
				buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
				icon: System.Windows.Forms.MessageBoxIcon.Question,
				defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
				options: System.Windows.Forms.MessageBoxOptions.RightAlign | System.Windows.Forms.MessageBoxOptions.RtlReading);
		}
		#endregion /QuestionMessage

		#region ErrorMessage
		public static void ErrorMessage(string text)
		{
			System.Windows.Forms.MessageBox.Show(
				text: text,
				caption: "خطا",
				buttons: System.Windows.Forms.MessageBoxButtons.OK,
				icon: System.Windows.Forms.MessageBoxIcon.Error,
				defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1,
				options: System.Windows.Forms.MessageBoxOptions.RightAlign |
				System.Windows.Forms.MessageBoxOptions.RtlReading);
		}
		#endregion ErrorMessage
	}
}
