// Configure o logger
var stringFactory = new StringFactory();

Console.WriteLine(" ====== STRINGS MAIS LEGÍVEIS ====== ");

#region INICIALIZA O MENU BASE
var text = MenuStrings.menuString();
#endregion

#region INICIALIZA OS METODOS DA STRING
stringFactory.Execute(text);
#endregion

Console.WriteLine("Pressione qualquer tecla para fechar ...");
Console.ReadKey();
