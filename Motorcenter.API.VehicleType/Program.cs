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
    app.AddEndpoint<Motorcenter.Data.Entities.Type, TypePostDTO, TypePutDTO, TypeGetDTO>();
}


void ConfigureAutoMapper()
{
    var config = new MapperConfiguration(cfg =>
    {
        cfg.CreateMap<eShop.Data.Entities.Type, TypePostDTO>().ReverseMap();
        cfg.CreateMap<eShop.Data.Entities.Type, TypePutDTO>().ReverseMap();
        cfg.CreateMap<eShop.Data.Entities.Type, TypeGetDTO>().ReverseMap();
        cfg.CreateMap<eShop.Data.Entities.Type, TypeSmallGetDTO>().ReverseMap();
        cfg.CreateMap<TypeVehicle, TypeVehicleDTO>().ReverseMap();
        /* cfg.CreateMap<Filter, FilterGetDTO>().ReverseMap();
         cfg.CreateMap<Size, OptionDTO>().ReverseMap();
         cfg.CreateMap<Color, OptionDTO>().ReverseMap();*/
    });
    var mapper = config.CreateMapper();
    builder.Services.AddSingleton(mapper);
}
