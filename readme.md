# CSharp: Trabalhando com arquivos

Programa para:

 * Criar um file stream por meio do Open e ler o arquivo, cirando o buffer e o passando ao método Read. Inclusive, tivemos toda a preocupação com os intervalos que esse método pode usar para gravar os dados do buffer.
 * Decodificação dos dados para exibir de bytes para o texto. Para realizar essa conversão, trabalhamos com a classe Encoding. Unicode, conceito de code point e formatos de transformação, como UTF-8 e UFT-32. Com o método GetString, conseguimos converter a cadeia de butes para string.
 * StreamReader para que não houvesse preocupação com o buffer, seus intervalos e o Encoding. Ler linhas e mostrar mensagens no console referentes ao conteúdo do arquivo, desenvolvendo um código para converter strings em ContaCorrente. Nesse processo, utiliamos o Parse para transformar strings em números inteiros e double, e também usamos o método Replace. Assim, conseguimos trazer o conteúdo do arquivo para dentro do nosso código e mostrá-lo no console.
 * Criar arquivos e inserir informações neles, utilizando o `FileMode.Create`. Desenvolvido o método `CriarArquivos` empregando o `GetBytes`, semelhante ao `GetString`.
 * Arquivos binários.
 * Otimizar o uso de memória do computador.
 * Stream do console.
