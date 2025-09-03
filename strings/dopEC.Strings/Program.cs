Console.WriteLine(" ====== STRINGS MAIS LEGÍVEIS ====== ");

var stringEntity = MenuStrings.menuString();

InterpolacaoComFormat.stringComFormat(stringEntity.Text);
InterpolacaoComCifrao.stringComCifrao(stringEntity.Text);

Console.WriteLine("Pressione qualquer tecla para fechar ...");
Console.ReadKey();