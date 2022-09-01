

using System.ComponentModel.DataAnnotations;

public class Tbl_Car{
[Key]
public int id { get; set; }
public string name { get; set; }
public string model { get; set; }
public int price { get; set; }

}
