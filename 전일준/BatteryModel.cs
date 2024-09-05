namespace Project_battery02.Models
{
    public class BatteryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public double Energy { get; set; }
        public string VoltageRange { get; set; }
        public string Dimension { get; set; }
        public string ImagePath { get; set; }
        public string Category { get; set; } // 새로운 필드 추가
    }
}
