using Postgrest.Attributes;
using Postgrest.Models;

namespace Supabase.ProEsport.Models;
public class ProEsporteamform : BaseModel
{
    [PrimaryKey("Id", false)]
    public long Id { get; set; }

[Column("team_name")]
    public string? Team_Name { get; set; }

[Column("Day")]
    public DateOnly Day { get; set; }

[Column("start_time")]
    public TimeOnly Start_Time { get; set; }

[Column("end_time")]
    public int End_Time { get; set; }

[Column("team_type")]
    public int Team_Type { get; set; }
}