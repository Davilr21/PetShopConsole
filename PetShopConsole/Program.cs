using PetShopConsole;

List<Animal> animais = new List<Animal>
{
     new Cachorro ("Rabito", 6),
     new Gato ("Davi", 3),
     new Passaro ("Platininha", 8)
};

foreach (Animal  animal in animais)
{
    Console.WriteLine (animal);
    Console.WriteLine(animal.FazerSom());
    animal.Comer();
    Console.WriteLine();
}

Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadLine();