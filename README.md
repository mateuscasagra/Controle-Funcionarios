
# Por

**Carlos Eduardo Gonçalves Faria RGM: 34249559**

**Mateus Zandona Casagrande 37482955**

Documentacao Controle-Funcionarios

1. Objetivo do Projeto,
O objetivo deste projeto é desenvolver uma API voltada ao controle e gestão de funcionários, com foco na parte salarial.
A aplicação foi concebida para possibilitar operações deconsulta de dados individuais e 
demissão de colaboradores, de forma estruturada e eficiente. Essa solução busca facilitar a gestão por parte dos 
profissionais de RH e superiores, garantindo agilidade, precisão e consistência no gerenciamento de informações relacionadas aos funcionários.

2. Estrutura da Solução,
2.1 Modelagem de Dados
A modelagem da aplicação foi centrada nas entidades “Cargo” e “Funcionário”, definidas com base nos requisitos de um sistema de controle de pessoal. 
Os atributos considerados (como nome, salário, CPF e cargo) foram selecionados para representar informações essenciais para a identificação, 
classificação e referência de cada colaborador. Essa modelagem foi transformada em classes na camada de domínio, servindo como base para a 
construção do banco de dados e definição das regras de negócio da aplicação.



2.2 Integração da API com a Solução
A API foi estruturada para atuar como a interface de comunicação entre o sistema e os dados armazenados. 
Cada rota foi implementada para representar uma funcionalidade específica da aplicação, como consulta geral, busca por CPF ou nome, 
cálculo de médias salariais e demissão de funcionários. Por meio dessa estrutura, a solução permite que qualquer profissional de RH ou superior 
possa gerenciar de maneira segura, rápida e consistente as informações de todos os colaboradores.



3. Tabela de Endpoints
Método              Rota                                      Descrição
GET         /admin/funcionarios                   Lista todos os funcionários cadastrados.
GET         /admin/cargos                         Lista todos os cargos disponíveis.
POST        /admin/funcionarios                   Cria um novo funcionário.
DELETE      /admin/funcionarios/{cpf}             Remove o funcionário com o CPF especificado.


4. Organização do Código,
O projeto foi dividido em componentes com responsabilidades bem definidas, promovendo clareza e modularidade:
• Models/Funcionario.cs – Define a estrutura da entidade principal “Funcionário”, incluindo atributos como CPF, nome, salário, carga horária e relacionamento com o cargo.
• Models/Cargo.cs – Define a estrutura da entidade “Cargo”, com atributos como ID e nome, além da lista de funcionários relacionados.
• Data/AppDbContext.cs – Responsável pela configuração da base de dados e integração com o Entity Framework, gerenciando as entidades e seus relacionamentos.
• Rotas/RotaGetFuncionarios.cs – Contém os métodos para listagem de todos os funcionários cadastrados no sistema.
• Rotas/RotaGetCargos.cs – Contém os métodos para listagem de todos os cargos disponíveis.
• Rotas/RotaPostFuncionario.cs – Responsável pelo cadastro de novos funcionários.
• Rotas/RotaDeleteFuncionario.cs – Gerencia a exclusão de funcionários existentes.
• Program.cs – Arquivo principal de inicialização da aplicação, onde são configurados os serviços (como o AppDbContext e políticas de CORS) e registradas as rotas da API.


5. Justificativa Técnica,
A modelagem das entidades principais — “Funcionário” e “Cargo” — foi realizada com base em atributos essenciais para identificação, classificação e referência, 
assegurando alinhamento com as práticas reais de gestão de equipes em empresas. Essa modelagem orientou toda a arquitetura da aplicação, incluindo a configuração da base de dados, 
a definição das rotas e a estrutura do código.

A separação entre os arquivos responsáveis pelas rotas, o modelo de dados e o contexto do banco de dados proporciona clareza na manutenção e facilita a evolução futura da aplicação. 
Caso novas funcionalidades precisem ser incorporadas, como atualização de informações, controle de promoções ou autenticação de usuários, essa organização modular garante maior flexibilidade e escalabilidade à solução.
