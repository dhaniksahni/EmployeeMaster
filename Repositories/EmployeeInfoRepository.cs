using Microsoft.Practices.Unity;
using EmployeeMaster.Models;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeMaster.Repositories
{
    public class EmployeeInfoRepository : IRepository<EmployeeInfo,int>
    {
        [Dependency]
        public ApplicationEntities context{get;set;}

        public IEnumerable<EmployeeInfo> Get()
        {
            return context.EmployeeInfoes.ToList();
        }

        public EmployeeInfo Get(int id)
        {
            return context.EmployeeInfoes.Find(id);
        }

        public void Add(EmployeeInfo entity)
        {
            context.EmployeeInfoes.Add(entity);
            context.SaveChanges();
        }

        public void Remove(EmployeeInfo entity)
        {
            var obj = context.EmployeeInfoes.Find(entity.EmpNo);
            context.EmployeeInfoes.Remove(obj);
            context.SaveChanges();
        }
    }
}