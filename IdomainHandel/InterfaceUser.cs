using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdomainHandel
{
   public interface InterfaceUser
    {
        IEnumerable<User> GetAll();
    }
}
