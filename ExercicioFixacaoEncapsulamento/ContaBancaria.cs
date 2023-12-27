using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExercicioFixacaoEncapsulamento
{
    internal class ContaBancaria
    {
        private double _saldo;
        public string _nome { get; private set; }
        public int _numeroConta { get; private set; }

        public ContaBancaria()
        {

        }
        public ContaBancaria(string nome, int numero, double saldo)
        {
            _numeroConta = numero;
            _nome = nome;
            _saldo = saldo;
        }
        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }
        public void Saque(double valor)
        {
            valor = valor + 5;
            Saldo -= valor;
        }
        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }
        public int Nconta
        {
            set { _numeroConta = value; }
        }
        public void Nome(string nome)
        {
            _nome = nome;
        }
        public override string ToString()
        {
            return "Conta " + _numeroConta
            + ", Titular: "
            + _nome
            + ", Saldo: $ "
            + _saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
