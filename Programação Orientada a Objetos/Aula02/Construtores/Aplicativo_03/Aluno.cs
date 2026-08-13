
namespace Aplicativo_03
{
    internal class Aluno
    {
        public string nomedoaluno;
        public double nota1;
        public double nota2;
        public double nota3;

        public Aluno(string nomedoaluno, double nota1, double nota2, double nota3)
        {
            this.nomedoaluno = nomedoaluno;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
        }

        public double NotaFinal()
        {
            return nota1 + nota2 + nota3;
        }

        public bool AprovadoOuReprovado()
        {
            return
        }

        public double Ponto()
        {
            throw new System.NotImplementedException();
        }
    }
}
