namespace BasicFacebookFeatures
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
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
            pictureBoxProfilePhoto.Invoke(new Action(() =>
            {
                pictureBoxProfilePhoto.LoadAsync(profilePictureUrl);
            }));
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void changeLabelVisible(List<Label> i_Labels, bool i_IsNeedToBeVisible)
        {
            foreach (Label labelToVisible in i_Labels)
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void buttonFetchEvents_Click(object sender, EventArgs e)
        {
            new Thread(() => inputUserInformation<Event>(listBoxOfEvents, "Events")).Start();
        }

        private void buttonFetchGroups_Click(object sender, EventArgs e)
        {
            new Thread(() => inputUserInformation<Group>(listBoxOfGroups, "Groups")).Start();
        }

        private void inputUserInformation<T>(ListBox i_ListBoxRequired, string i_TypeOfInformation)
        {
            FacebookObjectCollection<T> list;
            
            i_ListBoxRequired.Invoke(new Action(() => {
                    list = m_FacebookFacade.GetUserInformation<FacebookObjectCollection<T>>(i_TypeOfInformation);
                    fetchListBox<T>(i_ListBoxRequired, list); 
                }));
        }

        private void fetchDataBinding<T>(BindingSource o_BindingSourchToFill, ListBox i_ListBoxSource,
                                 FacebookObjectCollection<T> i_DataToInsert)
        {
            // check  cross-thread opertion:
            if (!i_ListBoxSource.InvokeRequired)
            {
                o_BindingSourchToFill.DataSource = i_DataToInsert;
            }
            else
            {
                i_ListBoxSource.Invoke(new Action(() => o_BindingSourchToFill.DataSource = i_DataToInsert));
            }
        }

        private void fetchPosts()
        {

            FacebookObjectCollection<Post> userPosts = m_FacebookFacade.GetUserInformation<FacebookObjectCollection<Post>>("Posts");

            listBoxOfPosts.Invoke(
                new Action(() => fetchDataBinding<Post>(postBindingSource, listBoxOfPosts, userPosts)));
        }

        private void buttonFetchAlbum_Click(object sender, EventArgs e)
        {
            new Thread(() => inputUserInformation<Album>(listBoxOfAlbum, "Albums")).Start();
        }

        private void buttonFetchPost_Click(object sender, EventArgs e)
        {
            new Thread(fetchPosts).Start();
        }

        private void ButtonCreatePost_Click(object sender, EventArgs e)
        {
            //createPost();
        }

        /*
        private void createPost()
        {
            string postText = textBoxPostToCreate.Text;
            if (!string.IsNullOrEmpty(postText) && r_Connection.IsUserLoggedIn())
            {
                try
                {
                    Status postedStatus = r_Connection.LoggedInUser.PostStatus(postText);
                    MessageBox.Show("Your Post has been uploaded", "Post Uploaded successful");
                    fetchPosts();
                }
                catch (Exception e)
                {
                    MessageBox.Show(string.Format("Cannot upload Post!! {0} ", e), "Error!");
                }
                finally
                {
                    textBoxPostToCreate.Clear();
                }
            }
        }
        */
        private void ButtonFetchFriends_Click(object sender, EventArgs e)
        {
            new Thread(() => inputUserInformation<User>(listBoxOfFriends, "Friends")).Start();
        }

        private void filterPhotoByChooise()
        {
            FacebookObjectCollection<Photo> userPhotos = null;
            pictureBoxOfUserPhoto.Image = null;
            labelDateOfPhoto.Text = string.Empty;
            labelNameOfAlbum.Text = string.Empty;
            labelLocation.Text = string.Empty;
            try
            {
                if (radioButtonShowAllPhotos.Checked)
                {

                    userPhotos = m_FacebookFacade.FilterAllPhotosFeature();
                }
                else if (radioButtonFilterByDate.Checked)
                {
                    userPhotos = m_FacebookFacade.FilterPhotosByDateFeature(dateTimePickerStartDate.Value, dateTimePickerEndDate.Value);
                }
                else if (radioButtonFilterByLocation.Checked)
                {
                    userPhotos = m_FacebookFacade.FilterPhotosByLocationFeature(textBoxLocation.Text);
                }
                else
                {
                    throw new Exception("You need to choose one of options");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            listBoxOfPhotos.Invoke(new Action(() => fetchListBox<Photo>(listBoxOfPhotos, userPhotos)));
        }

        private void ButtonPhotosFilter_Click(object sender, EventArgs e)
        {
            new Thread(filterPhotoByChooise).Start();
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

        private void buttonCheckFriendsInfo_Click(object sender, EventArgs e)
        {
            string amountOfYoungerFriends;
            string amountOfOlderFriends = m_FacebookFacade.amountOfOlderAndYoungerFriendsFeature(out amountOfYoungerFriends);
            FacebookObjectCollection<User> friendsBornOnTheSameDate =
                m_FacebookFacade.FriendsBornOnTheSameDateFeatue();
            FacebookObjectCollection<User> friendsLiningInSameCity =
                m_FacebookFacade.ExtractFriendsByCityFeatue();
            labelAmountOfOlderFriends.Text = amountOfOlderFriends;
            labelAmountOfYoungerFriends.Text = amountOfYoungerFriends;
            fetchListBox(listBoxOfFriendsLiveInSameCity, friendsLiningInSameCity);
            fetchListBox(listBoxOfFriendsBornOnSameDate, friendsBornOnTheSameDate);
        }

        private void buttonFetchLikedPages_Click(object sender, EventArgs e)
        {
            inputUserInformation<Page>(listBoxOfPagesLiked, "LikedPages");
        }
    }
}
