using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Exemplo
{
    class Pessoa
    {
        private String nome;
        private String rg;
        private int idade;

        public Pessoa() {}

        public Pessoa(String nome, String rg, int idade){
            this.nome = nome;
            this.rg = rg;
            this.idade = idade;
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }
 
        public String getNome()
        {
            return this.nome;
        }
 
        public void setRg(String rg)
        {
            this.rg = rg;
        }
 
        public String getRg()
        {
            return this.rg;
        }
 
        public void setIdade(int idade)
        {
            this.idade = idade;
        }
 
        public int getIdade()
        {
            return this.idade;
        }


        
    }
}