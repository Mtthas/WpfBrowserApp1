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

namespace WpfBrowserApp1
{



    /// <summary>

    /// Логика взаимодействия для MainWindow.xaml

    /// </summary>

    public partial class MainWindow : Window

    {

        public MainWindow()

        {

            InitializeComponent();

        }

        public string Num;

        void RadioButton_Checked(object sender, RoutedEventArgs e)

        {

            RadioButton pressed = (RadioButton)sender;

            // MessageBox.Show(pressed.Content.ToString());

            switch (pressed.Content.ToString())

            {

                case "BIN":

                    Num = string.Format("BIN {0:X8}", Convert.ToString(Convert.ToInt32(inNum.Text.ToString()), 2));

                    break;

                case "OCT":

                    Num = string.Format("OCT {0:X8}", Convert.ToString(Convert.ToInt32(inNum.Text.ToString()), 8));

                    //Num=String.format("0x{0:X8}", Num);

                    break;

                case "HEX":

                    Num = string.Format("HEX {0:X8}", Convert.ToString(Convert.ToInt32(inNum.Text.ToString()), 16)); ;

                    break;

            }

        }



        private void Button_Click(object sender, RoutedEventArgs e)

        {

            outNum.Text = Num;



        }

    }

}