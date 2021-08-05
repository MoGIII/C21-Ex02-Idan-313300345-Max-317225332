namespace BasicFacebookFeatures
{
    using System;
    using System.Globalization;
    using FacebookWrapper.ObjectModel;

    public static class FacebookFriendsHandlerLogic
    {
        public static FacebookObjectCollection<User> ExtractFriendsByCity(User i_User)
        {
            FacebookObjectCollection<User> listBoxOfFriendsOfSameCity = new FacebookObjectCollection<User>();

            foreach(User user in i_User.Friends)
            {
                if(user.Location != null)
                {
                    if(user.Location.Name.Equals(i_User.Location.Name))
                    {
                        listBoxOfFriendsOfSameCity.Add(user);
                    }
                }
            }

            return listBoxOfFriendsOfSameCity;
        }

        public static FacebookObjectCollection<User> ExtractFriendsByBirthDate(User i_User)
        {
            FacebookObjectCollection<User> listBoxOfFriendsOfSameBirthday = new FacebookObjectCollection<User>();

            foreach(User user in i_User.Friends)
            {
                if(!user.Birthday.Equals(string.Empty))
                {
                    if(user.Birthday.Equals(i_User.Birthday))
                    {
                        listBoxOfFriendsOfSameBirthday.Add(user);
                    }
                }
            }

            return listBoxOfFriendsOfSameBirthday;
        }

        public static string DisplayGeneralInformation(User i_User, out string o_AmountOfYoungerFriendsCount)
        {
            string amountOfOlderFriends = fetchFriendsAgeCounts(i_User, out o_AmountOfYoungerFriendsCount);

            return amountOfOlderFriends;
        }

        private static string fetchFriendsAgeCounts(User i_User, out string o_AmountOfYoungerFriendsCount)
        {
            int olderFriendsAmount = 0;
            int youngerFriendsAmount = 0;
            const string k_DatePattern = "MM/dd/yyyy";

            foreach(User friend in i_User.Friends)
            {
                if(!(friend.Birthday.Equals(string.Empty) && i_User.Birthday.Equals(string.Empty)))
                {
                    DateTime friendsBirthday = DateTime.ParseExact(friend.Birthday, k_DatePattern, CultureInfo.InvariantCulture);
                    DateTime usersBirthday = DateTime.ParseExact(i_User.Birthday, k_DatePattern, CultureInfo.InvariantCulture);
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
    }
}