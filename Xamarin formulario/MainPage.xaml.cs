using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin_formulario
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Boton_registrar_Clicked(object sender, EventArgs e)
        {
            //limpiarRegistros();
            //DisplayAlert("Registro Exitoso","Gracias por llenar los datos","continuar");
            string nombre = Label_nombre.Text;
            string apellido = Label_apellido.Text;
            int edad = int.Parse(Label_edad.Text);
            string correo = Label_correo.Text;
            int dni = int.Parse(Label_dni.Text);

            ModeloCV cv = new ModeloCV()
            {
                Label_nombre = nombre,
                Label_apellido = apellido,
                Label_edad = edad,
                Label_correo = correo,
                Label_dni = dni
            };

            await Navigation.PushAsync(new CV(cv));
        }
      
        /*private void limpiarRegistros()
        {
            label_nombre.Text = "";
            label_apellido.Text = "";
            label_edad.Text = "";
            label_correo.Text = "";
            label_dni.Text = "";
        }*/
            
     }
}
