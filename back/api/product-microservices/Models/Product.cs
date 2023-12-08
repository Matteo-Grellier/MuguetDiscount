using System.ComponentModel.DataAnnotations;
using System.Numerics;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using Npgsql.Internal.TypeHandlers;

public class Product
{
    [Key] public string ID { get; set; } = String.Empty;
    public string Name { get; set; } = String.Empty;
    public float Price { get; set; }
    public string Picture { get; set; } = String.Empty;
    public string Description { get; set; } = String.Empty;
    public string Category { get; set; } = String.Empty;
    public string Seller { get; set; } = String.Empty;
}