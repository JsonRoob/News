using IdomainHandel;
using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace domainHandel
{
   
    public class Users: InterfaceUser
    {
        private List<User> UserList = new List<User>();
        public IEnumerable<User> GetAll()

            {
            UserList.Clear();

            UserList. Add(new User { Id = 1, Name = "张三", Major = "软件工程", Graduation = "2013年", School = "西安工业大学" });
            UserList.Add(new User { Id = 2, Name = "李四", Major = "计算机科学与技术", Graduation = "2013年", School = "西安工业大学" });
            return UserList;

            }
}
}
