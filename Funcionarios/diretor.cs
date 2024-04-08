namespace bytebank.Funcionarios

{

    public class Diretor:Funcionario {



        public override double GetNotification()
        {
          return this.Salario;
        }



    }
}