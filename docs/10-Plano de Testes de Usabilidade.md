# Plano de Testes de Usabilidade

O objetivo dos testes de usabilidade é simular a utilização do sistema na perspectiva do usuário final, neste caso, donos de animais que necessitam de cuidados profissionais. Coletando dados que permitam mensurar a experiência do público alvo, garantindo um sistema que atende à demanda do cliente de forma eficiente e satisfatória.

Faz parte do escopo dos testes repetí-los para diferentes tipos de plataformas e diferentes perfis de usuário, a fim de assegurar uma experiência homogênea e a acessibilidade para difenrentes tipos de pessoas.

### Tarefas a serem observadas: Observação direta, medição e Avaliação

Seguem as tarefas a serem executadas pelos participantes e observadas


| **Caso de Teste** | **CT-01 Cadastro Usuário**|
|---|---|
| Requisitos Associados|•RF-05 A aplicação deve ter um formulário de cadastro do cliente, para coletar o nome completo, CPF, data de nascimento, endereço e telefone; |
|Objetivo de Teste | Verificar se o banco de dados está registrando as informações dos clientes corretamente.|
| Passos | 1) Abra o navegador.<br/> 2) Informe o endereço do site desejado. <br/> 3) Clique no botão _Entrar_, localizado no menu de navegação; <br/> 4) Clique na opção de _Registre-se agora_;<br/> 5) Preencha os campos com as informações requeridas.|
|Critéritos de Êxito| •A plataforma deve retornar um pop-up de confirmação do cadastro. |

| **Caso de Teste** | **CT-02 Login**|
|---|---|
| Requisitos Associados|•RF-09 A aplicação deve permitir que o usuário faça Login usando o e-mail e senha cadastrados; |
|Objetivo de Teste | Verificar se o cliente conseguirá acessar sua conta.|
| Passos | 1) Abra o navegador.<br/> 2) Informe o endereço do site desejado. <br/> 3) Clique no botão _Entrar_, localizado no menu de navegação; <br/> 4)  Preencha os campos com as informações requeridas (e-mail e senha cadastrados);<br/> 5) Clique em _entrar_.|
|Critéritos de Êxito| • O cliente será redirecionado á página Home. |

| **Caso de Teste** | **CT-03 Cadastro do Pet**|
|---|---|
| Requisitos Associados|•RF-06 A aplicação deve ter um formulário de cadastro do Pet, informando a idade, o porte do animal, informações das vacinas, CPF do dono cadastrado; (Polivalente V8 ou V10, Raiva e Giárdia);<br> •RF-07 O cadastro do Pet deve ser obrigatoriamente vinculado ao cadastro de seu dono; |
|Objetivo de Teste | Verificar se o banco de dados está registrando as informações dos pets corretamente.|
| Passos |1) Abra o navegador;<br/> 2) Informe o endereço do site desejado; <br/> 3) Clique no botão _Entrar_;  <br/>  5)Preencha os campos com as informações requeridas (e-mail e senha cadastrados); <br/> 6)Clique no botão de _Cadastro do Pet_, localizado no menu de navegação;  <br/> 7) Preencha os campos com as informações requeridas; <br/> 8) Clique em _Finalizar cadastro_.
|Critéritos de Êxito| •A plataforma deve retornar um pop-up de confirmação do cadastro. |

| **Caso de Teste** | **CT-04 Serviço de Agendas**|
|---|---|
| Requisitos Associados |•RF-03 A aplicação deve possibilitar a compra de pacotes de creche, adestramento e hospedagem e disponibilizar um calendário, para que o usuário veja as datas disponíveis e faça o agendamento on-line;<br> •RF-04 O sistema deve conter um limitador de vagas;  |
|Objetivo de Teste | Verificar se a pagina de agendamento esta em pleno funcionamento |
| Passos |  1) Abra o navegador;<br/> 2) Informe o endereço do site desejado; <br/> 3) Clique no botão _Entrar_;  <br/> 4) Realize o _login_;<br/> 5) Clique no item de navegação de nome "Serviços", na homepage; <br/> 6) Clique no serviço que deseja agendar, dentro do dropdown; <br/> 7) Selecione a data que deseja agendar; <br/> 8) Confirme se há disponibilidade nesta data;|
|Critéritos de Êxito| •Todos sistema de Agendas esteja funcionando corretamento.|


|**Caso de Teste** | **CT-05 Informações sobre a empresa**|
|---|---|
| Requisitos Associados |RF-02 A aplicação deve conter uma área de “Sobre a empresa”, onde contenha informações da empresa e da equipe, além de ter fotos e vídeos dos animais e do local; |
|Objetivo de Teste | Verificar se a pagina de Informaçôes, está em pleno funcionamento |
| Passos | 1) Abra o navegador;<br/> 2) Informe o endereço do site desejado; <br/> 3) Clique no Botão "A Empresa"; |
|Critéritos de Êxito| •Página carregar todo texto e a imagem. |

 |**Caso de Teste** | **CT-06-Responsividade, compatibilidade, cores e contraste**|
|---|---|
| Requisitos Associados |RNF-02 O site deverá ser responsivo, permitindo a visualização em um celular de forma adequada; 
|Objetivo de Teste | Verificar a responsividade em dispositivo mobile, compatibilidade com diversos navegadores e as cores/contraste dos elementos visuais. |
| Passos |  1) Utilizar a ferramenta de responsividade do navegador (inspecionar).|
|Critéritos de Êxito| •	Página responsiva e compatível. <br> •Imagens visíveis e agradáveis.|


## Análise do teste e resultados

A análise do resultado do teste de usabilidade à distância deve ser igual ao de um teste presencial, para registro será utilizada uma planilha conforme exemplo abaixo:

| **Usuário** 	| **Artefato** 	| **Tempo** | **Clicks/Ações** | **Qtd. Erros** | **Se recuperou do erro** | **Comentários e observações** |
| --- 	| --- 	| --- | ---  | --- | --- | --- |
| Usuário 1	| --- 	| --- | ---  | --- | --- | --- |
| Usuário 2 | --- 	| --- | ---  | --- | --- | --- |
| Usuário 3	| --- 	| --- | ---  | --- | --- | --- |
| Usuário 4	| --- 	| --- | ---  | --- | --- | --- |
| Usuário 5	| --- 	| --- | ---  | --- | --- | --- |

| **Usuário** 	| **Artefato** 	| **Tempo** | **Clicks/Ações** | **Qtd. Erros** | **Se recuperou do erro** | **Comentários e observações** |
| --- 	| --- 	| --- | ---  | --- | --- | --- |
| Usuário 1	| --- 	| --- | ---  | --- | --- | --- |
| Usuário 2 | --- 	| --- | ---  | --- | --- | --- |
| Usuário 3	| --- 	| --- | ---  | --- | --- | --- |
| Usuário 4	| --- 	| --- | ---  | --- | --- | --- |
| Usuário 5	| --- 	| --- | ---  | --- | --- | --- |
