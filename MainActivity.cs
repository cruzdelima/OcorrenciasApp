using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace OcorrenciasApp
{
    [Activity(Label = "Ocorr�ncias", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Define o layout principal
            SetContentView(Resource.Layout.activity_main);

            // Bot�o para lan�ar ocorr�ncia
            Button btnLaunchOccurrence = FindViewById<Button>(Resource.Id.btnLaunchOccurrence);
            btnLaunchOccurrence.Click += (sender, e) =>
            {
                // Navegar para o formul�rio
                Intent intent = new Intent(this, typeof(FormularioActivity));
                StartActivity(intent);
            };
        }
    }
}
