using System;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookApiLogic
{
    internal sealed class FacebookConnectionMangerSingleton
    {
        private static FacebookConnectionMangerSingleton s_Instance = null;
        private static readonly object sr_LockObj = new object();
        private const string k_AppId = "771374110194582";
        public User LoggedInUser { get;private set; }
        public LoginResult LoginResult { get;private set; } = null;

        private FacebookConnectionMangerSingleton() { }

        public static FacebookConnectionMangerSingleton Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (sr_LockObj)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new FacebookConnectionMangerSingleton();
                        }
                    }
                }

                return s_Instance;
            }
        }
    

        public void LoginToUser()
        {
            if(!IsUserLoggedIn())
            {
                LoginResult = FacebookService.Login(
       k_AppId,
       "public_profile",
       "email",
       "publish_to_groups",
       "user_birthday",
       "user_age_range",
       "user_gender",
       "user_link",
       "user_videos",
       "publish_to_groups",
       "groups_access_member_info",
       "pages_read_user_content",
       "user_friends",
       "user_events",
       "user_likes",
       "user_photos",
       "user_posts",
       "user_hometown");

                if(!string.IsNullOrEmpty(LoginResult.AccessToken))
                {
                    LoggedInUser = LoginResult.LoggedInUser;
                }
                else
                {
                    throw new Exception("Cannot login to user.");
                }
            }
        }

        public bool IsUserLoggedIn()
        {
            return LoggedInUser != null;
        }

        public void LogoutUserApi()
        {
            if(IsUserLoggedIn())
            {
                FacebookService.LogoutWithUI();
                LoggedInUser = null;
            }
        }
    }
}
