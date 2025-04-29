namespace aburbanoS2A.Views;

public partial class vElementos : ContentPage
{
	public vElementos(string usuario)
	{
		InitializeComponent();
		lblMensaje.Text = "¡Bienvenido, " + usuario + "!";
	}

    private void Paises_Clicked(object sender, EventArgs e)
    {
		try
		{
			if (pkPaises.SelectedIndex == -1)
			{
				DisplayAlert("Error", "El dato no exixte", "Cerrar");
				
			} else
				{
					string pais = pkPaises.Items[pkPaises.SelectedIndex].ToString();
				DisplayAlert("Paises", "El pais seleccionado es:" + pais, "Cerrar");

				}
		}
		catch (Exception ex)
		{

			DisplayAlert("Error", ex.Message, "Cerrar");
		}
		
    }

    private void btnFecha_Clicked(object sender, EventArgs e)
    {
		string  date = dpfecha.Date.ToString();
		DisplayAlert("Error", "La fecha es: " + date, "Cerrar");
    }
}