using System;

namespace FacebookApiLogic
{
    internal interface IFriendsBirthdayCheckingStrategy
    {
        bool CheckFriendsBirthday(DateTime i_FriendsBirthday, DateTime i_UserBirthday);
    }
}