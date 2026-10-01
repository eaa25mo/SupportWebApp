using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;


namespace SupportWebApp.Models;

public class SupportMessage
{
    [JsonProperty("id")]
    public string Id { get; set; } = Guid.NewGuid().ToString();

    [Required(ErrorMessage = "Navn skal udfyldes")]
    public string Name { get; set; } = "";

    [Required(ErrorMessage = "Email skal udfyldes")]
    [EmailAddress(ErrorMessage = "Email er ikke gyldig")]
    public string Email { get; set; } = "";

    [Required(ErrorMessage = "Telefon skal udfyldes")]
    public string Phone { get; set; } = "";

    [Required(ErrorMessage = "Beskrivelse skal udfyldes")]
    public string Description { get; set; } = "";

    [JsonProperty("category")]
    [Required(ErrorMessage = "Kategori skal vælges")]
    public string Category { get; set; } = "";

    public DateTime CreatedAt { get; set; } = DateTime.Now;
}