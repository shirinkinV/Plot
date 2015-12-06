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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PlotViewTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            plotView.Focus();
            plotView.addFunction(new PlotView.FunctionAppearance(Math.Sin, 0xff0000, -Math.PI * 2, Math.PI * 2, 1, 0x7e3c),"sin");
            plotView.addFunction(new PlotView.FunctionAppearance(Math.Cos, 0x0000FF, -Math.PI * 2, Math.PI * 2, 2, 0xFF00), "cos");
        }
    }
}
