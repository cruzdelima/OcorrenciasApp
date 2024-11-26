using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace OcorrenciasApp
{
    [Activity(Label = "Ocorrências", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Define o layout principal
            SetContentView(Resource.Layout.activity_main);

            // Botão para lançar ocorrência
            Button btnLaunchOccurrence = FindViewById<Button>(Resource.Id.btnLaunchOccurrence);
            btnLaunchOccurrence.Click += (sender, e) =>
            {
                // Navegar para o formulário
                Intent intent = new Intent(this, typeof(FormularioActivity));
                StartActivity(intent);
            };
        }
    }
}
