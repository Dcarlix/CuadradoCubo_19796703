namespace CuadradoCubo19796703
{
    public partial class MainPage : ContentPage
    {
        /// <summary>
        /// En esta aplicacion le pedimos al usuario que ingrese un numero, y luego le mostramos el mismo numero pero elevado al cuardado y tambien elevando al cubo
        /// </summary>
        public MainPage()
        {
            InitializeComponent();
        }

		private void Button_Clicked(object sender, EventArgs e)
		{
            if (double.TryParse(numero.Text, out double num))
            {
                double pow2 = Math.Pow(num, 2);
                double pow3 = Math.Pow(num, 3);
                cuadrado.Text = pow2.ToString();
                cubo.Text = pow3.ToString();
            }
            else
            {
                DisplayAlert("Error", "Solo numeros o no dejar en blanco", "Ok");
            }
        }
    }

}
