using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1606F.IService;
using _1606F.Model;

namespace _1606F.Service
{
    public class Service: _1606F.IService.Iservice
    {
        public int Add(Student student)
        {
            return 0;
        }
        public int Delete(Student student)
        {
            return 1;
        }
        public int Update(Student student)
        {
            return 2;
        }
        public List<Student> show()
        {
            return new List<Student>();
        }
    }
}
