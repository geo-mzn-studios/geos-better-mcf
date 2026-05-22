using Microsoft.Web.WebView2.WinForms;

namespace GBMCF
{
    public partial class Form1 : Form
    {
        WebView2 webView;

        public Form1()
        {
            InitializeComponent();

            this.Text = "Geo's Better MCF";
            this.Icon = new Icon("icon.ico");
            webView = new WebView2();
            webView.Dock = DockStyle.Fill;
            this.Controls.Add(webView);

            this.Load += Form1_Load;
        }

        private async void Form1_Load(object? sender, EventArgs e)
        {
            await webView.EnsureCoreWebView2Async();

            string path = Path.Combine(
                Application.StartupPath,
                "gbmcf/index.html"
            );

            webView.CoreWebView2.Navigate(path);
        }
    }
}