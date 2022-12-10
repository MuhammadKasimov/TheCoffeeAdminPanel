using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using TheCoffeAdminPanel.Wpf.Pages;
using TheCoffeAdminPanel.Wpf.Windows;
using THeCoffeAdminPanel.Wpf.Controls;
using TheCoffeeAdminPanel.Interfaces;
using TheCoffeeAdminPanel.Service.Constants;
using TheCoffeeAdminPanel.Service.DTOs;
using TheCoffeeAdminPanel.Service.Services;

namespace THeCoffeAdminPanel.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IEnumerable<CoffeeForViewDTO> allCoffees;
        private IEnumerable<UserForViewDTO> allUsers;
        private readonly ICoffeeService coffeeService;

        public MainWindow()
        {
            coffeeService = new CoffeeService();
            InitializeComponent();
        }

        private void MovePanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
        }

        private void MinimizeBtn_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();

            loginWindow.ShowDialog();

            Thread thread = new Thread(async () =>
            {
                this.Dispatcher.Invoke(() => UsersList.Items.Clear());

                allCoffees = (await coffeeService.GetAllAsync(new PaginationParams() { PageIndex = 0, PageSize = 0 })).Value;
                await LoadCoffee();
            });

            thread.Start();
        }

        private async ValueTask LoadCoffee()
        {
            foreach (var coffee in allCoffees)
            {
                await Dispatcher.InvokeAsync(() =>
                {
                    Button button = new Button()
                    {
                        Background = new SolidColorBrush(Color.FromRgb(38, 28, 44)),
                        Padding = new Thickness(0),
                        Height = 60,
                        BorderThickness = new Thickness(0),
                    };
                    button.Click += CoffeeFullInfoButton_Click;
                    CoffeeControl shortInfo = new CoffeeControl();
                    shortInfo.NameTxt.Text = coffee.Name;
                    shortInfo.PriceTxt.Text = coffee.Price.ToString();
                    shortInfo.Id = coffee.Id;
                    shortInfo.UserImg.ImageSource = new BitmapImage(new Uri(AppConstants.BASE_URL + coffee.Attachment.Path));
                    button.Content = shortInfo;

                    UsersList.Items.Add(button);
                });
            }
        }


        private async void CoffeeFullInfoButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            var shortInfo = button.Content as CoffeeControl;

            CoffeeForViewDTO coffee = (await coffeeService.GetAsync(shortInfo.Id.ToString())).Value;

            SaveCoffeePage savePage = new SaveCoffeePage();

            if (coffee != null)
            {
                savePage.Name.Text = coffee.Name;
                savePage.Description.Text = coffee.Description;
                savePage.Price.Text = coffee.Price.ToString();
                savePage.IdTxt.Text = coffee.Id.ToString();
                savePage.CoffeeImg.ImageSource = new BitmapImage(new Uri(AppConstants.BASE_URL + coffee.Attachment.Path, UriKind.Relative));
                savePage.AttachmentId = coffee.AttachmentId.ToString();

                UserFrame.Content = savePage;

                new SuccessWindow().ShowDialog();
            }
            else
            {
                new ErrorWindow().ShowDialog();
            }

        }

        private void CoffeeBtn_Click(object sender, RoutedEventArgs e)
        {
            Thread thread = new Thread(async () =>
            {
                this.Dispatcher.Invoke(() => UsersList.Items.Clear());

                allCoffees = (await coffeeService.GetAllAsync(new PaginationParams() { PageIndex = 0, PageSize = 0 })).Value;
                await LoadCoffee();
            });

            thread.Start();
        }
    }
}
