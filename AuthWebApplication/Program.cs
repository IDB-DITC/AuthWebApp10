using AuthWebApplication.Model;
//using AuthWebApplication.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Scalar.AspNetCore;
using System;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace AuthWebApplication
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.WebHost.UseKestrel(op =>
            {
                //op.ListenAnyIP(4000);
            });



            // Add services to the container.

            builder.Services.AddCors();

            //builder.Services.AddCors(op =>
            //{
            //  op.AddDefaultPolicy(policy =>
            //  {
            //    policy
            //    .AllowAnyOrigin()
            //    //.WithOrigins("http://localhost:4200")
            //    .AllowAnyHeader()
            //    .AllowAnyMethod();
            //  });
            //});

            builder.Services.AddDbContext<Model.ExamDb>(options =>
                      options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


            builder.Services.AddIdentity<AppUser, IdentityRole<Guid>>()
                      .AddEntityFrameworkStores<ExamDb>()
                      .AddDefaultTokenProviders();




            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme
          = options.DefaultScheme
          = options.DefaultChallengeScheme
          = options.DefaultForbidScheme
          = options.DefaultSignInScheme
          = options.DefaultSignOutScheme
          = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer(bearer =>
            {


                byte[] key = Encoding.UTF8.GetBytes(builder.Configuration.GetValue<string>("Jwt:Key"));
                //byte[] key = Encoding.UTF8.GetBytes(Key);

                bearer.RequireHttpsMetadata = false;

                bearer.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key)
                };

            });
            builder.Services.AddAuthorization(opt =>
            {
                opt.AddPolicy("Editor", policyOpt =>
          {
              //policyOpt.RequireUserName("admin");
              //policyOpt.RequireRole("Admin");
              //policyOpt.RequireRole("Moderator");

                  policyOpt.RequireAssertion(ctx => ctx.User.Claims.Any(c => (c.Type == ClaimTypes.Role && (c.Value == "Admin" || c.Value == "Moderator")) || (c.Type == ClaimTypes.Name && c.Value.ToLower().Contains("admin"))));
              });
            });

            //builder.Services.AddScoped<IImageUpload, ImageUpload>();

            builder.Services.AddControllers().AddJsonOptions(op =>
            {
                op.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;

                op.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
                //op.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenReading;

                //.DateFormatString = "yyyy-MM-dd";
                //op.JsonSerializerOptions.PropertyNamingPolicy  = JsonNamingPolicy.CamelCase;
                op.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                //op.JsonSerializerOptions.Converters.Add(new DateTimeConverter());
                //options.JsonSerializerOptions.DateFormatString = "yyyy-MM-dd HH:mm:ss";

            });

           
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            //builder.Services.AddOpenApi();
            builder.Services.AddOpenApi(options =>
            {
                options.AddDocumentTransformer<BearerSecuritySchemeTransformer>();
            });
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.MapScalarApiReference("/");
            }

            //app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            //app.UseCors();

            app.UseCors(policy =>
            {
                policy
          .AllowAnyOrigin()
          .AllowAnyMethod()
          .AllowAnyHeader();
            });
            app.Run();
        }
    }
}
