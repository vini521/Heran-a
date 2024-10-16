//namespace Herannca
//{
//    /*A classe "Animal" é uma classe Abstrata que servira de modelo para os outros animais*/
//    public abstract class Animal
//    {
//        public string Nome { get; set; }
//        public int Idade { get; set; }
//        public string TipoAlimentacao { get; set; }

//        /*Metodo abstrato - não possui implementação aqui mas as classes que herdarem vão precisar de implementação*/
//        public abstract void EmitirSom();
//    }

//    // A classe Cachorro herda da classe Animal
//    //Isso significa que o Cachorro terá todos atributos e comportamentos definidos em Animal. Mas também pode ter suas proprias caracteristicas
//    public class Cachorro : Animal
//    {
//        public string Raca { get; set; }
//        //Bool verdadeiro ou falço
//        public bool BuscaObjetos { get; set; }

//        public override void EmitirSom()
//        {
//            Console.WriteLine("Au Au");
//        }
//    }
//}
