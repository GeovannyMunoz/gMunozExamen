using static System.Runtime.InteropServices.JavaScript.JSType;

namespace gMunozExamen.Vistas;

public partial class Registro : ContentPage
{
	public Registro(string usuario)
	{
		InitializeComponent();
		lblUsuario.Text = "Usuario Conectado: " + usuario;
    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        double pagoTotal = 1500.00;
        double pagoInicial = Convert.ToDouble(txtMonto.Text);
        double cuota = ((pagoTotal -pagoInicial)/4)+(0.04*pagoTotal);
        txtPagoMensual.Text = cuota.ToString();

    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        string usuario = lblUsuario.Text;
        string nombre = txtNombre.Text;
        string apellido = txtApellido.Text;
        string edad = txtEdad.Text;
        string fecha = dpFecha.Date.ToString();
        string ciudad = pkCuidad.Items[pkCuidad.SelectedIndex].ToString();
        string pais = pkPais.Items[pkPais.SelectedIndex].ToString();
        string montoInicial = txtMonto.Text;
        string pagoMensual = txtPagoMensual.Text;
        double pagoTotal = Convert.ToDouble(montoInicial) +Convert.ToDouble(txtPagoMensual.Text)*4;

        DisplayAlert("RESUMEN", usuario+"\nNombre: " +nombre+"\nApellido: "+apellido+"\nEdad: "+edad+"\nFecha: "+fecha+"\nCuidad: "+ciudad+"\nPais: "+pais+"\nMonto Inicial: "+montoInicial+"\nPagoMensual: "+pagoMensual+"\nPagoTotal: "+pagoTotal, "CERRAR");

    }

    private void txtMonto_TextChanged(object sender, TextChangedEventArgs e)
    {
        try
        {
            double monto = Convert.ToDouble(txtMonto.Text);
            if(monto > 1500 || monto <=0)
            {
                DisplayAlert("ALERTA", "Solo valores mayores a 0 y menores a 1500", "Cancel");

            }
        }
        catch (Exception)
        {

            throw;
        }
    }
}