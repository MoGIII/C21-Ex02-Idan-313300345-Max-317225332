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
        string FetchFriendsAgeCounts(ref string i_AmountOfYoungerFriendsCount);

        string DisplayGeneralInformation(ref string i_AmountOfYoungerFriendsCount);
    }
}
