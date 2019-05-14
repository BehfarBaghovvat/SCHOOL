namespace Models
{
	public abstract class BaseEntity : object
	{
		public BaseEntity()
		{
			Id = System.Guid.NewGuid();
		}

		[System.ComponentModel.Browsable(browsable: false)]
		public System.Guid Id { get; }
	}
}
