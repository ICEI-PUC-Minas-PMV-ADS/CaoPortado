# Plano de Testes de Software

Os requisitos para realização dos testes de software são:
<br><br>
 •	_Site_ publicado na internet;<br/>
 •	Navegador de Internet (_Google Chrome, Microsoft Edge, Mozilla Firefox, Safari_);<br/>
 •	Conexão com a internet para acesso à plataforma.<br/>

Os testes funcionais a serem realizados no site são descritos a seguir:
 

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
|Critéritos de Êxito| •A plataforma deve retornar para a tela de perfil de pets cadastrados. |

| **Caso de Teste** | **CT-04 Agendar serviço**|
|---|---|
| Requisitos Associados |•RF-03 A aplicação deve possibilitar a compra de pacotes de creche, adestramento e hospedagem e disponibilizar um calendário, para que o usuário veja as datas disponíveis e faça o agendamento on-line;<br> •RF-04 O sistema deve conter um limitador de vagas;  |
|Objetivo de Teste | Verificar se a pagina de agendamento esta em pleno funcionamento |
| Passos |  1) Abra o navegador;<br/> 2) Informe o endereço do site desejado; <br/> 3) Clique no botão _Entrar_;  <br/> 4) Realize o _login_;<br/> 5) Clique no item de navegação de nome "Serviços", na homepage; <br/> 6) Clique no serviço que deseja agendar, dentro do dropdown; <br/> 7) Selecione a data que deseja agendar; <br/> 8) Confirme se há disponibilidade nesta data;|
|Critéritos de Êxito| •Todo o sistema de agendamento esteja funcionando corretamente. <br/> •O usuário será redirecionado á tela das suas reservas.|


|**Caso de Teste** | **CT-05 Informações sobre a empresa**|
|---|---|
| Requisitos Associados |RF-02 A aplicação deve conter uma área de “Sobre a empresa”, onde contenha informações da empresa e da equipe, além de ter fotos e vídeos dos animais e do local; |
|Objetivo de Teste | Verificar se a pagina de Informaçôes, está em pleno funcionamento |
| Passos | 1) Abra o navegador;<br/> 2) Informe o endereço do site desejado; <br/> 3) Clique no Botão "A Empresa"; |
|Critéritos de Êxito| •Página carregar todo texto e a imagem. |

 |**Caso de Teste** | **CT-06-Responsividade, compatibilidade, cores e contraste**|
|---|---|
| Requisitos Associados |RNF-02 O site deverá ser responsivo, permitindo a visualização em um celular de forma adequada; |
|Objetivo de Teste | Verificar a responsividade em dispositivo mobile, compatibilidade com diversos navegadores e as cores/contraste dos elementos visuais. |
| Passos |  1) Utilizar a ferramenta de responsividade do navegador (inspecionar).|
|Critéritos de Êxito| •	Página responsiva e compatível. <br> •Imagens visíveis e agradáveis.|

 |**Caso de Teste** | **CT-07-Álbum de fotos**|
|---|---|
| Requisitos Associados |RF-02 A aplicação deve conter uma área de “Sobre a empresa”, onde contenha informações da empresa e da equipe, além de ter fotos e vídeos dos animais e do local; |
|Objetivo de Teste | Verificar se a galeria de fotos, está em pleno funcionamento.  |
| Passos | 1) Abra o navegador;<br/> 2) Informe o endereço do site desejado; <br/> 3) Clique no Botão "A Empresa"; <br/> 4) Clicar na imagem do álbum de fotos. |
|Critéritos de Êxito| •	Página carrega com todos os védeos.|

 |**Caso de Teste** | **CT-08-Playlist de vídeos**|
|---|---|
| Requisitos Associados |RF-02 A aplicação deve conter uma área de “Sobre a empresa”, onde contenha informações da empresa e da equipe, além de ter fotos e vídeos dos animais e do local;|
|Objetivo de Teste | Verificar se a galeria de vídeos, está em pleno funcionamento. |
| Passos | 1) Abra o navegador;<br/> 2) Informe o endereço do site desejado; <br/> 3) Clique no Botão "A Empresa" <br/>  4) Clicar na imagem do álbum de fotos.|
|Critéritos de Êxito| •	Página carrega com todos os vídeos.|

 |**Caso de Teste** | **CT-09- Alterar os dados cadastrais do usuário**|
|---|---|
| Requisitos Associados |RF-10: a aplicação deve permitir que o usuário altere seus dados cadastrais na tela "Meu perfil", tais como: telefone, endereço, e-mail e senha; |
|Objetivo de Teste | Verificar se o usuário consegue alterar seus dados com facilidade. |
| Passos |1) Abra o navegador.<br/> 2) Informe o endereço do site desejado. <br/> 3) Clique no botão _Entrar_, localizado no menu de navegação; <br/> 4)  Preencha os campos com as informações requeridas (e-mail e senha cadastrados);<br/> 5) Clique em _entrar_. <br/> 6) Clique em perfil;<br/> 7) Clique em "Meu Perfil"; <br/> 8) Clique no botão "Editar perfil"; <br/> 9) Preencha os campos com os dados que deseja alterar; <br/> 10) Clique no botão "Salvar". |

 |**Caso de Teste** | **CT-10- Hospedagem**|
|---|---|
| Requisitos Associados |RNF-01: O site deve ser publicado em um ambiente acessível publicamente na Internet (Repl.it, GitHub Pages, Heroku); |
|Objetivo de Teste | Verificar se o usuário consegue acessar o site através da sua URL. |
| Passos |1) Abra o navegador.<br/> 2) Informe o endereço do site desejado.|
 
|**Caso de Teste** | **CT-11- Compatibilidade com os navegadores**|
|---|---|
| Requisitos Associados |RNF-04: O site deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge).|
|Objetivo de Teste | Verificar se o usuário consegue acessar o site através da sua URL, utilizando os principais navegadores do mercado. |
| Passos |1) Abra o seu navegador.<br/> 2) Informe o endereço do site desejado.|
