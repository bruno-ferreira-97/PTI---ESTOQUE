using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControleEstoque{
    public class ItemEstoque
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public string Fazenda { get; set; }
        public int Quantidade { get; set; } = 0;

        public ItemEstoque(string nome, double preco, string tipo, string descricao, string fazenda, int quantidade){
        Nome = nome;
        Preco = preco;
        Tipo = tipo;
        Descricao = descricao;
        Fazenda = fazenda;
        Quantidade = quantidade;
        }


        public override string ToString()
        {
            return $"Nome: {Nome}, Preço: {Preco}, Tipo: {Tipo}, Descrição: {Descricao}, Fazenda: {Fazenda}, Quantidade: {Quantidade}";
        }

        
    }


}
