using System.Numerics;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace command_microservices;

public class Command
{
    [Key] public string ID { get; set; } = String.Empty;
    public string UserID { get; set; } = String.Empty;
    public float TotalPrice { get; set; }
    public DateTime? Date { get; set; }
}
