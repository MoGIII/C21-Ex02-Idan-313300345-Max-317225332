using System;

namespace FacebookApiLogic
{
    public interface IFriendsBirthdayCheckingStrategy
    {
        bool CheckFriendsBirthday(DateTime i_FriendsBirthday, DateTime i_UserBirthday);
    }
}