using System.Numerics;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace command_microservices;

public class Command
{
    [Key] public int ID { get; set; }
    public int UserID { get; set; }
    public int TotalPrice { get; set; }
    public string? Date { get; set; }
}
