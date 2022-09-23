using System.Security.Cryptography;

int valorDoDado = RandomNumberGenerator.GetInt32(1, 7);

Console.WriteLine($"O seu dado caiu no lado: {valorDoDado}");
