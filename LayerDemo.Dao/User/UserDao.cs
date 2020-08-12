using LayerDemo.Data;
using LayerDemo.Entity.DO;
using LayerDemo.Entity.VO;
using LayerDemo.IDao.User;
using SSharing.Frameworks.NetCore.Common.Extends;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LayerDemo.Dao.User
{
    /// <summary>
    /// 用户DAO实现
    /// </summary>
    public class UserDao : BaseDao<TUser>, IUserDao
    {

    }
}
