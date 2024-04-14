using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.RequestFeature
{
    public class PagedList<T> : List<T>
    {
        public MetaData MetaData { get; set; }

        public PagedList(List<T> items, int count, int pageSize, int pageNumber)
        {
            MetaData = new MetaData()
            {
                CurrentPage = pageNumber,
                TotalCount = count,
                PageSize = pageSize,
                TotalPage = (int)Math.Ceiling(count / (double)pageSize)
            };
            AddRange(items);
        }

        public static PagedList<T> ToPagedList(List<T> source, int pageNumber, int pageSize)
        {
            var count = source.Count();
            var items = source.Take(((pageNumber - 1) * pageSize)..pageSize).ToList();

            return new PagedList<T>(items, count, pageSize, pageNumber);
        }
    }
}
