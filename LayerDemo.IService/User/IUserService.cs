using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using LayerDemo.Entity.BO;
using LayerDemo.Entity.DO;
using LayerDemo.Entity.VO;

namespace LayerDemo.IService.User
{
    /// <summary>
    /// 用户service接口
    /// </summary>
    public interface IUserService: IBaseService<Entity.BO.User>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        IList<Entity.BO.User> GetUsers(GetUsersRequest request);
    }
}
