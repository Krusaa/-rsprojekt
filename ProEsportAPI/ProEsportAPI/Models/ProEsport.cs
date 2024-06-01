using Postgrest.Attributes;
using Postgrest.Models;

namespace Supabase.ProEsport.Models;

[Table("ProEsport")]
public class ProEsportform : BaseModel
{
    [PrimaryKey("Id", false)]
    public long Id { get; set; }

[Column("first_name")]
    public string? First_Name { get; set; }

[Column("description")]
    public string? Description { get; set; }

[Column("read_time")]
    public int ReadTime { get; set; }

[Column("last_name")]
    public string? lastName { get; set;}
    
[Column("sir_name")]
    public string? sirName { get; set;}

[Column("birthday")]
    public DateOnly Birthday { get; set;}

[Column("username")]
    public string? UserName { get; set;}

[Column("password")]
    public string? Password { get; set;}

[Column("email")]
    public string? Email { get; set;}

[Column("mobil")]
    public int Mobil { get; set;}

[Column("address")]
    public string? Address { get; set;}

[Column("zipcode")]
    public int Zipcode { get; set;}

[Column("city")]
    public string? City { get; set;}

[Column("country_id")]
    public int CountryId { get; set;}

[Column("gender_id")]
    public int GenderId { get; set;}

[Column("team_id")]
    public int TeamId { get; set;}

[Column("created_at")]
    public DateTime CreatedAt { get; set;}

}

