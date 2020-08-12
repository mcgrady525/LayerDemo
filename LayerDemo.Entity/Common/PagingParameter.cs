using System;
using System.Linq.Expressions;
using static LayerDemo.Entity.Common.Enums;

namespace LayerDemo.Entity.Common
{
    public class PagingParameter<TEntity>
    {
        public Expression<Func<TEntity, bool>> WherePredicate { get; set; }

        public Expression<Func<TEntity, object>> OrderByPredicate { get; set; }

        public OrderByType OrderByType { get; set; }

        public int PageIndex { get; set; }

        public int PageSize { get; set; }
    }
}
