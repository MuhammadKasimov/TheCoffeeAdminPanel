using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using TheCoffeAdminPanel.Wpf.AuthHelper;
using TheCoffeAdminPanel.Wpf.Windows;
using TheCoffeeAdminPanel.Interfaces;
using TheCoffeeAdminPanel.Service.DTOs;
using TheCoffeeAdminPanel.Service.Services;

namespace TheCoffeAdminPanel.Wpf.Pages
{
    /// <summary>
    /// Логика взаимодействия для SaveCoffeePage.xaml
    /// </summary>
    public partial class SaveCoffeePage : Page
    {
        private string path;
        public string AttachmentId { get; set; }
        private readonly ICoffeeService coffeeService;
        public SaveCoffeePage()
        {
            coffeeService = new CoffeeService();
            InitializeComponent();
        }

        private void ImageBtn_Click(object sender, RoutedEventArgs e)
        {
            string portraitPath = ChooseFile();

            if (portraitPath != null)
                CoffeeImg.ImageSource = new BitmapImage(new Uri(portraitPath));
        }

        private async void SaveBtn_Click(object sender, RoutedEventArgs e)
        {

            CoffeeForCreationDTO coffeeForCreationDTO = new CoffeeForCreationDTO();
            coffeeForCreationDTO.Name = string.IsNullOrEmpty(Name.Text) ? coffeeForCreationDTO.Name : Name.Text;
            coffeeForCreationDTO.Description = string.IsNullOrEmpty(Description.Text) ? coffeeForCreationDTO.Description : Description.Text;
            coffeeForCreationDTO.Price = string.IsNullOrEmpty(Price.Text) ? coffeeForCreationDTO.Price : long.Parse(Price.Text);
            coffeeForCreationDTO.Image = File.OpenRead(path);

            var res = await coffeeService.UpdateAsync(IdTxt.Text, AttachmentId, coffeeForCreationDTO, Token.Content);

            if (res.StatusCode < 300)
                new SuccessWindow().ShowDialog();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            if (await coffeeService.DeleteAsync(IdTxt.Text, Token.Content))
                new SuccessWindow().ShowDialog();
            else
                new ErrorWindow().ShowDialog();
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
