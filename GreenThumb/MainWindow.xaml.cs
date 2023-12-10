using GreenThumb.Data;
using GreenThumb.Models;
using GreenThumb.Views;
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
        private List<PlantModel> plants;
        private PlantModel? filteredPlant;
        public MainWindow()
        {
            InitializeComponent();

            using ( PlantDbContext context = new())
            {
                PlantsUow uow = new(context);

                plants = uow.PlantRepository.GetAll();

                foreach(var plant in plants)
                {
                    ListViewItem item = new();
                    item.Tag = plant;
                    item.Content = plant.Name; 
                    lstPlants.Items.Add(item);
                    
                }
            }

            btnDelete.Visibility = Visibility.Hidden;
            btnDetails.Visibility = Visibility.Hidden;
            txtSearch.Clear();
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

                    filteredPlant = uow.PlantRepository.GetByName(searchText); 
                    if (filteredPlant != null)
                    {
                        btnDelete.Visibility= Visibility.Visible;
                        btnDetails.Visibility= Visibility.Visible;

                        lstPlants.Items.Clear();
                        ListViewItem item = new ListViewItem();
                        item.Tag = filteredPlant;
                        item.Content = filteredPlant.Name;
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
        // Ta fram detaljer om en växt
        private void btnDetails_Click(object sender, RoutedEventArgs e)
        {
            if(lstPlants.SelectedItem == null)
            {
                MessageBox.Show("Please select a plant!", "Warning");
            }
            else
            {
                ListViewItem selectedPlant = (ListViewItem)lstPlants.SelectedItem;
                PlantModel plantToShow = (PlantModel)selectedPlant.Tag;

                PlantDetailsWindow plantDetails = new PlantDetailsWindow(plantToShow);
                plantDetails.Show();
                Close();
            }

        }
        // Ta bort växt
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if(lstPlants.SelectedItem == null)
            {
                MessageBox.Show("Please select a plant!", "Warning");
                return;
            }
            
            ListViewItem selectedPlant = (ListViewItem)lstPlants.SelectedItem;  
            PlantModel plantToDelete = (PlantModel)selectedPlant.Tag;   

            using (PlantDbContext context = new())
            {
                PlantsUow uow = new(context);
                uow.PlantRepository.Delete(plantToDelete.Name);
            }

            MessageBox.Show($"Deleted {plantToDelete.Name}.", "Success");
            lstPlants.Items.Clear();

            txtSearch.Clear();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
           // Rensa listview:en och hämta alla plantor igen

            lstPlants.Items.Clear();
            using (PlantDbContext context = new())
            {
                PlantsUow uow = new(context);

                plants = uow.PlantRepository.GetAll();

                foreach (var plant in plants)
                {
                    ListViewItem item = new();
                    item.Tag = plant;
                    item.Content = plant.Name;
                    lstPlants.Items.Add(item);
                }
            }

            txtSearch.Clear();

            // Fixa så att detail och delete blir inaktiverade på Homepage

            btnDelete.Visibility = Visibility.Hidden;
            btnDetails.Visibility = Visibility.Hidden;
            
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddPlantWindow addPlantWindow = new();
            addPlantWindow.Show();
            Close();
        }
    }
}