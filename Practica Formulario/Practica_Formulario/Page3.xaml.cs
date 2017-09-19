using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica_Formulario
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        public Page3()
        {

            InitializeComponent();

           
            var datos1 = Practica_Formulario.MainPage.datos.VNombre1.Text;
            var datos2 = Practica_Formulario.MainPage.datos.VApellido1.Text;
            var datos3 = Practica_Formulario.MainPage.datos.VTelefono1.Text;
            var datos4 = Practica_Formulario.MainPage.datos.VDireccion1.Text;
            var datos5 = Practica_Formulario.Page1.datos1.VCarrera1.SelectedItem;
            var datos6 = Practica_Formulario.Page1.datos1.VSemestre1.SelectedItem;
            var datos7 = Practica_Formulario.Page1.datos1.VMatricula1.Text;
            var datos8 = Practica_Formulario.Page2.datos3.VCorreo1.Text;
            var datos9 = Practica_Formulario.Page2.datos3.VGithub1.Text;

            VResultado.Text = "DATOS PERSONALES" + Environment.NewLine +
                " Nombre: " + datos1 + Environment.NewLine +
                " Apellido: " + datos2 + Environment.NewLine +
                " Telefono: " + datos3 + Environment.NewLine +
                " Dirección: " + datos4 + Environment.NewLine +
                Environment.NewLine + Environment.NewLine + Environment.NewLine +
                " DATOS ESCOLARES " + Environment.NewLine +
                " Carrera: " + datos5 + Environment.NewLine +
                " Semestre: " + datos6 + Environment.NewLine +
                " Matricula: " + datos7 + Environment.NewLine +
                Environment.NewLine + Environment.NewLine + Environment.NewLine +
                " DATOS SOCIALES " + Environment.NewLine+
                " Correo: " + datos8 + Environment.NewLine+
                " Github: " + datos9 + Environment.NewLine;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
        }
    }
}