using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;


namespace StoreInvoiceCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double total = 0, tax = 0; //decare the toal and the tax
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            //clear the listbox 
            lstItems.Items.Clear();

        }


        private void Image_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.centennialcollege.ca/"); //Finally, clickable thanks Prof. took 2 days to read the documentation and get this step done. 
        }




        //combo box  event
        private void ComboBox_DropDownClosed(object sender, EventArgs e)
        {
            double electronics = 0, books = 0, jewelary = 0, toys = 0; //declare the variable
            const double GST = 0.18; //declare the GST tax variable

            if (cmbElectronics.SelectedIndex >= 0) //combox item is selected
            {
                
                electronics = 300; //set the price
                    lstItems.Items.Add(cmbElectronics.Text + " : " + electronics); //add items to the listbox
                
                
            }

            if (cmbBooks.SelectedIndex >= 0) 
            {
                books = 200; 
                lstItems.Items.Add(cmbBooks.Text + " : " + books);          

            }

            if (cmbJewelry.SelectedIndex >= 0) 
            {
                jewelary = 250; 
                lstItems.Items.Add(cmbJewelry.Text + " : " + jewelary);          
            }

            if (cmbToys.SelectedIndex >= 0) 
            {
                toys = 100; 
                lstItems.Items.Add(cmbToys.Text + " : " + toys);             
            }

            tax = (electronics + books + jewelary + toys) * GST; 
            total = tax + (electronics + books + jewelary + toys); //total

            //displayt to the label
            lblGST.Content = tax;
            lblTotal.Content = total;
        }

    }
}