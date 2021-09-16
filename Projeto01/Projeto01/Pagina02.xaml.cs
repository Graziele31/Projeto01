using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projeto01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina02 : ContentPage
    {
        public Pagina02()
        {
            InitializeComponent();

            StackLayout stk = new StackLayout()
            {
                Orientation = StackOrientation.Vertical
            };
            Label lb1 = new Label()
            {
                Text = "Curso Xamarin",
                FontAttributes = FontAttributes.Bold,
                FontSize = 24,
                BackgroundColor = Color.Black,
                Padding = new Thickness(10),
                TextColor = Color.White,
                HorizontalTextAlignment = TextAlignment.Center
            };
            stk.Children.Add(lb1);

            Label lb2 = new Label()
            {
                Text = "Banco de Dados",
                FontSize = 20,
                TextColor = Color.DarkBlue,
            };

            Label lb3 = new Label()
            {
                Text = "Java Web (EE)",
                FontSize = 20,
                TextColor = Color.DarkRed,
            };

            StackLayout stk2 = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Center,
                Padding = new Thickness (20),
                VerticalOptions = LayoutOptions.Center
            };
            stk2.Children.Add(lb2);
            stk2.Children.Add(lb3);

            stk.Children.Add(stk2);
            Content = stk;
        }
    }
}