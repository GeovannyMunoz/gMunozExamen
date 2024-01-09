using static System.Runtime.InteropServices.JavaScript.JSType;

namespace gMunozExamen.Vistas;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
        string[] user = { "estudiante2024", "examen1", "NombreEstudiante" };
        string[] pass = { "uisrael2024", "parcial1", "2024" };

        string usuario = "";
        string contrasena = "";
        int index = Array.IndexOf(user, txtUsuario.Text);
        if (index != -1)
        {
            usuario = txtUsuario.Text;
            contrasena = pass[index];

        }

        if (txtUsuario.Text == usuario && txtContrasena.Text == contrasena)
        {
            Navigation.PushAsync(new Vistas.Registro(usuario));

        }
        else
        {
            DisplayAlert("ALERTA", "Usuario/Contraseña incorrectos", "Cancel");
        }
    }

    private void btnAcerca_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("ACERCA DE", " Universidad Tecnologia Israel\n Desarrollado por: Geovanny Muñoz\n 8vo A\n Desarrollo Moviles", "CERRAR");
    }
}