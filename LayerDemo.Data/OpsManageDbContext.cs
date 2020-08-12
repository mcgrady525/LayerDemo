using LayerDemo.Entity.DO;
using Microsoft.EntityFrameworkCore;
using SSharing.Frameworks.NetCore.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace LayerDemo.Data
{
    public class OpsManageDbContext : BaseDbContext
    {
        public OpsManageDbContext(bool isLogging = false, bool isNoLock = false) : base("OpsManageDB", isLogging, isNoLock)
        { }

        public DbSet<TUser> TUser { get; set; }
    }
}
