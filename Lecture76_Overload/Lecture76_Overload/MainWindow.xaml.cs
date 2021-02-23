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

namespace Lecture76_Overload
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            sayHello();
            sayHello("Wirun");
        }

        private void sayHello()
        {
            Console.WriteLine("Hello World");
        }

        //ถ้ามี string name จะทำงานอันนี้
        private void sayHello(string name) //argument string name คือ signature
        {
            Console.WriteLine("Hello World : "+ name);
        }
    }
}
