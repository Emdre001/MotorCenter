using Motorcenter.API.Extensions.Extensions;
using Motorcenter.Data.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// SQL Server Service Registration
builder.Services.AddDbContext<MotorcenterContext>(
    options =>
        options.UseSqlServer(
            builder.Configuration.GetConnectionString("MotorcenterConnection")));

/**********
 ** CORS Cross-Origin Resource Sharing**
 **********/

builder.Services.AddCors(policy =>
{
    policy.AddPolicy("CorsAllAccessPolicy", opt =>
        opt.AllowAnyOrigin()
           .AllowAnyHeader()
           .AllowAnyMethod()
    );
});


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

RegisterServices();
ConfigureAutoMapper();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

RegisterEndpoints();

app.UseCors();
app.Run();

void RegisterServices()
{
    //builder.Services.
    ConfigureAutoMapper();
    builder.Services.AddScoped<IDbService, VehicleDbService>();
}

void RegisterEndpoints()
{
    app.AddEndpoint<Vehicle, VehiclePostDTO, VehiclePutDTO, VehicleGetDTO>();
    app.MapGet($"/api/VehiclesbyType/" + "{TypeId}", async (IDbService db, int TypeId) =>
    {
        try
        {
            var result = await ((VehicleDbService)db).GetVehiclesByTypeAsync(TypeId);
            return Results.Ok(result);
        }
        catch
        {
        }

        return Results.BadRequest($"Couldn't get the requested products of type {typeof(Vehicle).Name}.");
    });
}


void ConfigureAutoMapper()
{
    var config = new MapperConfiguration(cfg =>
    {
        cfg.CreateMap<Vehicle, VehiclePostDTO>().ReverseMap();
        cfg.CreateMap<Vehicle, VehiclePutDTO>().ReverseMap();
        cfg.CreateMap<Vehicle, VehicleGetDTO>().ReverseMap();
        cfg.CreateMap<TypeVehicle, TypeVehicleDTO>().ReverseMap();

    });
    var mapper = config.CreateMapper();
    builder.Services.AddSingleton(mapper);
}




