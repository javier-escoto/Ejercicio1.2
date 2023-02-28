using Ejercicio1_2PMO2.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;

namespace Ejercicio1_2PMO2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnenviar_Clicked(object sender, EventArgs e)
        {
            if (txtnombre.Text == null || txtapellidos.Text == null || txtedad.Text == null || txtcorreo.Text == null)
            {
                await DisplayAlert("Error", "Campos Vacios", "OK");
            }
            else
            {
                var usua = new Models.Usuario { id = 1, nombre = txtnombre.Text, apellidos = txtapellidos.Text, edad = txtedad.Text, correo = txtcorreo.Text };

                var pagetwo = new PageTwo();
                pagetwo.BindingContext = usua;

                await Navigation.PushAsync(pagetwo);
            }
            
            
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}
