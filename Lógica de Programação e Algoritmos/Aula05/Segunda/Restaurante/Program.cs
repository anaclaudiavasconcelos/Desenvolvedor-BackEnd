async Task Principal()
{
  Console.WriteLine("Pedido anotado");
  await Task.WhenAll(PrepararHamburguer(), PrepararBatata(), PrepararMilkShake());
  Console.WriteLine("Pedido entregue");
}

async Task PrepararHamburguer()
{
    Console.WriteLine("Preparando Hamburguer...");
    await Task.Delay(3000); //3 segundos
    Console.WriteLine("Hamburguer pronto!");
}

async Task PrepararBatata()
{
    Console.WriteLine("Preparando Batata Frita...");
    await Task.Delay(2500);
    Console.WriteLine("Batata Frita pronto!");
}


async Task PrepararMilkShake()
{
    Console.WriteLine("Preparando Milk Shake...");
    await Task.Delay(4000);
    Console.WriteLine("Milk Shake pronto!");
}

await Principal();
