using System.Numerics;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace product_microservices;

public class Product
{
    [Key] public BigInteger ID { get; set; }
    public BigInteger UserID { get; set; }
    public int TotalPrice { get; set; }
    public DateOnly Date { get; set; }
}
