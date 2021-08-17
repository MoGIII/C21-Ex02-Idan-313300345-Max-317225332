namespace BasicFacebookFeatures
{
    using System;
    using System.Globalization;
    using FacebookApiLogic;
    using FacebookWrapper.ObjectModel;

    public class FacebookFriendsHandlerLogic : IFacebookFriendsHandler
    {
        private readonly User r_LoggedUser;

        public FacebookFriendsHandlerLogic(User i_User)
        {
            r_LoggedUser = i_User;
        }

        public FacebookObjectCollection<User> ExtractFriendsByCity()
        {
            FacebookObjectCollection<User> listBoxOfFriendsOfSameCity = new FacebookObjectCollection<User>();

            foreach (User user in r_LoggedUser.Friends)
            {
                if (user.Location != null)
                {
                    if (user.Location.Name.Equals(r_LoggedUser.Location.Name))
                    {
                        listBoxOfFriendsOfSameCity.Add(user);
                    }
                }
            }

            return listBoxOfFriendsOfSameCity;
        }


        public FacebookObjectCollection<User> ExtractFriendsByBirthDate()
        {
            FacebookObjectCollection<User> listBoxOfFriendsOfSameBirthday = new FacebookObjectCollection<User>();

            foreach (User user in r_LoggedUser.Friends)
            {
                if (!user.Birthday.Equals(string.Empty))
                {
                    if (user.Birthday.Equals(r_LoggedUser.Birthday))
                    {
                        listBoxOfFriendsOfSameBirthday.Add(user);
                    }
                }
            }

            return listBoxOfFriendsOfSameBirthday;
        }

        public string DisplayGeneralInformation(string o_AmountOfYoungerFriendsCount)
        {
            string amountOfOlderFriends = fetchFriendsAgeCounts(o_AmountOfYoungerFriendsCount);

            return amountOfOlderFriends;
        }

        public string fetchFriendsAgeCounts(string o_AmountOfYoungerFriendsCount)
        {
            int olderFriendsAmount = 0;
            int youngerFriendsAmount = 0;
            const string k_DatePattern = "MM/dd/yyyy";

            foreach(User friend in r_LoggedUser.Friends)
            {
                if(!(friend.Birthday.Equals(string.Empty) && r_LoggedUser.Birthday.Equals(string.Empty)))
                {
                    DateTime friendsBirthday = DateTime.ParseExact(friend.Birthday, k_DatePattern, CultureInfo.InvariantCulture);
                    DateTime usersBirthday = DateTime.ParseExact(r_LoggedUser.Birthday, k_DatePattern, CultureInfo.InvariantCulture);
                    if(friendsBirthday > usersBirthday)
                    {
                        youngerFriendsAmount++;
                    }

                    if(friendsBirthday < usersBirthday)
                    {
                        olderFriendsAmount++;
                    }
                }
            }

            o_AmountOfYoungerFriendsCount = youngerFriendsAmount.ToString();
            return olderFriendsAmount.ToString();
        }

        public DateTime? LastTimeUpdateDate()
        {
            return r_LoggedUser.UpdateTime;
        }
    }
}