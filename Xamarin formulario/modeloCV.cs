using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Xamarin_formulario
{
    public class ModeloCV : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string nombre;
        public string Label_nombre
        {
            get { return nombre; }
            set
            {
                if (nombre != value)
                {
                    nombre = value;
                    OnPropertyChanged(nameof(Label_nombre));
                }
            }
        }
        private string apellido;
        public string Label_apellido
        {
            get { return apellido; }
            set
            {
                if (apellido != value)
                {
                    apellido = value;
                    OnPropertyChanged(nameof(Label_apellido));
                }
            }
        }

        private int edad;
        public int Label_edad
        {
            get { return edad; }
            set
            {
                if (edad != value)
                {
                    edad = value;
                    OnPropertyChanged(nameof(Label_edad));
                }
            }
        }

        private string correo;
        public string Label_correo
        {
            get { return correo; }
            set
            {
                if (correo != value)
                {
                    correo = value;
                    OnPropertyChanged(nameof(Label_correo));
                }
            }
        }

        private int dni;
        public int Label_dni
        {
            get { return dni; }
            set
            {
                if (dni != value)
                {
                    dni = value;
                    OnPropertyChanged(nameof(Label_dni));
                }
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}