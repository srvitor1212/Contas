﻿using Domain.Validation;

namespace Domain.Entities
{
    public sealed class Dividas : Base
    {
        public string Nome { get; private set; }
        public decimal Valor { get; private set; }
        public bool FoiPago { get; private set; } = false;
        public DateTime DataInicio { get; private set; }
        public DateTime DataFim { get; private set; }
        public byte DiaVencimento { get; private set; }

        public int PagamentosId { get; set; }
        public Pagamentos Pagamentos { get; set; }

        public int RecebedoresId { get; set; }
        public Recebedores Recebedores { get; set; }

        public Dividas(string nome, decimal valor, bool FoiPago,
            DateTime DataInicio, DateTime DataFim, byte DiaVencimento)
        {
            Validation(nome, valor, FoiPago,
                DataInicio, DataFim, DiaVencimento);
        }

        public Dividas(int id, string nome, decimal valor, bool FoiPago,
            DateTime DataInicio, DateTime DataFim, byte DiaVencimento)
        {
            DomainValidation.When(
                id < 0,
                "Id inválido!");
            this.Id = id;

            Validation(nome, valor, FoiPago,
                DataInicio, DataFim, DiaVencimento);
        }

        public void Update(string nome, decimal valor, bool FoiPago,
            DateTime DataInicio, DateTime DataFim, byte DiaVencimento)
        {
            Validation(nome, valor, FoiPago,
                DataInicio, DataFim, DiaVencimento);
        }

        public void Validation(string nome, decimal valor, bool FoiPago,
            DateTime DataInicio, DateTime DataFim, byte DiaVencimento)
        {
            //nome
            DomainValidation.When(
                string.IsNullOrEmpty(nome),
                "Nome é obrigatório");

            DomainValidation.When(
                nome.Length < 3,
                "Nome precisa ter no mínimo 2 caracteres");

            DomainValidation.When(
                nome.Length > 150,
                "Tamanho máximo de 150 caracteres");

            //valor
            DomainValidation.When(
                valor == 0,
                "Valor não pode ser zero");

            DomainValidation.When(
                valor < 0,
                "Valor não pode ser negativo");

            this.Nome = nome;
            this.Valor = valor;
            this.FoiPago = FoiPago;
            this.DataInicio = DataInicio;
            this.DataFim = DataFim;
            this.DiaVencimento = DiaVencimento;
        }

    }
}
