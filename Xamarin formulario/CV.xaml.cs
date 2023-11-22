using Xamarin_formulario;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace Xamarin_formulario
{
    public partial class CV : ContentPage
    {
        public CV(ModeloCV cv)
        {
            InitializeComponent();

            BindingContext = cv;
        }
    }
}