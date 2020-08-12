using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LayerDemo.IService
{
    public interface IBaseService<TBOEntity> where TBOEntity : class
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Add(TBOEntity entity);

        /// <summary>
        /// 新增(异步)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<bool> AddAsync(TBOEntity entity);

        /// <summary>
        /// 批量新增
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        bool Add(IList<TBOEntity> entities);

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Update(TBOEntity entity);

        /// <summary>
        /// 更新(异步)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<bool> UpdateAsync(TBOEntity entity);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Remove(TBOEntity entity);

        /// <summary>
        /// 查询（按主键）
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        TBOEntity Get(params object[] keys);

        /// <summary>
        /// 查询（按主键）
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        Task<TBOEntity> GetAsync(params object[] keys);
    }
}
