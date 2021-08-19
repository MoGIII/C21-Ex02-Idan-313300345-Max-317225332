using System;
using FacebookWrapper.ObjectModel;

namespace FacebookApiLogic
{
    public class FacebookApiFacade

    {
        private FacebookConnectionMangerSingleton m_ConnectionManager = null;
        private IFacebookFriendsHandler m_FriendsHandler;

        public T GetUserInformation<T>(string i_PropertyToCheck)
            where T : class
        {
            T objectToReturn = null;
            if(m_ConnectionManager != null)
            {
                objectToReturn = (T)m_ConnectionManager.LoggedInUser.GetType().GetProperty(i_PropertyToCheck)?.GetValue(m_ConnectionManager.LoggedInUser, null);
            }
            //else
            //{
            //   throw new Exception("The user is not logged in");
            //}
            return objectToReturn;
        }

        public FacebookObjectCollection<Photo> FilterAllPhotosFeature()
        {
            FacebookObjectCollection<Photo> photos = null;
            if (m_ConnectionManager != null)
            {
                FacebookObjectCollection<Album> userAlbums = m_ConnectionManager.LoggedInUser.Albums;
                photos = FacebookPhotosHandlerLogic.ExtractPhotosFromAlbum(userAlbums);
            }
            else
            {
                throw new Exception("You need to login first!");
            }
            return photos;
        }

        public FacebookObjectCollection<Photo> FilterPhotosByDateFeature(DateTime i_StartTime, DateTime i_EndTime )
        {
            FacebookObjectCollection<Photo> photos = null;
            if (m_ConnectionManager != null)
            {
                FacebookObjectCollection<Album> userAlbums = m_ConnectionManager.LoggedInUser.Albums;
                photos = FacebookPhotosHandlerLogic.FilterPhotoByDate(userAlbums, i_StartTime, i_EndTime);
            }
            else
            {
                throw new Exception("You need to login first!");
            }
            return photos;
        }

        public FacebookObjectCollection<Photo> FilterPhotosByLocationFeature(string i_Location)
        {
            FacebookObjectCollection<Photo> photos = null;
            if (m_ConnectionManager != null)
            {
                FacebookObjectCollection<Album> userAlbums = m_ConnectionManager.LoggedInUser.Albums;
                photos = FacebookPhotosHandlerLogic.FilterPhotoByLocation(userAlbums, i_Location);
            }
            else
            {
                throw new Exception("You need to login first!");
            }
            return photos;
        }

        public string AmountOfOlderAndYoungerFriendsFeature(ref string i_OAmountOfYoungerFriends)
        {
            string amountOfOlderFriends;
            if(m_FriendsHandler != null)
            {
                amountOfOlderFriends = m_FriendsHandler.DisplayGeneralInformation(ref i_OAmountOfYoungerFriends);
            }
            else
            {
                throw new Exception("No logged in user");
            }

            return amountOfOlderFriends;
        }

        public FacebookObjectCollection<User> FriendsBornOnTheSameDateFeature()
        {
            FacebookObjectCollection<User> friendsBornOnTheSameDate;
            if (m_FriendsHandler != null)
            {
                friendsBornOnTheSameDate = m_FriendsHandler.ExtractFriendsByBirthDate();
            }
            else
            {
                throw new Exception("Unable to retrieve friends born on same date");
            }
            return friendsBornOnTheSameDate;
        }

        public FacebookObjectCollection<User> ExtractFriendsByCityFeature()
        {
            FacebookObjectCollection<User> extractFriendsByCity;
            if (m_FriendsHandler != null)
            {
                extractFriendsByCity = m_FriendsHandler.ExtractFriendsByCity();
            }
            else
            {
                throw new Exception("Unable to retrieve friends living in same city");
            }
            return extractFriendsByCity;
        }


        public void Login()
        {
            m_ConnectionManager = FacebookConnectionMangerSingleton.Instance;
            m_ConnectionManager.LoginToUser();
            m_FriendsHandler = new CachingFriendsHandler(m_ConnectionManager.LoggedInUser);
        }

        

        public void Logout()
        {
            if(m_ConnectionManager !=  null)
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