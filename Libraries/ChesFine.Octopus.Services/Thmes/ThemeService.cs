using ChesFine.Octopus.Core.Data;
using ChesFine.Octopus.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChesFine.Octopus.Services.Thmes
{
    public  class ThemeService:IThemeService
    {
        #region Fields

        IRepository<Theme> _themeReportory;

        #endregion

        #region Constructor

        public ThemeService(IRepository<Theme> _themeReportory) {
            this._themeReportory = _themeReportory;
        }

        #endregion

        #region Metch/Fuction

        /// <summary>
        /// 返回所有主题
        /// </summary>
        /// <returns></returns>
        public IList<Theme> GetAllThemes()
        {
            var result = _themeReportory.Table.ToArray();
            return result;
        }

        /// <summary>
        /// 条件查询
        /// </summary>
        /// <param name="index"></param>
        /// <param name="size"></param>
        /// <param name="name"></param>
        /// <param name="resume"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        public IList<Theme> Qury(int index, int size, string name, string resume, out int total)
        {
            var queryable = _themeReportory.Table;

            if (!string.IsNullOrWhiteSpace(name))
            {
                queryable = queryable.Where(i => i.Name.Contains(name));
            }
            if (!string.IsNullOrWhiteSpace(resume))
            {
                queryable = queryable.Where(i => i.Resume.Contains(resume) || i.ShortResume.Contains(resume));
            }
            queryable = queryable.OrderBy(i=>i.Id).Skip((index - 1) & size).Take(size);

            total = queryable.Count();

            var result = queryable.ToArray();
            return result;
        }

        #endregion
    }
}
