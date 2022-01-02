using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace SistemaLDA
{
    public partial class InitForm : Form
    {
        private readonly MainScreen TelaInicial;

        public InitForm()
        {
            InitializeComponent();
            TelaInicial = Program.ServiceProvider.GetRequiredService<MainScreen>();

        }

        private void TimeShowing_Tick(object sender, EventArgs e)
        {
            TimeShowing.Enabled = true;
            ProgressBar.Increment(4);

            if (ProgressBar.Value == 100)
            {
                TimeShowing.Enabled = false;
                TelaInicial.Show();
                this.Hide();
            }

        }
    }
}
