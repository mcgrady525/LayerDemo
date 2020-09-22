using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LayerDemo.IService
{
    public interface IBaseService<TEntity> where TEntity : class
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
        /// 删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Remove(TEntity entity);

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
    }
}
