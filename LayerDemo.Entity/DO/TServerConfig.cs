using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LayerDemo.Entity.DO
{
    [Table("t_server_config")]
    public class TServerConfig
    {
        /// <summary>
        /// id
        /// </summary>
        [Key]
        [Column("id")]
        public int Id { get; set; }

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
        /// env
        /// </summary>
        [Column("env")]
        public string Env { get; set; }

        /// <summary>
        /// remark
        /// </summary>
        [Column("remark")]
        public string Remark { get; set; }
    }
}
