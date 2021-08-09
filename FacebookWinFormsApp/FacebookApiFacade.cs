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

        public FacebookObjectCollection<Photo> FilterAllPhotosFeature()
        {
            FacebookObjectCollection<Photo> photos = null;
            if (r_ConnectionManager.IsUserLoggedIn())
            {
                FacebookObjectCollection<Album> userAlbums = r_ConnectionManager.LoggedInUser.Albums;
                photos = FacebookPhotosHandlerLogic.ExtractPhotosFromAlbum(userAlbums);
            }
            return photos;
        }

        public FacebookObjectCollection<Photo> FilterPhotosByDateFeature(DateTime i_StartTime, DateTime i_EndTime )
        {
            FacebookObjectCollection<Photo> photos = null;
            if (r_ConnectionManager.IsUserLoggedIn())
            {
                FacebookObjectCollection<Album> userAlbums = r_ConnectionManager.LoggedInUser.Albums;
                photos = FacebookPhotosHandlerLogic.FilterPhotoByDate(userAlbums, i_StartTime, i_EndTime);
            }
            return photos;
        }

        public FacebookObjectCollection<Photo> FilterPhotosByLocationFeature(string i_Location)
        {
            FacebookObjectCollection<Photo> photos = null;
            if (r_ConnectionManager.IsUserLoggedIn())
            {
                FacebookObjectCollection<Album> userAlbums = r_ConnectionManager.LoggedInUser.Albums;
                photos = FacebookPhotosHandlerLogic.FilterPhotoByLocation(userAlbums, i_Location);
            }
            return photos;
        }

        public string amountOfOlderAndYoungerFriendsFeature(out string o_AmountOfYoungerFriends)
        {
            string amountOfOlderFriends = FacebookFriendsHandlerLogic.DisplayGeneralInformation(r_ConnectionManager.LoggedInUser,out o_AmountOfYoungerFriends);
            return amountOfOlderFriends;
        }

        public FacebookObjectCollection<User> FriendsBornOnTheSameDateFeatue()
        {
            FacebookObjectCollection<User> friendsBornOnTheSameDate =
               FacebookFriendsHandlerLogic.ExtractFriendsByBirthDate(r_ConnectionManager.LoggedInUser);
            return friendsBornOnTheSameDate;
        }

        public FacebookObjectCollection<User> ExtractFriendsByCityFeatue()
        {
            FacebookObjectCollection<User> ExtractFriendsByCity =
               FacebookFriendsHandlerLogic.ExtractFriendsByCity(r_ConnectionManager.LoggedInUser);
            return ExtractFriendsByCity;
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