using Microsoft.AspNetCore.Mvc;
using Project_battery02.Models;
using System.Collections.Generic;

namespace Project_battery02.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var batteryModels = new List<BatteryModel>
            {
                // Long Duration & Energy 카테고리
                new BatteryModel { Id = 1, Name = "R1000 (17 Packs)", Model = "M48145P5B", Energy = 126.6, VoltageRange = "714 - 1,000", Dimension = "520 x 2,200 x 655", ImagePath = "/images/battery1.png", Category = "LongDuration" },
                new BatteryModel { Id = 2, Name = "R1000 (17 Packs)", Model = "M48218P5B", Energy = 189.9, VoltageRange = "714 - 1,000", Dimension = "520 x 2,200 x 950", ImagePath = "/images/battery1.png", Category = "LongDuration" },
                new BatteryModel { Id = 3, Name = "R1000 (17 Packs)", Model = "M48290P5B", Energy = 253.2, VoltageRange = "714 - 1,000", Dimension = "520 x 2,200 x 1,200", ImagePath = "/images/battery1.png", Category = "LongDuration" },
                new BatteryModel { Id = 4, Name = "R1500 (24 Packs)", Model = "M48290P5B", Energy = 357.5, VoltageRange = "1,008 - 1,411", Dimension = "520 x 3,150 x 1,200", ImagePath = "/images/battery1.png", Category = "LongDuration" },
                new BatteryModel { Id = 5, Name = "TR1300", Model = "N/A", Energy = 327.712, VoltageRange = "924 - 1,293.6", Dimension = "1040 x 1200 x 1745", ImagePath = "/images/battery1.png", Category = "LongDuration" },

                // Short Duration & Power 카테고리
                new BatteryModel { Id = 6, Name = "R1000 (17 Packs)", Model = "M4864P6B", Energy = 56, VoltageRange = "714 - 1,000", Dimension = "520 x 2,200 x 425", ImagePath = "/images/battery1.png", Category = "ShortDuration" },
                new BatteryModel { Id = 7, Name = "R1000 (17 Packs)", Model = "M48128P6B", Energy = 112.1, VoltageRange = "714 - 1,000", Dimension = "520 x 2,200 x 655", ImagePath = "/images/battery1.png", Category = "ShortDuration" }
            };

            return View(batteryModels); // 배터리 리스트를 뷰로 전달
        }

        public IActionResult Detail(int id)
        {
            var batteryModels = new List<BatteryModel>
            {
                // Long Duration & Energy 카테고리
                new BatteryModel { Id = 1, Name = "R1000 (17 Packs)", Model = "M48145P5B", Energy = 126.6, VoltageRange = "714 - 1,000", Dimension = "520 x 2,200 x 655", ImagePath = "/images/battery1.png", Category = "LongDuration" },
                new BatteryModel { Id = 2, Name = "R1000 (17 Packs)", Model = "M48218P5B", Energy = 189.9, VoltageRange = "714 - 1,000", Dimension = "520 x 2,200 x 950", ImagePath = "/images/battery1.png", Category = "LongDuration" },
                new BatteryModel { Id = 3, Name = "R1000 (17 Packs)", Model = "M48290P5B", Energy = 253.2, VoltageRange = "714 - 1,000", Dimension = "520 x 2,200 x 1,200", ImagePath = "/images/battery1.png", Category = "LongDuration" },
                new BatteryModel { Id = 4, Name = "R1500 (24 Packs)", Model = "M48290P5B", Energy = 357.5, VoltageRange = "1,008 - 1,411", Dimension = "520 x 3,150 x 1,200", ImagePath = "/images/battery1.png", Category = "LongDuration" },
                new BatteryModel { Id = 5, Name = "TR1300", Model = "N/A", Energy = 327.712, VoltageRange = "924 - 1,293.6", Dimension = "1040 x 1200 x 1745", ImagePath = "/images/battery1.png", Category = "LongDuration" },

                // Short Duration & Power 카테고리
                new BatteryModel { Id = 6, Name = "R1000 (17 Packs)", Model = "M4864P6B", Energy = 56, VoltageRange = "714 - 1,000", Dimension = "520 x 2,200 x 425", ImagePath = "/images/battery1.png", Category = "ShortDuration" },
                new BatteryModel { Id = 7, Name = "R1000 (17 Packs)", Model = "M48128P6B", Energy = 112.1, VoltageRange = "714 - 1,000", Dimension = "520 x 2,200 x 655", ImagePath = "/images/battery1.png", Category = "ShortDuration" }
            };

            var battery = batteryModels.Find(b => b.Id == id);
            if (battery == null)
            {
                return NotFound(); // 배터리가 없을 경우 404 페이지
            }

            return View(battery); // 배터리 데이터를 Detail 뷰로 전달
        }
    }
}
