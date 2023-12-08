using GreenThumb.Data;
using GreenThumb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GreenThumb.Views
{
    /// <summary>
    /// Interaction logic for AddPlantWindow.xaml
    /// </summary>
    public partial class AddPlantWindow : Window
    {
        private List<PlantModel> plants = new();
        public AddPlantWindow()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        // Lägg till ny växt
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string plantName = txtName.Text;
            string? plantDescription = txtDescription.Text;

            if (string.IsNullOrEmpty(plantDescription))
            {
                plantDescription = null;
            }

            string instruction = txtInstruction.Text;

            if (string.IsNullOrEmpty(plantName) || string.IsNullOrEmpty(instruction))
            {
                MessageBox.Show("Name and instruction must be added", "Warning");
                return;
            }
            else
            {
                using (PlantDbContext context = new())
                {
                    PlantsUow uow = new(context);

                    plants = uow.PlantRepository.GetAll();

                    PlantModel plantToAdd = new()
                    {
                        Name = plantName,
                        Description = plantDescription
                    };

                    foreach (var plant in plants)
                    {
                        if (plant.Name.ToLower() == plantToAdd.Name.ToLower())
                        {
                            MessageBox.Show("This plant already exists!", "Warning");
                            txtName.Clear();
                            txtDescription.Clear();
                            txtInstruction.Clear();
                            return;
                        }
                    }

                    uow.PlantRepository.AddPlant(plantToAdd);

                    InstructionModel instructionToAdd = new()
                    {
                        InstructionInfo = instruction,
                        PlantId = plantToAdd.PlantId
                    };

                    uow.InstructionRepository.AddInstruction(instructionToAdd);

                    MessageBox.Show($"Added {plantToAdd.Name} successfully.", "Success");
                    txtName.Clear();
                    txtDescription.Clear();
                    txtInstruction.Clear(); 

                    MainWindow mainWindow = new MainWindow(); // Kolla om denna behövs
                    mainWindow.Show();
                    Close();
                }
            }
        }
    }
}
