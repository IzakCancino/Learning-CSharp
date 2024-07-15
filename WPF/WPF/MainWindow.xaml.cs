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

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            BrushConverter brushConverter = new BrushConverter();
            Brush redColor = (Brush)brushConverter.ConvertFromString("#c55");
            Brush greenColor = (Brush)brushConverter.ConvertFromString("#5c5");
            Brush blueColor = (Brush)brushConverter.ConvertFromString("#55c");

            Grid myGrid = new Grid();

            Button myBtn = new Button();
            WrapPanel myWrap = new WrapPanel();

            TextBlock myTextBlock1 = new TextBlock();
            myTextBlock1.Text = "I'm";
            myTextBlock1.Foreground = redColor;
            myWrap.Children.Add(myTextBlock1);

            TextBlock myTextBlock2 = new TextBlock();
            myTextBlock2.Text = "a colored";
            myTextBlock2.Foreground = greenColor;
            myWrap.Children.Add(myTextBlock2);

            TextBlock myTextBlock3 = new TextBlock();
            myTextBlock3.Text = "button!";
            myTextBlock3.Foreground = blueColor;
            myWrap.Children.Add(myTextBlock3);

            myBtn.Content = myWrap;
            myBtn.Width = 120;
            myBtn.Height = 40;
            myBtn.Background = Brushes.Orange;
            myGrid.Children.Add(myBtn);

            RootGrid.Children.Add(myGrid);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(sender);
            Console.WriteLine(e);

            this.Background = Brushes.LightGray;
        }
    }
}