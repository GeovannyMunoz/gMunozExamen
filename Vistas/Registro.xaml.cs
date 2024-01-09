namespace gMunozExamen.Vistas;

public partial class Registro : ContentPage
{
	public Registro(String usuario)
	{
		InitializeComponent();
		lblUsuario.Text = "Usuario Conectado: " + usuario;
    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        double pagoTotal = 1500.00;
        double pagoInicial = Convert.ToDouble(txtMonto.Text);
        double cuota = ((pagoTotal -pagoInicial)/4)+0.4*(pagoTotal);
        txtPagoMensual.Text = cuota.ToString();

    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {

    }
}