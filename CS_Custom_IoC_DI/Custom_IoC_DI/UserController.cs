using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_IoC_DI
{
    [Controller]
    class UserController
    {
        // public UserService userService = new UserService();
        [Inject]
        public UserService userService;

        public void GetTop3UserIds(int[] usersIds) {
            userService.Top3UsersIds(usersIds);
        }

        public void DeleteUser(object user) {
            userService.DeleteUser(user);
        }
    }
}
