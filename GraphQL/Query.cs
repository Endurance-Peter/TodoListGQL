using TodoListGQL.Models;

namespace TodoListGQL.GraphQL;

public class Query
{
    [UseDbContext(typeof(ApiDbContext))]
    [UseProjection]
    [UseSorting]
    [UseFiltering]
    public IQueryable<ItemList>? GetList([ScopedService] ApiDbContext context)
    {
        return context.Lists;
    }

    [UseDbContext(typeof(ApiDbContext))]
    [UseProjection]
    [UseSorting]
    [UseFiltering]
    public IQueryable<ItemData>? GetItems([ScopedService] ApiDbContext context)
    {
        return context.Items;
    }
}