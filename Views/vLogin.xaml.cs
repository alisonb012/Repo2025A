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
        string contrase�a = txtContrase�a.Text;

        if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrase�a))
        {
            DisplayAlert("Error", "Por favor ingrese usuario y contrase�a", "Aceptar");
        }

        int ingreso = Array.IndexOf(user, usuario);
        if (ingreso != -1 && pass[ingreso] == contrase�a)
        {
            Navigation.PushAsync(new Views.vElementos(txtUsuario.Text));
        }
        else
        {
            DisplayAlert("Error", "Usuario o contrase�a incorrectos.", "Aceptar");
        }
    }
}