namespace dopEC.Strings
{
    public class MenuStrings
    {
        public static StringEntity menuString()
        {
            //Console.WriteLine("Escolha uma opção:");
            //Console.WriteLine("1 - Método simples (só string)");
            //Console.WriteLine("2 - Usando StringEntity existente");
            //Console.WriteLine("3 - Criando novo StringEntity");
            //Console.WriteLine("4 - Com validação");
            //Console.Write("\nOpção: ");

            //var opcao = Console.ReadLine();
            //Console.Clear();

            //switch (opcao)
            //{
            //    case "1":
            //        Exemplo1_MetodoSimples();
            //        break;
            //    case "2":
            //        Exemplo2_EntityExistente();
            //        break;
            //    case "3":
            //        Exemplo3_NovoEntity();
            //        break;
            //    case "4":
            //        Exemplo4_ComValidacao();
            //        break;
            //    default:
            //        Console.WriteLine("Opção inválida! Executando exemplo padrão...\n");
            //        Exemplo4_ComValidacao();
            //        break;
            //}

            Console.Write("Escreva algo interessante e veja diferentes formas de exibi-lo: ");
            var texto = Console.ReadLine() ?? string.Empty;
            return new StringEntity { Text = texto };
        }
    }
}
