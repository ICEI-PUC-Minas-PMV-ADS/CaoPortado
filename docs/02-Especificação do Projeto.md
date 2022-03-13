# Especificações do Projeto
A escolha do referido problema foi definida por meio de discussões e estudos realizados pelos membros da equipe. Os detalhes levantados nesse processo foram consolidados na forma de personas e histórias de usuários.

## Personas
As personas foram criadas a partir do briefing feito para a empresa CãoPortado, baseadas em seu público real e, são apresentadas nas figuras que se seguem:

![](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t6-caoportado/blob/main/docs/img/Roberta.jpeg)
==========
![](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t6-caoportado/blob/main/docs/img/Jo%C3%A3o.jpeg)
======
![](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t6-caoportado/blob/main/docs/img/Andressa.jpeg)
=============================
![](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t6-caoportado/blob/main/docs/img/Sandra.png)
=============================
![](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t6-caoportado/blob/main/docs/img/Robert%20.png)
=============================
![](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t6-caoportado/blob/main/docs/img/C%C3%A3oportado.png)

# Histórias de Usuários
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
|RF-01| O sistema deve permitir que os cliente do Pet Hotel avaliem a empresa atribuindo estrelas e comentários; | BAIXA | 
|RF-02| O sistema deve conter uma área de “Sobre a empresa”, onde contenha informações da empresa e da equipe, além de ter fotos e vídeos dos animais e do local;| BAIXA |
|RF-03| O sistema deve disponibilizar um calendário, para que o usuário veja as datas disponíveis e faça o agendamento on-line. | ALTA | 
|RF-04| O sistema deve conter um limitador de vagas;| MÉDIA | 
|RF-05| O sistema deve possibilitar a compra de pacotes de creche, adestramento e hospedagem;| ALTA | 
|RF-06| O sistema deve realizar o cálculo do valor da hospedagem, considerando o preço fixo da diária, a quantidade de dias e o porte do animal;| ALTA |
|RF-07| O sistema deve conter um sistema de envio de comprovante de marcação para o cliente e envio do comprovante de pagamento para a empresa;| ALTA |
|RF-08| O sistema deve ter um formulário de cadastro do cliente, para coletar o nome completo, CPF, RG, data de nascimento, endereço e contato de WhatsApp;| ALTA |
|RF-09| O sistema deve ter um formulário de cadastro do Pet, informando o porte do animal e as datas e informações das vacinas (Polivalente V8 ou V10, Raiva e Giárdia);|MÉDIA|
|RF-10| O cadastro do Pet deve ser obrigatoriamente vinculado ao cadastro de seu dono;| ALTA |
|RF-11| O sistema deve permitir que o usuário faça Login usando o e-mail e senha cadastrados; | ALTA |
|RF-12| O sistema deve disponibilizar formas de pagamento para o serviço contratado; | ALTA |
|RF-13| O sistema deve permitir que o usuário redefina sua senha, informando o e-mail cadastrado; | MÉDIA |
|RF-14| O sistema deve permitir que o usuário altere seus dados cadastrais; | MÉDIA |
|RF-15| O sistema deve notificar ao Administrador qualquer alteração que o usuário fizer em suas reservas; | MÉDIA |
|RF-16| O sistema deve permitir que o usuário altere suas reservas; | MÉDIA |
|RF-17| O sistema deve permitir que o usuário e Administrador acessem as reservas feitas pelo usuário; | MÉDIA |
|RF-18| O sistema deve permitir que o Administrador altere valores e pacotes; | ALTA|
|RF-18| O sistema deve permitir que o Administrador consulte os dados do Usuário e do Pet; | ALTA|







### Requisitos não Funcionais
Os requisitos não-funcionais descrevem características de caráter mais técnico a serem observadas, com o objetivo de assegurar que os requisitos funcionais sejam devidamente atendidos.

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-01 | O site deve ser publicado em um ambiente acessível publicamente na Internet (Repl.it, GitHub Pages, Heroku);  | ALTA | 
|RNF-02 | O site deverá ser responsivo permitindo a visualização em um celular de forma adequada; |  ALTA | 
|RNF-03 | O site deve ter bom nível de contraste entre os elementos da tela em conformidade;      |  MÉDIA |
|RNF-04 | O site deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge).    |  ALTA |

## Restrições
O projeto está restrito pelos itens apresentados na tabela a seguir:

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de 25/06/2022; |
|02| A aplicação se restringirá às tecnologias básicas da Web no Back-End; |
|03| A equipe não pode subcontratar o desenvolvimento do trabalho; |

## Diagrama de Casos de Uso

O diagrama de casos de uso é o seguinte passo após a elicitação dos Requisitos Funcionais. Ele ilustra a interação de possíveis usuários com as funcionalidades primordiais do sistema projetado, utilizando-se de atores para representá-los.

![](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t6-caoportado/blob/main/docs/img/Diagrama%20de%20Caso%20de%20Uso.png)

Tabela - Casos de Uso

|ATOR             | DESCRIÇÃO                                                                                        |
|-----------------|--------------------------------------------------------------------------------------------------|
|Usuário Cadastrado| Pessoa que possui um cadastro no sistema.|
|Usuário Não Cadastrado| Pessoa que não possui um cadastro no sistema.|
|Administrador| Pessoa que gerencia e tem acesso a todos as funcionalidades do sistema.|


<br>
 
|CASO DE USO                    | DESCRIÇÃO                                                                                                | REQUISITO FUNCIONAL  |
|-------------------------------|----------------------------------------------------------------------------------------------------------|----------------------|
|Fazer Login                    | O usuário deve fazer o Login para acessar, em detalhes, a sua conta.                                     | RF-11 |
|Agendar diária                 | O usuário pode reservar diárias através do sistema.                                                      | RF-03 |
|Contratar um serviço           | O usuário pode fazer a compra dos serviços oferecidos pela empresa.                                      | RF-05 |
|Criar conta                    | O usuário deve criar uma conta para utilizar os recursos disponíveis no sistema.                         | RF-08 |
|Efetuar pagamento              | O usuário pode efetuar o pagamento, através das formas de pagamento oferecidas pelo sistema.             | RF-12 |
|Acessar reservas               | O usuário e o Administrador podem consultar as reservas realizadas pelo usuário.                         | RF-17 |
|Alterar reservas               | O usuário pode alterar sua reserva conforme as normas e disponibilidade.                                  | RF-15, RF-16 |
|Avaliar estabelecimento        | O usuário pode comentar e avaliar a empresa.                                                             | RF-01 | 
|Alterar dados cadastrais       | O usuário pode alterar seus dados cadastrais.                                                            | RF-14 | 
|Obter informações sobre o PetHotel | O usuário pode obter informações referentes a valores, fotos e vídeos, etc.                          | RF-01, RF-02 | 
|Realizar cadastro do Pet       | O usuário pode cadastrar os dados referentes ao seu cachorro (vacinas, porte, etc).                      | RF-09 | 
|Acessar comprovante de marcação e Pagamento | O Administrador e o usuário podem acessar o comprovante de marcação e pagamento             | RF-07 | 
|Alterar Valores e Pacotes      | O Administrador pode alterar valores e pacotes.                                                          | RF-18 | 
|Consultar Dados do Usuário/Pet | O Administrador pode consultar os dados dos pets e dos usuários.                                         | RF-19 | 

<br>

|RELACIONAMENTO| DESCRIÇÃO                                                                                                                                          |
|--------------|----------------------------------------------------------------------------------------------------------------------------------------------------|
|INCLUSÃO      |                                                                                                                                                    |
|              | Para efetivar o cadastro do Pet, o usuário deve fazer o Login.                                                           |
|              | Para avaliar o estabelecimento, o usuário deve fazer o Login.                                                                                    | 
|              | Para agendar uma diária, o usuário deve contratar um serviço.                                                                                      |
|              | Para efetuar pagamento, o usuário deve agendar uma diária.                                                                                         
|EXTENSÃO      |                                                                                                                                                    |
|              | O usuário pode alterar seus dados cadastrais, se fizer Login.                                                               |
|              | O usuário pode alterar reservas, se agendar uma diária. |

Fonte: Elaborado pelos autores do projeto

