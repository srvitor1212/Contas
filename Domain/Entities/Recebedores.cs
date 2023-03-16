﻿namespace Domain.Entities
{
    public sealed class Recebedores : Base
    {
        public string Nome { get; set; }

        public ICollection<Dividas> Dividas { get; private set; }
    }
}
