# Plano de Testes de Software

Os requisitos para realização dos testes de software são:
<br><br>
 •	_Site_ publicado na internet;<br/>
 •	Navegador de Internet (_Google Chrome, Microsoft Edge, Mozilla Firefox, Safari_);<br/>
 •	Conexão com a internet para acesso à plataforma.<br/>

Os testes funcionais a serem realizados no site são descritos a seguir:
 

| **Caso de Teste** | **CT-01 Cadastro**|
|---|---|
| Requisitos Associados|•RF-8 O sistema deve ter um formulário de cadastro do cliente, para coletar o nome completo, CPF, RG, data de nascimento, endereço e contato de WhatsApp;<br> •RF-9 O sistema deve ter um formulário de cadastro do Pet, informando o porte do animal e as datas e informações das vacinas (Polivalente V8 ou V10, Raiva e Giárdia);<br> •RF-10 ´po6O cadastro do Pet deve ser obrigatoriamente vinculado ao cadastro de seu dono; |
|Objetivo de Teste | Verificar se o banco de dados está registrando as informações dos clientes corretamente.RF-8,RF-9,RF-10|
| Passos |1) Abra o navegador.<br/> 2) Informe o endereço do site desejado. <br/> 3) Clique no botão "cadastrar". <br/> 4) Preencha os campos com as informações requeridas.<br/> 5) Clique no botão "cadastrar".<br/> 6) Clique no link de validação enviado para o e-mail cadastrado. <br/> 7)Clique no botão login.<br/> 8) Preencha os campos com o e-mail e senha cadastrados. <br/> 9) Clique em "entrar".|
|Critéritos de Êxito| •A plataforma deve retornar um pop-up de confirmação do cadastro. Sendo assim, o cliente já pode realizar o login na plataforma com as informações inseridas no cadastro. |


| **Caso de Teste** | **CT-03 Serviço de Agendas**|
|---|---|
| Requisitos Associados |x |
|Objetivo de Teste | Verificar se a pagina de agendamento esta em pleno funcionamento |
| Passos |  1) Abra o navegador;<br/> 2) Informe o endereço do site desejado; <br/> 3) Clique no botão de _login_;  <br/> 4) Realize _login_;<br/> 5) Clique no item de navegação de nome "Serviços", na homepage; <br/> 6) Clique no serviço que deseja comprar, dentro do dropdown; <br/> 7) Selecione a data que deseja agendar; <br/> 8) Confirme se há disponibilidade nesta data; <br/> 9) Clique em "Realizar pagamento". |
|Critéritos de Êxito| •Todos sistema de Agendas esteja funcionando corretamento.|


|**Caso de Teste** | **CT-04 Informaçoes**|
|---|---|
| Requisitos Associados |x |
|Objetivo de Teste | Verificar se a pagina de Informaçoes, esta em pleno funcionamento |
| Passos | 1) Abra o navegador;<br/> 2) Informe o endereço do site desejado; <br/> 3) Clique no Botão "A Empresa"; |
|Critéritos de Êxito| •Página carregar todo texto e a imagem. |




 |**Caso de Teste** | **CT-05 Depoimentos**|
|---|---|
| Requisitos Associados |x |
|Objetivo de Teste | Verificar se a pagina de depoimentos esta funcionado corretamento |
| Passos |  1) Abra o navegador;<br/> 2) Informe o endereço do site desejado; <br/> 3) Clique no botão de _login_;  <br/> 4) Realize _login_;<br/> 5) Clique no item de navegação de nome "DEPOIMENTOS";<br/> 6) Realize um feedback;<br/> 7) Clique em Enviar.|
|Critéritos de Êxito| • A funcionalidade Depoimentos esta em pleno funcionamento.|



 |**Caso de Teste** | **CT-06-Responsividade, compatibilidade, cores e contraste.**|
|---|---|
| Requisitos Associados |x |
|Objetivo de Teste | Verificar a responsividade em dispositivo mobile, compatibilidade com diversos navegadores e as cores/contraste dos elementos visuais. |
| Passos |  1) Verificar a responsividade no app: https://github.com/responsively-org/responsively-app<br> 2) Verificar a compatibilidade com os navegadores. |
|Critéritos de Êxito| •	Página responsiva e compativel. <br> •Imagens visíveis e agradáveis.|



 
