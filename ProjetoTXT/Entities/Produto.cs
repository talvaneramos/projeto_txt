﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoTXT.Entities
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
    }
}
