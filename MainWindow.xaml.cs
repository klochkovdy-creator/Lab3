using System.Windows;
using System.Windows.Controls;

namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        private IFigureFactory currentFactory;

        public MainWindow()
        {
            InitializeComponent();

            colorComboBox.Items.Add(new ComboBoxItem { Content = "Red" });
            colorComboBox.Items.Add(new ComboBoxItem { Content = "Green" });
            colorComboBox.Items.Add(new ComboBoxItem { Content = "Blue" });

            colorComboBox.SelectedIndex = 0;
            currentFactory = new RedFactory();

            UpdateShapes();
        }

        private void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (colorComboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                string color = selectedItem.Content.ToString();

                switch (color)
                {
                    case "Red":
                        currentFactory = new RedFactory();
                        break;
                    case "Green":
                        currentFactory = new GreenFactory();
                        break;
                    case "Blue":
                        currentFactory = new BlueFactory();
                        break;
                    default:
                        return;
                }

                UpdateShapes();
            }
        }

        private void UpdateShapes()
        {
            if (shapesPanel == null) return;

            shapesPanel.Children.Clear();

            shapesPanel.Children.Add(currentFactory.CreateCircle().CreateUIElement(80));
            shapesPanel.Children.Add(currentFactory.CreateSquare().CreateUIElement(80));
            shapesPanel.Children.Add(currentFactory.CreateTriangle().CreateUIElement(80));
        }
    }
}