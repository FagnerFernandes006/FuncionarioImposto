using System.Globalization;
namespace FuncionarioSalario
{
    public class Funcionario
    {
        public string nome { get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }

       public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double porcentagem)
        {
            double aumento = SalarioBruto * (porcentagem / 100);
            SalarioBruto = aumento + SalarioLiquido();
        }
        public override string ToString()
        {
            return nome + ", " + "$ " + SalarioBruto.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
