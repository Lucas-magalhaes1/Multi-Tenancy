# Multi Tenancy em C#

Este projeto demonstra uma estratégia simples de Multi Tenancy em C#, utilizando a separação por Schema para isolar os dados de diferentes inquilinos em um sistema.

## Estratégia Utilizada

A estratégia utilizada neste projeto é a separação por Schema, onde cada inquilino tem seu próprio schema no banco de dados. Isso permite que os dados de cada inquilino sejam armazenados e acessados de forma isolada.

## Implementação

### Classes Utilizadas

- `Tenant`: Representa um inquilino, com um ID e um nome.
- `DataObject`: Representa um objeto de dados associado a um inquilino.
- `TenantContext`: Classe estática para gerenciar o contexto do inquilino atual.
- `DataAccessLayer`: Classe responsável pelo acesso aos dados, filtrando os dados pelo inquilino atual.

### Organização do Projeto

O projeto está organizado da seguinte forma:

- MultiTenancyExample
  - Models
    - Tenant.cs
    - DataObject.cs
  - Context
    - TenantContext.cs
  - DataAccess
    - DataAccessLayer.cs
  - Program.cs

### Testando a Implementação

Para testar a implementação, basta executar o método `Main` da classe `Program`. O código irá simular a definição de diferentes inquilinos e realizar consultas aos dados para cada inquilino, verificando se os dados retornados correspondem aos dados do inquilino atual.

## Conclusão

A estratégia de Multi Tenancy por Schema é uma abordagem eficaz para isolar os dados de diferentes inquilinos em um sistema, garantindo a segurança e integridade dos dados. Esta implementação simples demonstra como essa estratégia pode ser aplicada em um sistema em C#.
