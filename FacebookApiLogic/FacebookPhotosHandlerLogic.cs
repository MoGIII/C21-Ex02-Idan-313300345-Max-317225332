using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookApiLogic
{
    internal static class FacebookPhotosHandlerLogic
    {
        public static FacebookObjectCollection<Photo> ExtractPhotosFromAlbum(FacebookObjectCollection<Album> i_Albums)
        {
            FacebookObjectCollection<Photo> photosCollection = new FacebookObjectCollection<Photo>();

            foreach(Album album in i_Albums)
            {
                foreach(Photo photo in album.Photos)
                {
                    photosCollection.Add(photo);
                }
            }

            return photosCollection;
        }

        public static FacebookObjectCollection<Photo> FilterPhotoByDate(FacebookObjectCollection<Album> i_Albums, DateTime i_StartTime, DateTime i_EndTime)
        {
            FacebookObjectCollection<Photo> photoFilterByDate = new FacebookObjectCollection<Photo>();

            if(DateTime.Compare(i_StartTime, i_EndTime) > 0)
            {
                throw new ArgumentException("You Entering a start date is greater than an end date", "Please try again");
            }
            else
            {
                foreach(Album album in i_Albums)
                {
                    foreach(Photo photo in album.Photos)
                    {
                        if(photo.CreatedTime >= i_StartTime && photo.CreatedTime <= i_EndTime)
                        {
                            photoFilterByDate.Add(photo);
                        }
                    }
                }
            }

            return photoFilterByDate;
        }

        public static string RemoveSpecialChar(string i_StringToRemoveSpecialCharsFrom)
        {
            List<char> charToRemove = new List<char>() { '\u200E', '\u200F' };

            foreach(char c in charToRemove)
            {
                i_StringToRemoveSpecialCharsFrom = i_StringToRemoveSpecialCharsFrom.Replace(c.ToString(), string.Empty);
            }

            return i_StringToRemoveSpecialCharsFrom;
        }

        public static FacebookObjectCollection<Photo> FilterPhotoByLocation(FacebookObjectCollection<Album> i_Albums, string i_Location)
        {
            FacebookObjectCollection<Photo> photoFilterByLocation = new FacebookObjectCollection<Photo>();

            foreach(Album album in i_Albums)
            {
                foreach(Photo photo in album.Photos)
                {
                    if(photo.Place != null)
                    {
                        string namePlaceOfPhoto = photo.Place.Name;

                        string namePlaceAfterRemoveSpecialChar = RemoveSpecialChar(namePlaceOfPhoto);
                        if(namePlaceAfterRemoveSpecialChar == i_Location)
                        {
                            photoFilterByLocation.Add(photo);
                        }
                    }
                }
            }

            return photoFilterByLocation;
        }
    }
}
