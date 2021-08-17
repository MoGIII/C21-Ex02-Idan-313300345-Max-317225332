using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApiLogic
{
    internal interface IFacebookFriendsHandler
    {
        FacebookObjectCollection<User> ExtractFriendsByCity();
        FacebookObjectCollection<User> ExtractFriendsByBirthDate();
        string fetchFriendsAgeCounts(string o_AmountOfYoungerFriendsCount);
        string DisplayGeneralInformation(string o_AmountOfYoungerFriendsCount);
    }
}
