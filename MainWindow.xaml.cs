using System.Windows;
using System.Windows.Controls;

namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            colorComboBox.Items.Add(new ComboBoxItem { Content = "Red" });
            colorComboBox.Items.Add(new ComboBoxItem { Content = "Green" });
            colorComboBox.Items.Add(new ComboBoxItem { Content = "Blue" });

            colorComboBox.SelectedIndex = 0;   

            UpdateShapes(); 
        }

        private void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateShapes();
        }

        private void UpdateShapes()
        {
            if (shapesPanel == null) return;

            shapesPanel.Children.Clear();

            if (colorComboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                string color = selectedItem.Content.ToString();

                CircleCreator circleCreator;
                SquareCreator squareCreator;
                TriangleCreator triangleCreator;

                switch (color)
                {
                    case "Red":
                        circleCreator = new RedCircleCreator();
                        squareCreator = new RedSquareCreator();
                        triangleCreator = new RedTriangleCreator();
                        break;
                    case "Green":
                        circleCreator = new GreenCircleCreator();
                        squareCreator = new GreenSquareCreator();
                        triangleCreator = new GreenTriangleCreator();
                        break;
                    case "Blue":
                        circleCreator = new BlueCircleCreator();
                        squareCreator = new BlueSquareCreator();
                        triangleCreator = new BlueTriangleCreator();
                        break;
                    default:
                        return;
                }

                shapesPanel.Children.Add(circleCreator.CreateCircle().CreateUIElement(80));
                shapesPanel.Children.Add(squareCreator.CreateSquare().CreateUIElement(80));
                shapesPanel.Children.Add(triangleCreator.CreateTriangle().CreateUIElement(80));
            }
        }
    }
}