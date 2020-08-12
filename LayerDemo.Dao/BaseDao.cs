using LayerDemo.Data;
using LayerDemo.Entity.Common;
using LayerDemo.IDao;
using Microsoft.EntityFrameworkCore;
using SSharing.Frameworks.NetCore.Common.Extends;
using SSharing.Frameworks.NetCore.Common.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LayerDemo.Dao
{
    public class BaseDao<TEntity> : IBaseDao<TEntity> where TEntity : class
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Add(TEntity entity)
        {
            var result = false;
            using (var ctx = new OpsManageDbContext())
            {
                ctx.Set<TEntity>().Add(entity);
                var effectedRows = ctx.SaveChanges();
                if (effectedRows > 0)
                {
                    result = true;
                }
            }

            return result;
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<bool> AddAsync(TEntity entity)
        {
            using (var ctx = new OpsManageDbContext())
            {
                await ctx.Set<TEntity>().AddAsync(entity);
                return await ctx.SaveChangesAsync() > 0;
            }
        }

        /// <summary>
        /// 批量新增
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public bool Add(IList<TEntity> entities)
        {
            var result = false;
            using (var ctx = new OpsManageDbContext())
            {
                ctx.Set<TEntity>().AddRange(entities);
                var effectedRows = ctx.SaveChanges();
                if (effectedRows > 0)
                {
                    result = true;
                }
            }

            return result;
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Update(TEntity entity)
        {
            var result = false;
            using (var ctx = new OpsManageDbContext())
            {
                ctx.Set<TEntity>().Update(entity);
                var effectedRows = ctx.SaveChanges();
                if (effectedRows > 0)
                {
                    result = true;
                }
            }

            return result;
        }

        public bool UpdateSpecificProperty(TEntity entity, params Expression<Func<TEntity, object>>[] propertyExpression)
        {
            using (var ctx = new OpsManageDbContext())
            {
                ctx.Set<TEntity>().Attach(entity);
                foreach (Expression<Func<TEntity, Object>> expression in propertyExpression)
                {
                    ctx.Entry(entity).Property(expression).IsModified = true;
                }

                return ctx.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 跟新指定的字段
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="propertyExpression"></param>
        /// <returns></returns>
        public async Task<bool> UpdateSpecificPropertyAsync(TEntity entity, params Expression<Func<TEntity, Object>>[] propertyExpression)
        {
            using (var ctx = new OpsManageDbContext())
            {
                ctx.Set<TEntity>().Attach(entity);
                foreach (Expression<Func<TEntity, Object>> expression in propertyExpression)
                {
                    ctx.Entry(entity).Property(expression).IsModified = true;
                }

                return await ctx.SaveChangesAsync() > 0;
            }
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<bool> UpdateAsync(TEntity entity)
        {
            using (var ctx = new OpsManageDbContext())
            {
                ctx.Set<TEntity>().Update(entity);
                return await ctx.SaveChangesAsync() > 0;
            }
        }

        /// <summary>
        /// 更新（按条件）
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public bool Update(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Remove(TEntity entity)
        {
            var result = false;
            using (var ctx = new OpsManageDbContext())
            {
                ctx.Set<TEntity>().Remove(entity);
                var effectedRows = ctx.SaveChanges();
                if (effectedRows > 0)
                {
                    result = true;
                }
            }

            return result;
        }

        /// <summary>
        /// 删除（按条件）
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public bool Remove(Expression<Func<TEntity, bool>> predicate)
        {
            var result = false;
            using (var ctx = new OpsManageDbContext())
            {
                var items = ctx.Set<TEntity>().Where(predicate).ToList();
                ctx.Set<TEntity>().RemoveRange(items);
                var effectedRows = ctx.SaveChanges();
                if (effectedRows > 0)
                {
                    result = true;
                }
            }

            return result;
        }

        /// <summary>
        /// 删除(按条件)
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public async Task<bool> RemoveAsync(Expression<Func<TEntity, bool>> predicate)
        {
            using (var ctx = new OpsManageDbContext())
            {
                var entity = ctx.Set<TEntity>();
                var items = await entity.Where(predicate).ToListAsync();
                entity.RemoveRange(items);
                return await ctx.SaveChangesAsync() > 0;
            }
        }

        /// <summary>
        /// 查询（按主键）
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        public TEntity Get(params object[] keys)
        {
            using (var ctx = new OpsManageDbContext(true))
            {
                return ctx.Set<TEntity>().Find(keys);
            }
        }

        /// <summary>
        /// 查询（按主键）
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        public async Task<TEntity> GetAsync(params object[] keys)
        {
            using (var ctx = new OpsManageDbContext(true))
            {
                return await ctx.Set<TEntity>().FindAsync(keys);
            }
        }

        /// <summary>
        /// 查询（按条件）
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IList<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
        {
            using (var ctx = new OpsManageDbContext(true))
            {
                return ctx.Set<TEntity>().Where(predicate).ToList();
            }
        }

        /// <summary>
        /// 查询（按条件）
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public async Task<IList<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate)
        {
            using (var ctx = new OpsManageDbContext(true))
            {
                return await ctx.Set<TEntity>().Where(predicate).ToListAsync();
            }
        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public virtual IPagingResult<TEntity> PagingGet(PagingParameter<TEntity> param)
        {
            using (var ctx = new OpsManageDbContext(true))
            {
                var query = ctx.Set<TEntity>().Where(param.WherePredicate);
                if (param.OrderByPredicate != null)
                {
                    if (param.OrderByType == Enums.OrderByType.DESC)
                    {
                        query = query.OrderByDescending(param.OrderByPredicate);
                    }
                    else
                    {
                        query = query.OrderBy(param.OrderByPredicate);
                    }
                }

                return query.Paging(param.PageIndex, param.PageSize);
            }
        }

    }
}
