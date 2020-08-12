using LayerDemo.Entity.Common;
using SSharing.Frameworks.NetCore.Common.Results;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LayerDemo.IDao
{
    /// <summary>
    /// 通用dao接口
    /// </summary>
    public interface IBaseDao<TEntity> where TEntity : class
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Add(TEntity entity);

        /// <summary>
        /// 新增(异步)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<bool> AddAsync(TEntity entity);

        /// <summary>
        /// 批量新增
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        bool Add(IList<TEntity> entities);

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Update(TEntity entity);

        /// <summary>
        /// 更新(异步)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<bool> UpdateAsync(TEntity entity);

        /// <summary>
        /// 更新指定字段
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="propertyExpression"></param>
        /// <returns></returns>
        bool UpdateSpecificProperty(TEntity entity, params Expression<Func<TEntity, Object>>[] propertyExpression);

        /// <summary>
        /// 更新指定字段
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="propertyExpression"></param>
        /// <returns></returns>
        Task<bool> UpdateSpecificPropertyAsync(TEntity entity, params Expression<Func<TEntity, Object>>[] propertyExpression);

        /// <summary>
        /// 更新(按条件)
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        bool Update(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Remove(TEntity entity);

        /// <summary>
        /// 删除（按条件）
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        bool Remove(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// 删除(按条件)
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<bool> RemoveAsync(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// 查询（按主键）
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        TEntity Get(params object[] keys);

        /// <summary>
        /// 查询（按主键）
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        Task<TEntity> GetAsync(params object[] keys);

        /// <summary>
        /// 查询（按条件）
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        IList<TEntity> Get(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// 查询（按条件）
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<IList<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// 分页获取
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        IPagingResult<TEntity> PagingGet(PagingParameter<TEntity> param);
    }
}
