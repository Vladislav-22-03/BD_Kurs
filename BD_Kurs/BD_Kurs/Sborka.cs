using System.ComponentModel.DataAnnotations.Schema;

public class Sborka
{
    // Свойство для внешнего ключа
    public int DetId { get; set; }

    [ForeignKey("DetId")]
    public Det Det { get; set; }

    // Остальные свойства
    public string TypePer { get; set; }
    public string TypeOpor { get; set; }
    public double Kbe { get; set; }
    public string HB { get; set; }
    public double u { get; set; }
    public string Mater { get; set; }
    public double Khb { get; set; }
    public double Kfb { get; set; }
    public double Y { get; set; }
    public double x { get; set; }
    public int Kd { get; set; }
    public double Km { get; set; }
    public double z { get; set; }
    public double thiHP { get; set; }
    public double thi { get; set; }
    public double Khl { get; set; }
    public int ID { get; set; }
}
