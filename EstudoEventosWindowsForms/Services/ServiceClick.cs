using EstudoEventosWindowsForms.EventArgs;
using System;

namespace EstudoEventosWindowsForms.Services
{
    public class ServiceClick
    {
        private int _qtdClick;

        public event EventHandler ValorMaximoClickEvent;

        protected virtual void OnValorMaximoClick(System.EventArgs e)
        {
            ValorMaximoClickEvent?.Invoke(this, e);
        }

        public ServiceClick()
        {
            _qtdClick = 0;
        }

        public int Clicar()
        {
            if (_qtdClick >= 80)
            {
                OnValorMaximoClick(new ExcessoClickEventArgs(_qtdClick));

                return _qtdClick;
            }

            return _qtdClick += 10;
        }
    }
}
