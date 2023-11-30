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
using System.Xml.Linq;

namespace proj
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Page
    {
        mydateEntities db = new mydateEntities();
        public login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
         llgin g=db.llgins.FirstOrDefault(x=>x.lname==namel.Text&&x.lpass==passl.Text);

            if(g==null)
            {
                MessageBox.Show("you are not a admen");
               
            }
          
            else  if (namel.Text == g.lname && passl.Text == g.lpass)
            {
                mydata a = new mydata();
                this.NavigationService.Navigate(a);
            }
            
        }
    }
}
