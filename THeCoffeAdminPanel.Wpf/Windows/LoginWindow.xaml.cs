using System.Windows;
using TheCoffeAdminPanel.Wpf.AuthHelper;
using TheCoffeeAdminPanel.Service.DTOs;
using TheCoffeeAdminPanel.Service.Interfaces;
using TheCoffeeAdminPanel.Service.Services;

namespace TheCoffeAdminPanel.Wpf.Windows
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private readonly IAuthService authService;
        public LoginWindow()
        {
            authService = new AuthService();
            InitializeComponent();
        }

        private async void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            UserForLoginDTO userForLoginDTO = new UserForLoginDTO();
            userForLoginDTO.Login = Username.Text;
            userForLoginDTO.Password = Password.Password;
            var responce = await authService.Login(userForLoginDTO);
            if (responce.StatusCode > 199 & responce.StatusCode < 300)
            {
                Token.Content = responce.Value.Token;
                Close();
            }
            else
            {
                new ErrorWindow().ShowDialog();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
