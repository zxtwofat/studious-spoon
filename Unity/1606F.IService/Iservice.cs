using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1606F.Model;

namespace _1606F.IService
{
    public interface Iservice
    {
        int Add(Student student);
        int Delete(Student student);
        int Update(Student student);
        List<Student> show();
    }
}
