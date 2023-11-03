namespace ControleManutencaoPreventiva.Service
{
    public class ComparaData
    {
        public int CountaDiasPreventiva(DateTime data)
        {
            var dataAtual = DateTime.Now;
            var diasParaProximaPreventiva =  data - dataAtual;

            return data.Day;
        }
    }
}
