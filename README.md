# Renomear

Este Software tem como objetivo trazer agilidade na administração da rede, como: Renomear máquinas dentro ou fora do Domínio, Desliga-las, Reinicia-las.
1)Para seu funcionamento na rede é preciso criar uma criar uma regra no Firewall da rede, e criar GPO para abrir as seguintes portas de Entrada e saída no firewall do Windows: RPC (Portas Dinâmicas), 445.
Para seu Funcionamento normal é preciso ter em seu computador a ferramenta RSAT "https://www.microsoft.com/pt-BR/download/details.aspx?id=45520, como habilita-la https://support.microsoft.com/pt-br/help/2693643/remote-server-administration-tools-rsat-for-windows-operating-systems Obs: Ambiente de administração testado em Windows 10".
Software de Renomear
A primeira tela que irá aparecer é a de Usuário e senha, no caso é a de Administrador local do PC Remoto. As credenciais de Domínio só devem ser utilizadas para usar a opção Renomear, mas funciona também no "sem Domínio".
O botão procurar exige que você insira uma lista de ips na ordem que você deseja executar as funções, seja Renomear, desligar ou outra qualquer. OBS. Evite deixar linhas em branco no seu txt.
A caixa Prefixo você irá inserir o nome de seu computador. A quantidade de máquinas que serão renomeadas pela ordem dos ips irão aparecer, e elas serão renomeadas da seguinte forma.
prefixo: LAB1 Quantidade: 3 LAB1-01 LAB1-02 LAB1-03
E abrirá uma janela de LOG para ver quem foi renomeado ou não.

