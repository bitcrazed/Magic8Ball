using System.Windows;
using Magic8BallApp.Magic8BallService;

namespace Magic8BallApp
{
    public partial class MainWindow : Window
    {
        private readonly Magic8BallClient _client;

        public MainWindow()
        {
            // Construct the client here but don't use it until after 
            // the UI has finished rendering.
            _client = new Magic8BallClient("Magic8Ball");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            textBoxQuestion.Focus();

            // Now the UI is rendered, attach all the event handlers
            // to keep the UI elements up to date with the state of 
            // the service.
            _client.ChannelFactory.Opened += new System.EventHandler(ChannelFactory_Opened);
            _client.ChannelFactory.Closed += new System.EventHandler(ChannelFactory_Closed);
            _client.ChannelFactory.Closing += new System.EventHandler(ChannelFactory_Closing);
            _client.Open();
        }

        void ChannelFactory_Closing(object sender, System.EventArgs e)
        {
            statusBar.Items[0] = "Closing connection to Magic8Ball service";
        }

        void ChannelFactory_Closed(object sender, System.EventArgs e)
        {
            buttonAsk.IsEnabled = false;
            statusBar.Items[0] = "Connection to Magic8Ball Service is closed";
        }

        void ChannelFactory_Opened(object sender, System.EventArgs e)
        {
            buttonAsk.IsEnabled = true;
            statusBar.Items[0] = string.Format(
                "Talking to Magic8Ball endpoint '{0}' @: {1}",
                _client.Endpoint.Name,
                _client.Endpoint.Address.ToString());
        }

        private void buttonAsk_Click(object sender, RoutedEventArgs e)
        {
            textBoxAnswer.Text = _client.Shake(textBoxQuestion.Text);
            textBoxQuestion.SelectAll();
            textBoxQuestion.Focus();
        }
    }
}
