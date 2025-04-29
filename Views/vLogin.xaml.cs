using static System.Runtime.InteropServices.JavaScript.JSType;

namespace aburbanoS2A.Views;

public partial class vLogin : ContentPage
{
    public vLogin()
    {
        InitializeComponent();
    }

    private readonly string[] user = {"Carlos", "Ana", "Jose" };
    private readonly string[] pass = { "carlos123", "ana123", "jose123" };

    private void btnIngreso_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string contraseña = txtContraseña.Text;

        if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
        {
            DisplayAlert("Error", "Por favor ingrese usuario y contraseña", "Aceptar");
        }

        int ingreso = Array.IndexOf(user, usuario);
        if (ingreso != -1 && pass[ingreso] == contraseña)
        {
            Navigation.PushAsync(new Views.vElementos(txtUsuario.Text));
        }
        else
        {
            DisplayAlert("Error", "Usuario o contraseña incorrectos.", "Aceptar");
        }
    }
}