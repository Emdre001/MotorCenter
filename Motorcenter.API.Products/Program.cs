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
    //app.AddEndpoint<Brand, BrandPostDTO, BrandPutDTO, BrandGetDTO>();
    //app.AddEndpoint<Color, ColorPostDTO, ColorPutDTO, ColorGetDTO>();
    //app.AddEndpoint<TypeVehicle, TypeVehiclePostDTO, TypeVehicleDeleteDTO>();
    //app.AddEndpoint<VehicleColor, VehicleColorPostDTO, VehicleColorDeleteDTO>();

}


void ConfigureAutoMapper()
{
    var config = new MapperConfiguration(cfg =>
    {
        cfg.CreateMap<Vehicle, VehiclePostDTO>().ReverseMap();
        cfg.CreateMap<Vehicle, VehiclePutDTO>().ReverseMap();
        cfg.CreateMap<Vehicle, VehicleGetDTO>().ReverseMap();

        cfg.CreateMap<Brand, BrandPostDTO>().ReverseMap();
        cfg.CreateMap<Brand, BrandPutDTO>().ReverseMap();
        cfg.CreateMap<Brand, BrandGetDTO>().ReverseMap();

        cfg.CreateMap<Color, ColorPostDTO>().ReverseMap();
        cfg.CreateMap<Color, ColorPutDTO>().ReverseMap();
        cfg.CreateMap<Color, ColorGetDTO>().ReverseMap();

        cfg.CreateMap<Year, YearPostDTO>().ReverseMap();
        cfg.CreateMap<Year, YearPutDTO>().ReverseMap();
        cfg.CreateMap<Year, YearGetDTO>().ReverseMap();

        cfg.CreateMap<TypeVehicle, TypeVehiclePostDTO>().ReverseMap();
        cfg.CreateMap<TypeVehicle, TypeVehicleDeleteDTO>().ReverseMap();

        cfg.CreateMap<VehicleColor, VehicleColorPostDTO>().ReverseMap();
        cfg.CreateMap<VehicleColor, VehicleColorDeleteDTO>().ReverseMap();
    });
    var mapper = config.CreateMapper();
    builder.Services.AddSingleton(mapper);
}




