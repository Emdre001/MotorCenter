


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

void RegisterEndpoints()
{
    app.AddEndpoint<Filter, FilterPostDTO, FilterPutDTO, FilterGetDTO>();
    //app.AddEndpoint<CategoryFilter, CategoryFilterPostDTO, CategoryFilterDeleteDTO>();
    //app.AddEndpoint<FilterType, FilterTypePostDTO, FilterTypePutDTO, FilterTypeGetDTO>();
    //app.AddEndpoint<Option, OptionPostDTO, OptionPutDTO, OptionGetDTO>();

    /*app.MapPost("/api/filterproducts", async (List<FilterRequestDTO> filterDTOs, IFilterService filterService) =>
    {
        try
        {
            // Assuming filterService.ProcessFiltering() is your method to apply filters
            var filterDTOs = filterService.ProcessFiltering(filterRequest);
            return Results.Ok(filterDTOs);
        }
        catch (Exception ex)
        {
            // Log the exception details and return an appropriate error response
            return Results.Problem(ex.Message);
        }
    });*/ 
}

void RegisterServices()
{
    //builder.Services.
    ConfigureAutoMapper();
    builder.Services.AddScoped<IDbService, VehicleDbService>();
}

void ConfigureAutoMapper()
{
    var config = new MapperConfiguration(cfg =>
    {
        cfg.CreateMap<Motorcenter.Data.Entities.Filter, FilterPostDTO>().ReverseMap();
        cfg.CreateMap<Motorcenter.Data.Entities.Filter, FilterPutDTO>().ReverseMap();
        cfg.CreateMap<Motorcenter.Data.Entities.Filter, FilterGetDTO>().ReverseMap();
        //cfg.CreateMap<Motorcenter.Data.Entities.Filter, FilterSmallGetDTO>().ReverseMap();
        /* cfg.CreateMap<Filter, FilterGetDTO>().ReverseMap();
         cfg.CreateMap<Size, OptionDTO>().ReverseMap();
         cfg.CreateMap<Color, OptionDTO>().ReverseMap();*/
    });
    var mapper = config.CreateMapper();
    builder.Services.AddSingleton(mapper);
}
