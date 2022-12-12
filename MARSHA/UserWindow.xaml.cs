using System.Windows;
namespace SQLiteApp
{
    public partial class UserWindow : Window
    {
        public Marsha User { get; private set; }
        public UserWindow(Marsha user)
        {
            InitializeComponent();
            User = user;
            DataContext = User;
        }

        void Accept_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
