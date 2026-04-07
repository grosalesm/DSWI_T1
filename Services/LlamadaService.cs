namespace DSWI_T1_RosalesGian.Services
{
    public class LlamadaService : ILlamadaService
    {
        public double CalcularCostoLlamada(int minutos)
        {
            double costoTotal = 10;
            if (minutos > 5)
            {
                costoTotal += (minutos - 5) * 3;
            }
            return costoTotal;
        }
    }
}
