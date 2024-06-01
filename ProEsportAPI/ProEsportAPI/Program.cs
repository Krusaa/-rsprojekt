using Supabase;
using Supabase.ProEsport.Contracts;
using Supabase.ProEsport.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<Supabase.Client>(_ =>
    new Supabase.Client(
        builder.Configuration["Supabase API URL"],
        builder.Configuration["Supabase API KEY"],
        new SupabaseOptions
        {
            AutoRefreshToken = true,
            AutoConnectRealtime = true
        }));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapPost("/user", async (
    CreateProEsportRequest request,
     Supabase.Client client) =>
     {
        var User = new ProEsportform
        {
            First_Name = request.First_Name,
            Description = request.Description,
            ReadTime = request.ReadTime,
            lastName = request.lastName,
            sirName = request.sirName,
            Birthday = request.Birthday,
            UserName = request.UserName,
            Password = request.Password,
            Email = request.Email,
            Mobil = request.Mobil,
            Address = request.Address,
            City = request.City,
            CountryId = request.CountryId,
            GenderId = request.GenderId,
            TeamId = request.TeamId,
            Zipcode = request.Zipcode,
        };

        var response = await client.From<ProEsportform>().Insert(User);

        var newUser = response.Models.First();

        return Results.Ok(newUser.Id);


     });

app.MapGet("/user/{id}", async (long id, Supabase.Client client ) =>
{
    var response = await client
        .From<ProEsportform>()
        .Where(n => n.Id == id)
        .Get();

    var User = response.Models.FirstOrDefault();
    
    if (User is null)
    {
        return Results.NotFound();
    }

    var userResponse = new ProEsportResponse
    {
        Id = User.Id,
        First_Name = User.First_Name,
        Description = User.Description,
        ReadTime = User.ReadTime,
        CreatedAt = User.CreatedAt,
    };

    return Results.Ok(userResponse);
});

app.MapDelete("/user/{id}", async (long id, Supabase.Client client) =>
{
    await client
        .From<ProEsportform>()
        .Where(n => n.Id == id)
        .Delete();

    return Results.NoContent();
});

app.UseHttpsRedirection();

app.Run();
