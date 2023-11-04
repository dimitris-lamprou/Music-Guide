namespace Music_Guide
{
    public partial class YouTubeForm : Form
    {
        public YouTubeForm(string url)
        {
            InitializeComponent();
            webView.Source = new Uri(url);
        }
    }
}
