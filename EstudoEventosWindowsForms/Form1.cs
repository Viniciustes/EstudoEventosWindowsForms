using EstudoEventosWindowsForms.EventArgs;
using EstudoEventosWindowsForms.Services;
using System.Windows.Forms;

namespace EstudoEventosWindowsForms
{
    public partial class FrmQtdClick : Form
    {
        private readonly ServiceClick _serviceClick;

        public FrmQtdClick()
        {
            InitializeComponent();
            _serviceClick = new ServiceClick();
            _serviceClick.ValorMaximoClickEvent += QuandoExcederClick;
        }

        private void FrmQtdClick_Load(object sender, System.EventArgs e)
        {
            PgbQtdClick.Value = 0;
        }

        private void BtnClique_Click(object sender, System.EventArgs e)
        {
            PgbQtdClick.Value = _serviceClick.Clicar();
        }

        private void QuandoExcederClick(object sender, System.EventArgs e)
        {
            var eventArgs = (ExcessoClickEventArgs)e;

            MessageBox.Show(string.Format("Quantidade máxima de clique que é de {0} foi excedido.", eventArgs.QtdClick), "Excesso de cliques", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
