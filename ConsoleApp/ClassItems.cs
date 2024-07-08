using System.ComponentModel.DataAnnotations;

namespace ConsoleApp;

public class Bind
{
    [Key]
    public int Id { get; set; }
    public int LineId { get; set; }
    public int UserId { get; set; }
    public string BindData { get; set; }
}

public class Item
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    
    public int? LineId { get; set; }
    public Line Line { get; set; }
}

public class Line
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
}
public class LineData
{
    [Key]
    public int Id { get; set; }
    public int LineId { get; set; }
    public List<int> ItemIds { get; set; }
}
