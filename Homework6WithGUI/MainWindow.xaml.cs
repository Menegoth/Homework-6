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

//Antonio Monteiro, 10/7/2020

namespace Homework6WithGUI {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    class Counter {

        //instance variables
        private int count = 0;

        //get count
        public int GetCount() {
            return count;
        }

        //set count to 0
        public void ResetCounter() {
            count = 0;
        }

        //add one
        public void AddOne() {
            count += 1;
        }

        //subtract one
        public void SubtractOne() {

            //check if below 0
            if ((count - 1) >= 0) {
                count -= 1;
            }

        }

        //ToString and Equals
        public override String ToString() {
            return "Count: " + count;
        }

        public bool Equals(Counter other) {
            return count == other.count;
        }

    }

    public partial class MainWindow : Window {

        //initiliaze counter
        Counter count = new Counter();

        public MainWindow() {
            InitializeComponent();

            //display on label initially
            UpdateCounter();

        }

        //method to update count label
        public void UpdateCounter() {
            counterLabel.Content = count.GetCount();
        }

        //subtract 1
        private void subtractButton_Click(object sender, RoutedEventArgs e) {
            count.SubtractOne();

            //refresh counter
            UpdateCounter();
        }

        //reset
        private void resetButton_Click(object sender, RoutedEventArgs e) {
            count.ResetCounter();

            //refresh counter
            UpdateCounter();
        }

        //add one
        private void addButton_Click(object sender, RoutedEventArgs e) {
            count.AddOne();

            //refresh counter
            UpdateCounter();
        }
    }


}
