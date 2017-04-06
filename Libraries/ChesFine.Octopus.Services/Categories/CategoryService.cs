using ChesFine.Octopus.Core.Data;
using ChesFine.Octopus.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChesFine.Octopus.Services.Categories
{
    public class CategoryService:ICategoryService
    {
        #region Fields

        IRepository<Category> _categoryReportory;

        #endregion

        #region Ctor

        public CategoryService(IRepository<Category> _categoryReportory)
        {
            this._categoryReportory = _categoryReportory;
        }


        #endregion

        #region Methods

        public List<Category> GetAllCategory()
        {
            var query = _categoryReportory.Table;
            return query.ToList();
        }

        public List<Category> GetAllCategoryWithStructure()
        {
            var list = GetAllCategory();
            List<Category> targetList = new List<Category>();
            return GetSubNode(list, null);
        }

        private List<Category> GetSubNode(List<Category> source,int? parentId)
        {
            var targets=  source.Where(c => c.ParentId == null).ToList();
            if (targets.Count > 0)
            {
                foreach (var j in targets)
                {
                    j.Children = GetSubNode(source, j.Id);
                }
            }

            return targets;
        }

        #endregion
    }
}
