using System;

class CuentaBancaria
{
    private double saldo;

    public CuentaBancaria(double saldoInicial)
    {
        saldo = saldoInicial;
    }

    public void Depositar(double cantidad)
    {
        saldo += cantidad;
        Console.WriteLine("Depositaste " + cantidad);
        Console.WriteLine("Nuevo saldo: " + saldo);
    }

    public void Retirar(double cantidad)
    {
        if (cantidad <= saldo)
        {
            saldo -= cantidad;
            Console.WriteLine("Retiraste " + cantidad);
            Console.WriteLine("Nuevo saldo: " + saldo);
        }
        else
        {
            Console.WriteLine("Fondos insuficientes");
        }
    }

    public double GetSaldo()
    {
        return saldo;
    }
}

class CajeroAutomatico
{

    static void Main(string[] args)
    {

        CuentaBancaria cuenta = new CuentaBancaria(500.0);

        int opcion;

        do
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Ver saldo");
            Console.WriteLine("2. Depositar");
            Console.WriteLine("3. Retirar");
            Console.WriteLine("4. Salir");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Su saldo es: " + cuenta.GetSaldo());
                    break;
                case 2:
                    Console.WriteLine("Ingrese monto a depositar:");
                    double montoDeposito = double.Parse(Console.ReadLine());
                    cuenta.Depositar(montoDeposito);
                    break;
                case 3:
                    Console.WriteLine("Ingrese monto a retirar:");
                    double montoRetiro = double.Parse(Console.ReadLine());
                    cuenta.Retirar(montoRetiro);
                    break;
            }

        } while (opcion != 4);

    }

}
