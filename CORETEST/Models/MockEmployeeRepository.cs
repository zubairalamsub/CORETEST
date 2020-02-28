using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORETEST.Models
{
	public class MockEmployeeRepository : IEmployeeRepository
	{

		private List<Employee> employees;
		public MockEmployeeRepository()
		{


			employees = new List<Employee>()
			{
				  new Employee() { Id = 1, Name = "Mary", Department = "HR", Email = "mary@pragimtech.com" },
			      new Employee() { Id = 2, Name = "John", Department = "IT", Email = "john@pragimtech.com" },
			      new Employee() { Id = 3, Name = "Sam", Department = "IT", Email = "sam@pragimtech.com" }
			};
		}
		public Employee GetEmployee(int Id)
		{
			return employees.FirstOrDefault(x => x.Id == Id);
		}
	}
}
