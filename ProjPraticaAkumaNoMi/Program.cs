using Controllers;
using Models;

Console.WriteLine("Inicio processamento...");

User user = new User
{
    UserName = "Trafalgar D. Water Law",
    UserAge = 21,
    HasKingHaki = false,
    AkumaNoMi = new AkumaNoMi { TypeFruit = "Paramecia", Rarity = "Special" },
};

Console.WriteLine(new UserCont().Insert(user) ? "Sucesso" : "Erro");