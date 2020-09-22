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
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        protected readonly IBaseDao<TEntity> _dao;

        public BaseService(IBaseDao<TEntity> dao)
        {
            _dao = dao;
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Add(TEntity entity)
        {
            return _dao.Add(entity);
        }

        /// <summary>
        /// 新增(异步)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<bool> AddAsync(TEntity entity)
        {
            return await _dao.AddAsync(entity);
        }

        /// <summary>
        /// 批量新增
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public bool Add(IList<TEntity> entities)
        {
            return _dao.Add(entities);
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Update(TEntity entity)
        {
            return _dao.Update(entity);
        }

        /// <summary>
        /// 更新(异步)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<bool> UpdateAsync(TEntity entity)
        {
            return await _dao.UpdateAsync(entity);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Remove(TEntity entity)
        {
            return _dao.Remove(entity);
        }

        /// <summary>
        /// 查询（按主键）
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        public TEntity Get(params object[] keys)
        {
            return _dao.Get(keys);
        }

        /// <summary>
        /// 查询（按主键）
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        public async Task<TEntity> GetAsync(params object[] keys)
        {
            return await _dao.GetAsync(keys);
        }
    }
}
