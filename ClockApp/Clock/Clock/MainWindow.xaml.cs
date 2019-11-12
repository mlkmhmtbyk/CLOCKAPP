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
using System.IO;

namespace Clock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        public static void WriteToTxt(string work, string day)
        {
            try
            {
                
                StreamWriter file = File.AppendText("scedule.txt");
                file.WriteLine(day + ": " + work);
                file.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("This writing to text failed:", ex);
            }
        }

        private void SundayClick(object sender, RoutedEventArgs e)
        {
            string work;
            work = new TextRange(textbox.Document.ContentStart, textbox.Document.ContentEnd).Text;
            string day;
            day = "Sunday";
            WriteToTxt(work, day);
        }

        private void MondayClick(object sender, RoutedEventArgs e)
        {
            string work;
            work = new TextRange(textbox.Document.ContentStart, textbox.Document.ContentEnd).Text;
            string day;
            day = "Monday";
            WriteToTxt(work, day);
        }

        private void TuesdayClick(object sender, RoutedEventArgs e)
        {
            string work;
            work = new TextRange(textbox.Document.ContentStart, textbox.Document.ContentEnd).Text;
            string day;
            day = "Tuesday";
            WriteToTxt(work, day);
        }

        private void WednesdayClick(object sender, RoutedEventArgs e)
        {
            string work;
            work = new TextRange(textbox.Document.ContentStart, textbox.Document.ContentEnd).Text;
            string day;
            day = "Wednesday";
            WriteToTxt(work, day);
        }
        private void ThursdayClick(object sender, RoutedEventArgs e)
        {
            string work;
            work = new TextRange(textbox.Document.ContentStart, textbox.Document.ContentEnd).Text;
            string day;
            day = "Thursday";
            WriteToTxt(work, day);

        }
        private void FridayClick(object sender, RoutedEventArgs e)
        {
            string work;
            work = new TextRange(textbox.Document.ContentStart, textbox.Document.ContentEnd).Text;
            string day;
            day = "Friday";
            WriteToTxt(work, day);
        }
        private void SaturdayClick(object sender, RoutedEventArgs e)
        {
            string work;
            work = new TextRange(textbox.Document.ContentStart, textbox.Document.ContentEnd).Text;
            string day;
            day = "Saturday";
            WriteToTxt(work, day);
        }



    }
}
