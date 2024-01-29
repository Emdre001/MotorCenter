using Motorcenter.API.Extensions.Extensions;

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


app.UseCors();
app.Run();


void RegisterServices()
{
    //builder.Services.
    ConfigureAutoMapper();
    builder.Services.AddScoped<IDbService, VehicleDbService>();
}



void RegisterEndpoints(WebApplication app)
{
    //app.AddEndpoint<Category, CategoryPostDTO, CategoryPutDTO, CategoryGetDTO>();
    //app.MapGet($"/api/categorieswithdata", async (IDbService db) =>
    //{
    //    try
    //    {
    //        return Results.Ok(await ((VehicleDbService)db).GetCategoriesWithAllRelatedDataAsync());
    //    }
    //    catch
    //    {
    //    }

    //    return Results.BadRequest($"Couldn't get the requested products of type {typeof(Vehicle).Name}.");
    //});
}


void ConfigureAutoMapper()
{
    var config = new MapperConfiguration(cfg =>
    {
        cfg.CreateMap<Brand, BrandPostDTO>().ReverseMap();
        cfg.CreateMap<Brand, BrandPutDTO>().ReverseMap();
        cfg.CreateMap<Brand, BrandGetDTO>().ReverseMap();
        /*cfg.CreateMap<Brand, CategorySmallGetDTO>().ReverseMap();
        /* cfg.CreateMap<Filter, FilterGetDTO>().ReverseMap();
         cfg.CreateMap<Size, OptionDTO>().ReverseMap();
         cfg.CreateMap<Color, OptionDTO>().ReverseMap();*/
    });
    var mapper = config.CreateMapper();
    builder.Services.AddSingleton(mapper);
}




