namespace MauiIssueSwipeView
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        /// <summary>
        /// Called when [open swipe view clicked].
        /// 🐛 SwipeView does not work correctly on iOS when opened programmatically!!!
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnOpenSwipeViewClicked(object sender, EventArgs e)
        {
            swipeView.Open(OpenSwipeItem.RightItems, true);
        }
    }
}