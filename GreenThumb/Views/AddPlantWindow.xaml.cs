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
        private List<PlantModel> _plants = new();
        private string _currentPlantName;
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
        private void btnAddPlant_Click(object sender, RoutedEventArgs e)
        {
            string plantName = txtName.Text;
            string? description = txtDescription.Text;

            if (string.IsNullOrEmpty(plantName))
            {
                MessageBox.Show("Plant must hava a name!", "Warning");
                return;
            }

            if (string.IsNullOrEmpty(description))
            {
                description = null;
            }

            using (PlantDbContext context = new())
            {
                PlantsUow uow = new(context);

                _plants = uow.PlantRepository.GetAll();

                PlantModel plantToAdd = new PlantModel()
                {
                    Name = plantName,
                    Description = description
                };
                _currentPlantName = plantToAdd.Name;

                foreach (var plant in _plants)
                {
                    if(plant.Name.ToLower() == plantToAdd.Name.ToLower())
                    {
                        MessageBox.Show("This plant already exists!", "Warning");
                        return;
                    }
                }
                
                uow.PlantRepository.AddPlant(plantToAdd);

                MessageBox.Show($"Added {plantToAdd.Name}", "Success");
            }
        }


        // För att lägga till en instruktion behöver man först lägga till en växt
        // Sparar växtens namn i _currentPlantName
        // Hämtar växten med hjälp av _currentPlantName och sätter instruktionens plantId (foreign key) till _currentPlant.PlantId

        private void btnAddInstruction_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(_currentPlantName))
            {
                MessageBox.Show("Must add a plant before adding instructions!", "Warning");
                return;
            }

            string instruction = txtInstruction.Text;

            if (string.IsNullOrEmpty(instruction))
            {
                MessageBox.Show("Instruction must have content!", "Warning");
                return;
            }

            using (PlantDbContext context = new())
            {
                PlantsUow uow = new(context);

                PlantModel? currentPlant = uow.PlantRepository.GetByName(_currentPlantName);
                if (currentPlant != null)
                {
                    InstructionModel instructionToAdd = new InstructionModel()
                    {
                        InstructionInfo = instruction,
                        PlantId = currentPlant.PlantId
                    };

                    uow.InstructionRepository.AddInstruction(instructionToAdd); 
                }
            }

            MessageBox.Show("Added instruction", "Success");
        }

        

    }
}
