# Programação de Funcionalidades

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="4-Metodologia.md"> Metodologia</a>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="5-Arquitetura da Solução.md"> Arquitetura da Solução</a>

Implementação do sistema descritas por meio dos requisitos funcionais e/ou não funcionais. Deve relacionar os requisitos atendidos os artefatos criados (código fonte) além das estruturas de dados utilizadas e as instruções para acesso e verificação da implementação que deve estar funcional no ambiente de hospedagem.

Para cada requisito funcional, pode ser entregue um artefato desse tipo

|ID    | Descrição do Requisito  | Artefatos |
|------|----------------------------------------|----  |
|RF-01| A aplicação deve conter uma área em que o cliente veja avaliações e feedbacks enviados por outros clientes á empresa (tela de Depoimentos); |https://caoportado.azurewebsites.net/Home/Depoimentos |
|RF-02| A aplicação deve conter uma área de “Sobre a empresa”, onde contenha informações da empresa e da equipe, além de ter fotos e vídeos dos animais e do local;| https://caoportado.azurewebsites.net/Home/Empresa <br/> https://caoportado.azurewebsites.net/Home/fotosevideos <br/>  https://caoportado.azurewebsites.net/Home/videos  |
|RF-03| A aplicação deve possibilitar a compra de pacotes de creche, adestramento e hospedagem e disponibilizar um calendário, para que o usuário veja as datas disponíveis e faça o agendamento on-line; | https://caoportado.azurewebsites.net/Reservations/Create|
|RF-04| A aplicação deve conter um limitador de vagas;| Em desenvolvimento |
|RF-05| A aplicação deve ter um formulário de cadastro do cliente, para coletar o nome completo, CPF, data de nascimento, endereço e telefone;| https://caoportado.azurewebsites.net/Clientes/Create |
|RF-06| A aplicação deve ter um formulário de cadastro do Pet, informando a idade, o porte do animal, informações das vacinas, CPF do dono cadastrado; (Polivalente V8 ou V10, Raiva e Giárdia);|https://caoportado.azurewebsites.net/CadPet/Create|
|RF-07| O cadastro do Pet deve ser obrigatoriamente vinculado ao cadastro de seu dono;| https://caoportado.azurewebsites.net/CadPet|
|RF-09| A aplicação deve permitir que o usuário faça Login usando o e-mail e senha cadastrados; | https://caoportado.azurewebsites.net/Clientes/Login|
|RF-09| A aplicação deve permitir que o usuário redefina a senha na Tela de Login, clicando no "Esqueci minha senha";| Em desenvolvimento |
|RF-10| A aplicação deve permitir que o usuário altere seus dados cadastrais na tela "Meu perfil", tais como: telefone, endereço, e-mail;| Em desenvolvimento |
|RF-11| A aplicação deve permitir que o usuário acesse apenas as suas reservas; | https://caoportado.azurewebsites.net/Reservations |
|RF-12| A aplicação deve permitir que o Administrador acesse todas as reservas. | Em desenvolvimento |
