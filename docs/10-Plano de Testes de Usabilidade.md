# Plano de Testes de Usabilidade

O objetivo dos testes de usabilidade é simular a utilização do sistema na perspectiva do usuário final, neste caso, donos de animais que necessitam de cuidados profissionais. Coletando dados que permitam mensurar a experiência do público alvo, garantindo um sistema que atende à demanda do cliente de forma eficiente e satisfatória.

Faz parte do escopo dos testes repetí-los para diferentes tipos de plataformas e diferentes perfis de usuário, a fim de assegurar uma experiência homogênea e a acessibilidade para difenrentes tipos de pessoas.

|Caso de Teste | CT-01 - Realizar cadastro do usuário e _login_ |
|:--|:--|
|**Requisitos Associados**|RF-08 - O sistema deve ter um formulário de cadastro do cliente, para coletar o nome completo, CPF, RG, data de nascimento, endereço e contato de WhatsApp; <br/> RF-011 - O sistema deve permitir que o usuário faça Login usando o e-mail e senha cadastrados; 
|**Objetivo do teste**|- Permitir que o usuário se cadastre no site.<br/> - Permitir que o usuário faça _login_ nos site.|
|**Passos**| 1) Abra o navegador.<br/> 2) Informe o endereço do site desejado. <br/> 3) Clique no botão "cadastrar". <br/> 4) Preencha os campos com as informações requeridas.<br/> 5) Clique no botão "cadastrar".<br/> 6) Clique no link de validação enviado para o e-mail cadastrado. <br/> 7)Clique no botão login.<br/> 8) Preencha os campos com o e-mail e senha cadastrados. <br/> 9) Clique em "entrar".|
|**Critérios de Êxito**| - Receber _e-mail_ de validação.<br/> - Confirmação do _login_ e redirecionamento para _a página inicial_ da plataforma.|

|Caso de Teste | CT-02 - Realizar cadastro do PET |
|:--|:--|
|**Requisitos Associados**|RF-09 – O sistema deve ter um formulário de cadastro do Pet, informando o porte do animal e as datas e informações das vacinas (Polivalente V8 ou V10, Raiva e Giárdia); 
|**Objetivo do teste**|- Permitir que o usuário adicione as informações sobre o seu PET.|
|**Passos**|1) Abra o navegador;<br/> 2) Informe o endereço do site desejado; <br/> 3) Clique no botão de _login_;  <br/> 4) Realize _login_;<br/> 5) Clique em “perfil”; <br/> 5) Clique em “cadastrar PET”; <br/> 6) Preencha os campos com as informações requeridas; <br/> 7) Clique em salvar alterações.
|**Critérios de Êxito**| - Salvar cadastro do PET.<br/> - Visualizar informações cadastradas.

|Caso de Teste | CT-03 - Agendar diária |                                    
|:--|:--|
|**Requisitos Associados**|RF-03 – O sistema deve disponibilizar um calendário, para que o usuário veja as datas disponíveis e faça o agendamento on-line; <br/> RF-05 – O sistema deve possibilitar a compra de pacotes de creche, adestramento e hospedagem; 
|**Objetivo do teste**|- Permitir que o usuário agende diárias no PetHotel. <br/> - Permitir que o usuário consiga comprar os serviços oferecidos.|
|**Passos**| 1) Abra o navegador;<br/> 2) Informe o endereço do site desejado; <br/> 3) Clique no botão de _login_;  <br/> 4) Realize _login_;<br/> 5) Clique no item de navegação de nome "Serviços", na homepage; <br/> 6) Clique no serviço que deseja comprar, dentro do dropdown, neste caso "Hotel"; <br/> 7) Selecione a data que deseja agendar; <br/> 8) Confirme se há disponibilidade nesta data; <br/> 9) Clique em "Realizar pagamento".| 
|**Critérios de Êxito**|- Visualização do calendário. <br/> - Visualização da página de serviços oferecidos.

|Caso de Teste | CT-04 - Pagamento do agendamento |
|:--|:--|
|**Requisitos Associados**|RF-12 - O sistema deve disponibilizar formas de pagamento para o serviço contratado; <br/> RF-07 – O sistema deve conter um sistema de envio de comprovante de marcação para o cliente e envio do comprovante de pagamento para a empresa;
|**Objetivo do teste**|- Permitir que o usuário realize o pagamento dos serviços adquiridos. <br/> - Permitir que o usuário escolha a forma de pagamento que lhe agrada.<br/> - Confirmar agendamento (cliente). <br/> - Confirmar pagamento (empresa).|
|**Passos**| 1) Após o clique em "Realizar pagamento" para agendar diária; <br/> 2) Selecione a forma de pagamento desejada; <br/> 3) Preencha os campos com as informações necessárias, de acordo com a forma de pagamento escolhida; <br/> 4) Clique em "Finalizar compra"; <br/> 5) Confirme que recebeu, em seu e-mail, o comprovante de de marcação (cliente).| 
|**Critérios de Êxito**|- Envio de comprovante de marcação para o cliente e envio do comprovante de pagamento para a empresa. <br/> - Visualização da página de formas de pagamento.

|Caso de Teste | CT-05 - Redefinir senha |
|:--|:--|
|**Requisitos Associados**|RF-013 – O sistema deve permitir que o usuário redefina sua senha, informando o e-mail cadastrado;.  
|**Objetivo do teste**|- Permitir que o usuário redefina sua senha.|
|**Passos**| 1) Abra o navegador; <br/> 2) Informe o endereço do site desejado; <br/> 3) Clique no botão de _login_;  <br/> 4) Clique em _Esqueci minha senha_;<br/> 5) Digite o e-mail cadastrado;  <br/> 6) Clique em "Redefinir"; <br/> 7) Clique no link de redefinição de senha, recebido no e-mail cadastrado; <br/> 8) Insira a nova senha, nos campos indicados; <br/> 9) Clique em "Salvar".|
|**Critérios de Êxito**|- Recebimento do e-mail para redefinição de senha. <br/> - Logar novamente, com a nova senha. 


## Ferramentas de Testes (Opcional)

Comente sobre as ferramentas de testes utilizadas.
 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
