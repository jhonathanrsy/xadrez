
namespace tabuleiro
{
    class Peca
    {
      public posicao posicao { get; set; }
      public Cor cor { get; protected set; } 
      public int qteMovimentos { get; protected set; }
      public Tabuleiro Tab { get; protected set; }

      public Peca (posicao posicao, Cor cor, Tabuleiro tab)
        {
            this.posicao = posicao;
            this.cor = cor;
            this.Tab = tab;
            this.qteMovimentos = 0;
           
        }

    }

  
}
