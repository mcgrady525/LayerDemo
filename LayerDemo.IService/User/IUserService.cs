using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using LayerDemo.Entity.DO;
using LayerDemo.Entity.VO;

namespace LayerDemo.IService.User
{
    /// <summary>
    /// 用户service接口
    /// </summary>
    public interface IUserService : IBaseService<Entity.DO.TUser>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        IList<Entity.DO.TUser> GetUsers(GetUsersRequest request);
    }
}
