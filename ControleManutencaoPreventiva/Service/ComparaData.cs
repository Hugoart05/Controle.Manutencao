﻿namespace ControleManutencaoPreventiva.Service
{
    public class ComparaData
    {
        public int CountaDiasPreventiva(DateTime data)
        {
            int meses = 6;

            var proxima = data.AddMonths(meses);
            var atual = DateTime.Today;
            var diaspara = proxima - atual;
            return diaspara.Days;
        }
    }
}
