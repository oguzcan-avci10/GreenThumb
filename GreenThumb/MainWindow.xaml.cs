using GreenThumb.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GreenThumb
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            // Hämta input och kolla om det finns en växt som matchar med hämtad input

            string searchText = txtSearch.Text.ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a valid plant name", "Warning");
                return;
            }
            else
            {
                using (PlantDbContext context = new())
                {
                    PlantsUow uow = new(context);

                    var plant = uow.PlantRepository.GetPlantByName(searchText); 
                    if (plant != null)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Tag = plant;
                        item.Content = plant.Name;
                        lstPlants.Items.Add(item);
                        return;
                    }
                    else
                    {
                        MessageBox.Show($"{searchText} does not exist!", "Warning");
                    }
                }
            }

        }
    }
}