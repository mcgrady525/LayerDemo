using System;
using System.Collections.Generic;
using System.Text;

namespace LayerDemo.Entity.BO
{
	public partial class User
	{
		public User()
		{ }

		/// <summary>
		/// id
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// created_time
		/// </summary>
		public DateTime CreatedTime { get; set; }

		/// <summary>
		/// created_by
		/// </summary>
		public long CreatedBy { get; set; }

		/// <summary>
		/// last_updated_time
		/// </summary>
		public DateTime? LastUpdatedTime { get; set; }

		/// <summary>
		/// last_updated_by
		/// </summary>
		public long? LastUpdatedBy { get; set; }

		/// <summary>
		/// user_id
		/// </summary>
		public string UserId { get; set; }

		/// <summary>
		/// user_name
		/// </summary>
		public string UserName { get; set; }

		/// <summary>
		/// passwd
		/// </summary>
		public string Passwd { get; set; }

		/// <summary>
		/// is_enabled
		/// </summary>
		public string IsEnabled { get; set; }

		/// <summary>
		/// role
		/// </summary>
		public string Role { get; set; }

		/// <summary>
		/// remark
		/// </summary>
		public string Remark { get; set; }

	}
}
