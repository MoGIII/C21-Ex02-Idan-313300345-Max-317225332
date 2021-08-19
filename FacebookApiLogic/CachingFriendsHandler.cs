using System;
using FacebookWrapper.ObjectModel;

namespace FacebookApiLogic
{
    internal class CachingFriendsHandler : IFacebookFriendsHandler
    {
        private delegate FacebookObjectCollection<T> FacebookFriendsHandlerDelegate<T>();
        private delegate string FacebookFriendsHandlerStringDelegate(ref string i_Data);
        // caching dates:
        private DateTime m_LastTimeUpdateFriendsCaching;
        // real subject:
        private readonly FacebookFriendsHandlerLogic r_FriendsHandlerLogic;
        // cache data:
        private FacebookObjectCollection<User> m_FriendsSameCity;
        private FacebookObjectCollection<User> m_FriendsDate;
        private string m_OlderFriendsCount;
        private string m_YoungerFriendsCount;

        public CachingFriendsHandler(User i_User)
        {

            r_FriendsHandlerLogic = new FacebookFriendsHandlerLogic(i_User);
        }

        public FacebookObjectCollection<User> ExtractFriendsByCity()
        {
            return getAndUpdateCacheData<User>(ref m_LastTimeUpdateFriendsCaching,
                r_FriendsHandlerLogic.ExtractFriendsByCity,
                ref m_FriendsSameCity);
        }
        public FacebookObjectCollection<User> ExtractFriendsByBirthDate()
        {
            return getAndUpdateCacheData<User>(ref m_LastTimeUpdateFriendsCaching,
           r_FriendsHandlerLogic.ExtractFriendsByBirthDate,
           ref m_FriendsDate);
        }


        private FacebookObjectCollection<T> getAndUpdateCacheData<T>(ref DateTime i_IoLastCachingDate,
                                                             FacebookFriendsHandlerDelegate<T> i_FacebookFriendsDelegate,
                                                             ref FacebookObjectCollection<T> i_IoCachedData)
        {
            // check first use or if we have the most updated data:
            if (i_IoCachedData == null || i_IoLastCachingDate < r_FriendsHandlerLogic.LastTimeUpdateDate())
            {
                i_IoCachedData = i_FacebookFriendsDelegate();
            }

            // update the last caching date:
            m_LastTimeUpdateFriendsCaching = DateTime.Now;

            return i_IoCachedData;
        }

        private string getAndUpdateCacheDataString(ref DateTime i_IoLastCachingDate,
                                                             FacebookFriendsHandlerStringDelegate i_FacebookFriendsDelegate,
                                                             ref string i_IoCachedData)
        {
            string returnedData = String.Empty;
            // check first use or if we have the most updated data:
            if (i_IoCachedData == null || i_IoLastCachingDate < r_FriendsHandlerLogic.LastTimeUpdateDate())
            {
                returnedData = i_FacebookFriendsDelegate(ref i_IoCachedData);
            }

            // update the last caching date:
            m_LastTimeUpdateFriendsCaching = DateTime.Now;

            return returnedData;
        }

        public string FetchFriendsAgeCounts(ref string i_IoCachedData)
        {
            return getAndUpdateCacheDataString(ref m_LastTimeUpdateFriendsCaching,
           r_FriendsHandlerLogic.FetchFriendsAgeCounts,
           ref i_IoCachedData);
        }

        public string DisplayGeneralInformation(ref string i_AmountOfYoungerFriendsCount)
        {
            //r_FriendsHandlerLogic.BirthdayCheckingStrategy = new CheckOlderFriendsStrategy();
            m_OlderFriendsCount = FetchFriendsAgeCounts(ref i_AmountOfYoungerFriendsCount);
            //r_FriendsHandlerLogic.BirthdayCheckingStrategy = new CheckYoungerFriendsStrategy();
            //i_AmountOfYoungerFriendsCount = FetchFriendsAgeCounts(ref m_YoungerFriendsCount);
            return m_OlderFriendsCount;
        }
    }
}
