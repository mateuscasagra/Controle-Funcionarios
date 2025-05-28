namespace ControleFuncionario.Models;
using System.ComponentModel.DataAnnotations;

public class Funcionario
{
    [Key]
    public string cpf { get; set; }
    public string nome { get; set; }

    public double salario { get; set; }

    public int idCargo { get; set; }

    public Cargo cargo { get; set; }
    
    public int cargaHoraria { get; set; }

}