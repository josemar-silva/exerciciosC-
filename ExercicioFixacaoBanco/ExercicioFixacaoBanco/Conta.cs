using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioFixacaoBanco {
    class Conta {

        public string Titular { get; set; }
        public double Saldo { get; private set; }
        public int Numero { get; private set; }

        public Conta(string titular, int numero) {
            Titular = titular;
            Numero = numero;
        }

        public Conta(string titular, double depositoInicial, int numero) : this(titular, numero) {
            Depositar(depositoInicial);
        }

        public void Depositar(double deposito) {
            Saldo += deposito;
        }
        public void Sacar(double saque) {
            int taxaSaque = 5;
            Saldo -= saque;
            Saldo -= taxaSaque;
        }
           
        public override string ToString() {
        return "Cliente: " + Titular + "\n" +
               "Numero da Conta ; " + Numero + "\n" +
               "Saldo atual: " + Saldo.ToString("F2", CultureInfo.InvariantCulture) + "\n";
            
               
        }

    }
}
