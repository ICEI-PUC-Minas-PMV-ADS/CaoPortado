# Especificações do Projeto
kk
<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

Pedro Paulo tem 26 anos, é arquiteto recém-formado e autônomo. Pensa em se desenvolver profissionalmente através de um mestrado fora do país, pois adora viajar, é solteiro e sempre quis fazer um intercâmbio. Está buscando uma agência que o ajude a encontrar universidades na Europa que aceitem alunos estrangeiros.

Enumere e detalhe as personas da sua solução. Para tanto, baseie-se tanto nos documentos disponibilizados na disciplina e/ou nos seguintes links:

> **Links Úteis**:
> - [Rock Content](https://rockcontent.com/blog/personas/)
> - [Hotmart](https://blog.hotmart.com/pt-br/como-criar-persona-negocio/)
> - [O que é persona?](https://resultadosdigitais.com.br/blog/persona-o-que-e/)
> - [Persona x Público-alvo](https://flammo.com.br/blog/persona-e-publico-alvo-qual-a-diferenca/)
> - [Mapa de Empatia](https://resultadosdigitais.com.br/blog/mapa-da-empatia/)
> - [Mapa de Stalkeholders](https://www.racecomunicacao.com.br/blog/como-fazer-o-mapeamento-de-stakeholders/)
>
Lembre-se que você deve ser enumerar e descrever precisamente e personalizada todos os clientes ideais que sua solução almeja.

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`       |
|--------------------|------------------------------------|------------------------------|
|  Roberta  Schawlski | Quero um PetHotel que seja confiável e tenha boas avaliações. | Para que meu cachorro fique num lugar com ótimos profissionais. |
|  João Schiabel | Quero poder saber quem são as pessoas que irão cuidar do meu pet. | Para que eu possa ter um breve conhecimento dos profissionais e ganhar confiança no trabalho deles.|
| Andressa Werneck | Quero poder fazer o agendamento online. | Para que eu possa agendar onde eu estiver e a qualquer hora. |
|  Sandra Januário | Quero conhecer o PetHotel antes mesmo de visitá-lo pessoalmente. | Para que eu possa saber se o local é seguro e organizado, para que meu cachorro não volte estressado novamente. |
|  Robert Dolittle | Quero um PetHotel com um preço mais acessível . | Para que eu possa organizar minhas finanças pessoais. |
|    CãoPortado | Quero uma forma automatizada, possibilitando que meus clientes realizarem o agendamento. | Para agilizar o atendimento ao cliente e eu poder focar em outros pontos. |
## Requisitos
<<<<<<< HEAD

O escopo funcional do projeto é definido por meio dos requisitos funcionais que descrevem as possibilidades de interação dos usuários, bem como os requisitos não funcionais que descrevem os aspectos que o sistema deverá apresentar de maneira geral. Estes requisitos são apresentados abaixo
### Requisitos funcionais
=======
De acordo com a necessidade de criação do site que, busca facilitar a vida do público-alvo, os requisitos do projeto são:
>>>>>>> 247b4e6a144a5833e7ca2c0922c8eba24d404d92

Os requisitos funcionais representam as necessidades, características e recursos fornecidos pelo Coleta.

|ID    | Descrição do Requisito  | Prioridade |
|------|----------------------------------------|----  |
|`RF-001`| O site deve permitir que os cliente do Pet Hotel avaliem a empresa atribuindo estrelas e comentários; | BAIXA | 
|`RF-002`| O site deve conter uma área de “Sobre a empresa”, onde contenha informações da empresa e da equipe, além de ter fotos e vídeos dos animais e do local;| BAIXA |
|`RF-003`| O site deve conter uma funcionalidade de agendamento online; | ALTA | 
|`RF-004`| O site deve conter um limitador de vagas;| MÉDIA | 
|`RF-005`| O site deve possibilitar a compra de planos e pacotes da creche e da hospedagem;| ALTA | 
|`RF-006`| O site deve realizar o cálculo do valor da hospedagem, considerando o preço fixo da diária, a quantidade de dias e o porte do animal;| ALTA |
|`RF-007`| O site deve conter um sistema de envio de comprovante de marcação para o cliente e envio do comprovante de pagamento para a empresa;| ALTA |
|`RF-008`| O site deve ter um formulário de cadastro do cliente, para coletar o nome completo, CPF, RG, data de nascimento, endereço e contato de WhatsApp;| ALTA |
|`RF-009`| O site deve ter um formulário de cadastro do Pet, informando o porte do animal e as datas e informações das vacinas (Polivalente V8 ou V10, Raiva e Giárdia);| MÉDIA |
|`RF-010`| O cadastro do pet  deve ser obrigatoriamente vinculado ao cadastro de seu dono.| ALTA |
### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001 | O site deve ser publicado em um ambiente acessível publicamente na Internet (Repl.it, GitHub Pages, Heroku);  | ALTA | 
|RNF-002 | O site deverá ser responsivo permitindo a visualização em um celular de forma adequada; |  ALTA | 
|RNF-003 | O site deve ter bom nível de contraste entre os elementos da tela em conformidade;      |  MÉDIA |
|RNF-004 | O site deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge).    |  ALTA |

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de 25/06/2022; |
|02| A aplicação se restringirá às tecnologias básicas da Web no Back-End; |
|03| A equipe não pode subcontratar o desenvolvimento do trabalho; |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
