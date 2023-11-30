using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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

namespace proj
{
    /// <summary>
    /// Interaction logic for mydata.xaml
    /// </summary>
    public partial class mydata : Page
    {
        mydateEntities db = new mydateEntities();
        public mydata()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(id.Text != "")
            {
                MessageBox.Show("you can not put ID");
            }
            mdate a = new mdate();
            a.namee = name.Text;
            a.email = email.Text;
            a.departmint = add.Text;
            db.mdates.Add(a);
            db.SaveChanges();
            MessageBox.Show("added");
          
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {


            mdate m = db.mdates.Remove(db.mdates.First(x => x.namee == name.Text));
            db.SaveChanges();
            MessageBox.Show("removed");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
           
            DG.ItemsSource = db.mdates.Where(x => x.namee.Contains(name.Text) ).ToList();
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
           
            mdate a= db.mdates.First(x=>x.namee==name.Text);
            a.namee = name.Text;
            a.email = email.Text;
            a.departmint = add.Text;
            db.mdates.AddOrUpdate(a);
            db.SaveChanges();
            MessageBox.Show("updateed");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            DG.ItemsSource = db.mdates.ToList();
        }
    }
}
