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
    /// Interaction logic for PlantDetailsWindow.xaml
    /// </summary>
    public partial class PlantDetailsWindow : Window
    {
        public PlantDetailsWindow(PlantModel plant)  // Hämta plant och visa info
        {
            InitializeComponent();

            txtDescription.Text = plant.Description;
            txtName.Text = plant.Name;

            foreach (var instruction in plant.Instructions)
            {
                ListBoxItem plantInstruction = new();
                plantInstruction.Tag = instruction;
                plantInstruction.Content = instruction.InstructionInfo;

                lstInstructions.Items.Add(plantInstruction);
            }
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
