using System;
using FacebookApiLogic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class FacebookApiFacade

    {
        private FacebookConnectionMangerSingleton m_ConnectionManager = null;
        private IFacebookFriendsHandler m_FriendsHandler;

        public T GetUserInformation<T>(string i_PropertyToCheck)
            where T : class
        {
            T objectToReturn = null;
            if(m_ConnectionManager.IsUserLoggedIn())
            {
                objectToReturn = (T)m_ConnectionManager.LoggedInUser.GetType().GetProperty(i_PropertyToCheck)
                    .GetValue(m_ConnectionManager.LoggedInUser, null);

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
            if (m_ConnectionManager.IsUserLoggedIn())
            {
                FacebookObjectCollection<Album> userAlbums = m_ConnectionManager.LoggedInUser.Albums;
                photos = FacebookPhotosHandlerLogic.ExtractPhotosFromAlbum(userAlbums);
            }
            return photos;
        }

        public FacebookObjectCollection<Photo> FilterPhotosByDateFeature(DateTime i_StartTime, DateTime i_EndTime )
        {
            FacebookObjectCollection<Photo> photos = null;
            if (m_ConnectionManager.IsUserLoggedIn())
            {
                FacebookObjectCollection<Album> userAlbums = m_ConnectionManager.LoggedInUser.Albums;
                photos = FacebookPhotosHandlerLogic.FilterPhotoByDate(userAlbums, i_StartTime, i_EndTime);
            }
            return photos;
        }

        public FacebookObjectCollection<Photo> FilterPhotosByLocationFeature(string i_Location)
        {
            FacebookObjectCollection<Photo> photos = null;
            if (m_ConnectionManager.IsUserLoggedIn())
            {
                FacebookObjectCollection<Album> userAlbums = m_ConnectionManager.LoggedInUser.Albums;
                photos = FacebookPhotosHandlerLogic.FilterPhotoByLocation(userAlbums, i_Location);
            }
            return photos;
        }

        public string amountOfOlderAndYoungerFriendsFeature(string o_AmountOfYoungerFriends)
        {
            string amountOfOlderFriends = m_FriendsHandler.DisplayGeneralInformation(o_AmountOfYoungerFriends);
            return amountOfOlderFriends;
        }

        public FacebookObjectCollection<User> FriendsBornOnTheSameDateFeatue()
        {
            FacebookObjectCollection<User> friendsBornOnTheSameDate =
               m_FriendsHandler.ExtractFriendsByBirthDate();
            return friendsBornOnTheSameDate;
        }

        public FacebookObjectCollection<User> ExtractFriendsByCityFeatue()
        {
            FacebookObjectCollection<User> ExtractFriendsByCity =
               m_FriendsHandler.ExtractFriendsByCity();
            return ExtractFriendsByCity;
        }


        public void Login()
        {
            m_ConnectionManager = FacebookConnectionMangerSingleton.Instance;
            m_ConnectionManager.LoginToUser();
            m_FriendsHandler = new CachingFriendsHandler(m_ConnectionManager.LoggedInUser);
        }

        

        public void Logout()
        {
            if(m_ConnectionManager.IsUserLoggedIn())
            {
                m_ConnectionManager.LogoutUserApi();
            }
            else
            {
                throw new Exception("You are not logged in to log out");
            }
        }
    }
}