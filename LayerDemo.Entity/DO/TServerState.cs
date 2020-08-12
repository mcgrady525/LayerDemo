using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// 
/// </summary>
namespace LayerDemo.Entity.DO
{
	[Table("t_server_state")]
	public partial class TServerState
	{
		public TServerState()
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
		/// ip
		/// </summary>
		[Column("ip")]
		public string Ip { get; set; }
	
		/// <summary>
		/// all_ip
		/// </summary>
		[Column("all_ip")]
		public string AllIp { get; set; }
	
		/// <summary>
		/// host_name
		/// </summary>
		[Column("host_name")]
		public string HostName { get; set; }
	
		/// <summary>
		/// os
		/// </summary>
		[Column("os")]
		public string Os { get; set; }
	
		/// <summary>
		/// is_activate_os
		/// </summary>
		[Column("is_activate_os")]
		public bool? IsActivateOs { get; set; }

		/// <summary>
		/// firewall_status
		/// </summary>
		[Column("firewall_status")]
		public string FirewallStatus { get; set; }
	
		/// <summary>
		/// high_risk_port
		/// </summary>
		[Column("high_risk_port")]
		public string HighRiskPort { get; set; }
	
		/// <summary>
		/// last_updated_pwd_time
		/// </summary>
		[Column("last_updated_pwd_time")]
		public DateTime? LastUpdatedPwdTime { get; set; }
	
		/// <summary>
		/// share_dir
		/// </summary>
		[Column("share_dir")]
		public string ShareDir { get; set; }
	
		/// <summary>
		/// ipc
		/// </summary>
		[Column("ipc")]
		public string Ipc { get; set; }
	
		/// <summary>
		/// post_time
		/// </summary>
		[Column("post_time")]
		public DateTime? PostTime { get; set; }
	
		/// <summary>
		/// risk_level
		/// </summary>
		[Column("risk_level")]
		public string RiskLevel { get; set; }

	}

	public partial class TServerState
	{
		[NotMapped]
		public string Env { get; set; }
	}
}