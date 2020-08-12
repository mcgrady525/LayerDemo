using SSharing.Frameworks.NetCore.Common.Results;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SSharing.Frameworks.NetCore.Common.Extends;
using System.Linq;
using LayerDemo.IService;
using LayerDemo.IDao;

namespace LayerDemo.Service
{
    public class BaseService<TBOEntity, TDOEntity> : IBaseService<TBOEntity>
                                                        where TBOEntity : class
                                                        where TDOEntity : class
    {
        protected readonly IBaseDao<TDOEntity> _dao;

        public BaseService(IBaseDao<TDOEntity> dao)
        {
            _dao = dao;
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Add(TBOEntity entity)
        {
            var item = entity.ToDto<TDOEntity>();
            return _dao.Add(item);
        }

        /// <summary>
        /// 新增(异步)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<bool> AddAsync(TBOEntity entity)
        {
            var item = entity.ToDto<TDOEntity>();
            return await _dao.AddAsync(item);
        }

        /// <summary>
        /// 批量新增
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public bool Add(IList<TBOEntity> entities)
        {
            var items = entities.Select(p => p.ToDto<TDOEntity>()).ToList();
            return _dao.Add(items);
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Update(TBOEntity entity)
        {
            var item = entity.ToDto<TDOEntity>();
            return _dao.Update(item);
        }

        /// <summary>
        /// 更新(异步)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<bool> UpdateAsync(TBOEntity entity)
        {
            var item = entity.ToDto<TDOEntity>();
            return await _dao.UpdateAsync(item);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Remove(TBOEntity entity)
        {
            var item = entity.ToDto<TDOEntity>();
            return _dao.Remove(item);
        }

        /// <summary>
        /// 查询（按主键）
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        public TBOEntity Get(params object[] keys)
        {
            TBOEntity result = null;

            var item = _dao.Get(keys);
            if (item != null)
            {
                result = item.ToDto<TBOEntity>();
            }

            return result;
        }

        /// <summary>
        /// 查询（按主键）
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        public async Task<TBOEntity> GetAsync(params object[] keys)
        {
            TBOEntity result = null;

            var item = await _dao.GetAsync(keys);
            if (item != null)
            {
                result = item.ToDto<TBOEntity>();
            }

            return result;
        }
    }
}
