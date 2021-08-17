using FacebookApiLogic;
using FacebookWrapper.ObjectModel;
using System;
using System.Globalization;

namespace BasicFacebookFeatures
{
    internal class CachingFriendsHandler : IFacebookFriendsHandler
    {
        private delegate FacebookObjectCollection<T> FacebookFriendsHandlerDelegate<T>();
        private delegate string FacebookFriendsHandlerStringDelegate(string inString);
        // caching dates:
        private DateTime m_LastTimeUpdateFriendsCaching;
        // real subject:
        private FacebookFriendsHandlerLogic m_FriendsHandlerLogic;
        // cache data:
        private FacebookObjectCollection<User> m_FriendsSameCity = null;
        private FacebookObjectCollection<User> m_FriendsDate = null;
        private string m_OlderFriendsCount;
        private string m_YongerFriendsCount;

        public CachingFriendsHandler(User i_User)
        {
            m_FriendsHandlerLogic = new FacebookFriendsHandlerLogic(i_User);
        }

        public FacebookObjectCollection<User> ExtractFriendsByCity()
        {
            return getAndUpdateCacheData<User>(ref m_LastTimeUpdateFriendsCaching,
                m_FriendsHandlerLogic.ExtractFriendsByCity,
                ref m_FriendsSameCity);
        }
        public FacebookObjectCollection<User> ExtractFriendsByBirthDate()
        {
            return getAndUpdateCacheData<User>(ref m_LastTimeUpdateFriendsCaching,
           m_FriendsHandlerLogic.ExtractFriendsByBirthDate,
           ref m_FriendsDate);
        }


        private FacebookObjectCollection<T> getAndUpdateCacheData<T>(ref DateTime io_LastCachingDate,
                                                             FacebookFriendsHandlerDelegate<T> i_FacebookFriendsDelegate,
                                                             ref FacebookObjectCollection<T> io_CachedData)
        {
            // check first use or if we have the most updated data:
            if (io_CachedData == null || io_LastCachingDate < m_FriendsHandlerLogic.LastTimeUpdateDate())
            {
                io_CachedData = i_FacebookFriendsDelegate();
            }

            // update the last caching date:
            m_LastTimeUpdateFriendsCaching = DateTime.Now;

            return io_CachedData;
        }

        private string getAndUpdateCacheDataString(ref DateTime io_LastCachingDate,
                                                             FacebookFriendsHandlerStringDelegate i_FacebookFriendsDelegate,
                                                             ref string io_CachedData)
        {
            // check first use or if we have the most updated data:
            if (io_CachedData == null || io_LastCachingDate < m_FriendsHandlerLogic.LastTimeUpdateDate())
            {
                io_CachedData = i_FacebookFriendsDelegate(io_CachedData);
            }

            // update the last caching date:
            m_LastTimeUpdateFriendsCaching = DateTime.Now;

            return io_CachedData;
        }

        public string fetchFriendsAgeCounts(string o_AmountOfYoungerFriendsCount)
        {
            return getAndUpdateCacheDataString(ref m_LastTimeUpdateFriendsCaching,
           m_FriendsHandlerLogic.fetchFriendsAgeCounts,
           ref m_YongerFriendsCount);
        }

        public string DisplayGeneralInformation(string o_AmountOfYoungerFriendsCount)
        {
            string amountOfOlderFriends = fetchFriendsAgeCounts(m_YongerFriendsCount);

            return amountOfOlderFriends;
        }
    }
}
