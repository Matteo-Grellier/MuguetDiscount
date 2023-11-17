using System.Numerics;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace command_microservices;

public class Command
{
    [Key] public BigInteger ID { get; set; }
    public BigInteger UserID { get; set; }
    public int TotalPrice { get; set; }
    public DateOnly Date { get; set; }
}
