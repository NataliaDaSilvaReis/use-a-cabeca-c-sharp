using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandubasPrecoBomEAqui
{
    internal class ItemDoMenu
    {
        public static Random randomizar = new Random();

        public string[] proteinas = { "Carne assada", "Salame", "Peru", "Presunto", "Pastrami", "Tofu" };
        public string[] condimentos = { "mostarda amarela", "mostarda escura", "mostarda e mel", "maionese", "relish", "molho french" };
        public string[] paes = { "pão de centeio", "pão branco", "pão de trigo", "pão integral", "pão de rolo" };

        public string descricao = "";
        public string preco;



        public void Gerar()
        {
            string randomProteina = proteinas[randomizar.Next(proteinas.Length)];
            string randomCondimento = condimentos[randomizar.Next(condimentos.Length)];
            string randomPao = paes[randomizar.Next(paes.Length)];

            descricao = $"{randomProteina} com {randomCondimento} no {randomPao}";

            decimal reais = randomizar.Next(2, 5);
            decimal centavos = randomizar.Next(1, 98);
            decimal valor = reais + (centavos * .01M);
            preco = valor.ToString("c");
        }
    }
}
