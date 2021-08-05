namespace BasicFacebookFeatures
{
    using System;
    using FacebookWrapper;
    using FacebookWrapper.ObjectModel;

    public class FacebookConnectionManger
    {
        private const string k_AppId = "771374110194582";
        private User m_LoggedInUser;
        private LoginResult m_LoginResult;

        public void LoginToUser()
        {
            if(!IsUserLoggedIn())
            {
                m_LoginResult = FacebookService.Login(
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

                if(!string.IsNullOrEmpty(m_LoginResult.AccessToken))
                {
                    m_LoggedInUser = m_LoginResult.LoggedInUser;
                }
                else
                {
                    throw new Exception("Cannot login to user.");
                }
            }
        }

        public LoginResult LoginResult
        {
            get
            {
                return m_LoginResult;
            }
        }

        public bool IsUserLoggedIn()
        {
            return LoggedInUser != null;
        }

        public User LoggedInUser
        {
            get
            {
                return m_LoggedInUser;
            }
        }

        public void LogoutUserApi()
        {
            if(IsUserLoggedIn())
            {
                FacebookService.LogoutWithUI();
                m_LoggedInUser = null;
            }
        }
    }
}
