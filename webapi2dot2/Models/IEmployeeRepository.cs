using System;
namespace webapi2dot2.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int Id);
    }
}
