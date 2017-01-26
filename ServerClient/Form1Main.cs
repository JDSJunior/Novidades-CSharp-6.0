using System;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ServerClient
{
    public partial class Form1Main : Form
    {
        public Form1Main()
        {
            InitializeComponent();
        }

        async Task Log(string mensagem)
        {
            txtResult.Text = mensagem;

        }
        private async void button1_Click(object sender, EventArgs e)
        {
            //usando metodos asincronos no bloco cathc
            try
            {
                int r = ExecutarWebServices();
                txtResult.Text = r.ToString();
            }
            catch (Exception E)
            {
                //a aplicação nao vai travar para ser executada a exceção
                //Erro
                await Log(E.Message);
            }
            finally
            {
                //Sempre
            }
        }

        private int ExecutarWebServices()
        {
            var calc = new Proxy.CalcWebService();
            return calc.Somar(Convert.ToInt32(txtX.Text), Convert.ToInt32(txtY.Text));
        }
    }
}
