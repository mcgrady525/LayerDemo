using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LayerDemo.IService
{
    public interface IBaseService<TDOEntity> where TDOEntity : class
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Add(TDOEntity entity);

        /// <summary>
        /// 新增(异步)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<bool> AddAsync(TDOEntity entity);

        /// <summary>
        /// 批量新增
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        bool Add(IList<TDOEntity> entities);

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Update(TDOEntity entity);

        /// <summary>
        /// 更新(异步)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<bool> UpdateAsync(TDOEntity entity);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Remove(TDOEntity entity);

        /// <summary>
        /// 查询（按主键）
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        TDOEntity Get(params object[] keys);

        /// <summary>
        /// 查询（按主键）
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        Task<TDOEntity> GetAsync(params object[] keys);
    }
}
