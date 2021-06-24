Processos e dados necessários à instalação, configuração e execução da aplicação:


1. Abrir o ficheiro Projeto.sln

2. Após o projeto abrir e carregar na sua totalidade, no menu superior do programa, selecionar o menu View e a opção Server Explorer

3. No Server Explorer, selecionar Data Connections com o botão direito do rato.

4. Selecionar Create New SQL Server Database:
   4.1. Em 'Server name:' colar: (localdb)\MSSQLLocalDB
   4.2. Selecionar 'Use Windows Authentication'
   4.3. Em 'New database name:' colocar: DA

5. No lado direito do programa, abrir a cascata de projeto e selecionar e abrir DB.edmx.sql.
	5.1. No menu logo a cima da linha de código selecionar connect:
		5.1.1. Browse
		5.1.2. Local
		5.1.3. Clicar uma vez no servidor que aparece disponível:
				MSSQLLocalDB
		5.1.4. Em baixo, em 'Database Name:' selecionar: DA
		5.1.5. Connect
	5.2. No mesmo menu logo a cima da linha de código, clicar na tecla verde
'Execute' ou atalho de teclado 'Ctrl+Shift+E' para fazer run da base de dados

6. No lado direito do programa, selecionar inserir.sql e executa-lo com os mesmos passos do ponto 5.

6. Selecionar 'Start' para fazer Run do programa.