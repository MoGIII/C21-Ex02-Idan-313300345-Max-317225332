namespace BasicFacebookFeatures
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using FacebookWrapper;
    using FacebookWrapper.ObjectModel;

    public partial class FormMain : Form
    {
        //private readonly FacebookConnectionManger r_Connection;
        private List<Label> m_ComponentToVisible = new List<Label>();
        private FacebookApiFacade m_FacebookFacade;

        public FormMain()
        {
            m_FacebookFacade = new FacebookApiFacade();
            InitializeComponent();
            FacebookService.s_CollectionLimit = 100;
            addedComponentToListVisible();
        }

        public void FetchInitialData()
        {
            string profilePictureUrl = m_FacebookFacade.GetUserInformation<string>("PictureNormalURL");
            // User profile picture:
            pictureBoxProfilePhoto.LoadAsync(profilePictureUrl);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInitApp();
        }

        private void addedComponentToListVisible()
        {
            m_ComponentToVisible.Add(labelWelcome);
            m_ComponentToVisible.Add(labelNameOfUser);
            m_ComponentToVisible.Add(labelBirthday);
            m_ComponentToVisible.Add(labelBirthdayLab);
            m_ComponentToVisible.Add(labelEmail);
            m_ComponentToVisible.Add(labelEmailLab);
        }

        private void loginAndInitApp()
        {
            try
            {
                m_FacebookFacade.Login();
                labelNameOfUser.Text =
                    m_FacebookFacade.GetUserInformation<string>("Name");
                labelEmail.Text = m_FacebookFacade.GetUserInformation<string>("Email");
                labelBirthday.Text = m_FacebookFacade.GetUserInformation<string>("Birthday");
                changeLabelVisible(m_ComponentToVisible, true);
                FetchInitialData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void changeLabelVisible(List<Label> i_Labels, bool i_IsNeedToBeVisible)
        {
            foreach(Label labelToVisible in i_Labels)
            {
                labelToVisible.Visible = i_IsNeedToBeVisible;
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            logoutUser();
        }

        private void logoutUser()
        {
            try
            {
                m_FacebookFacade.Logout();
                buttonLogin.Text = "Login";
                labelNameOfUser.Text = string.Empty;
                changeLabelVisible(m_ComponentToVisible, false);
                this.Controls.Clear();
                this.InitializeComponent();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void buttonFetchEvents_Click(object sender, EventArgs e)
        {
            fetchFromUserData<Event>(listBoxOfEvents, "Events");
        }

        private void buttonFetchGroups_Click(object sender, EventArgs e)
        {
            fetchFromUserData<Group>(listBoxOfGroups, "Groups");
        }

        private void fetchPosts()
        {
            if(r_Connection.IsUserLoggedIn())
            {
                listBoxOfPosts.Items.Clear();

                foreach(Post post in r_Connection.LoggedInUser.Posts)
                {
                    if(post.Message != null)
                    {
                        listBoxOfPosts.Items.Add(post.Message);
                    }
                    else if(post.Caption != null)
                    {
                        listBoxOfPosts.Items.Add(post.Caption);
                    }
                    else
                    {
                        listBoxOfPosts.Items.Add(string.Format("[{0}]", post.Type));
                    }
                }

                if(listBoxOfPosts.Items.Count == 0)
                {
                    MessageBox.Show("No Posts to retrieve :(");
                }
            }
            else
            {
                MessageBox.Show("You need to connect to show the information");
            }
        }

        private void buttonFetchAlbum_Click(object sender, EventArgs e)
        {
            fetchFromUserData<Album>(listBoxOfAlbum, "Albums");
        }

        private void buttonFetchPost_Click(object sender, EventArgs e)
        {
            fetchPosts();
        }

        private void ButtonCreatePost_Click(object sender, EventArgs e)
        {
            createPost();
        }

        private void createPost()
        {
            string postText = textBoxPostToCreate.Text;
            if(!string.IsNullOrEmpty(postText) && r_Connection.IsUserLoggedIn())
            {
                try
                {
                    Status postedStatus = r_Connection.LoggedInUser.PostStatus(postText);
                    MessageBox.Show("Your Post has been uploaded", "Post Uploaded successful");
                    fetchPosts();
                }
                catch (Exception e)
                {
                    MessageBox.Show(string.Format("Cannot upload Post!! {0} " ,e), "Error!");
                }
                finally
                {
                    textBoxPostToCreate.Clear();
                }
            }
        }

        private void ButtonFetchFriends_Click(object sender, EventArgs e)
        {
            fetchFromUserData<User>(listBoxOfFriends, "Friends");
        }

        private void ButtonPhotosFilter_Click(object sender, EventArgs e)
        {
            FacebookObjectCollection<Photo> userPhotos = null;
            pictureBoxOfUserPhoto.Image = null;
            labelDateOfPhoto.Text = string.Empty;
            labelNameOfAlbum.Text = string.Empty;
            labelLocation.Text = string.Empty;
            if(r_Connection.IsUserLoggedIn() == true)
            {
                try
                {
                    FacebookObjectCollection<Album> userAlbums = r_Connection.LoggedInUser.Albums;
                    if (radioButtonShowAllPhotos.Checked)
                    {
                        userPhotos = FacebookPhotosHandlerLogic.ExtractPhotosFromAlbum(userAlbums);
                    }
                    else if(radioButtonFilterByDate.Checked)
                    {
                        userPhotos = FacebookPhotosHandlerLogic.FilterPhotoByDate(userAlbums, dateTimePickerStartDate.Value, dateTimePickerEndDate.Value);
                    }
                    else if(radioButtonFilterByLocation.Checked)
                    {
                        userPhotos = FacebookPhotosHandlerLogic.FilterPhotoByLocation(userAlbums, textBoxLocation.Text);
                    }
                    else
                    {
                        throw new Exception("You need to choose one of options");
                    }

                    fetchListBox<Photo>(listBoxOfPhotos, userPhotos);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("You need to login to see the information");
            }
        }

        private void radioButtonFilterByLocation_CheckedChanged(object sender, EventArgs e)
        {
            textBoxLocation.Enabled = !textBoxLocation.Enabled;
        }

        private void radioButtonFilterByDate_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerStartDate.Enabled = !dateTimePickerStartDate.Enabled;
            dateTimePickerEndDate.Enabled = !dateTimePickerEndDate.Enabled;
        }

        private void ListBoxOfPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Photo currentPhoto = listBoxOfPhotos.SelectedItem as Photo;

            if(currentPhoto != null)
            {
                labelNameOfAlbum.Text = currentPhoto.Album.Name;
                labelDateOfPhoto.Text = currentPhoto.CreatedTime.ToString();
                if(currentPhoto.Place != null)
                {
                    labelLocation.Text = currentPhoto.Place.Name;
                }
                else
                {
                    labelLocation.Text = string.Empty;
                }

                pictureBoxOfUserPhoto.LoadAsync(currentPhoto.PictureNormalURL);
            }
        }

        private void fetchListBox<T>(ListBox i_ListBoxToFetch, FacebookObjectCollection<T> i_DataToInsert)
        {
            i_ListBoxToFetch.Items.Clear();
            if(i_DataToInsert.Count > 0)
            {
                foreach(T itemInCollection in i_DataToInsert)
                {
                    i_ListBoxToFetch.DisplayMember = itemInCollection is Photo ? "createdTime" : "Name";
                    i_ListBoxToFetch.Items.Add(itemInCollection);
                }
            }
            else
            {
                string listType = i_ListBoxToFetch.Name;
                listType = listType.Replace("listBoxOf", string.Empty);
                string noDataExistInObjectTypeMsg = string.Format("No {0} to retrieve :(", listType);
                MessageBox.Show(noDataExistInObjectTypeMsg);
            }
        }

        private void fetchFromUserData<T>(ListBox i_ListBoxToFetch, string i_PropertyName)
        {
            if(r_Connection.IsUserLoggedIn())
            {
                try
                {
                    FacebookObjectCollection<T> dataToInsertDetails = (FacebookObjectCollection<T>)r_Connection.LoggedInUser.GetType()
                        .GetProperty(i_PropertyName).GetValue(r_Connection.LoggedInUser, null);

                    fetchListBox<T>(i_ListBoxToFetch, dataToInsertDetails);
                }
                catch
                {
                    MessageBox.Show(string.Format("Error!, cannot access the {0} of the user."), i_PropertyName);
                }
            }
            else
            {
                MessageBox.Show("You need to connect to show the information");
            }
        }

        private void buttonCheckFriendsInfo_Click(object sender, EventArgs e)
        {
            if (r_Connection.IsUserLoggedIn())
            {
                string amountOfOlderFriends = FacebookFriendsHandlerLogic.DisplayGeneralInformation(r_Connection.LoggedInUser, out string amountOfYoungerFriends);
                FacebookObjectCollection<User> friendsBornOnTheSameDate =
                    FacebookFriendsHandlerLogic.ExtractFriendsByBirthDate(r_Connection.LoggedInUser);
                FacebookObjectCollection<User> friendsLiningInSameCity =
                    FacebookFriendsHandlerLogic.ExtractFriendsByCity(r_Connection.LoggedInUser);
                labelAmountOfOlderFriends.Text = amountOfOlderFriends;
                labelAmountOfYoungerFriends.Text = amountOfYoungerFriends;
                fetchListBox(listBoxOfFriendsLiveInSameCity, friendsLiningInSameCity);
                fetchListBox(listBoxOfFriendsBornOnSameDate, friendsBornOnTheSameDate);
            }
            else
            {
                MessageBox.Show("You need to connect to show the information");
            }
        }

        private void buttonFetchLikedPages_Click(object sender, EventArgs e)
        {
            fetchFromUserData<Page>(listBoxOfPagesLiked, "LikedPages");
        }
    }
}
