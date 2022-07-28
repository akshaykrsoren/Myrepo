using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Application_Project.Repository
{
    interface IEmployeeRepository
    {
        List<tblEmployee> getAllEmployeeList();
        tblEmployee getEmployeeById(int id);
        void SaveEmployee(tblEmployee obj);
        void UpdateEmployee(tblEmployee obj);
        void DelteEmployee(int eid);
    }
}
