# Especificações do Projeto



------------------------------------------------------------------------------------------------------


## Personas




-----------------------------------------------------------------------------------------------------



## Histórias de Usuários
A partir da compreensão do cotidiano das personas identificadas para o projeto, foram registradas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`       |
|--------------------|------------------------------------|------------------------------|
|  Roberta  Schawlski | Quero saber se o PetHotel é confiável e tem boas avaliações. | Para que meu cachorro fique num lugar com ótimos profissionais. |
|  João Schiabel | Quero poder saber quem são as pessoas que irão cuidar do meu pet. | Para que eu possa ter um breve conhecimento dos profissionais e ganhar confiança no trabalho deles.|
| Andressa Werneck | Quero poder fazer o agendamento online. | Para que eu possa agendar onde eu estiver e a qualquer hora. |
|  Sandra Januário | Quero conhecer o PetHotel antes mesmo de visitá-lo pessoalmente. | Para que eu possa saber se o local é seguro e organizado, para que meu cachorro não volte estressado novamente. |
|  Robert Dolittle | Quero saber se o PetHotel tem o preço mais acessível em comparação a outros. | Para que eu possa organizar minhas finanças pessoais. |
|    CãoPortado | Quero uma forma automatizada, possibilitando que meus clientes realizarem o agendamento. | Para agilizar o atendimento ao cliente e eu poder focar em outros pontos. |

## Requisitos
O escopo funcional do projeto é definido por meio dos requisitos funcionais que descrevem as possibilidades de interação dos usuários, bem como os requisitos não funcionais que descrevem os aspectos que o sistema deverá apresentar de maneira geral. Estes requisitos são apresentados abaixo:

### Requisitos funcionais
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
Os requisitos não-funcionais descrevem características de caráter mais técnico a serem observadas, com o objetivo de assegurar que os requisitos funcionais sejam devidamente atendidos.

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001 | O site deve ser publicado em um ambiente acessível publicamente na Internet (Repl.it, GitHub Pages, Heroku);  | ALTA | 
|RNF-002 | O site deverá ser responsivo permitindo a visualização em um celular de forma adequada; |  ALTA | 
|RNF-003 | O site deve ter bom nível de contraste entre os elementos da tela em conformidade;      |  MÉDIA |
|RNF-004 | O site deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge).    |  ALTA |

## Restrições
O projeto está restrito pelos itens apresentados na tabela a seguir:

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de 25/06/2022; |
|02| A aplicação se restringirá às tecnologias básicas da Web no Back-End; |
|03| A equipe não pode subcontratar o desenvolvimento do trabalho; |

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
