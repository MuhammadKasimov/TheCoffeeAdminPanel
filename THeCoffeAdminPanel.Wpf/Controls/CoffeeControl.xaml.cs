using System.Windows.Controls;

namespace THeCoffeAdminPanel.Wpf.Controls
{
    /// <summary>
    /// Логика взаимодействия для CoffeeControl.xaml
    /// </summary>
    public partial class CoffeeControl : UserControl
    {
        public int Id { get; set; }
        public CoffeeControl()
        {
            InitializeComponent();
        }
    }
}
