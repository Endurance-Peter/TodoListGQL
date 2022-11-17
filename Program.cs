using GraphQL.Server.Ui.Voyager;
using Microsoft.EntityFrameworkCore;
using TodoListGQL.GraphQL;
using TodoListGQL.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddPooledDbContextFactory<ApiDbContext>( options =>
                options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddGraphQLServer()
                .AddQueryType<Query>()
                .AddProjections()
                .AddSorting()
                .AddFiltering();

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGraphQL();
});

app.UseGraphQLVoyager("/graphql-ui", new VoyagerOptions()
{
    GraphQLEndPoint = "/graphql"
});

app.Run();
