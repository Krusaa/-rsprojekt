namespace Supabase.ProEsport.Contracts;

public class ProEsportResponse
{
    public long Id { get; set; }

    public string? First_Name { get; set; }

    public string? Description { get; set; }

    public int ReadTime { get; set; }

    public string? lastName { get; set; }

    public string? sirName { get; set; }

    public DateOnly Birthday { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? Email { get; set; }

    public int Mobil { get; set; }

    public string? Address { get; set; }

    public int Zipcode { get; set; }

    public string? City { get; set; }

    public int CountryId { get; set; }

    public int GenderId { get; set; }

    public int TeamId { get; set; }

    public DateTime CreatedAt { get; set; }
}