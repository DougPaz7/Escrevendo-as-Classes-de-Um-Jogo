# Escrevendo as Classes de Um Jogo
 
## Descrição

Este projeto cria uma classe genérica que representa um herói de uma aventura. A classe possui as seguintes propriedades:

- **Nome**
- **Tipo** (exemplo: guerreiro, mago, monge, ninja)

A classe também tem um método chamado `atacar`, que exibe uma mensagem de ataque personalizada, de acordo com o tipo do herói.

## Requisitos

O método `atacar` deve seguir os seguintes requisitos:

- Exibir a mensagem: `"O {nome} atacou usando {ataque}"`.
- No campo **{tipo}**, será concatenado o tipo do herói.
- No campo **{ataque}**, a descrição varia conforme o tipo, seguindo a tabela abaixo:

  - **Mago**: usou magia
  - **Guerreiro**: usou espada
  - **Monge**: usou artes marciais
  - **Ninja**: usou shuriken

## Exemplo de Saída

```plaintext
O mago atacou usando magia.
O guerreiro atacou usando espada.
O monge atacou usando artes marciais.
O ninja atacou usando shuriken.
