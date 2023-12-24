# DIO - Trilha .NET - Programação orientada a objetos
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de orientação a objetos, da trilha .NET da DIO.

## Contexto
Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta
Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Você deve criar as suas classes de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Solução
O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.

O projeto foca na aplicação dos princípios de Programação Orientada a Objetos (POO) por meio de conceitos como Herança, Classes Abstratas e Encapsulamento. Na classe Smartphone, foram definidos atributos essenciais, como o Modelo e o IMEI. Foi implementada uma validação simples do padrão do IMEI, usando Regex, garantindo sua conformidade. Além disso, foi criado um método privado que assegura a verificação da existência e preenchimento do nome do aplicativo a ser instalado, evitando valores nulos ou vazios.

## Referências
[Link utilizado para validação regex do IMEI do Smartphone](https://www.gov.br/anatel/pt-br/assuntos/celular-legal/imei#:~:text=Cada%20celular%20tem%20um%20número,-00-000000-0.)