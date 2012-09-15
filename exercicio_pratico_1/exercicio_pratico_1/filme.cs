using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercicio_pratico_1
{
        //criação de classe que servirá de base para os filmes
        public class Filme
        {
            string Nome;
            string Genero;
            string Data_Assistido;
            string Local;
            //construtor da classe Filmes - inicia todas os atributos vazios
            public Filme()
            {
                Nome = "";
                Genero = "";
                Data_Assistido = "";
                Local = "";
            }
        }
    
}
