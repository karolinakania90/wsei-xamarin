using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AirMonitor.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class DetailsPage : ContentPage
    {
        const string CaqiDescription = @"CAQI jest liczbą w skali od 1 do 100, gdzie niska wartość oznacza dobrą jakość powietrza oraz wysoka wartość oznacza złą jakość powietrza. 
                                        Indeks jest zdefiniowany w obu wersjach godzinowych i dziennych, a osobno w pobliżu dróg (a „przydrożne” lub „ruch” Index) lub z dala od dróg (a „t” index). 
                                        Począwszy od 2012 roku, CAQI miał dwóch obowiązkowych komponentów dla indeksu drogowej, NO 2 i PM 10 oraz trzy obowiązkowe elementy do indeksu tle, NO 2 , PM 10 i O 3 . 
                                        Zawierał on także ewentualne zanieczyszczenia PM 2,5 , Co i SO 2 . Określenie „pod-Index” oblicza się dla każdego z obowiązkowo (a opcjonalnie, jeśli są dostępne) składników";
        public DetailsPage()
        {
            InitializeComponent();
        }

        private void Help_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Co to jest CAQI?", CaqiDescription, "Zamknij");
        }
    }
}
