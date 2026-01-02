
using System.Diagnostics;
using System.Text;
using BusinessLogic.Mapping;
using BusinessLogic.Services;
using BusinessLogic.Services.Auth;
using DataAccess.Data;
using DataAccess.Identity;
using DataAccess.Interfaces;
using DataAccess.Repositories;
using DataAccess.Seeding;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Builder;
namespace ExaminationSystem
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<Context>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("CS"))
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
                .LogTo(log => Debug.WriteLine(log), LogLevel.Information)
                .EnableSensitiveDataLogging(true);
            });

            builder.Services.AddScoped(typeof(IGeneralRepository<>), typeof(GeneralRepository<>));
            builder.Services.AddScoped<IExamRepository, ExamRepository>();
            builder.Services.AddScoped<IChoiceRepository, ChoiceRepository>();
            builder.Services.AddScoped<IQuestionRepository, QuestionRepository>();

            builder.Services.AddScoped<ExamService>();
            builder.Services.AddScoped<CourseService>();
            builder.Services.AddScoped<AuthService>();
            builder.Services.AddScoped<UserRepository>();
            builder.Services.AddScoped<JwtTokenService>();
            builder.Services.AddScoped<ChoiceService>();
            builder.Services.AddScoped<QuestionService>();





            builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 6;
                options.Password.RequireDigit = true;
                options.Password.RequireNonAlphanumeric = false;
            })
             .AddEntityFrameworkStores<Context>()
             .AddSignInManager<SignInManager<ApplicationUser>>()
             .AddDefaultTokenProviders();

            var jwt = builder.Configuration.GetSection("Jwt");
            var key = Encoding.UTF8.GetBytes(jwt["Key"]);

            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidIssuer = jwt["Issuer"],
                    ValidAudience = jwt["Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ClockSkew = TimeSpan.Zero
                };
            });

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();
            builder.Services.AddAutoMapper(typeof(CourseProfile).Assembly);
            builder.Services.AddAutoMapper(typeof(ExamProfile).Assembly);
            builder.Services.AddAutoMapper(typeof(ChoiceProfile).Assembly);
            builder.Services.AddAutoMapper(typeof(QuistionProfile).Assembly);
            builder.Services.AddAutoMapper(typeof(CourseAssignmentProfile).Assembly);
            builder.Services.AddAutoMapper(typeof(ExamQuestionProfile).Assembly);
            builder.Services.AddAutoMapper(typeof(StudentAnswerProfile).Assembly);
            builder.Services.AddAutoMapper(typeof(StudentExamProfile).Assembly);



            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", builder =>
                {
                    builder.AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader();
                });
            });

            builder.Services.AddMemoryCache();
            builder.Services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = "redis-19151.c15.us-east-1-2.ec2.cloud.redislabs.com:19151, Password=O4hGPDNFTY5lI2BcQnxfCTXW7tHzAN9i";
                options.InstanceName = "QuizSystem";
            });
            var app = builder.Build();
            using (var scope = app.Services.CreateScope())
            {
                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                await RoleSeeder.SeedRoles(roleManager);
            }

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("/openapi/v1.json", "QuizSystem API v1");
                    options.RoutePrefix = string.Empty; 
                });
            }
            app.UseCors("AllowAll");

            app.UseAuthentication();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
