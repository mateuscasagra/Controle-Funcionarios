using ControleFuncionario.Models;
using ControleFuncionario.Data;
using System.Collections.Generic;
using System.Linq;

namespace ControleFuncionario.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            // Garante que o banco está criado
            context.Database.EnsureCreated();

            // Verifica se já tem cargos
            if (context.Cargos.Any())
            {
                return;   // Banco já foi inicializado
            }

            // Cria cargos
            var cargos = new List<Cargo>
            {
                new Cargo { Nome = "Gerente" },
                new Cargo { Nome = "Analista" },
                new Cargo { Nome = "Desenvolvedor" },
                new Cargo { Nome = "Designer" },
                new Cargo { Nome = "Tester" },
                new Cargo { Nome = "Suporte" },
                new Cargo { Nome = "Estagiário" },
                new Cargo { Nome = "Coordenador" },
                new Cargo { Nome = "Diretor" },
                new Cargo { Nome = "Auxiliar Administrativo" }
            };

            context.Cargos.AddRange(cargos);
            context.SaveChanges();

            // Cria funcionários vinculados aos cargos
            var funcionarios = new List<Funcionario>
            {
                new Funcionario { cpf = "11111111111", nome = "João Silva", salario = 5000, idCargo = cargos[0].Id, cargaHoraria = 40 },
                new Funcionario { cpf = "22222222222", nome = "Maria Oliveira", salario = 4000, idCargo = cargos[1].Id, cargaHoraria = 40 },
                new Funcionario { cpf = "33333333333", nome = "Pedro Santos", salario = 4500, idCargo = cargos[2].Id, cargaHoraria = 40 },
                new Funcionario { cpf = "44444444444", nome = "Ana Costa", salario = 3800, idCargo = cargos[3].Id, cargaHoraria = 40 },
                new Funcionario { cpf = "55555555555", nome = "Lucas Almeida", salario = 3500, idCargo = cargos[4].Id, cargaHoraria = 40 },
                new Funcionario { cpf = "66666666666", nome = "Carla Pereira", salario = 3200, idCargo = cargos[5].Id, cargaHoraria = 40 },
                new Funcionario { cpf = "77777777777", nome = "Rafael Lima", salario = 2800, idCargo = cargos[6].Id, cargaHoraria = 20 },
                new Funcionario { cpf = "88888888888", nome = "Juliana Rocha", salario = 6000, idCargo = cargos[7].Id, cargaHoraria = 40 },
                new Funcionario { cpf = "99999999999", nome = "Thiago Fernandes", salario = 7000, idCargo = cargos[8].Id, cargaHoraria = 40 },
                new Funcionario { cpf = "10101010101", nome = "Patrícia Martins", salario = 2200, idCargo = cargos[9].Id, cargaHoraria = 30 }
            };

            context.Funcionarios.AddRange(funcionarios);
            context.SaveChanges();
        }
    }
}
