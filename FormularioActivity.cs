using Android.App;
using Android.OS;
using Android.Widget;
using System.IO;

namespace OcorrenciasApp
{
    [Activity(Label = "Lançar Ocorrência")]
    public class FormularioActivity : Activity
    {
        // Declaração dos campos
        private EditText inputData, inputHoraRecebimento;
        private Switch switchVeiculo;
        private LinearLayout veiculo1Layout, veiculo2Layout;
        private Button btnSalvar;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Define o layout do formulário
            SetContentView(Resource.Layout.formulario_ocorrencia);

            // Referências aos campos
            inputData = FindViewById<EditText>(Resource.Id.inputData);
            inputHoraRecebimento = FindViewById<EditText>(Resource.Id.inputHoraRecebimento);
            switchVeiculo = FindViewById<Switch>(Resource.Id.switchVeiculo);
            veiculo1Layout = FindViewById<LinearLayout>(Resource.Id.veiculo1Layout);
            veiculo2Layout = FindViewById<LinearLayout>(Resource.Id.veiculo2Layout);
            btnSalvar = FindViewById<Button>(Resource.Id.btnSalvar);

            // Lógica do botão salvar
            btnSalvar.Click += (sender, e) =>
            {
                // Obter os valores dos campos
                string data = inputData.Text;
                string horaRecebimento = inputHoraRecebimento.Text;

                // Criar um objeto de ocorrência (exemplo simplificado)
                string ocorrencia = $"Data: {data}, Hora: {horaRecebimento}\n";

                // Salvar localmente (armazenamento interno)
                string filePath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData), "ocorrencias.txt");
                File.AppendAllText(filePath, ocorrencia);

                // Exibir mensagem de sucesso
                Toast.MakeText(this, "Ocorrência salva com sucesso!", ToastLength.Long).Show();

                // Limpar campos
                inputData.Text = "";
                inputHoraRecebimento.Text = "";
            };

            // Lógica do switch (mostrar/ocultar campos dos veículos)
            switchVeiculo.CheckedChange += (sender, e) =>
            {
                if (e.IsChecked)
                {
                    // Se o switch estiver marcado, mostra os campos dos veículos
                    veiculo1Layout.Visibility = Android.Views.ViewStates.Visible;
                    veiculo2Layout.Visibility = Android.Views.ViewStates.Visible;
                }
                else
                {
                    // Se o switch não estiver marcado, esconde os campos dos veículos
                    veiculo1Layout.Visibility = Android.Views.ViewStates.Gone;
                    veiculo2Layout.Visibility = Android.Views.ViewStates.Gone;
                }
            };
        }
    }
}
