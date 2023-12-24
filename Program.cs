using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Criando o Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "452", modelo: "G11 Plus NK095", imei: "442563-22-098392-1", memoria: 128);
nokia.Ligar();
try {
    nokia.InstalarAplicativo("Digital Innovation One");
} catch (ArgumentException e) {
    Console.WriteLine($"Ocorreu um problema ao instalar o aplicativo: {e.Message}");
}

Console.WriteLine("Criando o Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "223", modelo: "XR", imei: "452325-67-233607-4", memoria: 64);
iphone.Ligar();
try {
    iphone.InstalarAplicativo("Digital Innovation One");
} catch (ArgumentException e) {
    Console.WriteLine($"Ocorreu um problema ao instalar o aplicativo: {e.Message}");
}
