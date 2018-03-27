using Giftshop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftShop.core.IDatos
{
   public interface IUser
    {
        User GetUser(decimal UserID, string password);
        bool ChangePassword(User user);
        bool ShortPassword(User user);
    }
}
