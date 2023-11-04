namespace Music_Guide
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            login_panel = new Panel();
            eye_button = new Button();
            login_error_label = new Label();
            login_help_button = new Button();
            signup_button = new Button();
            login_button = new Button();
            password_textBox = new TextBox();
            username_textBox = new TextBox();
            login_label = new Label();
            question_panel = new Panel();
            question_next_button = new Button();
            question_disco_checkBox = new CheckBox();
            question_electronic_checkBox = new CheckBox();
            question_pop_checkBox = new CheckBox();
            question_classical_checkBox = new CheckBox();
            question_metal_checkBox = new CheckBox();
            question_rock_checkBox = new CheckBox();
            question_label = new Label();
            question_title_label = new Label();
            main_panel = new Panel();
            mood_panel = new Panel();
            mood_music_label = new Label();
            mood_listen_label = new Label();
            mood_comboBox = new ComboBox();
            mood_rec_panel = new Panel();
            mood_rec_refresh_button = new Button();
            mood_heart_button5 = new Button();
            mood_heart_button4 = new Button();
            mood_heart_button3 = new Button();
            mood_heart_button2 = new Button();
            mood_heart_button1 = new Button();
            mood_year_label5 = new Label();
            mood_year_label4 = new Label();
            mood_year_label3 = new Label();
            mood_year_label2 = new Label();
            mood_artist_label5 = new Label();
            mood_artist_label4 = new Label();
            mood_artist_label3 = new Label();
            mood_artist_label2 = new Label();
            mood_year_label1 = new Label();
            mood_artist_label1 = new Label();
            mood_year_label = new Label();
            mood_art_label = new Label();
            mood_tit_label = new Label();
            mood_title_button5 = new Button();
            mood_title_button4 = new Button();
            mood_title_button3 = new Button();
            mood_title_button2 = new Button();
            mood_title_button1 = new Button();
            mood_rec_label = new Label();
            liked_songs_panel = new Panel();
            liked_songs_listView = new ListView();
            likedSongs_title_columnHeader = new ColumnHeader();
            likedSongs_artist_columnHeader = new ColumnHeader();
            likedSongs_year_columnHeader = new ColumnHeader();
            liked_songs_label = new Label();
            statistics_panel = new Panel();
            separator_panel2 = new Panel();
            separator_panel1 = new Panel();
            genre_like_label = new Label();
            genre_like_listView = new ListView();
            statistics_genre_columnHeader = new ColumnHeader();
            count_like_label = new Label();
            count_clicks_label = new Label();
            count_clicks_listView = new ListView();
            statistics_song_columnHeader = new ColumnHeader();
            statistics_click_columnHeader = new ColumnHeader();
            main_recommendations_panel = new Panel();
            main_recommendations_refresh_button = new Button();
            main_recommendations_heart5_button = new Button();
            main_recommendations_heart4_button = new Button();
            main_recommendations_heart3_button = new Button();
            main_recommendations_heart2_button = new Button();
            main_recommendations_heart1_button = new Button();
            main_recommendations_released5_label = new Label();
            main_recommendations_released4_label = new Label();
            main_recommendations_released3_label = new Label();
            main_recommendations_released2_label = new Label();
            main_recommendations_artist5_label = new Label();
            main_recommendations_artist4_label = new Label();
            main_recommendations_artist3_label = new Label();
            main_recommendations_artist2_label = new Label();
            main_recommendations_released1_label = new Label();
            main_recommendations_artist1_label = new Label();
            main_recommendations_year_label = new Label();
            main_recommendations_artist_label = new Label();
            main_recommendations_title_label = new Label();
            main_recommendations_title5_button = new Button();
            main_recommendations_title4_button = new Button();
            main_recommendations_title3_button = new Button();
            main_recommendations_title2_button = new Button();
            main_recommendations_title1_button = new Button();
            main_recommendations_label = new Label();
            menu_button = new Button();
            clock_label = new Label();
            settings_button = new Button();
            clock_pictureBox = new PictureBox();
            settings_panel = new Panel();
            change_genre_preferences_button = new Button();
            clock_checkBox = new CheckBox();
            sign_out_button = new Button();
            inverted_settings_button = new Button();
            main_magnifier_button = new Button();
            main_search_textBox = new TextBox();
            menu_panel = new Panel();
            mood_button = new Button();
            menu_recommend_label = new Label();
            menu_view_label = new Label();
            liked_songs_button = new Button();
            go_to_main_button = new Button();
            statistics_button = new Button();
            inverted_menu_button = new Button();
            main_search_listBox = new ListBox();
            timer = new System.Windows.Forms.Timer(components);
            login_panel.SuspendLayout();
            question_panel.SuspendLayout();
            main_panel.SuspendLayout();
            mood_panel.SuspendLayout();
            mood_rec_panel.SuspendLayout();
            liked_songs_panel.SuspendLayout();
            statistics_panel.SuspendLayout();
            main_recommendations_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clock_pictureBox).BeginInit();
            settings_panel.SuspendLayout();
            menu_panel.SuspendLayout();
            SuspendLayout();
            // 
            // login_panel
            // 
            login_panel.BackColor = Color.Teal;
            login_panel.Controls.Add(eye_button);
            login_panel.Controls.Add(login_error_label);
            login_panel.Controls.Add(login_help_button);
            login_panel.Controls.Add(signup_button);
            login_panel.Controls.Add(login_button);
            login_panel.Controls.Add(password_textBox);
            login_panel.Controls.Add(username_textBox);
            login_panel.Controls.Add(login_label);
            login_panel.Location = new Point(760, 289);
            login_panel.Name = "login_panel";
            login_panel.Size = new Size(400, 438);
            login_panel.TabIndex = 0;
            // 
            // eye_button
            // 
            eye_button.BackColor = Color.Teal;
            eye_button.BackgroundImage = Properties.Resources.eye;
            eye_button.BackgroundImageLayout = ImageLayout.Zoom;
            eye_button.Cursor = Cursors.Hand;
            eye_button.FlatAppearance.BorderSize = 0;
            eye_button.FlatStyle = FlatStyle.Flat;
            eye_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            eye_button.ForeColor = Color.Navy;
            eye_button.Location = new Point(330, 143);
            eye_button.Name = "eye_button";
            eye_button.Size = new Size(57, 27);
            eye_button.TabIndex = 6;
            eye_button.UseVisualStyleBackColor = true;
            eye_button.MouseDown += eye_button_MouseDown;
            eye_button.MouseUp += eye_button_MouseUp;
            // 
            // login_error_label
            // 
            login_error_label.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            login_error_label.ForeColor = Color.Red;
            login_error_label.Location = new Point(33, 198);
            login_error_label.Name = "login_error_label";
            login_error_label.Size = new Size(334, 78);
            login_error_label.TabIndex = 3;
            login_error_label.Text = "Error Label";
            login_error_label.TextAlign = ContentAlignment.MiddleCenter;
            login_error_label.Visible = false;
            // 
            // login_help_button
            // 
            login_help_button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            login_help_button.Cursor = Cursors.Hand;
            login_help_button.FlatAppearance.BorderSize = 0;
            login_help_button.FlatStyle = FlatStyle.Flat;
            login_help_button.Font = new Font("Segoe UI Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            login_help_button.ForeColor = Color.Navy;
            login_help_button.Location = new Point(3, 405);
            login_help_button.Name = "login_help_button";
            login_help_button.Size = new Size(60, 30);
            login_help_button.TabIndex = 5;
            login_help_button.Text = "Help!";
            login_help_button.UseVisualStyleBackColor = true;
            login_help_button.Click += login_help_button_Click;
            // 
            // signup_button
            // 
            signup_button.Cursor = Cursors.Hand;
            signup_button.FlatAppearance.BorderSize = 0;
            signup_button.FlatStyle = FlatStyle.Flat;
            signup_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            signup_button.ForeColor = Color.Navy;
            signup_button.Location = new Point(153, 321);
            signup_button.Name = "signup_button";
            signup_button.Size = new Size(94, 36);
            signup_button.TabIndex = 4;
            signup_button.Text = "Sign up";
            signup_button.UseVisualStyleBackColor = true;
            signup_button.Click += signup_button_Click;
            // 
            // login_button
            // 
            login_button.Cursor = Cursors.Hand;
            login_button.FlatAppearance.BorderSize = 0;
            login_button.FlatStyle = FlatStyle.Flat;
            login_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            login_button.ForeColor = Color.Navy;
            login_button.Location = new Point(161, 279);
            login_button.Name = "login_button";
            login_button.Size = new Size(78, 36);
            login_button.TabIndex = 0;
            login_button.Text = "Log in";
            login_button.UseVisualStyleBackColor = true;
            login_button.Click += login_button_Click;
            // 
            // password_textBox
            // 
            password_textBox.BackColor = Color.Turquoise;
            password_textBox.Location = new Point(75, 143);
            password_textBox.MaxLength = 20;
            password_textBox.Name = "password_textBox";
            password_textBox.PasswordChar = '*';
            password_textBox.PlaceholderText = "Password";
            password_textBox.Size = new Size(249, 27);
            password_textBox.TabIndex = 2;
            password_textBox.KeyPress += password_textBox_KeyPress;
            // 
            // username_textBox
            // 
            username_textBox.BackColor = Color.Turquoise;
            username_textBox.Location = new Point(75, 94);
            username_textBox.MaxLength = 30;
            username_textBox.Name = "username_textBox";
            username_textBox.PlaceholderText = "Username";
            username_textBox.Size = new Size(250, 27);
            username_textBox.TabIndex = 1;
            username_textBox.KeyPress += password_textBox_KeyPress;
            // 
            // login_label
            // 
            login_label.AutoSize = true;
            login_label.Dock = DockStyle.Top;
            login_label.Font = new Font("Tempus Sans ITC", 19.2F, FontStyle.Bold, GraphicsUnit.Point);
            login_label.Location = new Point(0, 0);
            login_label.Margin = new Padding(0);
            login_label.Name = "login_label";
            login_label.Size = new Size(396, 42);
            login_label.TabIndex = 0;
            login_label.Text = "Welcome to Music Guide!";
            login_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // question_panel
            // 
            question_panel.BackColor = Color.Crimson;
            question_panel.Controls.Add(question_next_button);
            question_panel.Controls.Add(question_disco_checkBox);
            question_panel.Controls.Add(question_electronic_checkBox);
            question_panel.Controls.Add(question_pop_checkBox);
            question_panel.Controls.Add(question_classical_checkBox);
            question_panel.Controls.Add(question_metal_checkBox);
            question_panel.Controls.Add(question_rock_checkBox);
            question_panel.Controls.Add(question_label);
            question_panel.Location = new Point(460, 290);
            question_panel.Name = "question_panel";
            question_panel.Size = new Size(1000, 500);
            question_panel.TabIndex = 1;
            question_panel.Visible = false;
            // 
            // question_next_button
            // 
            question_next_button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            question_next_button.AutoSize = true;
            question_next_button.Cursor = Cursors.Hand;
            question_next_button.FlatAppearance.BorderSize = 0;
            question_next_button.FlatStyle = FlatStyle.Flat;
            question_next_button.Font = new Font("Segoe UI Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            question_next_button.ForeColor = Color.Navy;
            question_next_button.Location = new Point(923, 455);
            question_next_button.Name = "question_next_button";
            question_next_button.Size = new Size(74, 42);
            question_next_button.TabIndex = 6;
            question_next_button.Text = "Next";
            question_next_button.UseVisualStyleBackColor = true;
            question_next_button.Click += question_next_button_Click;
            // 
            // question_disco_checkBox
            // 
            question_disco_checkBox.AutoSize = true;
            question_disco_checkBox.Cursor = Cursors.Hand;
            question_disco_checkBox.FlatStyle = FlatStyle.Flat;
            question_disco_checkBox.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            question_disco_checkBox.Location = new Point(729, 357);
            question_disco_checkBox.Name = "question_disco_checkBox";
            question_disco_checkBox.Size = new Size(120, 50);
            question_disco_checkBox.TabIndex = 6;
            question_disco_checkBox.Text = "Disco";
            question_disco_checkBox.UseVisualStyleBackColor = true;
            // 
            // question_electronic_checkBox
            // 
            question_electronic_checkBox.AutoSize = true;
            question_electronic_checkBox.Cursor = Cursors.Hand;
            question_electronic_checkBox.FlatStyle = FlatStyle.Flat;
            question_electronic_checkBox.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            question_electronic_checkBox.Location = new Point(729, 250);
            question_electronic_checkBox.Name = "question_electronic_checkBox";
            question_electronic_checkBox.Size = new Size(184, 50);
            question_electronic_checkBox.TabIndex = 5;
            question_electronic_checkBox.Text = "Electronic";
            question_electronic_checkBox.UseVisualStyleBackColor = true;
            // 
            // question_pop_checkBox
            // 
            question_pop_checkBox.AutoSize = true;
            question_pop_checkBox.Cursor = Cursors.Hand;
            question_pop_checkBox.FlatStyle = FlatStyle.Flat;
            question_pop_checkBox.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            question_pop_checkBox.Location = new Point(729, 142);
            question_pop_checkBox.Name = "question_pop_checkBox";
            question_pop_checkBox.Size = new Size(96, 50);
            question_pop_checkBox.TabIndex = 4;
            question_pop_checkBox.Text = "Pop";
            question_pop_checkBox.UseVisualStyleBackColor = true;
            // 
            // question_classical_checkBox
            // 
            question_classical_checkBox.AutoSize = true;
            question_classical_checkBox.Cursor = Cursors.Hand;
            question_classical_checkBox.FlatStyle = FlatStyle.Flat;
            question_classical_checkBox.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            question_classical_checkBox.Location = new Point(147, 357);
            question_classical_checkBox.Name = "question_classical_checkBox";
            question_classical_checkBox.Size = new Size(161, 50);
            question_classical_checkBox.TabIndex = 3;
            question_classical_checkBox.Text = "Classical";
            question_classical_checkBox.UseVisualStyleBackColor = true;
            // 
            // question_metal_checkBox
            // 
            question_metal_checkBox.AutoSize = true;
            question_metal_checkBox.Cursor = Cursors.Hand;
            question_metal_checkBox.FlatStyle = FlatStyle.Flat;
            question_metal_checkBox.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            question_metal_checkBox.Location = new Point(147, 250);
            question_metal_checkBox.Name = "question_metal_checkBox";
            question_metal_checkBox.Size = new Size(124, 50);
            question_metal_checkBox.TabIndex = 2;
            question_metal_checkBox.Text = "Metal";
            question_metal_checkBox.UseVisualStyleBackColor = true;
            // 
            // question_rock_checkBox
            // 
            question_rock_checkBox.AutoSize = true;
            question_rock_checkBox.Cursor = Cursors.Hand;
            question_rock_checkBox.FlatStyle = FlatStyle.Flat;
            question_rock_checkBox.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            question_rock_checkBox.Location = new Point(147, 142);
            question_rock_checkBox.Name = "question_rock_checkBox";
            question_rock_checkBox.Size = new Size(110, 50);
            question_rock_checkBox.TabIndex = 1;
            question_rock_checkBox.Text = "Rock";
            question_rock_checkBox.UseVisualStyleBackColor = true;
            // 
            // question_label
            // 
            question_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            question_label.Location = new Point(378, 50);
            question_label.Name = "question_label";
            question_label.Size = new Size(244, 59);
            question_label.TabIndex = 0;
            question_label.Text = "What music do you like?";
            question_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // question_title_label
            // 
            question_title_label.Enabled = false;
            question_title_label.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            question_title_label.Location = new Point(694, 200);
            question_title_label.Name = "question_title_label";
            question_title_label.Size = new Size(532, 78);
            question_title_label.TabIndex = 2;
            question_title_label.Text = "As a new user we will ask you a question\r\nto configure your preferences";
            question_title_label.TextAlign = ContentAlignment.MiddleCenter;
            question_title_label.Visible = false;
            // 
            // main_panel
            // 
            main_panel.Controls.Add(mood_panel);
            main_panel.Controls.Add(liked_songs_panel);
            main_panel.Controls.Add(statistics_panel);
            main_panel.Controls.Add(main_recommendations_panel);
            main_panel.Controls.Add(menu_button);
            main_panel.Controls.Add(clock_label);
            main_panel.Controls.Add(settings_button);
            main_panel.Controls.Add(clock_pictureBox);
            main_panel.Controls.Add(settings_panel);
            main_panel.Controls.Add(main_magnifier_button);
            main_panel.Controls.Add(main_search_textBox);
            main_panel.Controls.Add(menu_panel);
            main_panel.Controls.Add(main_search_listBox);
            main_panel.Dock = DockStyle.Fill;
            main_panel.Location = new Point(0, 0);
            main_panel.Name = "main_panel";
            main_panel.Size = new Size(1902, 1033);
            main_panel.TabIndex = 3;
            main_panel.Visible = false;
            main_panel.VisibleChanged += main_panel_visible_changed;
            main_panel.Click += HideSearchSettingsAndMenu;
            // 
            // mood_panel
            // 
            mood_panel.Controls.Add(mood_music_label);
            mood_panel.Controls.Add(mood_listen_label);
            mood_panel.Controls.Add(mood_comboBox);
            mood_panel.Controls.Add(mood_rec_panel);
            mood_panel.Location = new Point(336, 68);
            mood_panel.Name = "mood_panel";
            mood_panel.Size = new Size(1230, 959);
            mood_panel.TabIndex = 41;
            mood_panel.Visible = false;
            mood_panel.Click += HideSearchSettingsAndMenu;
            // 
            // mood_music_label
            // 
            mood_music_label.AutoSize = true;
            mood_music_label.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            mood_music_label.Location = new Point(785, 132);
            mood_music_label.Name = "mood_music_label";
            mood_music_label.Size = new Size(90, 38);
            mood_music_label.TabIndex = 4;
            mood_music_label.Text = "Music";
            mood_music_label.Click += HideSearchSettingsAndMenu;
            // 
            // mood_listen_label
            // 
            mood_listen_label.AutoSize = true;
            mood_listen_label.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            mood_listen_label.Location = new Point(327, 132);
            mood_listen_label.Name = "mood_listen_label";
            mood_listen_label.Size = new Size(198, 38);
            mood_listen_label.TabIndex = 3;
            mood_listen_label.Text = "I want to listen";
            mood_listen_label.Click += HideSearchSettingsAndMenu;
            // 
            // mood_comboBox
            // 
            mood_comboBox.BackColor = Color.Teal;
            mood_comboBox.Cursor = Cursors.Hand;
            mood_comboBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            mood_comboBox.FormattingEnabled = true;
            mood_comboBox.Items.AddRange(new object[] { "Happy", "Excited", "Love", "Nostalgic", "Sad", "Uplifting", "Energetic", "Catchy", "Rebellion", "Empowerment", "Angry", "Elegance", "Inspirational", "Peaceful", "Calming", "Joyful", "Danceable", "Relaxed", "Suspense", "Melancholic", "Dark", "Moody" });
            mood_comboBox.Location = new Point(531, 129);
            mood_comboBox.Name = "mood_comboBox";
            mood_comboBox.Size = new Size(248, 45);
            mood_comboBox.TabIndex = 2;
            mood_comboBox.Text = "Happy";
            mood_comboBox.SelectedIndexChanged += mood_comboBox_SelectedIndexChanged;
            mood_comboBox.Click += HideSearchSettingsAndMenu;
            // 
            // mood_rec_panel
            // 
            mood_rec_panel.BorderStyle = BorderStyle.FixedSingle;
            mood_rec_panel.Controls.Add(mood_rec_refresh_button);
            mood_rec_panel.Controls.Add(mood_heart_button5);
            mood_rec_panel.Controls.Add(mood_heart_button4);
            mood_rec_panel.Controls.Add(mood_heart_button3);
            mood_rec_panel.Controls.Add(mood_heart_button2);
            mood_rec_panel.Controls.Add(mood_heart_button1);
            mood_rec_panel.Controls.Add(mood_year_label5);
            mood_rec_panel.Controls.Add(mood_year_label4);
            mood_rec_panel.Controls.Add(mood_year_label3);
            mood_rec_panel.Controls.Add(mood_year_label2);
            mood_rec_panel.Controls.Add(mood_artist_label5);
            mood_rec_panel.Controls.Add(mood_artist_label4);
            mood_rec_panel.Controls.Add(mood_artist_label3);
            mood_rec_panel.Controls.Add(mood_artist_label2);
            mood_rec_panel.Controls.Add(mood_year_label1);
            mood_rec_panel.Controls.Add(mood_artist_label1);
            mood_rec_panel.Controls.Add(mood_year_label);
            mood_rec_panel.Controls.Add(mood_art_label);
            mood_rec_panel.Controls.Add(mood_tit_label);
            mood_rec_panel.Controls.Add(mood_title_button5);
            mood_rec_panel.Controls.Add(mood_title_button4);
            mood_rec_panel.Controls.Add(mood_title_button3);
            mood_rec_panel.Controls.Add(mood_title_button2);
            mood_rec_panel.Controls.Add(mood_title_button1);
            mood_rec_panel.Controls.Add(mood_rec_label);
            mood_rec_panel.Location = new Point(286, 229);
            mood_rec_panel.Name = "mood_rec_panel";
            mood_rec_panel.Size = new Size(658, 500);
            mood_rec_panel.TabIndex = 1;
            mood_rec_panel.Click += HideSearchSettingsAndMenu;
            // 
            // mood_rec_refresh_button
            // 
            mood_rec_refresh_button.BackColor = Color.DarkSlateGray;
            mood_rec_refresh_button.BackgroundImage = Properties.Resources.refresh;
            mood_rec_refresh_button.BackgroundImageLayout = ImageLayout.Zoom;
            mood_rec_refresh_button.Cursor = Cursors.Hand;
            mood_rec_refresh_button.FlatAppearance.BorderSize = 0;
            mood_rec_refresh_button.FlatStyle = FlatStyle.Flat;
            mood_rec_refresh_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            mood_rec_refresh_button.ForeColor = Color.Navy;
            mood_rec_refresh_button.Location = new Point(595, 3);
            mood_rec_refresh_button.Name = "mood_rec_refresh_button";
            mood_rec_refresh_button.Size = new Size(57, 27);
            mood_rec_refresh_button.TabIndex = 33;
            mood_rec_refresh_button.UseVisualStyleBackColor = false;
            mood_rec_refresh_button.Click += mood_comboBox_SelectedIndexChanged;
            // 
            // mood_heart_button5
            // 
            mood_heart_button5.BackColor = Color.DarkSlateGray;
            mood_heart_button5.BackgroundImage = Properties.Resources.heartUnfilled;
            mood_heart_button5.BackgroundImageLayout = ImageLayout.Zoom;
            mood_heart_button5.Cursor = Cursors.Hand;
            mood_heart_button5.FlatAppearance.BorderSize = 0;
            mood_heart_button5.FlatStyle = FlatStyle.Flat;
            mood_heart_button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            mood_heart_button5.ForeColor = Color.Navy;
            mood_heart_button5.Location = new Point(595, 416);
            mood_heart_button5.Name = "mood_heart_button5";
            mood_heart_button5.Size = new Size(57, 27);
            mood_heart_button5.TabIndex = 32;
            mood_heart_button5.UseVisualStyleBackColor = false;
            mood_heart_button5.Click += heart_button_Click;
            // 
            // mood_heart_button4
            // 
            mood_heart_button4.BackColor = Color.DarkSlateGray;
            mood_heart_button4.BackgroundImage = Properties.Resources.heartUnfilled;
            mood_heart_button4.BackgroundImageLayout = ImageLayout.Zoom;
            mood_heart_button4.Cursor = Cursors.Hand;
            mood_heart_button4.FlatAppearance.BorderSize = 0;
            mood_heart_button4.FlatStyle = FlatStyle.Flat;
            mood_heart_button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            mood_heart_button4.ForeColor = Color.Navy;
            mood_heart_button4.Location = new Point(595, 345);
            mood_heart_button4.Name = "mood_heart_button4";
            mood_heart_button4.Size = new Size(57, 27);
            mood_heart_button4.TabIndex = 31;
            mood_heart_button4.UseVisualStyleBackColor = false;
            mood_heart_button4.Click += heart_button_Click;
            // 
            // mood_heart_button3
            // 
            mood_heart_button3.BackColor = Color.DarkSlateGray;
            mood_heart_button3.BackgroundImage = Properties.Resources.heartUnfilled;
            mood_heart_button3.BackgroundImageLayout = ImageLayout.Zoom;
            mood_heart_button3.Cursor = Cursors.Hand;
            mood_heart_button3.FlatAppearance.BorderSize = 0;
            mood_heart_button3.FlatStyle = FlatStyle.Flat;
            mood_heart_button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            mood_heart_button3.ForeColor = Color.Navy;
            mood_heart_button3.Location = new Point(595, 272);
            mood_heart_button3.Name = "mood_heart_button3";
            mood_heart_button3.Size = new Size(57, 27);
            mood_heart_button3.TabIndex = 30;
            mood_heart_button3.UseVisualStyleBackColor = false;
            mood_heart_button3.Click += heart_button_Click;
            // 
            // mood_heart_button2
            // 
            mood_heart_button2.BackColor = Color.DarkSlateGray;
            mood_heart_button2.BackgroundImage = Properties.Resources.heartUnfilled;
            mood_heart_button2.BackgroundImageLayout = ImageLayout.Zoom;
            mood_heart_button2.Cursor = Cursors.Hand;
            mood_heart_button2.FlatAppearance.BorderSize = 0;
            mood_heart_button2.FlatStyle = FlatStyle.Flat;
            mood_heart_button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            mood_heart_button2.ForeColor = Color.Navy;
            mood_heart_button2.Location = new Point(595, 203);
            mood_heart_button2.Name = "mood_heart_button2";
            mood_heart_button2.Size = new Size(57, 27);
            mood_heart_button2.TabIndex = 29;
            mood_heart_button2.UseVisualStyleBackColor = false;
            mood_heart_button2.Click += heart_button_Click;
            // 
            // mood_heart_button1
            // 
            mood_heart_button1.BackColor = Color.DarkSlateGray;
            mood_heart_button1.BackgroundImage = Properties.Resources.heartUnfilled;
            mood_heart_button1.BackgroundImageLayout = ImageLayout.Zoom;
            mood_heart_button1.Cursor = Cursors.Hand;
            mood_heart_button1.FlatAppearance.BorderSize = 0;
            mood_heart_button1.FlatStyle = FlatStyle.Flat;
            mood_heart_button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            mood_heart_button1.ForeColor = Color.Navy;
            mood_heart_button1.Location = new Point(595, 132);
            mood_heart_button1.Name = "mood_heart_button1";
            mood_heart_button1.Size = new Size(57, 27);
            mood_heart_button1.TabIndex = 7;
            mood_heart_button1.UseVisualStyleBackColor = false;
            mood_heart_button1.Click += heart_button_Click;
            // 
            // mood_year_label5
            // 
            mood_year_label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            mood_year_label5.Location = new Point(521, 411);
            mood_year_label5.Name = "mood_year_label5";
            mood_year_label5.Size = new Size(74, 36);
            mood_year_label5.TabIndex = 28;
            mood_year_label5.Text = "Year 5";
            mood_year_label5.TextAlign = ContentAlignment.MiddleCenter;
            mood_year_label5.Click += HideSearchSettingsAndMenu;
            // 
            // mood_year_label4
            // 
            mood_year_label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            mood_year_label4.Location = new Point(521, 339);
            mood_year_label4.Name = "mood_year_label4";
            mood_year_label4.Size = new Size(74, 36);
            mood_year_label4.TabIndex = 27;
            mood_year_label4.Text = "Year 4";
            mood_year_label4.TextAlign = ContentAlignment.MiddleCenter;
            mood_year_label4.Click += HideSearchSettingsAndMenu;
            // 
            // mood_year_label3
            // 
            mood_year_label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            mood_year_label3.Location = new Point(521, 269);
            mood_year_label3.Name = "mood_year_label3";
            mood_year_label3.Size = new Size(74, 36);
            mood_year_label3.TabIndex = 26;
            mood_year_label3.Text = "Year 3";
            mood_year_label3.TextAlign = ContentAlignment.MiddleCenter;
            mood_year_label3.Click += HideSearchSettingsAndMenu;
            // 
            // mood_year_label2
            // 
            mood_year_label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            mood_year_label2.Location = new Point(521, 199);
            mood_year_label2.Name = "mood_year_label2";
            mood_year_label2.Size = new Size(74, 36);
            mood_year_label2.TabIndex = 25;
            mood_year_label2.Text = "Year 2";
            mood_year_label2.TextAlign = ContentAlignment.MiddleCenter;
            mood_year_label2.Click += HideSearchSettingsAndMenu;
            // 
            // mood_artist_label5
            // 
            mood_artist_label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            mood_artist_label5.Location = new Point(328, 411);
            mood_artist_label5.Name = "mood_artist_label5";
            mood_artist_label5.Size = new Size(187, 36);
            mood_artist_label5.TabIndex = 24;
            mood_artist_label5.Text = "Artist 5";
            mood_artist_label5.TextAlign = ContentAlignment.MiddleCenter;
            mood_artist_label5.Click += HideSearchSettingsAndMenu;
            // 
            // mood_artist_label4
            // 
            mood_artist_label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            mood_artist_label4.Location = new Point(328, 339);
            mood_artist_label4.Name = "mood_artist_label4";
            mood_artist_label4.Size = new Size(187, 36);
            mood_artist_label4.TabIndex = 23;
            mood_artist_label4.Text = "Artist 4";
            mood_artist_label4.TextAlign = ContentAlignment.MiddleCenter;
            mood_artist_label4.Click += HideSearchSettingsAndMenu;
            // 
            // mood_artist_label3
            // 
            mood_artist_label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            mood_artist_label3.Location = new Point(328, 270);
            mood_artist_label3.Name = "mood_artist_label3";
            mood_artist_label3.Size = new Size(187, 36);
            mood_artist_label3.TabIndex = 22;
            mood_artist_label3.Text = "Artist 3";
            mood_artist_label3.TextAlign = ContentAlignment.MiddleCenter;
            mood_artist_label3.Click += HideSearchSettingsAndMenu;
            // 
            // mood_artist_label2
            // 
            mood_artist_label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            mood_artist_label2.Location = new Point(328, 199);
            mood_artist_label2.Name = "mood_artist_label2";
            mood_artist_label2.Size = new Size(187, 36);
            mood_artist_label2.TabIndex = 21;
            mood_artist_label2.Text = "Artist 2";
            mood_artist_label2.TextAlign = ContentAlignment.MiddleCenter;
            mood_artist_label2.Click += HideSearchSettingsAndMenu;
            // 
            // mood_year_label1
            // 
            mood_year_label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            mood_year_label1.Location = new Point(521, 127);
            mood_year_label1.Name = "mood_year_label1";
            mood_year_label1.Size = new Size(74, 36);
            mood_year_label1.TabIndex = 20;
            mood_year_label1.Text = "Year 1";
            mood_year_label1.TextAlign = ContentAlignment.MiddleCenter;
            mood_year_label1.Click += HideSearchSettingsAndMenu;
            // 
            // mood_artist_label1
            // 
            mood_artist_label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            mood_artist_label1.Location = new Point(328, 127);
            mood_artist_label1.Name = "mood_artist_label1";
            mood_artist_label1.Size = new Size(187, 36);
            mood_artist_label1.TabIndex = 19;
            mood_artist_label1.Text = "Artist 1";
            mood_artist_label1.TextAlign = ContentAlignment.MiddleCenter;
            mood_artist_label1.Click += HideSearchSettingsAndMenu;
            // 
            // mood_year_label
            // 
            mood_year_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            mood_year_label.Location = new Point(521, 55);
            mood_year_label.Name = "mood_year_label";
            mood_year_label.Size = new Size(74, 36);
            mood_year_label.TabIndex = 10;
            mood_year_label.Text = "Year";
            mood_year_label.TextAlign = ContentAlignment.MiddleCenter;
            mood_year_label.Click += HideSearchSettingsAndMenu;
            // 
            // mood_art_label
            // 
            mood_art_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            mood_art_label.Location = new Point(328, 55);
            mood_art_label.Name = "mood_art_label";
            mood_art_label.Size = new Size(187, 36);
            mood_art_label.TabIndex = 9;
            mood_art_label.Text = "Artist";
            mood_art_label.TextAlign = ContentAlignment.MiddleCenter;
            mood_art_label.Click += HideSearchSettingsAndMenu;
            // 
            // mood_tit_label
            // 
            mood_tit_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            mood_tit_label.Location = new Point(3, 55);
            mood_tit_label.Name = "mood_tit_label";
            mood_tit_label.Size = new Size(319, 36);
            mood_tit_label.TabIndex = 6;
            mood_tit_label.Text = "Title";
            mood_tit_label.TextAlign = ContentAlignment.MiddleCenter;
            mood_tit_label.Click += HideSearchSettingsAndMenu;
            // 
            // mood_title_button5
            // 
            mood_title_button5.AutoEllipsis = true;
            mood_title_button5.Cursor = Cursors.Hand;
            mood_title_button5.FlatAppearance.BorderSize = 0;
            mood_title_button5.FlatStyle = FlatStyle.Flat;
            mood_title_button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            mood_title_button5.ForeColor = Color.Black;
            mood_title_button5.Location = new Point(3, 410);
            mood_title_button5.Name = "mood_title_button5";
            mood_title_button5.Size = new Size(319, 38);
            mood_title_button5.TabIndex = 5;
            mood_title_button5.Text = "Title 5";
            mood_title_button5.TextAlign = ContentAlignment.MiddleLeft;
            mood_title_button5.UseVisualStyleBackColor = true;
            mood_title_button5.Click += title_button_Click;
            // 
            // mood_title_button4
            // 
            mood_title_button4.AutoEllipsis = true;
            mood_title_button4.Cursor = Cursors.Hand;
            mood_title_button4.FlatAppearance.BorderSize = 0;
            mood_title_button4.FlatStyle = FlatStyle.Flat;
            mood_title_button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            mood_title_button4.ForeColor = Color.Black;
            mood_title_button4.Location = new Point(3, 339);
            mood_title_button4.Name = "mood_title_button4";
            mood_title_button4.Size = new Size(319, 38);
            mood_title_button4.TabIndex = 4;
            mood_title_button4.Text = "Title 4";
            mood_title_button4.TextAlign = ContentAlignment.MiddleLeft;
            mood_title_button4.UseVisualStyleBackColor = true;
            mood_title_button4.Click += title_button_Click;
            // 
            // mood_title_button3
            // 
            mood_title_button3.AutoEllipsis = true;
            mood_title_button3.Cursor = Cursors.Hand;
            mood_title_button3.FlatAppearance.BorderSize = 0;
            mood_title_button3.FlatStyle = FlatStyle.Flat;
            mood_title_button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            mood_title_button3.ForeColor = Color.Black;
            mood_title_button3.Location = new Point(3, 268);
            mood_title_button3.Name = "mood_title_button3";
            mood_title_button3.Size = new Size(319, 38);
            mood_title_button3.TabIndex = 3;
            mood_title_button3.Text = "Title 3";
            mood_title_button3.TextAlign = ContentAlignment.MiddleLeft;
            mood_title_button3.UseVisualStyleBackColor = true;
            mood_title_button3.Click += title_button_Click;
            // 
            // mood_title_button2
            // 
            mood_title_button2.AutoEllipsis = true;
            mood_title_button2.Cursor = Cursors.Hand;
            mood_title_button2.FlatAppearance.BorderSize = 0;
            mood_title_button2.FlatStyle = FlatStyle.Flat;
            mood_title_button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            mood_title_button2.ForeColor = Color.Black;
            mood_title_button2.Location = new Point(3, 197);
            mood_title_button2.Name = "mood_title_button2";
            mood_title_button2.Size = new Size(319, 38);
            mood_title_button2.TabIndex = 2;
            mood_title_button2.Text = "Title 2";
            mood_title_button2.TextAlign = ContentAlignment.MiddleLeft;
            mood_title_button2.UseVisualStyleBackColor = true;
            mood_title_button2.Click += title_button_Click;
            // 
            // mood_title_button1
            // 
            mood_title_button1.AutoEllipsis = true;
            mood_title_button1.Cursor = Cursors.Hand;
            mood_title_button1.FlatAppearance.BorderSize = 0;
            mood_title_button1.FlatStyle = FlatStyle.Flat;
            mood_title_button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            mood_title_button1.ForeColor = Color.Black;
            mood_title_button1.Location = new Point(3, 126);
            mood_title_button1.Name = "mood_title_button1";
            mood_title_button1.Size = new Size(319, 38);
            mood_title_button1.TabIndex = 1;
            mood_title_button1.Text = "Title 1";
            mood_title_button1.TextAlign = ContentAlignment.MiddleLeft;
            mood_title_button1.UseVisualStyleBackColor = true;
            mood_title_button1.Click += title_button_Click;
            // 
            // mood_rec_label
            // 
            mood_rec_label.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            mood_rec_label.Location = new Point(179, 0);
            mood_rec_label.Name = "mood_rec_label";
            mood_rec_label.Size = new Size(302, 36);
            mood_rec_label.TabIndex = 0;
            mood_rec_label.Text = "Recommendations";
            mood_rec_label.TextAlign = ContentAlignment.TopCenter;
            mood_rec_label.Click += HideSearchSettingsAndMenu;
            // 
            // liked_songs_panel
            // 
            liked_songs_panel.Controls.Add(liked_songs_listView);
            liked_songs_panel.Controls.Add(liked_songs_label);
            liked_songs_panel.Location = new Point(336, 68);
            liked_songs_panel.Name = "liked_songs_panel";
            liked_songs_panel.Size = new Size(1230, 959);
            liked_songs_panel.TabIndex = 40;
            liked_songs_panel.Visible = false;
            liked_songs_panel.Click += HideSearchSettingsAndMenu;
            // 
            // liked_songs_listView
            // 
            liked_songs_listView.BackColor = Color.Teal;
            liked_songs_listView.Columns.AddRange(new ColumnHeader[] { likedSongs_title_columnHeader, likedSongs_artist_columnHeader, likedSongs_year_columnHeader });
            liked_songs_listView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            liked_songs_listView.FullRowSelect = true;
            liked_songs_listView.Location = new Point(160, 205);
            liked_songs_listView.Name = "liked_songs_listView";
            liked_songs_listView.Size = new Size(910, 562);
            liked_songs_listView.TabIndex = 1;
            liked_songs_listView.UseCompatibleStateImageBehavior = false;
            liked_songs_listView.View = View.Details;
            liked_songs_listView.Click += HideSearchSettingsAndMenu;
            // 
            // likedSongs_title_columnHeader
            // 
            likedSongs_title_columnHeader.Text = "Title";
            likedSongs_title_columnHeader.Width = 400;
            // 
            // likedSongs_artist_columnHeader
            // 
            likedSongs_artist_columnHeader.Text = "Artist";
            likedSongs_artist_columnHeader.Width = 400;
            // 
            // likedSongs_year_columnHeader
            // 
            likedSongs_year_columnHeader.Text = "Year";
            likedSongs_year_columnHeader.Width = 100;
            // 
            // liked_songs_label
            // 
            liked_songs_label.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            liked_songs_label.Location = new Point(363, 132);
            liked_songs_label.Name = "liked_songs_label";
            liked_songs_label.Size = new Size(504, 70);
            liked_songs_label.TabIndex = 35;
            liked_songs_label.Text = "Here you can see the songs that you like";
            liked_songs_label.TextAlign = ContentAlignment.TopCenter;
            liked_songs_label.Click += HideSearchSettingsAndMenu;
            // 
            // statistics_panel
            // 
            statistics_panel.Controls.Add(separator_panel2);
            statistics_panel.Controls.Add(separator_panel1);
            statistics_panel.Controls.Add(genre_like_label);
            statistics_panel.Controls.Add(genre_like_listView);
            statistics_panel.Controls.Add(count_like_label);
            statistics_panel.Controls.Add(count_clicks_label);
            statistics_panel.Controls.Add(count_clicks_listView);
            statistics_panel.Location = new Point(336, 68);
            statistics_panel.Name = "statistics_panel";
            statistics_panel.Size = new Size(1230, 959);
            statistics_panel.TabIndex = 41;
            statistics_panel.Visible = false;
            statistics_panel.Click += HideSearchSettingsAndMenu;
            // 
            // separator_panel2
            // 
            separator_panel2.BackColor = Color.Black;
            separator_panel2.Location = new Point(0, 822);
            separator_panel2.Name = "separator_panel2";
            separator_panel2.Size = new Size(1230, 11);
            separator_panel2.TabIndex = 39;
            separator_panel2.Click += HideSearchSettingsAndMenu;
            // 
            // separator_panel1
            // 
            separator_panel1.BackColor = Color.Black;
            separator_panel1.Location = new Point(0, 411);
            separator_panel1.Name = "separator_panel1";
            separator_panel1.Size = new Size(1230, 11);
            separator_panel1.TabIndex = 38;
            separator_panel1.Click += HideSearchSettingsAndMenu;
            // 
            // genre_like_label
            // 
            genre_like_label.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            genre_like_label.Location = new Point(440, 439);
            genre_like_label.Name = "genre_like_label";
            genre_like_label.Size = new Size(351, 75);
            genre_like_label.TabIndex = 37;
            genre_like_label.Text = "Here you can see the genres that you like";
            genre_like_label.TextAlign = ContentAlignment.TopCenter;
            genre_like_label.Click += HideSearchSettingsAndMenu;
            // 
            // genre_like_listView
            // 
            genre_like_listView.BackColor = Color.Teal;
            genre_like_listView.Columns.AddRange(new ColumnHeader[] { statistics_genre_columnHeader });
            genre_like_listView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            genre_like_listView.FullRowSelect = true;
            genre_like_listView.Location = new Point(363, 517);
            genre_like_listView.Name = "genre_like_listView";
            genre_like_listView.Size = new Size(499, 285);
            genre_like_listView.TabIndex = 36;
            genre_like_listView.UseCompatibleStateImageBehavior = false;
            genre_like_listView.View = View.Details;
            genre_like_listView.Click += HideSearchSettingsAndMenu;
            // 
            // statistics_genre_columnHeader
            // 
            statistics_genre_columnHeader.Text = "Genre";
            statistics_genre_columnHeader.Width = 345;
            // 
            // count_like_label
            // 
            count_like_label.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            count_like_label.Location = new Point(357, 864);
            count_like_label.Name = "count_like_label";
            count_like_label.Size = new Size(516, 34);
            count_like_label.TabIndex = 35;
            count_like_label.Text = "Songs that you like in total: 22";
            count_like_label.TextAlign = ContentAlignment.TopCenter;
            count_like_label.Click += HideSearchSettingsAndMenu;
            // 
            // count_clicks_label
            // 
            count_clicks_label.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            count_clicks_label.Location = new Point(363, 25);
            count_clicks_label.Name = "count_clicks_label";
            count_clicks_label.Size = new Size(504, 70);
            count_clicks_label.TabIndex = 34;
            count_clicks_label.Text = "Here you can see how many clicks you have done per song";
            count_clicks_label.TextAlign = ContentAlignment.TopCenter;
            count_clicks_label.Click += HideSearchSettingsAndMenu;
            // 
            // count_clicks_listView
            // 
            count_clicks_listView.BackColor = Color.Teal;
            count_clicks_listView.Columns.AddRange(new ColumnHeader[] { statistics_song_columnHeader, statistics_click_columnHeader });
            count_clicks_listView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            count_clicks_listView.FullRowSelect = true;
            count_clicks_listView.Location = new Point(363, 98);
            count_clicks_listView.Name = "count_clicks_listView";
            count_clicks_listView.Size = new Size(499, 285);
            count_clicks_listView.TabIndex = 0;
            count_clicks_listView.UseCompatibleStateImageBehavior = false;
            count_clicks_listView.View = View.Details;
            count_clicks_listView.Click += HideSearchSettingsAndMenu;
            // 
            // statistics_song_columnHeader
            // 
            statistics_song_columnHeader.Text = "Song";
            statistics_song_columnHeader.Width = 350;
            // 
            // statistics_click_columnHeader
            // 
            statistics_click_columnHeader.Text = "Clicks";
            statistics_click_columnHeader.Width = 100;
            // 
            // main_recommendations_panel
            // 
            main_recommendations_panel.BorderStyle = BorderStyle.FixedSingle;
            main_recommendations_panel.Controls.Add(main_recommendations_refresh_button);
            main_recommendations_panel.Controls.Add(main_recommendations_heart5_button);
            main_recommendations_panel.Controls.Add(main_recommendations_heart4_button);
            main_recommendations_panel.Controls.Add(main_recommendations_heart3_button);
            main_recommendations_panel.Controls.Add(main_recommendations_heart2_button);
            main_recommendations_panel.Controls.Add(main_recommendations_heart1_button);
            main_recommendations_panel.Controls.Add(main_recommendations_released5_label);
            main_recommendations_panel.Controls.Add(main_recommendations_released4_label);
            main_recommendations_panel.Controls.Add(main_recommendations_released3_label);
            main_recommendations_panel.Controls.Add(main_recommendations_released2_label);
            main_recommendations_panel.Controls.Add(main_recommendations_artist5_label);
            main_recommendations_panel.Controls.Add(main_recommendations_artist4_label);
            main_recommendations_panel.Controls.Add(main_recommendations_artist3_label);
            main_recommendations_panel.Controls.Add(main_recommendations_artist2_label);
            main_recommendations_panel.Controls.Add(main_recommendations_released1_label);
            main_recommendations_panel.Controls.Add(main_recommendations_artist1_label);
            main_recommendations_panel.Controls.Add(main_recommendations_year_label);
            main_recommendations_panel.Controls.Add(main_recommendations_artist_label);
            main_recommendations_panel.Controls.Add(main_recommendations_title_label);
            main_recommendations_panel.Controls.Add(main_recommendations_title5_button);
            main_recommendations_panel.Controls.Add(main_recommendations_title4_button);
            main_recommendations_panel.Controls.Add(main_recommendations_title3_button);
            main_recommendations_panel.Controls.Add(main_recommendations_title2_button);
            main_recommendations_panel.Controls.Add(main_recommendations_title1_button);
            main_recommendations_panel.Controls.Add(main_recommendations_label);
            main_recommendations_panel.Location = new Point(622, 303);
            main_recommendations_panel.Name = "main_recommendations_panel";
            main_recommendations_panel.Size = new Size(658, 500);
            main_recommendations_panel.TabIndex = 0;
            main_recommendations_panel.Click += HideSearchSettingsAndMenu;
            // 
            // main_recommendations_refresh_button
            // 
            main_recommendations_refresh_button.BackColor = Color.DarkSlateGray;
            main_recommendations_refresh_button.BackgroundImage = Properties.Resources.refresh;
            main_recommendations_refresh_button.BackgroundImageLayout = ImageLayout.Zoom;
            main_recommendations_refresh_button.Cursor = Cursors.Hand;
            main_recommendations_refresh_button.FlatAppearance.BorderSize = 0;
            main_recommendations_refresh_button.FlatStyle = FlatStyle.Flat;
            main_recommendations_refresh_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            main_recommendations_refresh_button.ForeColor = Color.Navy;
            main_recommendations_refresh_button.Location = new Point(595, 3);
            main_recommendations_refresh_button.Name = "main_recommendations_refresh_button";
            main_recommendations_refresh_button.Size = new Size(57, 27);
            main_recommendations_refresh_button.TabIndex = 33;
            main_recommendations_refresh_button.UseVisualStyleBackColor = false;
            main_recommendations_refresh_button.Click += main_panel_visible_changed;
            // 
            // main_recommendations_heart5_button
            // 
            main_recommendations_heart5_button.BackColor = Color.DarkSlateGray;
            main_recommendations_heart5_button.BackgroundImage = Properties.Resources.heartUnfilled;
            main_recommendations_heart5_button.BackgroundImageLayout = ImageLayout.Zoom;
            main_recommendations_heart5_button.Cursor = Cursors.Hand;
            main_recommendations_heart5_button.FlatAppearance.BorderSize = 0;
            main_recommendations_heart5_button.FlatStyle = FlatStyle.Flat;
            main_recommendations_heart5_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            main_recommendations_heart5_button.ForeColor = Color.Navy;
            main_recommendations_heart5_button.Location = new Point(595, 416);
            main_recommendations_heart5_button.Name = "main_recommendations_heart5_button";
            main_recommendations_heart5_button.Size = new Size(57, 27);
            main_recommendations_heart5_button.TabIndex = 32;
            main_recommendations_heart5_button.UseVisualStyleBackColor = false;
            main_recommendations_heart5_button.Click += heart_button_Click;
            // 
            // main_recommendations_heart4_button
            // 
            main_recommendations_heart4_button.BackColor = Color.DarkSlateGray;
            main_recommendations_heart4_button.BackgroundImage = Properties.Resources.heartUnfilled;
            main_recommendations_heart4_button.BackgroundImageLayout = ImageLayout.Zoom;
            main_recommendations_heart4_button.Cursor = Cursors.Hand;
            main_recommendations_heart4_button.FlatAppearance.BorderSize = 0;
            main_recommendations_heart4_button.FlatStyle = FlatStyle.Flat;
            main_recommendations_heart4_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            main_recommendations_heart4_button.ForeColor = Color.Navy;
            main_recommendations_heart4_button.Location = new Point(595, 345);
            main_recommendations_heart4_button.Name = "main_recommendations_heart4_button";
            main_recommendations_heart4_button.Size = new Size(57, 27);
            main_recommendations_heart4_button.TabIndex = 31;
            main_recommendations_heart4_button.UseVisualStyleBackColor = false;
            main_recommendations_heart4_button.Click += heart_button_Click;
            // 
            // main_recommendations_heart3_button
            // 
            main_recommendations_heart3_button.BackColor = Color.DarkSlateGray;
            main_recommendations_heart3_button.BackgroundImage = Properties.Resources.heartUnfilled;
            main_recommendations_heart3_button.BackgroundImageLayout = ImageLayout.Zoom;
            main_recommendations_heart3_button.Cursor = Cursors.Hand;
            main_recommendations_heart3_button.FlatAppearance.BorderSize = 0;
            main_recommendations_heart3_button.FlatStyle = FlatStyle.Flat;
            main_recommendations_heart3_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            main_recommendations_heart3_button.ForeColor = Color.Navy;
            main_recommendations_heart3_button.Location = new Point(595, 272);
            main_recommendations_heart3_button.Name = "main_recommendations_heart3_button";
            main_recommendations_heart3_button.Size = new Size(57, 27);
            main_recommendations_heart3_button.TabIndex = 30;
            main_recommendations_heart3_button.UseVisualStyleBackColor = false;
            main_recommendations_heart3_button.Click += heart_button_Click;
            // 
            // main_recommendations_heart2_button
            // 
            main_recommendations_heart2_button.BackColor = Color.DarkSlateGray;
            main_recommendations_heart2_button.BackgroundImage = Properties.Resources.heartUnfilled;
            main_recommendations_heart2_button.BackgroundImageLayout = ImageLayout.Zoom;
            main_recommendations_heart2_button.Cursor = Cursors.Hand;
            main_recommendations_heart2_button.FlatAppearance.BorderSize = 0;
            main_recommendations_heart2_button.FlatStyle = FlatStyle.Flat;
            main_recommendations_heart2_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            main_recommendations_heart2_button.ForeColor = Color.Navy;
            main_recommendations_heart2_button.Location = new Point(595, 203);
            main_recommendations_heart2_button.Name = "main_recommendations_heart2_button";
            main_recommendations_heart2_button.Size = new Size(57, 27);
            main_recommendations_heart2_button.TabIndex = 29;
            main_recommendations_heart2_button.UseVisualStyleBackColor = false;
            main_recommendations_heart2_button.Click += heart_button_Click;
            // 
            // main_recommendations_heart1_button
            // 
            main_recommendations_heart1_button.BackColor = Color.DarkSlateGray;
            main_recommendations_heart1_button.BackgroundImage = Properties.Resources.heartUnfilled;
            main_recommendations_heart1_button.BackgroundImageLayout = ImageLayout.Zoom;
            main_recommendations_heart1_button.Cursor = Cursors.Hand;
            main_recommendations_heart1_button.FlatAppearance.BorderSize = 0;
            main_recommendations_heart1_button.FlatStyle = FlatStyle.Flat;
            main_recommendations_heart1_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            main_recommendations_heart1_button.ForeColor = Color.Navy;
            main_recommendations_heart1_button.Location = new Point(595, 132);
            main_recommendations_heart1_button.Name = "main_recommendations_heart1_button";
            main_recommendations_heart1_button.Size = new Size(57, 27);
            main_recommendations_heart1_button.TabIndex = 7;
            main_recommendations_heart1_button.UseVisualStyleBackColor = false;
            main_recommendations_heart1_button.Click += heart_button_Click;
            // 
            // main_recommendations_released5_label
            // 
            main_recommendations_released5_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            main_recommendations_released5_label.Location = new Point(521, 411);
            main_recommendations_released5_label.Name = "main_recommendations_released5_label";
            main_recommendations_released5_label.Size = new Size(74, 36);
            main_recommendations_released5_label.TabIndex = 28;
            main_recommendations_released5_label.Text = "Year 5";
            main_recommendations_released5_label.TextAlign = ContentAlignment.MiddleCenter;
            main_recommendations_released5_label.Click += HideSearchSettingsAndMenu;
            // 
            // main_recommendations_released4_label
            // 
            main_recommendations_released4_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            main_recommendations_released4_label.Location = new Point(521, 339);
            main_recommendations_released4_label.Name = "main_recommendations_released4_label";
            main_recommendations_released4_label.Size = new Size(74, 36);
            main_recommendations_released4_label.TabIndex = 27;
            main_recommendations_released4_label.Text = "Year 4";
            main_recommendations_released4_label.TextAlign = ContentAlignment.MiddleCenter;
            main_recommendations_released4_label.Click += HideSearchSettingsAndMenu;
            // 
            // main_recommendations_released3_label
            // 
            main_recommendations_released3_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            main_recommendations_released3_label.Location = new Point(521, 269);
            main_recommendations_released3_label.Name = "main_recommendations_released3_label";
            main_recommendations_released3_label.Size = new Size(74, 36);
            main_recommendations_released3_label.TabIndex = 26;
            main_recommendations_released3_label.Text = "Year 3";
            main_recommendations_released3_label.TextAlign = ContentAlignment.MiddleCenter;
            main_recommendations_released3_label.Click += HideSearchSettingsAndMenu;
            // 
            // main_recommendations_released2_label
            // 
            main_recommendations_released2_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            main_recommendations_released2_label.Location = new Point(521, 199);
            main_recommendations_released2_label.Name = "main_recommendations_released2_label";
            main_recommendations_released2_label.Size = new Size(74, 36);
            main_recommendations_released2_label.TabIndex = 25;
            main_recommendations_released2_label.Text = "Year 2";
            main_recommendations_released2_label.TextAlign = ContentAlignment.MiddleCenter;
            main_recommendations_released2_label.Click += HideSearchSettingsAndMenu;
            // 
            // main_recommendations_artist5_label
            // 
            main_recommendations_artist5_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            main_recommendations_artist5_label.Location = new Point(328, 411);
            main_recommendations_artist5_label.Name = "main_recommendations_artist5_label";
            main_recommendations_artist5_label.Size = new Size(187, 36);
            main_recommendations_artist5_label.TabIndex = 24;
            main_recommendations_artist5_label.Text = "Artist 5";
            main_recommendations_artist5_label.TextAlign = ContentAlignment.MiddleCenter;
            main_recommendations_artist5_label.Click += HideSearchSettingsAndMenu;
            // 
            // main_recommendations_artist4_label
            // 
            main_recommendations_artist4_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            main_recommendations_artist4_label.Location = new Point(328, 339);
            main_recommendations_artist4_label.Name = "main_recommendations_artist4_label";
            main_recommendations_artist4_label.Size = new Size(187, 36);
            main_recommendations_artist4_label.TabIndex = 23;
            main_recommendations_artist4_label.Text = "Artist 4";
            main_recommendations_artist4_label.TextAlign = ContentAlignment.MiddleCenter;
            main_recommendations_artist4_label.Click += HideSearchSettingsAndMenu;
            // 
            // main_recommendations_artist3_label
            // 
            main_recommendations_artist3_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            main_recommendations_artist3_label.Location = new Point(328, 270);
            main_recommendations_artist3_label.Name = "main_recommendations_artist3_label";
            main_recommendations_artist3_label.Size = new Size(187, 36);
            main_recommendations_artist3_label.TabIndex = 22;
            main_recommendations_artist3_label.Text = "Artist 3";
            main_recommendations_artist3_label.TextAlign = ContentAlignment.MiddleCenter;
            main_recommendations_artist3_label.Click += HideSearchSettingsAndMenu;
            // 
            // main_recommendations_artist2_label
            // 
            main_recommendations_artist2_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            main_recommendations_artist2_label.Location = new Point(328, 199);
            main_recommendations_artist2_label.Name = "main_recommendations_artist2_label";
            main_recommendations_artist2_label.Size = new Size(187, 36);
            main_recommendations_artist2_label.TabIndex = 21;
            main_recommendations_artist2_label.Text = "Artist 2";
            main_recommendations_artist2_label.TextAlign = ContentAlignment.MiddleCenter;
            main_recommendations_artist2_label.Click += HideSearchSettingsAndMenu;
            // 
            // main_recommendations_released1_label
            // 
            main_recommendations_released1_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            main_recommendations_released1_label.Location = new Point(521, 127);
            main_recommendations_released1_label.Name = "main_recommendations_released1_label";
            main_recommendations_released1_label.Size = new Size(74, 36);
            main_recommendations_released1_label.TabIndex = 20;
            main_recommendations_released1_label.Text = "Year 1";
            main_recommendations_released1_label.TextAlign = ContentAlignment.MiddleCenter;
            main_recommendations_released1_label.Click += HideSearchSettingsAndMenu;
            // 
            // main_recommendations_artist1_label
            // 
            main_recommendations_artist1_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            main_recommendations_artist1_label.Location = new Point(328, 127);
            main_recommendations_artist1_label.Name = "main_recommendations_artist1_label";
            main_recommendations_artist1_label.Size = new Size(187, 36);
            main_recommendations_artist1_label.TabIndex = 19;
            main_recommendations_artist1_label.Text = "Artist 1";
            main_recommendations_artist1_label.TextAlign = ContentAlignment.MiddleCenter;
            main_recommendations_artist1_label.Click += HideSearchSettingsAndMenu;
            // 
            // main_recommendations_year_label
            // 
            main_recommendations_year_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            main_recommendations_year_label.Location = new Point(521, 55);
            main_recommendations_year_label.Name = "main_recommendations_year_label";
            main_recommendations_year_label.Size = new Size(74, 36);
            main_recommendations_year_label.TabIndex = 10;
            main_recommendations_year_label.Text = "Year";
            main_recommendations_year_label.TextAlign = ContentAlignment.MiddleCenter;
            main_recommendations_year_label.Click += HideSearchSettingsAndMenu;
            // 
            // main_recommendations_artist_label
            // 
            main_recommendations_artist_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            main_recommendations_artist_label.Location = new Point(328, 55);
            main_recommendations_artist_label.Name = "main_recommendations_artist_label";
            main_recommendations_artist_label.Size = new Size(187, 36);
            main_recommendations_artist_label.TabIndex = 9;
            main_recommendations_artist_label.Text = "Artist";
            main_recommendations_artist_label.TextAlign = ContentAlignment.MiddleCenter;
            main_recommendations_artist_label.Click += HideSearchSettingsAndMenu;
            // 
            // main_recommendations_title_label
            // 
            main_recommendations_title_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            main_recommendations_title_label.Location = new Point(3, 55);
            main_recommendations_title_label.Name = "main_recommendations_title_label";
            main_recommendations_title_label.Size = new Size(319, 36);
            main_recommendations_title_label.TabIndex = 6;
            main_recommendations_title_label.Text = "Title";
            main_recommendations_title_label.TextAlign = ContentAlignment.MiddleCenter;
            main_recommendations_title_label.Click += HideSearchSettingsAndMenu;
            // 
            // main_recommendations_title5_button
            // 
            main_recommendations_title5_button.AutoEllipsis = true;
            main_recommendations_title5_button.Cursor = Cursors.Hand;
            main_recommendations_title5_button.FlatAppearance.BorderSize = 0;
            main_recommendations_title5_button.FlatStyle = FlatStyle.Flat;
            main_recommendations_title5_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            main_recommendations_title5_button.ForeColor = Color.Black;
            main_recommendations_title5_button.Location = new Point(3, 410);
            main_recommendations_title5_button.Name = "main_recommendations_title5_button";
            main_recommendations_title5_button.Size = new Size(319, 38);
            main_recommendations_title5_button.TabIndex = 5;
            main_recommendations_title5_button.Text = "Title 5";
            main_recommendations_title5_button.TextAlign = ContentAlignment.MiddleLeft;
            main_recommendations_title5_button.UseVisualStyleBackColor = true;
            main_recommendations_title5_button.Click += title_button_Click;
            // 
            // main_recommendations_title4_button
            // 
            main_recommendations_title4_button.AutoEllipsis = true;
            main_recommendations_title4_button.Cursor = Cursors.Hand;
            main_recommendations_title4_button.FlatAppearance.BorderSize = 0;
            main_recommendations_title4_button.FlatStyle = FlatStyle.Flat;
            main_recommendations_title4_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            main_recommendations_title4_button.ForeColor = Color.Black;
            main_recommendations_title4_button.Location = new Point(3, 339);
            main_recommendations_title4_button.Name = "main_recommendations_title4_button";
            main_recommendations_title4_button.Size = new Size(319, 38);
            main_recommendations_title4_button.TabIndex = 4;
            main_recommendations_title4_button.Text = "Title 4";
            main_recommendations_title4_button.TextAlign = ContentAlignment.MiddleLeft;
            main_recommendations_title4_button.UseVisualStyleBackColor = true;
            main_recommendations_title4_button.Click += title_button_Click;
            // 
            // main_recommendations_title3_button
            // 
            main_recommendations_title3_button.AutoEllipsis = true;
            main_recommendations_title3_button.Cursor = Cursors.Hand;
            main_recommendations_title3_button.FlatAppearance.BorderSize = 0;
            main_recommendations_title3_button.FlatStyle = FlatStyle.Flat;
            main_recommendations_title3_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            main_recommendations_title3_button.ForeColor = Color.Black;
            main_recommendations_title3_button.Location = new Point(3, 268);
            main_recommendations_title3_button.Name = "main_recommendations_title3_button";
            main_recommendations_title3_button.Size = new Size(319, 38);
            main_recommendations_title3_button.TabIndex = 3;
            main_recommendations_title3_button.Text = "Title 3";
            main_recommendations_title3_button.TextAlign = ContentAlignment.MiddleLeft;
            main_recommendations_title3_button.UseVisualStyleBackColor = true;
            main_recommendations_title3_button.Click += title_button_Click;
            // 
            // main_recommendations_title2_button
            // 
            main_recommendations_title2_button.AutoEllipsis = true;
            main_recommendations_title2_button.Cursor = Cursors.Hand;
            main_recommendations_title2_button.FlatAppearance.BorderSize = 0;
            main_recommendations_title2_button.FlatStyle = FlatStyle.Flat;
            main_recommendations_title2_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            main_recommendations_title2_button.ForeColor = Color.Black;
            main_recommendations_title2_button.Location = new Point(3, 197);
            main_recommendations_title2_button.Name = "main_recommendations_title2_button";
            main_recommendations_title2_button.Size = new Size(319, 38);
            main_recommendations_title2_button.TabIndex = 2;
            main_recommendations_title2_button.Text = "Title 2";
            main_recommendations_title2_button.TextAlign = ContentAlignment.MiddleLeft;
            main_recommendations_title2_button.UseVisualStyleBackColor = true;
            main_recommendations_title2_button.Click += title_button_Click;
            // 
            // main_recommendations_title1_button
            // 
            main_recommendations_title1_button.AutoEllipsis = true;
            main_recommendations_title1_button.Cursor = Cursors.Hand;
            main_recommendations_title1_button.FlatAppearance.BorderSize = 0;
            main_recommendations_title1_button.FlatStyle = FlatStyle.Flat;
            main_recommendations_title1_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            main_recommendations_title1_button.ForeColor = Color.Black;
            main_recommendations_title1_button.Location = new Point(3, 126);
            main_recommendations_title1_button.Name = "main_recommendations_title1_button";
            main_recommendations_title1_button.Size = new Size(319, 38);
            main_recommendations_title1_button.TabIndex = 1;
            main_recommendations_title1_button.Text = "Title 1";
            main_recommendations_title1_button.TextAlign = ContentAlignment.MiddleLeft;
            main_recommendations_title1_button.UseVisualStyleBackColor = true;
            main_recommendations_title1_button.Click += title_button_Click;
            // 
            // main_recommendations_label
            // 
            main_recommendations_label.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            main_recommendations_label.Location = new Point(179, 0);
            main_recommendations_label.Name = "main_recommendations_label";
            main_recommendations_label.Size = new Size(302, 36);
            main_recommendations_label.TabIndex = 0;
            main_recommendations_label.Text = "Recommendations";
            main_recommendations_label.TextAlign = ContentAlignment.TopCenter;
            main_recommendations_label.Click += HideSearchSettingsAndMenu;
            // 
            // menu_button
            // 
            menu_button.BackColor = Color.DarkSlateGray;
            menu_button.BackgroundImage = Properties.Resources.menu;
            menu_button.BackgroundImageLayout = ImageLayout.Zoom;
            menu_button.Cursor = Cursors.Hand;
            menu_button.FlatAppearance.BorderSize = 0;
            menu_button.FlatStyle = FlatStyle.Flat;
            menu_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            menu_button.ForeColor = Color.Navy;
            menu_button.Location = new Point(12, 12);
            menu_button.Name = "menu_button";
            menu_button.Size = new Size(50, 50);
            menu_button.TabIndex = 36;
            menu_button.UseVisualStyleBackColor = false;
            menu_button.Click += menu_button_Click;
            // 
            // clock_label
            // 
            clock_label.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            clock_label.Location = new Point(392, 12);
            clock_label.Name = "clock_label";
            clock_label.Size = new Size(160, 50);
            clock_label.TabIndex = 40;
            clock_label.Text = "00 : 00 : 00";
            clock_label.TextAlign = ContentAlignment.MiddleCenter;
            clock_label.Click += HideSearchSettingsAndMenu;
            // 
            // settings_button
            // 
            settings_button.BackColor = Color.DarkSlateGray;
            settings_button.BackgroundImage = Properties.Resources.settings;
            settings_button.BackgroundImageLayout = ImageLayout.Zoom;
            settings_button.Cursor = Cursors.Hand;
            settings_button.FlatAppearance.BorderSize = 0;
            settings_button.FlatStyle = FlatStyle.Flat;
            settings_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            settings_button.ForeColor = Color.Navy;
            settings_button.Location = new Point(1840, 12);
            settings_button.Name = "settings_button";
            settings_button.Size = new Size(50, 50);
            settings_button.TabIndex = 34;
            settings_button.UseVisualStyleBackColor = false;
            settings_button.Click += settings_button_Click;
            // 
            // clock_pictureBox
            // 
            clock_pictureBox.BackgroundImage = Properties.Resources.clock;
            clock_pictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            clock_pictureBox.Location = new Point(336, 12);
            clock_pictureBox.Name = "clock_pictureBox";
            clock_pictureBox.Size = new Size(50, 50);
            clock_pictureBox.TabIndex = 39;
            clock_pictureBox.TabStop = false;
            clock_pictureBox.Click += HideSearchSettingsAndMenu;
            // 
            // settings_panel
            // 
            settings_panel.BackColor = Color.Black;
            settings_panel.Controls.Add(change_genre_preferences_button);
            settings_panel.Controls.Add(clock_checkBox);
            settings_panel.Controls.Add(sign_out_button);
            settings_panel.Controls.Add(inverted_settings_button);
            settings_panel.Dock = DockStyle.Right;
            settings_panel.Location = new Point(1572, 0);
            settings_panel.Name = "settings_panel";
            settings_panel.Size = new Size(330, 1033);
            settings_panel.TabIndex = 37;
            settings_panel.Visible = false;
            // 
            // change_genre_preferences_button
            // 
            change_genre_preferences_button.BackColor = Color.White;
            change_genre_preferences_button.Cursor = Cursors.Hand;
            change_genre_preferences_button.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            change_genre_preferences_button.Location = new Point(3, 261);
            change_genre_preferences_button.Name = "change_genre_preferences_button";
            change_genre_preferences_button.Size = new Size(324, 50);
            change_genre_preferences_button.TabIndex = 41;
            change_genre_preferences_button.Text = "Change Genre Preferences";
            change_genre_preferences_button.TextAlign = ContentAlignment.MiddleLeft;
            change_genre_preferences_button.UseVisualStyleBackColor = false;
            change_genre_preferences_button.Click += change_genre_preferences_button_Click;
            // 
            // clock_checkBox
            // 
            clock_checkBox.CheckAlign = ContentAlignment.MiddleRight;
            clock_checkBox.Checked = true;
            clock_checkBox.CheckState = CheckState.Checked;
            clock_checkBox.Cursor = Cursors.Hand;
            clock_checkBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            clock_checkBox.ForeColor = Color.White;
            clock_checkBox.Location = new Point(3, 166);
            clock_checkBox.Name = "clock_checkBox";
            clock_checkBox.Size = new Size(324, 50);
            clock_checkBox.TabIndex = 40;
            clock_checkBox.Text = "Show Clock";
            clock_checkBox.UseVisualStyleBackColor = true;
            clock_checkBox.CheckedChanged += clock_checkBox_CheckedChanged;
            // 
            // sign_out_button
            // 
            sign_out_button.BackColor = Color.White;
            sign_out_button.Cursor = Cursors.Hand;
            sign_out_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            sign_out_button.ForeColor = Color.Navy;
            sign_out_button.Location = new Point(118, 956);
            sign_out_button.Name = "sign_out_button";
            sign_out_button.Size = new Size(94, 29);
            sign_out_button.TabIndex = 39;
            sign_out_button.Text = "Sign Out";
            sign_out_button.UseVisualStyleBackColor = false;
            sign_out_button.Click += sign_out_button_Click;
            // 
            // inverted_settings_button
            // 
            inverted_settings_button.BackColor = Color.Black;
            inverted_settings_button.BackgroundImage = Properties.Resources.invertedSettings;
            inverted_settings_button.BackgroundImageLayout = ImageLayout.Zoom;
            inverted_settings_button.Cursor = Cursors.Hand;
            inverted_settings_button.FlatAppearance.BorderSize = 0;
            inverted_settings_button.FlatStyle = FlatStyle.Flat;
            inverted_settings_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            inverted_settings_button.ForeColor = Color.Navy;
            inverted_settings_button.Location = new Point(3, 12);
            inverted_settings_button.Name = "inverted_settings_button";
            inverted_settings_button.Size = new Size(50, 50);
            inverted_settings_button.TabIndex = 38;
            inverted_settings_button.UseVisualStyleBackColor = false;
            inverted_settings_button.Click += HideSearchSettingsAndMenu;
            // 
            // main_magnifier_button
            // 
            main_magnifier_button.BackColor = Color.DarkSlateGray;
            main_magnifier_button.BackgroundImage = Properties.Resources.magnifier;
            main_magnifier_button.BackgroundImageLayout = ImageLayout.Zoom;
            main_magnifier_button.Cursor = Cursors.Hand;
            main_magnifier_button.FlatAppearance.BorderSize = 0;
            main_magnifier_button.FlatStyle = FlatStyle.Flat;
            main_magnifier_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            main_magnifier_button.ForeColor = Color.Navy;
            main_magnifier_button.Location = new Point(1141, 12);
            main_magnifier_button.Name = "main_magnifier_button";
            main_magnifier_button.Size = new Size(57, 34);
            main_magnifier_button.TabIndex = 34;
            main_magnifier_button.UseVisualStyleBackColor = false;
            main_magnifier_button.Click += main_magnifier_button_Click;
            // 
            // main_search_textBox
            // 
            main_search_textBox.BackColor = Color.Teal;
            main_search_textBox.Cursor = Cursors.IBeam;
            main_search_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            main_search_textBox.ForeColor = SystemColors.WindowText;
            main_search_textBox.Location = new Point(785, 12);
            main_search_textBox.Name = "main_search_textBox";
            main_search_textBox.PlaceholderText = "Search Song Title";
            main_search_textBox.Size = new Size(350, 34);
            main_search_textBox.TabIndex = 1;
            main_search_textBox.KeyPress += main_search_textBox_KeyPress;
            // 
            // menu_panel
            // 
            menu_panel.BackColor = Color.Black;
            menu_panel.Controls.Add(mood_button);
            menu_panel.Controls.Add(menu_recommend_label);
            menu_panel.Controls.Add(menu_view_label);
            menu_panel.Controls.Add(liked_songs_button);
            menu_panel.Controls.Add(go_to_main_button);
            menu_panel.Controls.Add(statistics_button);
            menu_panel.Controls.Add(inverted_menu_button);
            menu_panel.Dock = DockStyle.Left;
            menu_panel.Location = new Point(0, 0);
            menu_panel.Name = "menu_panel";
            menu_panel.Size = new Size(330, 1033);
            menu_panel.TabIndex = 38;
            menu_panel.Visible = false;
            // 
            // mood_button
            // 
            mood_button.BackColor = Color.White;
            mood_button.Cursor = Cursors.Hand;
            mood_button.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            mood_button.Location = new Point(3, 432);
            mood_button.Name = "mood_button";
            mood_button.Size = new Size(324, 70);
            mood_button.TabIndex = 47;
            mood_button.Text = "Songs Based On Your Mood";
            mood_button.TextAlign = ContentAlignment.MiddleLeft;
            mood_button.UseVisualStyleBackColor = false;
            mood_button.Click += mood_button_Click;
            // 
            // menu_recommend_label
            // 
            menu_recommend_label.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            menu_recommend_label.ForeColor = Color.White;
            menu_recommend_label.Location = new Point(3, 166);
            menu_recommend_label.Name = "menu_recommend_label";
            menu_recommend_label.Size = new Size(324, 70);
            menu_recommend_label.TabIndex = 46;
            menu_recommend_label.Text = "Recommend                              ";
            menu_recommend_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // menu_view_label
            // 
            menu_view_label.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            menu_view_label.ForeColor = Color.White;
            menu_view_label.Location = new Point(3, 576);
            menu_view_label.Name = "menu_view_label";
            menu_view_label.Size = new Size(324, 70);
            menu_view_label.TabIndex = 45;
            menu_view_label.Text = "View                                            ";
            menu_view_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // liked_songs_button
            // 
            liked_songs_button.BackColor = Color.White;
            liked_songs_button.Cursor = Cursors.Hand;
            liked_songs_button.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            liked_songs_button.Location = new Point(3, 731);
            liked_songs_button.Name = "liked_songs_button";
            liked_songs_button.Size = new Size(324, 70);
            liked_songs_button.TabIndex = 44;
            liked_songs_button.Text = "Songs That You Like";
            liked_songs_button.TextAlign = ContentAlignment.MiddleLeft;
            liked_songs_button.UseVisualStyleBackColor = false;
            liked_songs_button.Click += liked_songs_button_Click;
            // 
            // go_to_main_button
            // 
            go_to_main_button.BackColor = Color.White;
            go_to_main_button.Cursor = Cursors.Hand;
            go_to_main_button.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            go_to_main_button.Location = new Point(3, 321);
            go_to_main_button.Name = "go_to_main_button";
            go_to_main_button.Size = new Size(324, 70);
            go_to_main_button.TabIndex = 43;
            go_to_main_button.Text = "Songs Based On Your Favourites Genres";
            go_to_main_button.TextAlign = ContentAlignment.MiddleLeft;
            go_to_main_button.UseVisualStyleBackColor = false;
            go_to_main_button.Click += go_to_main_button_Click;
            // 
            // statistics_button
            // 
            statistics_button.BackColor = Color.White;
            statistics_button.Cursor = Cursors.Hand;
            statistics_button.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            statistics_button.Location = new Point(3, 842);
            statistics_button.Name = "statistics_button";
            statistics_button.Size = new Size(324, 70);
            statistics_button.TabIndex = 42;
            statistics_button.Text = "Statistics";
            statistics_button.TextAlign = ContentAlignment.MiddleLeft;
            statistics_button.UseVisualStyleBackColor = false;
            statistics_button.Click += statistics_button_Click;
            // 
            // inverted_menu_button
            // 
            inverted_menu_button.BackColor = Color.Black;
            inverted_menu_button.BackgroundImage = Properties.Resources.invertedMenu;
            inverted_menu_button.BackgroundImageLayout = ImageLayout.Zoom;
            inverted_menu_button.Cursor = Cursors.Hand;
            inverted_menu_button.FlatAppearance.BorderSize = 0;
            inverted_menu_button.FlatStyle = FlatStyle.Flat;
            inverted_menu_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            inverted_menu_button.ForeColor = Color.Navy;
            inverted_menu_button.Location = new Point(12, 12);
            inverted_menu_button.Name = "inverted_menu_button";
            inverted_menu_button.Size = new Size(50, 50);
            inverted_menu_button.TabIndex = 39;
            inverted_menu_button.UseVisualStyleBackColor = false;
            inverted_menu_button.Click += HideSearchSettingsAndMenu;
            // 
            // main_search_listBox
            // 
            main_search_listBox.BackColor = Color.Teal;
            main_search_listBox.Cursor = Cursors.Hand;
            main_search_listBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            main_search_listBox.FormattingEnabled = true;
            main_search_listBox.ItemHeight = 25;
            main_search_listBox.Location = new Point(785, 72);
            main_search_listBox.Name = "main_search_listBox";
            main_search_listBox.Size = new Size(350, 204);
            main_search_listBox.TabIndex = 35;
            main_search_listBox.Visible = false;
            main_search_listBox.SelectedIndexChanged += main_listBox_SelectedIndexChanged;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1902, 1033);
            Controls.Add(main_panel);
            Controls.Add(question_panel);
            Controls.Add(question_title_label);
            Controls.Add(login_panel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Music Guide";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            login_panel.ResumeLayout(false);
            login_panel.PerformLayout();
            question_panel.ResumeLayout(false);
            question_panel.PerformLayout();
            main_panel.ResumeLayout(false);
            main_panel.PerformLayout();
            mood_panel.ResumeLayout(false);
            mood_panel.PerformLayout();
            mood_rec_panel.ResumeLayout(false);
            liked_songs_panel.ResumeLayout(false);
            statistics_panel.ResumeLayout(false);
            main_recommendations_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)clock_pictureBox).EndInit();
            settings_panel.ResumeLayout(false);
            menu_panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel login_panel;
        private Label login_label;
        private TextBox username_textBox;
        private TextBox password_textBox;
        private Button login_button;
        private Button signup_button;
        private Button login_help_button;
        private Label login_error_label;
        private Panel question_panel;
        private Label question_title_label;
        private Label question_label;
        private CheckBox question_rock_checkBox;
        private CheckBox question_classical_checkBox;
        private CheckBox question_metal_checkBox;
        private CheckBox question_disco_checkBox;
        private CheckBox question_electronic_checkBox;
        private CheckBox question_pop_checkBox;
        private Button question_next_button;
        private Panel main_panel;
        private Panel main_recommendations_panel;
        public Label main_recommendations_label;
        private Button main_recommendations_title5_button;
        private Button main_recommendations_title4_button;
        private Button main_recommendations_title3_button;
        private Button main_recommendations_title2_button;
        private Button main_recommendations_title1_button;
        private Label main_recommendations_title_label;
        private Button eye_button;
        private Label main_recommendations_year_label;
        private Label main_recommendations_artist_label;
        private Label main_recommendations_artist1_label;
        private Label main_recommendations_artist5_label;
        private Label main_recommendations_artist4_label;
        private Label main_recommendations_artist3_label;
        private Label main_recommendations_artist2_label;
        private Label main_recommendations_released1_label;
        private Label main_recommendations_released5_label;
        private Label main_recommendations_released4_label;
        private Label main_recommendations_released3_label;
        private Label main_recommendations_released2_label;
        private Button main_recommendations_heart1_button;
        private Button main_recommendations_heart5_button;
        private Button main_recommendations_heart4_button;
        private Button main_recommendations_heart3_button;
        private Button main_recommendations_heart2_button;
        private Button main_recommendations_refresh_button;
        private TextBox main_search_textBox;
        private Button main_magnifier_button;
        private ListBox main_search_listBox;
        private Button settings_button;
        private Button menu_button;
        private Panel settings_panel;
        private Button inverted_settings_button;
        private Panel menu_panel;
        private Button inverted_menu_button;
        private Button sign_out_button;
        private Label clock_label;
        private PictureBox clock_pictureBox;
        private System.Windows.Forms.Timer timer;
        private CheckBox clock_checkBox;
        private Button change_genre_preferences_button;
        private Panel statistics_panel;
        private ListView count_clicks_listView;
        private ColumnHeader statistics_song_columnHeader;
        private ColumnHeader statistics_click_columnHeader;
        private Button statistics_button;
        public Label count_clicks_label;
        public Label count_like_label;
        public Label genre_like_label;
        private ListView genre_like_listView;
        private ColumnHeader statistics_genre_columnHeader;
        private Panel separator_panel2;
        private Panel separator_panel1;
        private Button go_to_main_button;
        private Button liked_songs_button;
        private Panel liked_songs_panel;
        public Label liked_songs_label;
        private ListView liked_songs_listView;
        private ColumnHeader likedSongs_title_columnHeader;
        private ColumnHeader likedSongs_artist_columnHeader;
        private ColumnHeader likedSongs_year_columnHeader;
        private Panel mood_panel;
        private Panel mood_rec_panel;
        private Button mood_rec_refresh_button;
        private Button mood_heart_button5;
        private Button mood_heart_button4;
        private Button mood_heart_button3;
        private Button mood_heart_button2;
        private Button mood_heart_button1;
        private Label mood_year_label5;
        private Label mood_year_label4;
        private Label mood_year_label3;
        private Label mood_year_label2;
        private Label mood_artist_label5;
        private Label mood_artist_label4;
        private Label mood_artist_label3;
        private Label mood_artist_label2;
        private Label mood_year_label1;
        private Label mood_artist_label1;
        private Label mood_year_label;
        private Label mood_art_label;
        private Label mood_tit_label;
        private Button mood_title_button5;
        private Button mood_title_button4;
        private Button mood_title_button3;
        private Button mood_title_button2;
        private Button mood_title_button1;
        public Label mood_rec_label;
        private ComboBox mood_comboBox;
        private Label mood_music_label;
        private Label mood_listen_label;
        private Label menu_recommend_label;
        private Label menu_view_label;
        private Button mood_button;
    }
}