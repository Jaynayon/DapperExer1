using Dapper;
using DapperExer2.Context;
using DapperExer2.Models;

namespace DapperExer2.Repositories
{
    internal class SchoolRepository : ISchoolRepository
    {
        private readonly DapperContext _dapperContext;

        public SchoolRepository()
        {
            _dapperContext = new DapperContext("Data Source=COMPUTER-PC;Initial Catalog=Exer1Db;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;");
        }
        public Task<int> AddSchool(School school)
        {
            return (Task<int>)Task.Run(() =>
            {
                var sql = "INSERT INTO SCHOOL(NAME,ADDRESS,MOTTO,AVERAGETUITION) VALUES(@Name, @Address, @Motto, @AverageTuition);"
                + "SELECT CAST(SCOPE_IDENTITY() as int)";
                using (var connection = _dapperContext.CreateConnection())
                {
                    return connection.QuerySingle<int>(sql, new { school.Id, school.Name, school.Address, school.Motto, school.AverageTuition });
                }
            });
        }

        public Task<bool> DeleteSchool(int id)
        {
            return (Task<bool>)Task.Run(() =>
            {
                var sql = "DELETE FROM School WHERE ID = @id";
                using (var connection = _dapperContext.CreateConnection())
                {
                    if (connection.Execute(sql, new { id }) > 0)
                        return true;
                    else
                        return false;
                }
            });
        }

        public Task<IEnumerable<School>> GetAllSchools()
        {
            return (Task<IEnumerable<School>>)Task.Run(() =>
            {
                var sql = "SELECT * FROM School";
                using (var connection = _dapperContext.CreateConnection())
                {
                    return connection.Query<School>(sql);
                }
            });
        }

        public Task<School> GetSchool(int id)
        {
            return (Task<School>)Task.Run(() =>
            {
                var sql = "SELECT * FROM School WHERE ID = @id";
                using (var connection = _dapperContext.CreateConnection())
                {
                    return connection.QuerySingleOrDefault<School>(sql, new { id });
                }
            });
        }

        public Task<bool> UpdateSchool(School school)
        {
            return (Task<bool>)Task.Run(() =>
            {
                var sql = "UPDATE School SET Motto = @Motto WHERE NAME = @Name AND ADDRESS = @Address AND AVERAGETUITION = @AverageTuition";
                using (var connection = _dapperContext.CreateConnection())
                {
                    if (connection.Execute(sql, new { school.Motto, school.Name, school.Address, school.AverageTuition }) > 0)
                        return true;
                    else
                        return false;
                }
            });
        }
    }
}
