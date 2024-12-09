using System.ComponentModel.DataAnnotations.Schema;

public class Itog
{

    // Внешний ключ
    public int DetId { get; set; }

    [ForeignKey("DetId")]
    public Det Det { get; set; }

    public double de1 { get; set; }
    public double m { get; set; }
    public int ID { get; set; }
}
