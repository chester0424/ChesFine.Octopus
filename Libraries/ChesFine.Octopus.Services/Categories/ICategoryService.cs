using ChesFine.Octopus.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChesFine.Octopus.Services.Categories
{
    public interface ICategoryService
    {
        List<Category> GetAllCategory();
    }
}
