using KutumbaBhoj.Application.Interfaces;
using KutumbaBhoj.Application.Services;
using KutumbaBhoj.Infrastructure.DbContext;
using KutumbaBhoj.Infrastructure.Repository;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Facebook;
using Microsoft.EntityFrameworkCore;
using Microsoft.Owin.Security.Facebook;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IDishes, ServiceDishes>();
builder.Services.AddScoped<IFoods, ServiceFoods>();
builder.Services.AddScoped<IUsers, ServiceUsers>();
builder.Services.AddScoped<IOrder, ServiceOrders>();
builder.Services.AddScoped<IRestaurants, ServiceRestaurants>();
builder.Services.AddScoped<IFeedback, ServiceFeedbacks>();

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IDishRepository, DishRepository>();
builder.Services.AddScoped<IFoodRepository, FoodRepository>();
builder.Services.AddScoped<IFeedbackRepository, FeedbackRepository>();
builder.Services.AddScoped<IOrderRepository,OrderRepository>();
builder.Services.AddScoped<IRestaurantRepository, RestaurantRepository>();



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program).Assembly);

var Configuration = builder.Configuration;

builder.Services.AddDbContext<DataContext>(options =>
    options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));


    

var app = builder.Build();

//app.UseFacebookAuthentication(new FacebookAuthenticationOptions()
//{
//    AppId = "3685898741738785",
//    AppSecret = "597c889249e9f11407992b0daab9bd3f"
//});




// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
