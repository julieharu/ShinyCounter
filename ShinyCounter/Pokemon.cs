using System;
using System.Collections.Generic;
using System.Text;

namespace ShinyCounter {
    class Pokemon {
        private int num;
        private string nome;

        public Pokemon(int num, string nome) {
            this.num = num;
            this.nome = nome;
        }

        public int Num { get => num; set => num = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}
