namespace Frontend.Model.Response
{
	//quando o elemento for RESPONSE quer dizer que é oque o sistema ira ENVIAR, ou seja são os itens que irao aparecer na tela apos o sistema rodar 
	//lembrando que a pasta MODELL no front e no back tem que ser tudo igual nome e etc
	public class CarteirinhaResponse
    {
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string CorDeFundo { get; set; }
    }
}
