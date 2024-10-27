using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioEncapsulamento
{
    class Banco
    {
        private int _conta;
        public string Titular { get; set; }
        public double Valor { get; private set; }

        public Banco() { }

        public Banco(int conta, string titular, double valor)
        {
            _conta = conta;
            Titular = titular;
            Valor = valor;

        }
        public int Conta { get { return _conta; } }

        public void AdicionarValor(double valor)
        { Valor += valor; }

        public void RemoverValor(double valor)
        { Valor = Valor - valor - 5.0; }

        public override string ToString()
        {
            return 
                "Conta " +
                Conta +
                ", Titular: " +
                Titular +
                ", Saldo: $ " +
                Valor.ToString("F2", CultureInfo.InvariantCulture); 
        }
    }
}
