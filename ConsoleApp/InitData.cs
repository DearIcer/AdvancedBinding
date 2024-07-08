namespace ConsoleApp;

public static class InitData
{
    public static void Init()
    {
        using (var context = new AppDbContext())
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }

        var dbContext = new AppDbContext();
        dbContext.Item.Add(new Item { Name = "项目1" , Description = "Item1 Description", Price = 1.0m });
        dbContext.Item.Add(new Item { Name = "项目2" , Description = "Item2 Description", Price = 2.0m});
        dbContext.Item.Add(new Item { Name = "项目3" , Description = "Item3 Description", Price = 3.0m});
        dbContext.Item.Add(new Item { Name = "项目4" , Description = "Item4 Description", Price = 4.0m });
        dbContext.SaveChanges();
        dbContext.Line.Add(new Line { Name = "产品线1" });
        dbContext.Line.Add(new Line { Name = "产品线2" });
        dbContext.LineData.Add(new LineData { LineId = 1});
        dbContext.LineData.Add(new LineData { LineId = 2});
        dbContext.SaveChanges();
        
    }
}