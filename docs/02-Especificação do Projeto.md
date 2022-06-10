# Especificações do Projeto
A escolha do referido problema foi definida por meio de discussões e estudos realizados pelos membros da equipe. Os detalhes levantados nesse processo foram consolidados na forma de personas e histórias de usuários.

## Personas
As personas foram criadas a partir do briefing feito para a empresa CãoPortado, baseadas em seu público real e, são apresentadas nas figuras que se seguem:

![](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t6-caoportado/blob/main/docs/img/Roberta.jpeg)
==========
![](https://github.com/ICEI-PUC-Minas-PMV-ADS/CaoPortado/blob/main/docs/img/Jo%25C3%25A3o.jpeg)
======
![](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t6-caoportado/blob/main/docs/img/Andressa.jpeg)
=============================
![](https://github.com/ICEI-PUC-Minas-PMV-ADS/CaoPortado/blob/main/docs/img/sandra%20januario.png)
=============================
![](https://github.com/ICEI-PUC-Minas-PMV-ADS/CaoPortado/blob/main/docs/img/Robert%2520.jpeg)
=============================
![](https://github.com/ICEI-PUC-Minas-PMV-ADS/CaoPortado/blob/main/docs/img/Caoportado.png)

# Histórias de Usuários
A partir da compreensão do cotidiano das personas identificadas para o projeto, foram registradas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`       |
|--------------------|------------------------------------|------------------------------|
|  Roberta  Schawlski | Quero saber se o PetHotel é confiável e tem boas avaliações. | Para que meu cachorro fique num lugar com ótimos profissionais. |
|  João Schiabel | Quero saber quem são as pessoas que vão cuidar do meu pet. | Para que eu possa ter um breve conhecimento dos profissionais e ganhar confiança em seu trabalho.|
| Andressa Werneck | Quero poder fazer o agendamento online. | Para que eu possa agendar a qualquer hora e local e não precisar ir até o local físico para fazer uma reserva. |
|  Sandra Januário | Quero conhecer o PetHotel antes mesmo de visitá-lo pessoalmente. | Para que eu possa saber se o local é seguro e organizado, para que meu cachorro não volte estressado novamente. |
|  Robert Dolittle | Quero saber se o PetHotel tem o preço mais acessível em comparação a outros. | Para que eu possa organizar minhas finanças pessoais. |
|    CãoPortado | Quero uma forma automatizada, possibilitando que meus clientes realizarem o agendamento. | Para agilizar o atendimento ao cliente e eu poder focar em outros pontos. |

## Requisitos
O escopo funcional do projeto é definido por meio dos requisitos funcionais que descrevem as possibilidades de interação dos usuários, bem como os requisitos não funcionais que descrevem os aspectos que o sistema deverá apresentar de maneira geral. Estes requisitos são apresentados abaixo:

### Requisitos funcionais
Os requisitos funcionais representam as necessidades, características e recursos fornecidos pelo Coleta.

|ID    | Descrição do Requisito  | Prioridade |
|------|----------------------------------------|----  |
|RF-01| A aplicação deve permitir que o cliente do Pet Hotel avaliem a empresa atribuindo estrelas e comentários; | BAIXA |
|RF-02| A aplicação deve conter uma área de “Sobre a empresa”, onde contenha informações da empresa e da equipe, além de ter fotos e vídeos dos animais e do local;| BAIXA |
|RF-03| A aplicação deve possibilitar a compra de pacotes de creche, adestramento e hospedagem e disponibilizar um calendário, para que o usuário veja as datas disponíveis e faça o agendamento on-line; | ALTA |
|RF-04| A aplicação deve conter um limitador de vagas;| MÉDIA |
|RF-05| A aplicação deve ter um formulário de cadastro do cliente, para coletar o nome completo, CPF, data de nascimento, endereço e telefone;| ALTA |
|RF-06| A aplicação deve ter um formulário de cadastro do Pet, informando a idade, o porte do animal, informações das vacinas, CPF do dono cadastrado; (Polivalente V8 ou V10, Raiva e Giárdia);|MÉDIA|
|RF-07| O cadastro do Pet deve ser obrigatoriamente vinculado ao cadastro de seu dono;| ALTA |
|RF-09| A aplicação deve permitir que o usuário faça Login usando o e-mail e senha cadastrados; | ALTA |
|RF-09| A aplicação deve permitir que o usuário redefina a senha na Tela de Login, clicando no "Esqueci minha senha";| MÉDIA |
|RF-10| A aplicação deve permitir que o usuário altere seus dados cadastrais na tela "Meu perfil", tais como: telefone, endereço, e-mail;| MÉDIA |
|RF-11| A aplicação deve permitir que o usuário consulte suas reservas; | MÉDIA |
|RF-12| A aplicação deve permitir que o usuário acesse apenas as suas reservas e permitir que o Administrador acesse todas as reservas; | MÉDIA |
|RF-13| A aplicação deve permitir que o Administrador consulte os dados do Usuário e do Pet. | ALTA|

### Requisitos não Funcionais
Os requisitos não-funcionais descrevem características de caráter mais técnico a serem observadas, com o objetivo de assegurar que os requisitos funcionais sejam devidamente atendidos.

|ID     | Descrição do Requisito  | Prioridade |
|-------|-------------------------|----|
|RNF-01 | O site deve ser publicado em um ambiente acessível publicamente na Internet (Repl.it, GitHub Pages, Heroku);  | ALTA |
|RNF-02 | O site deverá ser responsivo, permitindo a visualização em um celular de forma adequada; |  ALTA |
|RNF-03 | O site deve ter bom nível de contraste entre os elementos da tela em conformidade;      |  MÉDIA |
|RNF-04 | O site deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge). |  ALTA |

## Restrições
O projeto está restrito pelos itens apresentados na tabela a seguir:

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de 25/06/2022; |
|02| A aplicação se restringirá às tecnologias básicas da Web no Back-End; |
|03| A equipe não pode subcontratar o desenvolvimento do trabalho. |

## Diagrama de Casos de Uso

O diagrama de casos de uso é o seguinte passo após a elicitação dos Requisitos Funcionais. Ele ilustra a interação de possíveis usuários com as funcionalidades primordiais do sistema projetado, utilizando-se de atores para representá-los.

![](https://github.com/ICEI-PUC-Minas-PMV-ADS/CaoPortado/blob/main/docs/img/diagrama%20de%20caso%20de%20uso%20-%20Page%201.jpeg)


<br>

|CASO DE USO                    | DESCRIÇÃO                                                                                                | REQUISITO FUNCIONAL  |
|-------------------------------|----------------------------------------------------------------------------------------------------------|----------------------|
|Obter informações sobre o PetHotel | O usuário pode obter informações referentes a empresa e sua quipe, além de conseguir ver fotos e vídeos do local e dos pets;                                                                                                                                                | RF-02 |
|Fazer reserva                  | O usuário deve conseguir contratar os serviços oferecidos pela empresa, realizando o agendamto online;   | RF-03 |
|Criar conta                    | O usuário deve conseguir criar uma conta para, assim, utilizar todos os recursos disponíveis no sistema; | RF-05 |
|Realizar cadastro do Pet       | O usuário pode cadastrar os dados referentes ao seu cachorro (vacinas, porte, data de nascimento, nome e raça);                                                                                                                                                                  | RF-06 |
|Fazer Login                    | O usuário deve fazer o Login para acessar, em detalhes, a sua conta;                                     | RF-09 |
|Alterar dados cadastrais       | O usuário pode alterar seus dados cadastrais, tais como: telefone, endereço, e-mail e senha;             | RF-10 |
|Consultar reservas             | O usuário e o Administrador podem consultar as reservas realizadas pelo usuário;                         | RF-12 |
|Consultar Dados do Usuário/Pet | O Administrador pode consultar os dados dos pets e dos usuários.                                         | RF-13 |

<br>

|RELACIONAMENTO| DESCRIÇÃO                                                                                                                                          |
|--------------|----------------------------------------------------------------------------------------------------------------------------------------------------|
|INCLUSÃO      |                                                                                                                                                    |
|              | Para logar no site, o usuário deve ter criado uma conta.                                                                                           |                                                                           
|EXTENSÃO      |                                                                                                                                                    |
|              | O usuário pode alterar seus dados cadastrais, se fizer Login;                                                                                      |
|              | O usuário pode consultar suas reservas, se agendar uma diária;                                                                                     |
|              | Para agendar uma diária, o usuário deve contratar um serviço;                                                                                      |
|              | Para efetivar o cadastro do Pet, o usuário deve fazer o Login;                                                                                     |
|              | O usuário poderá Visualizar erro de login, caso erre sua senha cadastrada;                                                                         |
|              | O administrador poderá visualizar acessar as reservas, caso esteja logado;                                                                         |
|              | O administrador poderá gerenciar dados do pet e do usuário, caso esteja logado.                                                                    |

Fonte: Elaborado pelos autores do projeto
