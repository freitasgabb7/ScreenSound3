//using OpenAI_API;
using ScreenSound3.Modelos;
namespace ScreenSound3.Menus;

internal class MenuRegistrarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro das bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Banda banda = new Banda(nomeDaBanda);
        bandasRegistradas.Add(nomeDaBanda, banda);

        //var client = new OpenAIAPI (KEYHERE);

        //var chat = client.Chat.CreateConversation();

        //chat.AppendSystemMessage($"Resuma a banda {nomeDaBanda} em um parágrafo. Adote um estilo formal e bem formatado.");

        //string resposta = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
        //banda.Resumo = resposta;

        Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso!");
        Console.Write("\nPressione uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}