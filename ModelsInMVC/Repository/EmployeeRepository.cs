using ModelsInMVC.Models;

namespace ModelsInMVC.Repository
{
    public class EmployeeRepository:IEmployee
    {
        public List<EmployeeModel> getAllEmployees()
        {
            return DataSource();
        }
        public EmployeeModel getEmployeeById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        private List<EmployeeModel> DataSource()
        {
            var employees = new List<EmployeeModel>
            {
                new EmployeeModel { Id=1,Name= "Rajesh" ,Age=25,Salary=2300 },
                new EmployeeModel { Id=2,Name= "Sohan" ,Age=25,Salary=2500 },
                new EmployeeModel { Id=3,Name= "Somana" ,Age=25,Salary=2000 },
                new EmployeeModel { Id=4,Name= "rinki" ,Age=25,Salary=25600 }
            };
            return employees;
        }

        
    }
}
