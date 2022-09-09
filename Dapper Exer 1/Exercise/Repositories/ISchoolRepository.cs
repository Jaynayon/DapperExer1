using DapperExer1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperExer1.Repositories
{
    /// <summary>
    /// Interface for school repository
    /// </summary>
    internal interface ISchoolRepository
    {
        School Get(int id);
        IEnumerable<School> GetAll();
        int Add(School school);
        bool Update(School school);
        bool Delete(int id);
    }
}
