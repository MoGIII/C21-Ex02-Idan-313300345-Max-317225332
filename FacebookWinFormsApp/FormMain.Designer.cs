

namespace BasicFacebookFeatures
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true ifmanaged resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.listBoxOfEvents = new System.Windows.Forms.ListBox();
            this.buttonFetchEvents = new System.Windows.Forms.Button();
            this.buttonFetchGroups = new System.Windows.Forms.Button();
            this.listBoxOfGroups = new System.Windows.Forms.ListBox();
            this.listBoxOfAlbum = new System.Windows.Forms.ListBox();
            this.buttonFetchAlbum = new System.Windows.Forms.Button();
            this.listBoxOfPosts = new System.Windows.Forms.ListBox();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonFetchPost = new System.Windows.Forms.Button();
            this.pictureBoxProfilePhoto = new System.Windows.Forms.PictureBox();
            this.textBoxPostToCreate = new System.Windows.Forms.TextBox();
            this.ButtonCreatePost = new System.Windows.Forms.Button();
            this.LabelPostTitle = new System.Windows.Forms.Label();
            this.listBoxOfFriends = new System.Windows.Forms.ListBox();
            this.ButtonFetchFriends = new System.Windows.Forms.Button();
            this.TabControlProfile = new System.Windows.Forms.TabControl();
            this.tabPageProfile = new System.Windows.Forms.TabPage();
            this.buttonFetchLikedPages = new System.Windows.Forms.Button();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelBirthdayLab = new System.Windows.Forms.Label();
            this.labelEmailLab = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelNameOfUser = new System.Windows.Forms.Label();
            this.listBoxOfPagesLiked = new System.Windows.Forms.ListBox();
            this.tabPagePhotos = new System.Windows.Forms.TabPage();
            this.groupBoxPhotoInfo = new System.Windows.Forms.GroupBox();
            this.labelLocation = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDateOfPhoto = new System.Windows.Forms.Label();
            this.labelNameOfAlbum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxOfUserPhoto = new System.Windows.Forms.PictureBox();
            this.listBoxOfPhotos = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.radioButtonShowAllPhotos = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.radioButtonFilterByLocation = new System.Windows.Forms.RadioButton();
            this.ButtonPhotosFilter = new System.Windows.Forms.Button();
            this.radioButtonFilterByDate = new System.Windows.Forms.RadioButton();
            this.tabPageFriends = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBoxOfFriendsLiveInSameCity = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBoxOfFriendsBornOnSameDate = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCheckFriendsInfo = new System.Windows.Forms.Button();
            this.labelAmountOfOlderFriends = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelAmountOfYoungerFriends = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listBoxOfFriendsInSameCity = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePhoto)).BeginInit();
            this.TabControlProfile.SuspendLayout();
            this.tabPageProfile.SuspendLayout();
            this.tabPagePhotos.SuspendLayout();
            this.groupBoxPhotoInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOfUserPhoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPageFriends.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogin.Image")));
            this.buttonLogin.Location = new System.Drawing.Point(4, 31);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(288, 75);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogout.Image")));
            this.buttonLogout.Location = new System.Drawing.Point(8, 132);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(288, 75);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // listBoxOfEvents
            // 
            this.listBoxOfEvents.FormattingEnabled = true;
            this.listBoxOfEvents.ItemHeight = 23;
            this.listBoxOfEvents.Location = new System.Drawing.Point(63, 455);
            this.listBoxOfEvents.Name = "listBoxOfEvents";
            this.listBoxOfEvents.Size = new System.Drawing.Size(268, 165);
            this.listBoxOfEvents.TabIndex = 53;
            // 
            // buttonFetchEvents
            // 
            this.buttonFetchEvents.BackColor = System.Drawing.Color.Wheat;
            this.buttonFetchEvents.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonFetchEvents.ImageIndex = 0;
            this.buttonFetchEvents.Location = new System.Drawing.Point(84, 360);
            this.buttonFetchEvents.Name = "buttonFetchEvents";
            this.buttonFetchEvents.Size = new System.Drawing.Size(236, 68);
            this.buttonFetchEvents.TabIndex = 54;
            this.buttonFetchEvents.Text = "Fetch Events";
            this.buttonFetchEvents.UseVisualStyleBackColor = false;
            this.buttonFetchEvents.Click += new System.EventHandler(this.buttonFetchEvents_Click);
            // 
            // buttonFetchGroups
            // 
            this.buttonFetchGroups.BackColor = System.Drawing.Color.Wheat;
            this.buttonFetchGroups.Location = new System.Drawing.Point(526, 360);
            this.buttonFetchGroups.Name = "buttonFetchGroups";
            this.buttonFetchGroups.Size = new System.Drawing.Size(236, 68);
            this.buttonFetchGroups.TabIndex = 55;
            this.buttonFetchGroups.Text = "Fetch Groups";
            this.buttonFetchGroups.UseVisualStyleBackColor = false;
            this.buttonFetchGroups.Click += new System.EventHandler(this.buttonFetchGroups_Click);
            // 
            // listBoxOfGroups
            // 
            this.listBoxOfGroups.FormattingEnabled = true;
            this.listBoxOfGroups.ItemHeight = 23;
            this.listBoxOfGroups.Location = new System.Drawing.Point(510, 455);
            this.listBoxOfGroups.Name = "listBoxOfGroups";
            this.listBoxOfGroups.Size = new System.Drawing.Size(268, 165);
            this.listBoxOfGroups.TabIndex = 56;
            // 
            // listBoxOfAlbum
            // 
            this.listBoxOfAlbum.FormattingEnabled = true;
            this.listBoxOfAlbum.ItemHeight = 23;
            this.listBoxOfAlbum.Location = new System.Drawing.Point(909, 754);
            this.listBoxOfAlbum.Name = "listBoxOfAlbum";
            this.listBoxOfAlbum.Size = new System.Drawing.Size(268, 165);
            this.listBoxOfAlbum.TabIndex = 57;
            // 
            // buttonFetchAlbum
            // 
            this.buttonFetchAlbum.BackColor = System.Drawing.Color.Wheat;
            this.buttonFetchAlbum.Location = new System.Drawing.Point(924, 662);
            this.buttonFetchAlbum.Name = "buttonFetchAlbum";
            this.buttonFetchAlbum.Size = new System.Drawing.Size(236, 68);
            this.buttonFetchAlbum.TabIndex = 58;
            this.buttonFetchAlbum.Text = "Fetch Album";
            this.buttonFetchAlbum.UseVisualStyleBackColor = false;
            this.buttonFetchAlbum.Click += new System.EventHandler(this.buttonFetchAlbum_Click);
            // 
            // listBoxOfPosts
            // 
            this.listBoxOfPosts.DataSource = this.postBindingSource;
            this.listBoxOfPosts.DisplayMember = "Type";
            this.listBoxOfPosts.FormattingEnabled = true;
            this.listBoxOfPosts.ItemHeight = 23;
            this.listBoxOfPosts.Location = new System.Drawing.Point(63, 754);
            this.listBoxOfPosts.Name = "listBoxOfPosts";
            this.listBoxOfPosts.Size = new System.Drawing.Size(268, 165);
            this.listBoxOfPosts.TabIndex = 59;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // buttonFetchPost
            // 
            this.buttonFetchPost.BackColor = System.Drawing.Color.Wheat;
            this.buttonFetchPost.Location = new System.Drawing.Point(84, 662);
            this.buttonFetchPost.Name = "buttonFetchPost";
            this.buttonFetchPost.Size = new System.Drawing.Size(236, 68);
            this.buttonFetchPost.TabIndex = 60;
            this.buttonFetchPost.Text = "Fetch Post";
            this.buttonFetchPost.UseVisualStyleBackColor = false;
            this.buttonFetchPost.Click += new System.EventHandler(this.buttonFetchPost_Click);
            // 
            // pictureBoxProfilePhoto
            // 
            this.pictureBoxProfilePhoto.Location = new System.Drawing.Point(321, 31);
            this.pictureBoxProfilePhoto.Name = "pictureBoxProfilePhoto";
            this.pictureBoxProfilePhoto.Size = new System.Drawing.Size(202, 177);
            this.pictureBoxProfilePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfilePhoto.TabIndex = 61;
            this.pictureBoxProfilePhoto.TabStop = false;
            // 
            // textBoxPostToCreate
            // 
            this.textBoxPostToCreate.Location = new System.Drawing.Point(63, 269);
            this.textBoxPostToCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPostToCreate.Name = "textBoxPostToCreate";
            this.textBoxPostToCreate.Size = new System.Drawing.Size(882, 31);
            this.textBoxPostToCreate.TabIndex = 62;
            // 
            // ButtonCreatePost
            // 
            this.ButtonCreatePost.BackColor = System.Drawing.Color.Wheat;
            this.ButtonCreatePost.Location = new System.Drawing.Point(972, 269);
            this.ButtonCreatePost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonCreatePost.Name = "ButtonCreatePost";
            this.ButtonCreatePost.Size = new System.Drawing.Size(188, 48);
            this.ButtonCreatePost.TabIndex = 63;
            this.ButtonCreatePost.Text = "Post";
            this.ButtonCreatePost.UseVisualStyleBackColor = false;
            this.ButtonCreatePost.Click += new System.EventHandler(this.ButtonCreatePost_Click);
            // 
            // LabelPostTitle
            // 
            this.LabelPostTitle.AutoSize = true;
            this.LabelPostTitle.ForeColor = System.Drawing.Color.DarkOrange;
            this.LabelPostTitle.Location = new System.Drawing.Point(63, 228);
            this.LabelPostTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPostTitle.Name = "LabelPostTitle";
            this.LabelPostTitle.Size = new System.Drawing.Size(180, 23);
            this.LabelPostTitle.TabIndex = 64;
            this.LabelPostTitle.Text = "What\'s on your mind?";
            // 
            // listBoxOfFriends
            // 
            this.listBoxOfFriends.FormattingEnabled = true;
            this.listBoxOfFriends.ItemHeight = 23;
            this.listBoxOfFriends.Location = new System.Drawing.Point(904, 455);
            this.listBoxOfFriends.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxOfFriends.Name = "listBoxOfFriends";
            this.listBoxOfFriends.Size = new System.Drawing.Size(268, 165);
            this.listBoxOfFriends.TabIndex = 65;
            // 
            // ButtonFetchFriends
            // 
            this.ButtonFetchFriends.BackColor = System.Drawing.Color.Wheat;
            this.ButtonFetchFriends.Location = new System.Drawing.Point(924, 360);
            this.ButtonFetchFriends.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonFetchFriends.Name = "ButtonFetchFriends";
            this.ButtonFetchFriends.Size = new System.Drawing.Size(236, 68);
            this.ButtonFetchFriends.TabIndex = 66;
            this.ButtonFetchFriends.Text = "Fetch Friends";
            this.ButtonFetchFriends.UseVisualStyleBackColor = false;
            this.ButtonFetchFriends.Click += new System.EventHandler(this.ButtonFetchFriends_Click);
            // 
            // TabControlProfile
            // 
            this.TabControlProfile.Controls.Add(this.tabPageProfile);
            this.TabControlProfile.Controls.Add(this.tabPagePhotos);
            this.TabControlProfile.Controls.Add(this.tabPageFriends);
            this.TabControlProfile.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControlProfile.ImageList = this.imageList1;
            this.TabControlProfile.Location = new System.Drawing.Point(4, 3);
            this.TabControlProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabControlProfile.Name = "TabControlProfile";
            this.TabControlProfile.SelectedIndex = 0;
            this.TabControlProfile.Size = new System.Drawing.Size(1252, 1011);
            this.TabControlProfile.TabIndex = 67;
            // 
            // tabPageProfile
            // 
            this.tabPageProfile.AutoScroll = true;
            this.tabPageProfile.BackColor = System.Drawing.Color.Beige;
            this.tabPageProfile.Controls.Add(this.buttonFetchLikedPages);
            this.tabPageProfile.Controls.Add(this.labelBirthday);
            this.tabPageProfile.Controls.Add(this.labelBirthdayLab);
            this.tabPageProfile.Controls.Add(this.labelEmailLab);
            this.tabPageProfile.Controls.Add(this.labelEmail);
            this.tabPageProfile.Controls.Add(this.labelWelcome);
            this.tabPageProfile.Controls.Add(this.labelNameOfUser);
            this.tabPageProfile.Controls.Add(this.listBoxOfPagesLiked);
            this.tabPageProfile.Controls.Add(this.buttonLogin);
            this.tabPageProfile.Controls.Add(this.listBoxOfFriends);
            this.tabPageProfile.Controls.Add(this.ButtonFetchFriends);
            this.tabPageProfile.Controls.Add(this.buttonLogout);
            this.tabPageProfile.Controls.Add(this.pictureBoxProfilePhoto);
            this.tabPageProfile.Controls.Add(this.listBoxOfEvents);
            this.tabPageProfile.Controls.Add(this.listBoxOfPosts);
            this.tabPageProfile.Controls.Add(this.buttonFetchPost);
            this.tabPageProfile.Controls.Add(this.textBoxPostToCreate);
            this.tabPageProfile.Controls.Add(this.ButtonCreatePost);
            this.tabPageProfile.Controls.Add(this.listBoxOfAlbum);
            this.tabPageProfile.Controls.Add(this.buttonFetchAlbum);
            this.tabPageProfile.Controls.Add(this.LabelPostTitle);
            this.tabPageProfile.Controls.Add(this.buttonFetchEvents);
            this.tabPageProfile.Controls.Add(this.buttonFetchGroups);
            this.tabPageProfile.Controls.Add(this.listBoxOfGroups);
            this.tabPageProfile.ImageIndex = 1;
            this.tabPageProfile.Location = new System.Drawing.Point(4, 32);
            this.tabPageProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageProfile.Name = "tabPageProfile";
            this.tabPageProfile.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageProfile.Size = new System.Drawing.Size(1244, 975);
            this.tabPageProfile.TabIndex = 0;
            this.tabPageProfile.Text = "Profile Info";
            // 
            // buttonFetchLikedPages
            // 
            this.buttonFetchLikedPages.BackColor = System.Drawing.Color.Wheat;
            this.buttonFetchLikedPages.Location = new System.Drawing.Point(526, 662);
            this.buttonFetchLikedPages.Name = "buttonFetchLikedPages";
            this.buttonFetchLikedPages.Size = new System.Drawing.Size(236, 68);
            this.buttonFetchLikedPages.TabIndex = 74;
            this.buttonFetchLikedPages.Text = "Fetch Liked Pages";
            this.buttonFetchLikedPages.UseVisualStyleBackColor = false;
            this.buttonFetchLikedPages.Click += new System.EventHandler(this.buttonFetchLikedPages_Click);
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(682, 172);
            this.labelBirthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(132, 23);
            this.labelBirthday.TabIndex = 73;
            this.labelBirthday.Text = "[BirthdayName]";
            this.labelBirthday.Visible = false;
            // 
            // labelBirthdayLab
            // 
            this.labelBirthdayLab.AutoSize = true;
            this.labelBirthdayLab.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelBirthdayLab.Location = new System.Drawing.Point(554, 172);
            this.labelBirthdayLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBirthdayLab.Name = "labelBirthdayLab";
            this.labelBirthdayLab.Size = new System.Drawing.Size(80, 23);
            this.labelBirthdayLab.TabIndex = 72;
            this.labelBirthdayLab.Text = "Birthday:";
            this.labelBirthdayLab.Visible = false;
            // 
            // labelEmailLab
            // 
            this.labelEmailLab.AutoSize = true;
            this.labelEmailLab.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelEmailLab.Location = new System.Drawing.Point(554, 114);
            this.labelEmailLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmailLab.Name = "labelEmailLab";
            this.labelEmailLab.Size = new System.Drawing.Size(56, 23);
            this.labelEmailLab.TabIndex = 71;
            this.labelEmailLab.Text = "Email:";
            this.labelEmailLab.Visible = false;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(682, 114);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(108, 23);
            this.labelEmail.TabIndex = 70;
            this.labelEmail.Text = "[EmailName]";
            this.labelEmail.Visible = false;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelWelcome.Location = new System.Drawing.Point(549, 29);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(140, 39);
            this.labelWelcome.TabIndex = 69;
            this.labelWelcome.Text = "Welcome";
            this.labelWelcome.Visible = false;
            // 
            // labelNameOfUser
            // 
            this.labelNameOfUser.AutoSize = true;
            this.labelNameOfUser.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameOfUser.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelNameOfUser.Location = new System.Drawing.Point(768, 37);
            this.labelNameOfUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNameOfUser.Name = "labelNameOfUser";
            this.labelNameOfUser.Size = new System.Drawing.Size(84, 33);
            this.labelNameOfUser.TabIndex = 68;
            this.labelNameOfUser.Text = "[User]";
            this.labelNameOfUser.Visible = false;
            // 
            // listBoxOfPagesLiked
            // 
            this.listBoxOfPagesLiked.FormattingEnabled = true;
            this.listBoxOfPagesLiked.ItemHeight = 23;
            this.listBoxOfPagesLiked.Location = new System.Drawing.Point(510, 754);
            this.listBoxOfPagesLiked.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxOfPagesLiked.Name = "listBoxOfPagesLiked";
            this.listBoxOfPagesLiked.Size = new System.Drawing.Size(268, 165);
            this.listBoxOfPagesLiked.TabIndex = 67;
            // 
            // tabPagePhotos
            // 
            this.tabPagePhotos.BackColor = System.Drawing.Color.Beige;
            this.tabPagePhotos.Controls.Add(this.groupBoxPhotoInfo);
            this.tabPagePhotos.Controls.Add(this.pictureBoxOfUserPhoto);
            this.tabPagePhotos.Controls.Add(this.listBoxOfPhotos);
            this.tabPagePhotos.Controls.Add(this.groupBox1);
            this.tabPagePhotos.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPagePhotos.ImageIndex = 0;
            this.tabPagePhotos.Location = new System.Drawing.Point(4, 32);
            this.tabPagePhotos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPagePhotos.Name = "tabPagePhotos";
            this.tabPagePhotos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPagePhotos.Size = new System.Drawing.Size(1244, 975);
            this.tabPagePhotos.TabIndex = 1;
            this.tabPagePhotos.Text = "Photos";
            // 
            // groupBoxPhotoInfo
            // 
            this.groupBoxPhotoInfo.Controls.Add(this.labelLocation);
            this.groupBoxPhotoInfo.Controls.Add(this.label5);
            this.groupBoxPhotoInfo.Controls.Add(this.labelDateOfPhoto);
            this.groupBoxPhotoInfo.Controls.Add(this.labelNameOfAlbum);
            this.groupBoxPhotoInfo.Controls.Add(this.label4);
            this.groupBoxPhotoInfo.Controls.Add(this.label3);
            this.groupBoxPhotoInfo.Location = new System.Drawing.Point(686, 114);
            this.groupBoxPhotoInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxPhotoInfo.Name = "groupBoxPhotoInfo";
            this.groupBoxPhotoInfo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxPhotoInfo.Size = new System.Drawing.Size(546, 223);
            this.groupBoxPhotoInfo.TabIndex = 5;
            this.groupBoxPhotoInfo.TabStop = false;
            this.groupBoxPhotoInfo.Text = "Photo Info";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(190, 158);
            this.labelLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(0, 18);
            this.labelLocation.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Location:";
            // 
            // labelDateOfPhoto
            // 
            this.labelDateOfPhoto.AutoSize = true;
            this.labelDateOfPhoto.Location = new System.Drawing.Point(190, 100);
            this.labelDateOfPhoto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateOfPhoto.Name = "labelDateOfPhoto";
            this.labelDateOfPhoto.Size = new System.Drawing.Size(0, 18);
            this.labelDateOfPhoto.TabIndex = 5;
            // 
            // labelNameOfAlbum
            // 
            this.labelNameOfAlbum.AutoSize = true;
            this.labelNameOfAlbum.Location = new System.Drawing.Point(190, 43);
            this.labelNameOfAlbum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNameOfAlbum.Name = "labelNameOfAlbum";
            this.labelNameOfAlbum.Size = new System.Drawing.Size(0, 18);
            this.labelNameOfAlbum.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Date of photo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name of album:";
            // 
            // pictureBoxOfUserPhoto
            // 
            this.pictureBoxOfUserPhoto.Location = new System.Drawing.Point(686, 369);
            this.pictureBoxOfUserPhoto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxOfUserPhoto.Name = "pictureBoxOfUserPhoto";
            this.pictureBoxOfUserPhoto.Size = new System.Drawing.Size(549, 526);
            this.pictureBoxOfUserPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOfUserPhoto.TabIndex = 3;
            this.pictureBoxOfUserPhoto.TabStop = false;
            // 
            // listBoxOfPhotos
            // 
            this.listBoxOfPhotos.FormattingEnabled = true;
            this.listBoxOfPhotos.ItemHeight = 18;
            this.listBoxOfPhotos.Location = new System.Drawing.Point(10, 114);
            this.listBoxOfPhotos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxOfPhotos.Name = "listBoxOfPhotos";
            this.listBoxOfPhotos.Size = new System.Drawing.Size(664, 778);
            this.listBoxOfPhotos.TabIndex = 2;
            this.listBoxOfPhotos.SelectedIndexChanged += new System.EventHandler(this.ListBoxOfPhotos_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxLocation);
            this.groupBox1.Controls.Add(this.radioButtonShowAllPhotos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePickerEndDate);
            this.groupBox1.Controls.Add(this.dateTimePickerStartDate);
            this.groupBox1.Controls.Add(this.radioButtonFilterByLocation);
            this.groupBox1.Controls.Add(this.ButtonPhotosFilter);
            this.groupBox1.Controls.Add(this.radioButtonFilterByDate);
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1222, 95);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Enabled = false;
            this.textBoxLocation.Location = new System.Drawing.Point(753, 32);
            this.textBoxLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(158, 26);
            this.textBoxLocation.TabIndex = 10;
            // 
            // radioButtonShowAllPhotos
            // 
            this.radioButtonShowAllPhotos.AutoSize = true;
            this.radioButtonShowAllPhotos.Location = new System.Drawing.Point(922, 38);
            this.radioButtonShowAllPhotos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonShowAllPhotos.Name = "radioButtonShowAllPhotos";
            this.radioButtonShowAllPhotos.Size = new System.Drawing.Size(80, 22);
            this.radioButtonShowAllPhotos.TabIndex = 9;
            this.radioButtonShowAllPhotos.TabStop = true;
            this.radioButtonShowAllPhotos.Text = "Show All";
            this.radioButtonShowAllPhotos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "to:";
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Enabled = false;
            this.dateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(388, 34);
            this.dateTimePickerEndDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(151, 26);
            this.dateTimePickerEndDate.TabIndex = 6;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Enabled = false;
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(184, 34);
            this.dateTimePickerStartDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(146, 26);
            this.dateTimePickerStartDate.TabIndex = 5;
            this.dateTimePickerStartDate.Value = new System.DateTime(2021, 7, 17, 0, 0, 0, 0);
            // 
            // radioButtonFilterByLocation
            // 
            this.radioButtonFilterByLocation.AutoSize = true;
            this.radioButtonFilterByLocation.Location = new System.Drawing.Point(550, 34);
            this.radioButtonFilterByLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonFilterByLocation.Name = "radioButtonFilterByLocation";
            this.radioButtonFilterByLocation.Size = new System.Drawing.Size(129, 22);
            this.radioButtonFilterByLocation.TabIndex = 3;
            this.radioButtonFilterByLocation.TabStop = true;
            this.radioButtonFilterByLocation.Text = "Filter by location";
            this.radioButtonFilterByLocation.UseVisualStyleBackColor = true;
            this.radioButtonFilterByLocation.CheckedChanged += new System.EventHandler(this.radioButtonFilterByLocation_CheckedChanged);
            // 
            // ButtonPhotosFilter
            // 
            this.ButtonPhotosFilter.Location = new System.Drawing.Point(1052, 34);
            this.ButtonPhotosFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonPhotosFilter.Name = "ButtonPhotosFilter";
            this.ButtonPhotosFilter.Size = new System.Drawing.Size(147, 45);
            this.ButtonPhotosFilter.TabIndex = 3;
            this.ButtonPhotosFilter.Text = "Filter";
            this.ButtonPhotosFilter.UseVisualStyleBackColor = true;
            this.ButtonPhotosFilter.Click += new System.EventHandler(this.ButtonPhotosFilter_Click);
            // 
            // radioButtonFilterByDate
            // 
            this.radioButtonFilterByDate.AutoSize = true;
            this.radioButtonFilterByDate.Location = new System.Drawing.Point(8, 38);
            this.radioButtonFilterByDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonFilterByDate.Name = "radioButtonFilterByDate";
            this.radioButtonFilterByDate.Size = new System.Drawing.Size(112, 22);
            this.radioButtonFilterByDate.TabIndex = 2;
            this.radioButtonFilterByDate.TabStop = true;
            this.radioButtonFilterByDate.Text = "Filter by date:";
            this.radioButtonFilterByDate.UseVisualStyleBackColor = true;
            this.radioButtonFilterByDate.CheckedChanged += new System.EventHandler(this.radioButtonFilterByDate_CheckedChanged);
            // 
            // tabPageFriends
            // 
            this.tabPageFriends.BackColor = System.Drawing.Color.Beige;
            this.tabPageFriends.Controls.Add(this.groupBox4);
            this.tabPageFriends.Controls.Add(this.groupBox3);
            this.tabPageFriends.Controls.Add(this.groupBox2);
            this.tabPageFriends.ImageIndex = 2;
            this.tabPageFriends.Location = new System.Drawing.Point(4, 32);
            this.tabPageFriends.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageFriends.Name = "tabPageFriends";
            this.tabPageFriends.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageFriends.Size = new System.Drawing.Size(1244, 975);
            this.tabPageFriends.TabIndex = 2;
            this.tabPageFriends.Text = "Friends";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBoxOfFriendsLiveInSameCity);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.groupBox4.Location = new System.Drawing.Point(632, 111);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(598, 835);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Friends who live in the same city";
            // 
            // listBoxOfFriendsLiveInSameCity
            // 
            this.listBoxOfFriendsLiveInSameCity.FormattingEnabled = true;
            this.listBoxOfFriendsLiveInSameCity.ItemHeight = 18;
            this.listBoxOfFriendsLiveInSameCity.Location = new System.Drawing.Point(6, 48);
            this.listBoxOfFriendsLiveInSameCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxOfFriendsLiveInSameCity.Name = "listBoxOfFriendsLiveInSameCity";
            this.listBoxOfFriendsLiveInSameCity.Size = new System.Drawing.Size(589, 778);
            this.listBoxOfFriendsLiveInSameCity.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBoxOfFriendsBornOnSameDate);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.groupBox3.Location = new System.Drawing.Point(9, 111);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(608, 835);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Friends born on same date";
            // 
            // listBoxOfFriendsBornOnSameDate
            // 
            this.listBoxOfFriendsBornOnSameDate.FormattingEnabled = true;
            this.listBoxOfFriendsBornOnSameDate.ItemHeight = 18;
            this.listBoxOfFriendsBornOnSameDate.Location = new System.Drawing.Point(9, 45);
            this.listBoxOfFriendsBornOnSameDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxOfFriendsBornOnSameDate.Name = "listBoxOfFriendsBornOnSameDate";
            this.listBoxOfFriendsBornOnSameDate.Size = new System.Drawing.Size(588, 778);
            this.listBoxOfFriendsBornOnSameDate.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonCheckFriendsInfo);
            this.groupBox2.Controls.Add(this.labelAmountOfOlderFriends);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.labelAmountOfYoungerFriends);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.groupBox2.Location = new System.Drawing.Point(8, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1224, 97);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Friends Info";
            // 
            // buttonCheckFriendsInfo
            // 
            this.buttonCheckFriendsInfo.Location = new System.Drawing.Point(927, 38);
            this.buttonCheckFriendsInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCheckFriendsInfo.Name = "buttonCheckFriendsInfo";
            this.buttonCheckFriendsInfo.Size = new System.Drawing.Size(242, 37);
            this.buttonCheckFriendsInfo.TabIndex = 4;
            this.buttonCheckFriendsInfo.Text = "Check friends Info";
            this.buttonCheckFriendsInfo.UseVisualStyleBackColor = true;
            this.buttonCheckFriendsInfo.Click += new System.EventHandler(this.buttonCheckFriendsInfo_Click);
            // 
            // labelAmountOfOlderFriends
            // 
            this.labelAmountOfOlderFriends.AutoSize = true;
            this.labelAmountOfOlderFriends.Location = new System.Drawing.Point(812, 49);
            this.labelAmountOfOlderFriends.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAmountOfOlderFriends.Name = "labelAmountOfOlderFriends";
            this.labelAmountOfOlderFriends.Size = new System.Drawing.Size(15, 18);
            this.labelAmountOfOlderFriends.TabIndex = 3;
            this.labelAmountOfOlderFriends.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(476, 49);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Amount of friends older than you:";
            // 
            // labelAmountOfYoungerFriends
            // 
            this.labelAmountOfYoungerFriends.AutoSize = true;
            this.labelAmountOfYoungerFriends.Location = new System.Drawing.Point(372, 49);
            this.labelAmountOfYoungerFriends.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAmountOfYoungerFriends.Name = "labelAmountOfYoungerFriends";
            this.labelAmountOfYoungerFriends.Size = new System.Drawing.Size(15, 18);
            this.labelAmountOfYoungerFriends.TabIndex = 1;
            this.labelAmountOfYoungerFriends.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Amount of friends younger than you:";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Photos_Icon.png");
            this.imageList1.Images.SetKeyName(1, "Profile_Information_Icon.png");
            this.imageList1.Images.SetKeyName(2, "Friends_Icon.png");
            // 
            // listBoxOfFriendsInSameCity
            // 
            this.listBoxOfFriendsInSameCity.FormattingEnabled = true;
            this.listBoxOfFriendsInSameCity.ItemHeight = 18;
            this.listBoxOfFriendsInSameCity.Location = new System.Drawing.Point(6, 30);
            this.listBoxOfFriendsInSameCity.Name = "listBoxOfFriendsInSameCity";
            this.listBoxOfFriendsInSameCity.Size = new System.Drawing.Size(409, 508);
            this.listBoxOfFriendsInSameCity.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 1014);
            this.Controls.Add(this.TabControlProfile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook Application";
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePhoto)).EndInit();
            this.TabControlProfile.ResumeLayout(false);
            this.tabPageProfile.ResumeLayout(false);
            this.tabPageProfile.PerformLayout();
            this.tabPagePhotos.ResumeLayout(false);
            this.groupBoxPhotoInfo.ResumeLayout(false);
            this.groupBoxPhotoInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOfUserPhoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageFriends.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.ListBox listBoxOfEvents;
        private System.Windows.Forms.Button buttonFetchEvents;
        private System.Windows.Forms.Button buttonFetchGroups;
        private System.Windows.Forms.ListBox listBoxOfGroups;
        private System.Windows.Forms.ListBox listBoxOfAlbum;
        private System.Windows.Forms.Button buttonFetchAlbum;
        private System.Windows.Forms.ListBox listBoxOfPosts;
        private System.Windows.Forms.Button buttonFetchPost;
        private System.Windows.Forms.PictureBox pictureBoxProfilePhoto;
        private System.Windows.Forms.TextBox textBoxPostToCreate;
        private System.Windows.Forms.Button ButtonCreatePost;
        private System.Windows.Forms.Label LabelPostTitle;
        private System.Windows.Forms.ListBox listBoxOfFriends;
        private System.Windows.Forms.Button ButtonFetchFriends;
        private System.Windows.Forms.TabControl TabControlProfile;
        private System.Windows.Forms.TabPage tabPageProfile;
        private System.Windows.Forms.TabPage tabPagePhotos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonPhotosFilter;
        private System.Windows.Forms.RadioButton radioButtonFilterByLocation;
        private System.Windows.Forms.RadioButton radioButtonFilterByDate;
        private System.Windows.Forms.PictureBox pictureBoxOfUserPhoto;
        private System.Windows.Forms.ListBox listBoxOfPhotos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.RadioButton radioButtonShowAllPhotos;
        private System.Windows.Forms.GroupBox groupBoxPhotoInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDateOfPhoto;
        private System.Windows.Forms.Label labelNameOfAlbum;
        private System.Windows.Forms.ListBox listBoxOfPagesLiked;
        private System.Windows.Forms.Label labelNameOfUser;
        private System.Windows.Forms.TabPage tabPageFriends;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelBirthdayLab;
        private System.Windows.Forms.Label labelEmailLab;
        private System.Windows.Forms.ListBox listBoxOfFriendsInSameCity;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxOfFriendsBornOnSameDate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelAmountOfOlderFriends;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelAmountOfYoungerFriends;
        private System.Windows.Forms.Label label6;


        //private System.Windows.Forms.DateTimePicker dateTimePickerFromDate;
        //private System.Windows.Forms.RadioButton radioButtonFilterByDates;
        //private System.Windows.Forms.Label labelMostCommentsInSinglePost;
        //private System.Windows.Forms.Label labelMostLikesGivenToPost;
        //private System.Windows.Forms.Label labelTotalNumberOfPosts;
        //private System.Windows.Forms.Label label13;
        //private System.Windows.Forms.Label label12;
        //private System.Windows.Forms.Label label11;
        //private System.Windows.Forms.Label labelNumberOfComments;
        //private System.Windows.Forms.Label labelNumberOfLikes;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBoxOfFriendsLiveInSameCity;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Button buttonCheckFriendsInfo;
        private System.Windows.Forms.Button buttonFetchLikedPages;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.BindingSource postBindingSource;
    }
}

