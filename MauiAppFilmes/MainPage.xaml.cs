using MauiAppFilmes.Categorias;

namespace MauiAppFilmes
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnAventura_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Aventura());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void BtnComedia_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Comedia());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void BtnDrama_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Drama());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void BtnTerror_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Terror());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void BtnFiccao_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Ficcao());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void BtnSuspense_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Suspense());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}
