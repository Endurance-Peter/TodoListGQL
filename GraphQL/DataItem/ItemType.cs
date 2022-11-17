using TodoListGQL.Models;

namespace TodoListGQL.GraphQL.DataItem;

public class ItemType : ObjectType<ItemData>
{
    protected override void Configure(IObjectTypeDescriptor<ItemData> descriptor)
    {
        base.Configure(descriptor);

        descriptor.Description("This model is used as item for the to list");

        descriptor.Field(x => x.ItemList).Description("This is the list that the item belongs to");
    }
}