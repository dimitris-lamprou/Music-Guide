using Microsoft.IdentityModel.Tokens;
using Music_Guide.Models;
using Music_Guide.Data;

namespace Music_Guide
{
    public partial class MainForm : Form
    {
        User user = new();
        readonly Dictionary<string, string> moodDictionary = new();
        readonly MusicGuideContext db = new();
        readonly Random random = new();
        int timeInSeconds = 0;
        int timeInMinutes = 0;
        int timeInHours = 0;
        string hoursFactor = "";
        string minutesFactor = " : ";
        string secondsFactor = " : ";
        string mood = "Happy";

        public MainForm()
        {
            InitializeComponent();
        }

        private void login_help_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. If you are a new User, you can insert a username from 2 up to 30 characters\n" +
                            "   and a password from 4 up to 20 characters and then click sign up\n" +
                            "\n" +
                            "2. If you already created your account then you can insert your\n" +
                            "   username and your password and then click log in");
        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            var usersList = db.Users.Where(u => u.Name.Equals(username_textBox.Text));

            if (username_textBox.Text.IsNullOrEmpty() || password_textBox.Text.IsNullOrEmpty()            //----
                || password_textBox.Text.Length < 4 || username_textBox.Text.Length < 2
                || !usersList.IsNullOrEmpty()                                                                  // if there is a wrong
               )                                                                                          // input turn on the
            {                                                                                             // error label
                login_error_label.Visible = true;
            }

            if (username_textBox.Text.IsNullOrEmpty())
            {
                login_error_label.Text = "You did not enter a username";
            }
            else if (password_textBox.Text.IsNullOrEmpty())                                                // sign up check for
            {                                                                                              // wrong input
                login_error_label.Text = "You did not enter a password";
            }
            else if (username_textBox.Text.Length < 2)
            {
                login_error_label.Text = "You have to insert at least 2 characters in the username field";
            }
            else if (password_textBox.Text.Length < 4)
            {
                login_error_label.Text = "You have to insert at least 4 characters in the password field";
            }                                                                                              //----
            else if (!usersList.IsNullOrEmpty())                                                               // sign up check for
            {                                                                                              // same username
                login_error_label.Text = "This username is already taken. Try another one";
            }
            else                                                                                           // sign up starts here
            {
                User newUser = new()
                {
                    Id = Guid.NewGuid(),
                    Name = username_textBox.Text,
                    Password = password_textBox.Text,
                    NewUser = true
                };
                db.Add(newUser);
                db.SaveChanges();

                user = newUser;

                login_panel.Visible = false;
                question_panel.Visible = true;
                question_title_label.Visible = true;
            }
        }

        private void question_next_button_Click(object sender, EventArgs e)
        {
            if (!question_rock_checkBox.Checked && !question_metal_checkBox.Checked && !question_classical_checkBox.Checked &&
                !question_pop_checkBox.Checked && !question_electronic_checkBox.Checked && !question_disco_checkBox.Checked
               )
            {
                MessageBox.Show("You have to check at least 1 genre");
                return;
            }

            if (question_rock_checkBox.Checked)
            {
                //if there is a record of the user and the specific genre
                if (db.UserGenreInterfaces.Where(u => u.UserId == user.Id && u.GenreId ==
                db.Genres.Where(g => g.Genre1.Equals("Rock")).Select(g => g.Id).Single()).SingleOrDefault() != null)
                {
                    db.UserGenreInterfaces.Where(u => u.UserId == user.Id && u.GenreId ==
                        db.Genres.Where(g => g.Genre1.Equals("Rock")).Select(g => g.Id).Single()).SingleOrDefault().IsLiked = true;
                }
                else
                {
                    UserGenreInterface rockIsLiked = new()
                    {
                        UserId = user.Id,
                        GenreId = db.Genres.Where(g => g.Genre1.Equals("Rock")).Select(g => g.Id).Single(),
                        IsLiked = true
                    };
                    db.Add(rockIsLiked);
                }
            }
            else
            {
                //if there is a record of the user and the specific genre
                if (db.UserGenreInterfaces.Where(u => u.UserId == user.Id && u.GenreId ==
                db.Genres.Where(g => g.Genre1.Equals("Rock")).Select(g => g.Id).Single()).SingleOrDefault() != null)
                {
                    db.UserGenreInterfaces.Where(u => u.UserId == user.Id && u.GenreId ==
                        db.Genres.Where(g => g.Genre1.Equals("Rock")).Select(g => g.Id).Single()).SingleOrDefault().IsLiked = false;
                }
            }
            if (question_metal_checkBox.Checked)
            {
                //if there is a record of the user and the specific genre
                if (db.UserGenreInterfaces.Where(u => u.UserId == user.Id && u.GenreId ==
                db.Genres.Where(g => g.Genre1.Equals("Metal")).Select(g => g.Id).Single()).SingleOrDefault() != null)
                {
                    db.UserGenreInterfaces.Where(u => u.UserId == user.Id && u.GenreId ==
                        db.Genres.Where(g => g.Genre1.Equals("Metal")).Select(g => g.Id).Single()).SingleOrDefault().IsLiked = true;
                }
                else
                {
                    UserGenreInterface MetalIsLiked = new()
                    {
                        UserId = user.Id,
                        GenreId = db.Genres.Where(g => g.Genre1.Equals("Metal")).Select(g => g.Id).Single(),
                        IsLiked = true
                    };
                    db.Add(MetalIsLiked);
                }
            }
            else
            {
                //if there is a record of the user and the specific genre
                if (db.UserGenreInterfaces.Where(u => u.UserId == user.Id && u.GenreId ==
                db.Genres.Where(g => g.Genre1.Equals("Metal")).Select(g => g.Id).Single()).SingleOrDefault() != null)
                {
                    db.UserGenreInterfaces.Where(u => u.UserId == user.Id && u.GenreId ==
                        db.Genres.Where(g => g.Genre1.Equals("Metal")).Select(g => g.Id).Single()).SingleOrDefault().IsLiked = false;
                }
            }
            if (question_classical_checkBox.Checked)
            {
                //if there is a record of the user and the specific genre
                if (db.UserGenreInterfaces.Where(u => u.UserId == user.Id && u.GenreId ==
                db.Genres.Where(g => g.Genre1.Equals("Classical")).Select(g => g.Id).Single()).SingleOrDefault() != null)
                {
                    db.UserGenreInterfaces.Where(u => u.UserId == user.Id && u.GenreId ==
                        db.Genres.Where(g => g.Genre1.Equals("Classical")).Select(g => g.Id).Single()).SingleOrDefault().IsLiked = true;
                }
                else
                {
                    UserGenreInterface ClassicalIsLiked = new()
                    {
                        UserId = user.Id,
                        GenreId = db.Genres.Where(g => g.Genre1.Equals("Classical")).Select(g => g.Id).Single(),
                        IsLiked = true
                    };
                    db.Add(ClassicalIsLiked);
                }
            }
            else
            {
                //if there is a record of the user and the specific genre
                if (db.UserGenreInterfaces.Where(u => u.UserId == user.Id && u.GenreId ==
                db.Genres.Where(g => g.Genre1.Equals("Classical")).Select(g => g.Id).Single()).SingleOrDefault() != null)
                {
                    db.UserGenreInterfaces.Where(u => u.UserId == user.Id && u.GenreId ==
                        db.Genres.Where(g => g.Genre1.Equals("Classical")).Select(g => g.Id).Single()).SingleOrDefault().IsLiked = false;
                }
            }
            if (question_pop_checkBox.Checked)
            {
                //if there is a record of the user and the specific genre
                if (db.UserGenreInterfaces.Where(u => u.UserId == user.Id && u.GenreId ==
                db.Genres.Where(g => g.Genre1.Equals("Pop")).Select(g => g.Id).Single()).SingleOrDefault() != null)
                {
                    db.UserGenreInterfaces.Where(u => u.UserId == user.Id && u.GenreId ==
                        db.Genres.Where(g => g.Genre1.Equals("Pop")).Select(g => g.Id).Single()).SingleOrDefault().IsLiked = true;
                }
                else
                {
                    UserGenreInterface PopIsLiked = new()
                    {
                        UserId = user.Id,
                        GenreId = db.Genres.Where(g => g.Genre1.Equals("Pop")).Select(g => g.Id).Single(),
                        IsLiked = true
                    };
                    db.Add(PopIsLiked);
                }
            }
            else
            {
                //if there is a record of the user and the specific genre
                if (db.UserGenreInterfaces.Where(u => u.UserId == user.Id && u.GenreId ==
                db.Genres.Where(g => g.Genre1.Equals("Pop")).Select(g => g.Id).Single()).SingleOrDefault() != null)
                {
                    db.UserGenreInterfaces.Where(u => u.UserId == user.Id && u.GenreId ==
                        db.Genres.Where(g => g.Genre1.Equals("Pop")).Select(g => g.Id).Single()).SingleOrDefault().IsLiked = false;
                }
            }
            if (question_electronic_checkBox.Checked)
            {
                //if there is a record of the user and the specific genre
                if (db.UserGenreInterfaces.Where(u => u.UserId == user.Id && u.GenreId ==
                db.Genres.Where(g => g.Genre1.Equals("Electronic")).Select(g => g.Id).Single()).SingleOrDefault() != null)
                {
                    db.UserGenreInterfaces.Where(u => u.UserId == user.Id && u.GenreId ==
                        db.Genres.Where(g => g.Genre1.Equals("Electronic")).Select(g => g.Id).Single()).SingleOrDefault().IsLiked = true;
                }
                else
                {
                    UserGenreInterface ElectronicIsLiked = new()
                    {
                        UserId = user.Id,
                        GenreId = db.Genres.Where(g => g.Genre1.Equals("Electronic")).Select(g => g.Id).Single(),
                        IsLiked = true
                    };
                    db.Add(ElectronicIsLiked);
                }
            }
            else
            {
                //if there is a record of the user and the specific genre
                if (db.UserGenreInterfaces.Where(u => u.UserId == user.Id && u.GenreId ==
                db.Genres.Where(g => g.Genre1.Equals("Electronic")).Select(g => g.Id).Single()).SingleOrDefault() != null)
                {
                    db.UserGenreInterfaces.Where(u => u.UserId == user.Id && u.GenreId ==
                        db.Genres.Where(g => g.Genre1.Equals("Electronic")).Select(g => g.Id).Single()).SingleOrDefault().IsLiked = false;
                }
            }
            if (question_disco_checkBox.Checked)
            {
                //if there is a record of the user and the specific genre
                if (db.UserGenreInterfaces.Where(u => u.UserId == user.Id && u.GenreId ==
                db.Genres.Where(g => g.Genre1.Equals("Disco")).Select(g => g.Id).Single()).SingleOrDefault() != null)
                {
                    db.UserGenreInterfaces.Where(u => u.UserId == user.Id && u.GenreId ==
                        db.Genres.Where(g => g.Genre1.Equals("Disco")).Select(g => g.Id).Single()).SingleOrDefault().IsLiked = true;
                }
                else
                {
                    UserGenreInterface DiscoIsLiked = new()
                    {
                        UserId = user.Id,
                        GenreId = db.Genres.Where(g => g.Genre1.Equals("Disco")).Select(g => g.Id).Single(),
                        IsLiked = true
                    };
                    db.Add(DiscoIsLiked);
                }
            }
            else
            {
                //if there is a record of the user and the specific genre
                if (db.UserGenreInterfaces.Where(u => u.UserId == user.Id && u.GenreId ==
                db.Genres.Where(g => g.Genre1.Equals("Disco")).Select(g => g.Id).Single()).SingleOrDefault() != null)
                {
                    db.UserGenreInterfaces.Where(u => u.UserId == user.Id && u.GenreId ==
                        db.Genres.Where(g => g.Genre1.Equals("Disco")).Select(g => g.Id).Single()).SingleOrDefault().IsLiked = false;
                }
            }
            db.SaveChanges();

            question_panel.Visible = false;
            question_title_label.Visible = false;
            main_panel.Visible = true;

            //return label to its natural text cause if a user change his genre prefs the label text changes and then if 
            //another new user sign ups the label will have wrong text 
            question_title_label.Text = "As a new user we will ask you a question\r\nto configure your preferences";

            //return checkBoxes to their natural check state (Unchecked)
            question_rock_checkBox.Checked = false;
            question_metal_checkBox.Checked = false;
            question_classical_checkBox.Checked = false;
            question_pop_checkBox.Checked = false;
            question_electronic_checkBox.Checked = false;
            question_disco_checkBox.Checked = false;

            HideAllCentricPanelsExcept(main_panel);
            ChangeSearchListBoxParent(main_panel);
        }

        private void main_panel_visible_changed(object sender, EventArgs e)
        {
            var likedGenresIds = db.UserGenreInterfaces.Where(u => u.UserId == user.Id && u.IsLiked == true).
                                                        Select(u => u.GenreId).ToArray();

            //if the user exit the app without answering the question for the genres and no userGenreInterface was made
            if (likedGenresIds.IsNullOrEmpty())
            {
                main_panel.Visible = false;
                question_title_label.Visible = true;
                question_panel.Visible = true;
                return;
            }

            List<Song> recommendedSongsBasedOnLikedGenres = new();

            for (int i = 0; i < likedGenresIds.Length; i++)
            {
                recommendedSongsBasedOnLikedGenres.AddRange(db.Songs.Where(s => s.GenreId.Equals(likedGenresIds[i])).ToList());
            }

            /*
             * In the loop below we take a random song from the list of favorites based on liked genres and we print its
             * data and then we take it out of the list so in the next loop we wont take the same song. We do that 5 times
             * so that we have a recommendation of 5 songs. We also set a tag for title buttons because in the title the user
             * will click to listen the song so we keep the youTube url in the tag and we set a tag for heart (like) buttons.
             * That tag contains the song id so that we can know if the user click a button what song is it. Then we check in
             * the db if that song is liked from the user so that we can set the image of the button to filled or unfilled
             * 
             */

            for (int i = 0; i < 5; i++)
            {
                var x = random.Next(recommendedSongsBasedOnLikedGenres.Count); //a random int from 0 to max of the list
                var userSongInterface = db.UserSongInterfaces.
                            Where(u => u.UserId == user.Id && u.SongId == recommendedSongsBasedOnLikedGenres[x].Id).
                            SingleOrDefault();
                if (i == 0)
                {
                    PrintSong(main_recommendations_title1_button, recommendedSongsBasedOnLikedGenres,
                        main_recommendations_artist1_label, x, main_recommendations_released1_label,
                        main_recommendations_heart1_button, userSongInterface);
                }
                else if (i == 1)
                {
                    PrintSong(main_recommendations_title2_button, recommendedSongsBasedOnLikedGenres,
                        main_recommendations_artist2_label, x, main_recommendations_released2_label,
                        main_recommendations_heart2_button, userSongInterface);
                }
                else if (i == 2)
                {
                    PrintSong(main_recommendations_title3_button, recommendedSongsBasedOnLikedGenres,
                        main_recommendations_artist3_label, x, main_recommendations_released3_label,
                        main_recommendations_heart3_button, userSongInterface);
                }
                else if (i == 3)
                {
                    PrintSong(main_recommendations_title4_button, recommendedSongsBasedOnLikedGenres,
                        main_recommendations_artist4_label, x, main_recommendations_released4_label,
                        main_recommendations_heart4_button, userSongInterface);
                }
                else
                {
                    PrintSong(main_recommendations_title5_button, recommendedSongsBasedOnLikedGenres,
                        main_recommendations_artist5_label, x, main_recommendations_released5_label,
                        main_recommendations_heart5_button, userSongInterface);
                }
                recommendedSongsBasedOnLikedGenres.RemoveAt(x); //remove from the list so that we wont take the same song
            }
            HideSearchSettingsAndMenu(sender, e);
        }

        private void login_button_Click(object sender, EventArgs e)
        {
#pragma warning disable CS8601 // Possible null reference assignment.
            // finds if there is a user registered in the database with the username and password the user provided
            user = db.Users.Where(u => u.Name.Equals(username_textBox.Text) && u.Password.Equals(password_textBox.Text)).SingleOrDefault();
#pragma warning restore CS8601 // Possible null reference assignment.

            if (username_textBox.Text.IsNullOrEmpty() || password_textBox.Text.IsNullOrEmpty()            //----
                || password_textBox.Text.Length < 4 || username_textBox.Text.Length < 2
                || user == null
               )                                                                                          // if there is a wrong                                                                                          
            {                                                                                             // input turn on the                                                         
                login_error_label.Visible = true;                                                         // error label
            }

            if (username_textBox.Text.IsNullOrEmpty())
            {
                login_error_label.Text = "You did not enter a username";
            }
            else if (password_textBox.Text.IsNullOrEmpty())                                                // log in check for
            {                                                                                              // wrong input
                login_error_label.Text = "You did not enter a password";
            }
            else if (username_textBox.Text.Length < 2)
            {
                login_error_label.Text = "You have to insert at least 2 characters in the username field";
            }
            else if (password_textBox.Text.Length < 4)
            {
                login_error_label.Text = "You have to insert at least 4 characters in the password field";
            }                                                                                              //----
            else if (user == null)
            {
                login_error_label.Text = "Your username or your password is incorrect"; //no user found with the username and
            }                                                                           //password the user provided
            else                                                                                           // log in succed
            {
                login_panel.Visible = false;
                main_panel.Visible = true;
            }
        }

        private void password_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevents the Enter key from appearing in the TextBox
                login_button_Click(sender, e);
            }
        }

        private void eye_button_MouseDown(object sender, MouseEventArgs e)
        {
            password_textBox.PasswordChar = '\0';
        }

        private void eye_button_MouseUp(object sender, MouseEventArgs e)
        {
            password_textBox.PasswordChar = '*';
        }

        private void heart_button_Click(object sender, EventArgs e)
        {
            Button buttonClicked = (Button)sender; //cast the sender into a button

            if (buttonClicked == main_recommendations_heart1_button)
            {
                heart_button_click_function(main_recommendations_heart1_button);
            }
            else if (buttonClicked == main_recommendations_heart2_button)
            {
                heart_button_click_function(main_recommendations_heart2_button);
            }
            else if (buttonClicked == main_recommendations_heart3_button)
            {
                heart_button_click_function(main_recommendations_heart3_button);
            }
            else if (buttonClicked == main_recommendations_heart4_button)
            {
                heart_button_click_function(main_recommendations_heart4_button);
            }
            else if (buttonClicked == main_recommendations_heart5_button)
            {
                heart_button_click_function(main_recommendations_heart5_button);
            }
            else if (buttonClicked == mood_heart_button1)
            {
                heart_button_click_function(mood_heart_button1);
            }
            else if (buttonClicked == mood_heart_button2)
            {
                heart_button_click_function(mood_heart_button2);
            }
            else if (buttonClicked == mood_heart_button3)
            {
                heart_button_click_function(mood_heart_button3);
            }
            else if (buttonClicked == mood_heart_button4)
            {
                heart_button_click_function(mood_heart_button4);
            }
            else if (buttonClicked == mood_heart_button5)
            {
                heart_button_click_function(mood_heart_button5);
            }
            HideSearchSettingsAndMenu(sender, e);
        }

        private void heart_button_click_function(Button heart_button)
        {
            var userSongInterface = db.UserSongInterfaces.
                            Where(u => u.UserId == user.Id && u.SongId == (Guid)heart_button.Tag)
                            .SingleOrDefault();
            if (userSongInterface == null)
            {
                UserSongInterface likeSong = new()
                {
                    UserId = user.Id,
                    SongId = (Guid)heart_button.Tag,
                    IsLiked = true,
                    ListenedCount = 0
                };
                db.Add(likeSong);
                db.SaveChanges();

                heart_button.BackgroundImage = Properties.Resources.heartFilled;
            }
            else if (!userSongInterface.IsLiked)
            {
                userSongInterface.IsLiked = true;
                db.SaveChanges();

                heart_button.BackgroundImage = Properties.Resources.heartFilled;
            }
            else
            {
                userSongInterface.IsLiked = false;
                db.SaveChanges();

                heart_button.BackgroundImage = Properties.Resources.heartUnfilled;
            }
        }

        private static void PrintSong(Button title, List<Song> songs, Label artist, Int32 rand,
                                        Label year, Button heart, UserSongInterface userSongInterface)
        {
            title.Text = songs[rand].Title.Trim();
            artist.Text = songs[rand].Artist.Trim();
            year.Text = songs[rand].Released.ToString();
            heart.Tag = songs[rand].Id;
            title.Tag = songs[rand].Id;

            if (userSongInterface == null || !userSongInterface.IsLiked)
            {
                heart.BackgroundImage = Properties.Resources.heartUnfilled;
            }
            else
            {
                heart.BackgroundImage = Properties.Resources.heartFilled;
            }
        }

        private void title_button_Click(object sender, EventArgs e)
        {
            Button buttonClicked = (Button)sender; //cast the sender into a button

            PlaySong(buttonClicked);
            HideSearchSettingsAndMenu(sender, e);
        }

        private void main_magnifier_button_Click(object sender, EventArgs e)
        {
            var searchedSongs = db.Songs.Where(s => s.Title.Contains(main_search_textBox.Text)).ToArray();
            main_search_listBox.Items.Clear();
            foreach (var song in searchedSongs)
            {
                main_search_listBox.Items.Add(song.Title);
            }
            main_search_listBox.Visible = true;
            if (main_search_listBox.Items.Count < 1)
            {
                main_search_listBox.ForeColor = Color.Red;
                main_search_listBox.Items.Add("No song found");
            }
            else
            {
                main_search_listBox.ForeColor = Color.Black;
            }
            HideSettingsAndMenu();
        }

        private void main_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (main_search_listBox.SelectedItem == null || main_search_listBox.Items.Contains("No song found"))
            {
                return;
            }
            //not good tactic to search without id/primary key
            PlaySong(main_search_listBox);
            main_search_listBox.Visible = false;
            main_search_textBox.Text = null;
        }

        private void main_search_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevents the Enter key from appearing in the TextBox
                main_magnifier_button_Click(sender, e);
            }
        }

        private void PlaySong(Button buttonClicked)
        {
            Song song = db.Songs.Where(s => s.Id == (Guid)buttonClicked.Tag).Single();

            UserSongInterface userSongInterface = db.UserSongInterfaces.Where(u => u.UserId == user.Id && u.SongId == song.Id)
                                                                       .SingleOrDefault();
            if (userSongInterface == null)
            {
                userSongInterface = new UserSongInterface()
                {
                    UserId = user.Id,
                    SongId = song.Id,
                    ListenedCount = 1,
                    IsLiked = false
                };
                db.Add(userSongInterface);
            }
            else
            {
                userSongInterface.ListenedCount++;
            }
            db.SaveChanges();

            YouTubeForm youTubeForm = new(song.Url)
            {
                Text = song.Title
            };
            youTubeForm.Show();
        }

        private void PlaySong(ListBox listBox)
        {
            Song selectedSearchedSong = db.Songs.Where(s => s.Title == listBox.SelectedItem.ToString()).First();

            UserSongInterface userSongInterface = db.UserSongInterfaces
                                                    .Where(u => u.UserId == user.Id && u.SongId == selectedSearchedSong.Id)
                                                    .SingleOrDefault();
            if (userSongInterface == null)
            {
                userSongInterface = new UserSongInterface()
                {
                    UserId = user.Id,
                    SongId = selectedSearchedSong.Id,
                    ListenedCount = 1,
                    IsLiked = false
                };
                db.Add(userSongInterface);
            }
            else
            {
                userSongInterface.ListenedCount++;
            }
            db.SaveChanges();

            YouTubeForm youTubeForm = new(selectedSearchedSong.Url)
            {
                Text = selectedSearchedSong.Title
            };
            youTubeForm.Show();
        }

        private void HideSearchSettingsAndMenu(object sender, EventArgs e)
        {
            //use for focus chagne
            main_search_listBox.Visible = false;
            main_search_textBox.Text = null;
            settings_panel.Visible = false;
            menu_panel.Visible = false;
            settings_button.Visible = true;
            menu_button.Visible = true;
        }

        private void HideSearch()
        {
            //use for focus chagne
            main_search_listBox.Visible = false;
            main_search_textBox.Text = null;
        }

        private void HideSettingsAndMenu()
        {
            settings_panel.Visible = false;
            menu_panel.Visible = false;
            settings_button.Visible = true;
            menu_button.Visible = true;
        }

        private void HideSettings()
        {
            settings_panel.Visible = false;
            settings_button.Visible = true;
        }

        private void HideMenu()
        {
            menu_panel.Visible = false;
            menu_button.Visible = true;
        }

        private void menu_button_Click(object sender, EventArgs e)
        {
            menu_panel.Visible = true;
            menu_button.Visible = false;
            HideSearch();
            HideSettings();
        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            settings_panel.Visible = true;
            settings_button.Visible = false;
            HideSearch();
            HideMenu();
        }

        private void sign_out_button_Click(object sender, EventArgs e)
        {
            main_panel.Visible = false;
            login_panel.Visible = true;
            login_error_label.Visible = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeInSeconds++;

            if (timeInSeconds == 60)
            {
                timeInMinutes++;
                timeInSeconds = 0;
            }
            if (timeInMinutes == 60)
            {
                timeInHours++;
                timeInMinutes = 0;
            }

            if (timeInSeconds < 10)
            {
                secondsFactor = " : 0";
            }
            else
            {
                secondsFactor = " : ";
            }
            if (timeInMinutes < 10)
            {
                minutesFactor = " : 0";
            }
            else
            {
                minutesFactor = " : ";
            }
            if (timeInHours < 10)
            {
                hoursFactor = "0";
            }
            else
            {
                hoursFactor = "";
            }
            clock_label.Text = hoursFactor + timeInHours.ToString() + minutesFactor + timeInMinutes.ToString() +
                secondsFactor + timeInSeconds.ToString();
        }

        private void clock_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            clock_pictureBox.Visible = !clock_pictureBox.Visible;
            clock_label.Visible = !clock_label.Visible;
        }

        private void change_genre_preferences_button_Click(object sender, EventArgs e)
        {
            question_title_label.Visible = true;
            question_panel.Visible = true;
            main_panel.Visible = false;

            question_title_label.Text = "Here you can change your genre preferences";

            if (db.UserGenreInterfaces.Where(u => u.UserId == user.Id && u.GenreId ==
                db.Genres.Where(g => g.Genre1.Equals("Rock")).Select(g => g.Id).Single()).SingleOrDefault() != null
                && db.UserGenreInterfaces.Where(u => u.UserId == user.Id && u.GenreId ==
                db.Genres.Where(g => g.Genre1.Equals("Rock")).Select(g => g.Id).Single()).SingleOrDefault().IsLiked)
            {
                question_rock_checkBox.Checked = true;
            }
            if (db.UserGenreInterfaces.Where(u => u.UserId == user.Id && u.GenreId ==
                db.Genres.Where(g => g.Genre1.Equals("Metal")).Select(g => g.Id).Single()).SingleOrDefault() != null
                && db.UserGenreInterfaces.Where(u => u.UserId == user.Id && u.GenreId ==
                db.Genres.Where(g => g.Genre1.Equals("Metal")).Select(g => g.Id).Single()).SingleOrDefault().IsLiked)
            {
                question_metal_checkBox.Checked = true;
            }
            if (db.UserGenreInterfaces.Where(u => u.UserId == user.Id && u.GenreId ==
                db.Genres.Where(g => g.Genre1.Equals("Pop")).Select(g => g.Id).Single()).SingleOrDefault() != null
                && db.UserGenreInterfaces.Where(u => u.UserId == user.Id && u.GenreId ==
                db.Genres.Where(g => g.Genre1.Equals("Pop")).Select(g => g.Id).Single()).SingleOrDefault().IsLiked)
            {
                question_pop_checkBox.Checked = true;
            }
            if (db.UserGenreInterfaces.Where(u => u.UserId == user.Id && u.GenreId ==
                db.Genres.Where(g => g.Genre1.Equals("Classical")).Select(g => g.Id).Single()).SingleOrDefault() != null
                && db.UserGenreInterfaces.Where(u => u.UserId == user.Id && u.GenreId ==
                db.Genres.Where(g => g.Genre1.Equals("Classical")).Select(g => g.Id).Single()).SingleOrDefault().IsLiked)
            {
                question_classical_checkBox.Checked = true;
            }
            if (db.UserGenreInterfaces.Where(u => u.UserId == user.Id && u.GenreId ==
                db.Genres.Where(g => g.Genre1.Equals("Disco")).Select(g => g.Id).Single()).SingleOrDefault() != null
                && db.UserGenreInterfaces.Where(u => u.UserId == user.Id && u.GenreId ==
                db.Genres.Where(g => g.Genre1.Equals("Disco")).Select(g => g.Id).Single()).SingleOrDefault().IsLiked)
            {
                question_disco_checkBox.Checked = true;
            }
            if (db.UserGenreInterfaces.Where(u => u.UserId == user.Id && u.GenreId ==
                db.Genres.Where(g => g.Genre1.Equals("Electronic")).Select(g => g.Id).Single()).SingleOrDefault() != null
                && db.UserGenreInterfaces.Where(u => u.UserId == user.Id && u.GenreId ==
                db.Genres.Where(g => g.Genre1.Equals("Electronic")).Select(g => g.Id).Single()).SingleOrDefault().IsLiked)
            {
                question_electronic_checkBox.Checked = true;
            }
        }

        private void statistics_button_Click(object sender, EventArgs e)
        {
            HideMenu();
            HideAllCentricPanelsExcept(statistics_panel);
            ChangeSearchListBoxParent(statistics_panel);

            //for the clicks count statistic
            count_clicks_listView.Items.Clear();
            var userSongInterfaceArray = db.UserSongInterfaces.Where(u => u.UserId == user.Id && u.ListenedCount > 0)
                                            .OrderByDescending(u => u.ListenedCount).ToArray();
            foreach (var usi in userSongInterfaceArray)
            {
                ListViewItem listViewItem = new(db.Songs.Where(s => s.Id == usi.SongId).Select(s => s.Title.Trim()).Single());
                listViewItem.SubItems.Add(usi.ListenedCount.ToString());
                count_clicks_listView.Items.Add(listViewItem);
            }

            //for the genres
            genre_like_listView.Items.Clear();
            var userGenres = db.UserGenreInterfaces.Where(u => u.UserId == user.Id && u.IsLiked == true).ToArray();
            foreach (var userInterfaceGenre in userGenres)
            {
                genre_like_listView.Items.Add(db.Genres.Where(g => g.Id == userInterfaceGenre.GenreId).Select(g => g.Genre1.Trim())
                                                        .Single());
            }

            //for the label
            var likeCount = db.UserSongInterfaces.Where(u => u.UserId == user.Id && u.IsLiked == true).Select(u => u.IsLiked)
                            .Count();
            count_like_label.Text = "Songs that you like in total: " + likeCount.ToString();
        }

        private void go_to_main_button_Click(object sender, EventArgs e)
        {
            HideMenu();
            HideAllCentricPanelsExcept(main_panel);
            ChangeSearchListBoxParent(main_panel);
        }

        private void HideAllCentricPanelsExcept(Panel nextPanel)
        {
            statistics_panel.Visible = false;
            liked_songs_panel.Visible = false;
            mood_panel.Visible = false;

            nextPanel.Visible = true;
        }

        private void ChangeSearchListBoxParent(Panel target)
        {
            if (main_search_listBox.Parent != target)
            {
                Panel source = (Panel)main_search_listBox.Parent;

                Point currentLoc = main_search_listBox.Location;
                source.Controls.Remove(main_search_listBox);
                main_search_listBox.Location = target.PointToClient(source.PointToScreen(currentLoc));
                target.Controls.Add(main_search_listBox);
                main_search_listBox.BringToFront();
            }
        }

        private void liked_songs_button_Click(object sender, EventArgs e)
        {
            HideMenu();
            HideAllCentricPanelsExcept(liked_songs_panel);
            ChangeSearchListBoxParent(liked_songs_panel);

            liked_songs_listView.Items.Clear();
            var likedSongs = db.UserSongInterfaces.Where(u => u.UserId == user.Id && u.IsLiked == true).ToArray();
            foreach (var userSongInterface in likedSongs)
            {
                ListViewItem listViewItem = new(db.Songs.Where(s => s.Id == userSongInterface.SongId).Select(s => s.Title.Trim())
                                                        .Single());
                listViewItem.SubItems.Add(db.Songs.Where(s => s.Id == userSongInterface.SongId).Select(s => s.Artist.Trim())
                                                    .Single());
                listViewItem.SubItems.Add(db.Songs.Where(s => s.Id == userSongInterface.SongId).Select(s => s.Released.ToString())
                                                    .Single());
                liked_songs_listView.Items.Add(listViewItem);
            }
        }

        private void mood_button_Click(object sender, EventArgs e)
        {
            HideMenu();
            HideAllCentricPanelsExcept(mood_panel);
            ChangeSearchListBoxParent(mood_panel);

            var happySongs = db.Songs.Where(s => s.Mood.Contains("Happy")).ToList();
            for (int i = 0; i < 5; i++)
            {
                var x = random.Next(happySongs.Count); //a random int from 0 to max of the list
                var userSongInterface = db.UserSongInterfaces
                                        .Where(u => u.UserId == user.Id && u.SongId == happySongs[x].Id)
                                        .SingleOrDefault();

                switch (i)
                {
                    case 0:
                        PrintSong(mood_title_button1, happySongs, mood_artist_label1, x, mood_year_label1, mood_heart_button1,
                                    userSongInterface);
                        break;
                    case 1:
                        PrintSong(mood_title_button2, happySongs, mood_artist_label2, x, mood_year_label2, mood_heart_button2,
                                    userSongInterface);
                        break;
                    case 2:
                        PrintSong(mood_title_button3, happySongs, mood_artist_label3, x, mood_year_label3, mood_heart_button3,
                                    userSongInterface);
                        break;
                    case 3:
                        PrintSong(mood_title_button4, happySongs, mood_artist_label4, x, mood_year_label4, mood_heart_button4,
                                    userSongInterface);
                        break;
                    case 4:
                        PrintSong(mood_title_button5, happySongs, mood_artist_label5, x, mood_year_label5, mood_heart_button5,
                                    userSongInterface);
                        break;
                }

                happySongs.RemoveAt(x);
            }
        }

        private void mood_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mood = moodDictionary[mood_comboBox.Text];
            var happySongs = db.Songs.Where(s => s.Mood.Contains(mood)).ToList();
            for (int i = 0; i < 5; i++)
            {
                var x = random.Next(happySongs.Count); //a random int from 0 to max of the list
                var userSongInterface = db.UserSongInterfaces
                                        .Where(u => u.UserId == user.Id && u.SongId == happySongs[x].Id)
                                        .SingleOrDefault();

                switch (i)
                {
                    case 0:
                        PrintSong(mood_title_button1, happySongs, mood_artist_label1, x, mood_year_label1, mood_heart_button1,
                                    userSongInterface);
                        break;
                    case 1:
                        PrintSong(mood_title_button2, happySongs, mood_artist_label2, x, mood_year_label2, mood_heart_button2,
                                    userSongInterface);
                        break;
                    case 2:
                        PrintSong(mood_title_button3, happySongs, mood_artist_label3, x, mood_year_label3, mood_heart_button3,
                                    userSongInterface);
                        break;
                    case 3:
                        PrintSong(mood_title_button4, happySongs, mood_artist_label4, x, mood_year_label4, mood_heart_button4,
                                    userSongInterface);
                        break;
                    case 4:
                        PrintSong(mood_title_button5, happySongs, mood_artist_label5, x, mood_year_label5, mood_heart_button5,
                                    userSongInterface);
                        break;
                }

                happySongs.RemoveAt(x);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            moodDictionary["Happy"] = "Happy";
            moodDictionary["Excited"] = "Happy";
            moodDictionary["Uplifting"] = "Happy";
            moodDictionary["Catchy"] = "Happy";
            moodDictionary["Joyful"] = "Happy";

            moodDictionary["Love"] = "Love";

            moodDictionary["Sad"] = "Sad";
            moodDictionary["Nostalgic"] = "Sad";
            moodDictionary["Melancholic"] = "Sad";
            moodDictionary["Dark"] = "Sad";
            moodDictionary["Moody"] = "Sad";

            moodDictionary["Energetic"] = "Energy";
            moodDictionary["Empowerment"] = "Energy";
            moodDictionary["Suspense"] = "Energy";

            moodDictionary["Angry"] = "Anger";
            moodDictionary["Rebellion"] = "Anger";

            moodDictionary["Inspirational"] = "Inspiration";
            moodDictionary["Elegance"] = "Inspiration";

            moodDictionary["Danceable"] = "Danceable";

            moodDictionary["Calming"] = "Calming";
            moodDictionary["Peaceful"] = "Calming";
            moodDictionary["Relaxed"] = "Calming";
        }
    }
}