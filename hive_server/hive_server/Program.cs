using hive_server;
using hive_server.Components;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<HiveDataBaseSettings>(builder.Configuration.GetSection("HiveDataBaseSettings"));
builder.Services.AddSingleton<HiveServices>();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

app.MapGet("/", () => "Hive Server API");


app.MapGet("/api/hives/{id}", async (HiveServices services, string id) => {
    var record = await services.Get(id);
    return record is null? Results.NotFound() : Results.Ok(record);

});

app.MapPost("/api/hives", async (HiveServices services, Module_record record) => {
    await services.Create(record);
    return Results.Ok();
});

app.MapPut("/api/movies/{id}", async (HiveServices services, string id, Module_record updatedrecord) => {
    var record = await services.Get(id);
    if (record is null) return Results.NotFound();

    updatedrecord._id = record._id;
    await services.Update(id, updatedrecord);

    return Results.NotFound();

});




/*// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();*/

app.Run();