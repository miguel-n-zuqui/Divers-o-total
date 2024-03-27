using System.ComponentModel.DataAnnotations;

namespace Frontend.Model.Request
{
    //quando o elemento for REQUEST quer dizer que é oque o sistema ira RECEBER, ou seja são os itens que irao aparecer na tela 
    //lembrando que a pasta MODELL no front e no back tem que ser tudo igual nome e etc
    public class ClienteRequest
    {
        [Required (ErrorMessage = "Nome é obrigatório")]
        [StringLength(100, MinimumLength = 10, 
            ErrorMessage = "Nome deve ter no minímo 10 caracteres")]
        public string Nome { get; set; }

        [Required (ErrorMessage = "Data de nascimento é obrigatório")]
        public DateTime Nascimento  { get; set; }
    }
}
