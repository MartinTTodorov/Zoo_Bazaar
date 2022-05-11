using Entities;

namespace DataAccessLayer
{
    public class MockEmployeeDB : ICRUD<Employee>
    {
        public void Add(Employee obj)
        {
          
        }

        public List<Employee> Read()
        {
            return new List<Employee>();
        }

        public void Update(int id, Employee obj)
        {
            
        }
    }
}
