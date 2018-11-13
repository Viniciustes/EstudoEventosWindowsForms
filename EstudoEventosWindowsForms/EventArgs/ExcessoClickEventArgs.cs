namespace EstudoEventosWindowsForms.EventArgs
{
    public class ExcessoClickEventArgs : System.EventArgs 
    {
        public ExcessoClickEventArgs(int qtdClick)
        {
            QtdClick = qtdClick;
        }

        public int QtdClick { get; set; }
    }
}
