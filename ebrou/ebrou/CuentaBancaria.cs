using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ebrou
{
    public class CuentaBancaria
    {
        private int numero;
        private string titular;
        private decimal saldo;

        public CuentaBancaria()
        {

        }

        public CuentaBancaria(int numero, string titular, decimal saldo)
        {
            this.numero = numero;
            this.titular = titular;
            this.saldo = saldo;
        }

        public int Getnumero()
        {
            return numero;
        }

        public void Setnumero(int numero)
        {
            this.numero = numero;
        }

        public string Gettitular()
        {
            return titular;
        }
        
        public void Settitular(string titular)
        {
            this.titular = titular;
        }

        public decimal Getsaldo()
        {
            return saldo;
        }

        public void Setsaldo(decimal saldo)
        {
            this.saldo = saldo;
        }

        public void Depositar(decimal monto)
        {
             this.saldo += monto;
        }

        public decimal Extraer(decimal monto)
        { 
            if(this.saldo>monto)
            {
                 this.saldo -= monto;
                return this.saldo;
            }


            else
            {
                Console.WriteLine("El saldo es insuficiente. Intente con otro monto");
                return -1;
            }
        }

       


    }

}
