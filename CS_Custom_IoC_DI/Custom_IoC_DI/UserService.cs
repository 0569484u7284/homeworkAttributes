using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_IoC_DI
{
    // [Service]
    class UserService
    {
        public void Top3UsersIds(int[] usersIds)
        {
            usersIds.Take(3).ToList().ForEach(Console.WriteLine);
        }

        public void DeleteUser(object user)
        {
            Console.WriteLine(user.ToString() + " Deleted");
        }
    }
}
