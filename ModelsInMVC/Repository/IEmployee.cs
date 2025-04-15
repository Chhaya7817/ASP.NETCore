using ModelsInMVC.Models;

namespace ModelsInMVC.Repository
{
    public interface IEmployee
    {
        List<EmployeeModel> getAllEmployees();
        EmployeeModel getEmployeeById(int id);

    }
}
