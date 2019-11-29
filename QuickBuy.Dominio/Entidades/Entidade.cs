using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        public List<string> _mensagenValidacao { get; set; }

        private List<string> mensagemValidacao
        {
            get { return _mensagenValidacao ?? (_mensagenValidacao = new List<string>()); }


        }
        protected void LimparMensagensValidacao()
        {
            mensagemValidacao.Clear();
        }
        protected void AdicionarCritica(string mensagem)
        {
            mensagemValidacao.Add(mensagem);
        }


        public abstract void Validade();
        protected bool EhValido
        {
            get { return !mensagemValidacao.Any(); }
        }
    }
}
