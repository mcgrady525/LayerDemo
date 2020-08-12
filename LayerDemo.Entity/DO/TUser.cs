using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// 
/// </summary>
namespace LayerDemo.Entity.DO
{
	[Table("t_user")]
	public partial class TUser
	{
		public TUser()
		{ }

		/// <summary>
		/// id
		/// </summary>
		[Key] 
		[Column("id")]
		public long Id { get; set; }
	
		/// <summary>
		/// created_time
		/// </summary>
		[Column("created_time")]
		public DateTime CreatedTime { get; set; }
	
		/// <summary>
		/// created_by
		/// </summary>
		[Column("created_by")]
		public long CreatedBy { get; set; }
	
		/// <summary>
		/// last_updated_time
		/// </summary>
		[Column("last_updated_time")]
		public DateTime? LastUpdatedTime { get; set; }
	
		/// <summary>
		/// last_updated_by
		/// </summary>
		[Column("last_updated_by")]
		public long? LastUpdatedBy { get; set; }
	
		/// <summary>
		/// user_id
		/// </summary>
		[Column("user_id")]
		public string UserId { get; set; }
	
		/// <summary>
		/// user_name
		/// </summary>
		[Column("user_name")]
		public string UserName { get; set; }
	
		/// <summary>
		/// passwd
		/// </summary>
		[Column("passwd")]
		public string Passwd { get; set; }
	
		/// <summary>
		/// is_enabled
		/// </summary>
		[Column("is_enabled")]
		public string IsEnabled { get; set; }
	
		/// <summary>
		/// role
		/// </summary>
		[Column("role")]
		public string Role { get; set; }
	
		/// <summary>
		/// remark
		/// </summary>
		[Column("remark")]
		public string Remark { get; set; }
	
	}
}