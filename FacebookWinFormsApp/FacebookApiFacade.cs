using System;
using System.Runtime.Remoting.Messaging;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class FacebookApiFacade

    {
        private readonly FacebookConnectionManger r_ConnectionManager = new FacebookConnectionManger();

        public T GetUserInformation<T>(string i_PropertyToCheck)
            where T : class
        {
            T objectToReturn = null;
            if(r_ConnectionManager.IsUserLoggedIn())
            {
                objectToReturn = (T)r_ConnectionManager.LoggedInUser.GetType().GetProperty(i_PropertyToCheck)
                    .GetValue(r_ConnectionManager.LoggedInUser, null);

            }
            else
            {
               throw new Exception("The user is not logged in");
            }
            return objectToReturn;
        }

        public void Login()
        {
            if(!r_ConnectionManager.IsUserLoggedIn())
            {
                r_ConnectionManager.LoginToUser();
            }
            else
            {
                throw new Exception("User is already logged in");
            }
        }

        public void Logout()
        {
            if(r_ConnectionManager.IsUserLoggedIn())
            {
                r_ConnectionManager.LogoutUserApi();
            }
            else
            {
                throw new Exception("You are not logged in to log out");
            }
        }
    }
}