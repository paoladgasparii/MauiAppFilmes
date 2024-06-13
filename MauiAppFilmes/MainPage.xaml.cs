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

        private void BtnDocumentario_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Documentario());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void BtnNacional_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Nacional());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void BtnAnimacao_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Animacao());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void BtnInfantil_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Infantil());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void BtnGuerra_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Guerra());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void BtnRomance_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Romance());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}
