namespace Models
{
	public class User
	{
		static User()
		{

		}

		public User()
		{

		}

		[System.ComponentModel.DisplayName(displayName: "فعال")]
		public bool IsActive { get; set; }
		//======================================================================

		//======================================================================
		[System.ComponentModel.DisplayName(displayName: "مدیر")]
		public bool IsAdministrator { get; set; }
		//======================================================================

		//======================================================================
		[System.ComponentModel.DisplayName(displayName: "شناسه کاربری")]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20)]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = true)]

		public string Username { get; set; }
		//======================================================================

		//======================================================================
		[System.ComponentModel.Browsable(browsable: false)]
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 40)]

		public string Password { get; set; }
		//======================================================================

		//======================================================================
		[System.ComponentModel.DisplayName(displayName: "نام و نام خانوادگی")]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 50)]

		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = false)]

		public string FullName { get; set; }
		//======================================================================

		//======================================================================
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength:250)]

		[System.ComponentModel.Browsable(browsable: false)]

		public string Description { get; set; }
		//======================================================================

		//======================================================================
		[System.ComponentModel.Browsable(browsable: false)]

		public string AdministratorDescription { get; set; }
		//======================================================================
	}
}
