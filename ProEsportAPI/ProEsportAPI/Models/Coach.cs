using Postgrest.Attributes;
using Postgrest.Models;

namespace Supabase.ProEsport.Models;
public class ProEsporcoachform : BaseModel
{
    [PrimaryKey("Id", false)]
    public long Id { get; set; }

[Column("team_id")]
    public int TeamId { get; set; }

[Column("coach_id")]
    public int Coach_Id { get; set; }

[Column("created_at")]
    public DateTime Created_At { get; set; }
}