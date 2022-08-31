using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA_2__N_6322043
{
    internal class Filme
    {
        string titulo;
        string sinopse;
        string genero;
        string classificacao;

        public void Receber(string ti, string si, string ge, string cla)
        {
            this.titulo = ti;
            this.sinopse = si;
            this.genero = ge;
            this.classificacao = cla;
                
        }
        public string Mostrar()
        {
            return "Titulo: " + this.titulo + "\nSinopse: " + this.sinopse + "\nGenero: "
                + this.genero + "\nClassificação: " + this.classificacao;
                
        }


    }
}
