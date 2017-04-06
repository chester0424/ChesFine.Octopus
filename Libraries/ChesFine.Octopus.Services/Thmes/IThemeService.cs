using ChesFine.Octopus.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChesFine.Octopus.Services.Thmes
{
    public interface IThemeService
    {
        IList<Theme> GetAllThemes();

       /// <summary>
       /// 条件查询
       /// </summary>
       /// <param name="index">页编号</param>
       /// <param name="size">页大熊啊</param>
       /// <param name="name">过滤名称</param>
       /// <param name="resume">过滤说明</param>
       /// <param name="total">总数量</param>
       /// <returns></returns>
        IList<Theme> Qury(int index,int size,string name,string resume,out int total);
    }
}
