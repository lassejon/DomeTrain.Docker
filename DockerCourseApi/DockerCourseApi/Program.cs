using Dapper;
using Microsoft.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();

var app = builder.Build();

app.UseCors(p => p.AllowAnyOrigin());

app.MapGet("/podcasts", async () =>
{
    var db = new SqlConnection("Server=tcp:database; Initial catalog=Podcasts; user ID=sa; Password=Passw0rd; TrustServerCertificate=True;");

    var records = (await db.QueryAsync<PodCast>("SELECT * FROM Podcast")).Select(p => p.Title);

    return records;
});

app.Run();

record PodCast(Guid Id, string Title);