namespace Practica11Ej1
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Algoritmo que se ejecuta al hacer clic en el botón
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCounterClicked(object sender, EventArgs e)
        {
            //Si el entry costo y el entry pago contienen caractéres...
            if (eCosto.Text != null && ePago.Text != null)
            {
                //Hacemos un try
                try
                {
                    //Se crean las variables cambio, costo y pago
                    double cambio;
                    double costo = Convert.ToDouble(eCosto.Text), pago = Convert.ToDouble(ePago.Text);
                    //Si pagas más de lo que cuesta el producto...
                    if (costo < pago) 
                    { 
                        //El cambio es lo que pagaste menos el costo
                        cambio = pago - costo;
                        //Mostrando el cambio en el entry correspondiente
                        eCambio.Text = cambio.ToString("C2");
                    }
                    //Si pagas menos de lo que cuesta el producto...
                    else if (costo > pago)
                    {
                        //El cambio es lo que te falta pagar
                        cambio = costo - pago;
                        //Mostrando el cambio en el entry correspondiente
                        eCambio.Text = "Debes " + cambio.ToString("C2");
                    }
                }
                //Si hay un error
                catch 
                {
                    //Mostramos una alerta
                    DisplayAlert("Error", "Los datos deben ser numéricos", "Ok");
                }
            }
            //Si esos entries están vacíos...
            else
            {
                //Mostramos esta alerta
                DisplayAlert("Error", "Debe introducir el costo y el pago", "Ok");
            }
        }
    }

}
