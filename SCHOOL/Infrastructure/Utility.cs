namespace Infrastructure
{
	public class Utility
	{
		static Utility()
		{

		}

		#region Exit
		public static void Exit()
		{
			System.Windows.Forms.DialogResult dialogResult;

			dialogResult = System.Windows.Forms.MessageBox.Show(
				text: "آیا از برنامه خارج میشود؟",
				caption: "خروج",
				buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
				icon: System.Windows.Forms.MessageBoxIcon.Question,
				defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
				options: System.Windows.Forms.MessageBoxOptions.RightAlign |
				System.Windows.Forms.MessageBoxOptions.RtlReading);
			if (dialogResult == System.Windows.Forms.DialogResult.Yes)
			{
				System.Windows.Forms.Application.Exit();
			}
		}
		#endregion /Exit
	}
}
