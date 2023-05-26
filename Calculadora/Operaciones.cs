public class Operaciones
{
    #region Noel
    public int Suma(int a, int b)
    {
        // throw new NotImplementedException("No Implementado");

        return a + b;
    }
    #endregion
    public int Resta(int a, int b)
    {
        // throw new NotImplementedException("No Implementado");
        return a -b;
    }

    public int Multiplicacion(int a, int b)
    {
        // throw new NotImplementedException("No Implementado");

        return a * b;
    }

    public int Division(int a, int b)
    {
        // if (a == 0 || b == 0){
        //     throw new NotImplementedException("No existe division por cero");
        // }

        if (a == 0 || b == 0){
            return 0;
        }

        return a /b;    
    }
}