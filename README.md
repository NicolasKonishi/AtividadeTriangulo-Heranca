# Identificador de Triângulos

Este é um simples programa em C# recebido na aula de orientação à objetos no curso de Análise de sistemas que demonstra o uso de herança de classe com propriedades abstratas, interface para o método principal e Windows Forms do .NET para a interface do usuário. O programa identifica o tipo de triângulo com base nos comprimentos dos seus lados.

## Funcionalidades

- Permite ao usuário inserir os comprimentos dos três lados do triângulo.
- Identifica se o triângulo é equilátero, isósceles ou escaleno.
- Utiliza herança de classe com propriedades abstratas na classe `AbsPropriedades` para definir as propriedades dos lados do triângulo.
- Utiliza a interface `IMetodos` para gerenciar os métodos relacionados à identificação do tipo de triângulo.
- Utiliza a classe `Controle` para direcionar os números para as classes e executar as funções.
- Utiliza a classe `Triangulos` para receber os três números e identificar o tipo do triângulo, enviando uma mensagem através de uma variável.
- Utiliza a classe `Validacao` para validar se foram digitados três números e se esses números podem formar um triângulo (observando se a soma de dois lados é maior que o terceiro).

## Uso

1. Clone o repositório para sua máquina local.
2. Abra o projeto no Visual Studio ou outra IDE compatível com o .NET.
3. Compile e execute o programa.
4. Insira os comprimentos dos lados do triângulo quando solicitado.
5. O programa exibirá o tipo de triângulo com base nos comprimentos inseridos.

## Estrutura do Projeto

- `AbsPropriedades.cs`: Define a classe base `AbsPropriedades` com as propriedades abstratas para os lados do triângulo.
- `IMetodos.cs`: Define a interface `IMetodos` para gerenciar os métodos relacionados à identificação do tipo de triângulo.
- `Controle.cs`: Direciona os números para as classes e executa as funções.
- `Triangulos.cs`: Recebe os três números e identifica o tipo do triângulo, enviando uma mensagem através de uma variável.
- `Validacao.cs`: Valida se foram digitados três números e se esses números podem formar um triângulo (observando se a soma de dois lados é maior que o terceiro).
- `FormPrincipal.cs`: Contém o código para a interface do usuário usando Windows Forms.

## Contribuição

Contribuições são bem-vindas! Para contribuir com este projeto, siga estas etapas:

1. Faça um fork do projeto.
2. Crie uma branch com sua feature (`git checkout -b feature/MinhaFeature`).
3. Faça commit das suas mudanças (`git commit -am 'Adiciona MinhaFeature'`).
4. Faça push para a branch (`git push origin feature/MinhaFeature`).
5. Abra um pull request.
