using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using TheCoffeAdminPanel.Wpf.AuthHelper;
using TheCoffeeAdminPanel.Interfaces;
using TheCoffeeAdminPanel.Service.DTOs;
using TheCoffeeAdminPanel.Service.Services;

namespace TheCoffeAdminPanel.Wpf.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddCoffeePage.xaml
    /// </summary>
    public partial class AddCoffeePage : Page
    {
        private string path;
        private readonly ICoffeeService coffeeService;

        public AddCoffeePage()
        {
            InitializeComponent();
            coffeeService= new CoffeeService();
        }

        private async void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            CoffeeForCreationDTO coffeeForCreationDTO = new CoffeeForCreationDTO();
            coffeeForCreationDTO.Name = String.IsNullOrEmpty(Name.Text) ? coffeeForCreationDTO.Name : Name.Text;
            coffeeForCreationDTO.Description = String.IsNullOrEmpty(Description.Text) ? coffeeForCreationDTO.Description : Description.Text;
            coffeeForCreationDTO.Price = String.IsNullOrEmpty(Price.Text) ? coffeeForCreationDTO.Price : long.Parse(Price.Text);
            coffeeForCreationDTO.Image = File.OpenRead(path);

            var res = await coffeeService.CreateAsync(coffeeForCreationDTO, Token.Content);

        }

        private void ImageBtn_Click(object sender, RoutedEventArgs e)
        {
            string portraitPath = ChooseFile();

            if (portraitPath != null)
                CoffeeImg.ImageSource = new BitmapImage(new Uri(portraitPath));
        }

        private string ChooseFile()
        {
            var openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.PNG,*.JPG;)|*.JPG;*.PNG";
            openFileDialog.InitialDirectory = Environment.GetFolderPath
                (Environment.SpecialFolder.MyPictures);


            if (openFileDialog.ShowDialog() == true)
            {
                path = openFileDialog.FileName;
                return path;
            }
            return null;
        }


    }
}
