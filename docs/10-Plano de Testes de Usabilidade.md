# Plano de Testes de Usabilidade

O objetivo dos testes de usabilidade é simular a utilização do sistema na perspectiva do usuário final, neste caso, donos de animais que necessitam de cuidados profissionais. Coletando dados que permitam mensurar a experiência do público alvo, garantindo um sistema que atende à demanda do cliente de forma eficiente e satisfatória.

Faz parte do escopo dos testes repetí-los para diferentes tipos de plataformas e diferentes perfis de usuário, a fim de assegurar uma experiência homogênea e a acessibilidade para difenrentes tipos de pessoas.

|Caso de Teste | CT-01 - Realizar cadastro do usuário e _login_ |
|:--|:--|
|**Requisitos Associados**|RF-08 - O sistema deve ter um formulário de cadastro do cliente, para coletar o nome completo, CPF, RG, data de nascimento, endereço e contato de WhatsApp; <br/> RF-011 - O sistema deve permitir que o usuário faça Login usando o e-mail e senha cadastrados; 
|**Objetivo do teste**|- Permitir que o usuário se cadastre no site.<br/> - Permitir que o usuário faça _login_ nos site.|
|**Passos**| 1) Abra o navegador.<br/> 2) Informe o endereço do site desejado. <br/> 3) Clique no botão de _login_, localizado no menu de navegação; <br/> 4) Clique na opção de _Cadastre-se_;<br/> 5) Preencha os campos com as informações requeridas e em _Cadastre-se_;<br/> 6) Clique novamanete no botão de _login_, localizado no menu de navegação; <br/> 7)Preencha os campos com o e-mail e senha cadastrados;<br/> 8) Clique em _entrar_.|
|**Critérios de Êxito**| - Conseguir logar, se transfromando em _User_, caso não seja um Administrador.|

|Caso de Teste | CT-02 - Realizar cadastro do PET |
|:--|:--|
|**Requisitos Associados**|RF-09 – O sistema deve ter um formulário de cadastro do Pet, informando o porte do animal e as datas e informações das vacinas (Polivalente V8 ou V10, Raiva e Giárdia); 
|**Objetivo do teste**|- Permitir que o usuário adicione as informações sobre o seu PET.|
|**Passos**|1) Abra o navegador;<br/> 2) Informe o endereço do site desejado; <br/> 3) Clique no botão de _Cadastro do Pet_, localizado no menu de navegação;  <br/> 4) Preencha os campos com as informações requeridas; <br/> 5) Clique em _Finalizar cadastro_.
|**Critérios de Êxito**| - Salvar cadastro do PET.

|Caso de Teste | CT-03 - Agendar diária |                                    
|:--|:--|
|**Requisitos Associados**|RF-03 – O sistema deve disponibilizar um calendário, para que o usuário veja as datas disponíveis e faça o agendamento on-line; <br/> RF-05 – O sistema deve possibilitar a compra de pacotes de creche, adestramento e hospedagem; 
|**Objetivo do teste**|- Permitir que o usuário agende diárias no PetHotel. <br/> - Permitir que o usuário consiga comprar os serviços oferecidos.|
|**Passos**| 1) Abra o navegador;<br/> 2) Informe o endereço do site desejado; <br/> 3) Clique no botão de _login_;  <br/> 4) Realize _login_;<br/> 5) Clique no item de navegação de nome "Serviços", na homepage; <br/> 6) Clique no serviço que deseja comprar, dentro do dropdown, neste caso "Hotel"; <br/> 7) Selecione a data que deseja agendar; <br/> 8) Confirme se há disponibilidade nesta data.| 
|**Critérios de Êxito**|- Visualização do calendário. <br/> - Visualização da página de serviços oferecidos.


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
