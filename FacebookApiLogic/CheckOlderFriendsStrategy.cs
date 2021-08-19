using System;

namespace FacebookApiLogic
{
    public class CheckOlderFriendsStrategy : IFriendsBirthdayCheckingStrategy
    {
        public bool CheckFriendsBirthday(DateTime i_FriendsBirthday, DateTime i_UserBirthday)
        {
            return i_FriendsBirthday > i_UserBirthday;
        }
    }
}