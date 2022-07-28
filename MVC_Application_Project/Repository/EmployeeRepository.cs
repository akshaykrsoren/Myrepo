using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Application_Project.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        testdbEntities objentity;
        public EmployeeRepository()
        {
            objentity = new testdbEntities();
        }

        public void DelteEmployee(int eid)
        {
            try
            {
                tblEmployee obj = new tblEmployee();
                obj = objentity.tblEmployees.Where(m => m.Eid == eid).FirstOrDefault();
                objentity.tblEmployees.Remove(obj);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<tblEmployee> getAllEmployeeList()
        {
            List<tblEmployee> lstEmployee = new List<tblEmployee>();
            try
            { 
                lstEmployee = objentity.tblEmployees.ToList(); 
            }

            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return lstEmployee;


        }

        public tblEmployee getEmployeeById(int id)
        {
            try
            {
                tblEmployee obj = new tblEmployee();
                obj = objentity.tblEmployees.Where(m => m.Eid == id).FirstOrDefault();
                return obj;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public void SaveEmployee(tblEmployee obj)
        {
            try
            {
                tblEmployee objemp = new tblEmployee();
                objemp.Name = obj.Name;
                objemp.Email = obj.Email;
                objemp.Phone = obj.Phone;
                objemp.Salary = obj.Salary;
                objemp.tblcountry.countryid = (Int32)obj.CountryId;
                objemp.tblRoleMaster.RoleId = (Int32)obj.RoleTypeId;
                objentity.tblEmployees.Add(objemp);
                objentity.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public void UpdateEmployee(tblEmployee obj)
        {
            try
                { 
            tblEmployee objemp = new tblEmployee();
            objemp = objentity.tblEmployees.Where(m => m.Eid == obj.Eid).FirstOrDefault();
            objemp.Name = obj.Name;
            objemp.Email = obj.Email;
            objemp.Phone = obj.Phone;
            objemp.Salary = obj.Salary;
            objemp.tblcountry.countryid = (Int32)obj.CountryId;
            objemp.tblRoleMaster.RoleId = (Int32)obj.RoleTypeId;
            objentity.SaveChanges();
        }
             catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }
    }
}