using LayerDemo.Entity.BO;
using LayerDemo.Entity.DO;
using LayerDemo.IDao.User;
using LayerDemo.IService.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using SSharing.Frameworks.NetCore.Common.Extends;
using System.Linq;
using LayerDemo.Entity.VO;
using LayerDemo.Common.Expressions;

namespace LayerDemo.Service.User
{
    public class UserService : BaseService<Entity.BO.User, TUser>, IUserService
    {
        public UserService(IUserDao userDao) : base(userDao) { }

        public IList<Entity.BO.User> GetUsers(GetUsersRequest request)
        {
            IList<Entity.BO.User> result = new List<Entity.BO.User>();

            var query = PredicateBuilder.True<TUser>();
            if (!request.UserId.IsNullOrEmpty())
            {
                query = query.And(p => p.UserId == request.UserId);
            }
            if (!request.UserName.IsNullOrEmpty())
            {
                query = query.And(p => p.UserName == request.UserName);
            }
            if (!request.IsEnabled.IsNullOrEmpty())
            {
                query = query.And(p => p.IsEnabled == request.IsEnabled);
            }

            var users= ((IUserDao)_dao).Get(query);
            if (users.HasValue())
            {
                result= users.Select(p => p.ToDto<Entity.BO.User>()).ToList();
            }

            return result;
        }
    }
}
