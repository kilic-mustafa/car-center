using System.Runtime.CompilerServices;
using CarCenter.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarCenter.Controllers
{
    public class CarController : Controller
    {
        private static readonly List<CarModel> _cars = new();

        private List<string> Brands = new List<string>
        {
            "Aion", "Alfa Romeo", "Alpine", "Anadol", "Arora", "Aston Martin", "Audi",
            "Bentley", "BMW", "Buick", "BYD", "Cadillac", "Chery", "Chevrolet", "Chrysler",
            "Citroen", "Cupra", "Dacia", "Daewoo", "Daihatsu", "Dodge", "DS Automobiles",
            "Eagle", "Ferrari", "Fiat", "Ford", "Geely", "Honda", "Hyundai", "I-GO",
            "Ikco", "Infiniti", "Jaguar", "Jiayuan", "Kia", "Kuba", "Lada", "Lamborghini",
            "Lancia", "Leapmotor", "Lexus", "Lincoln", "Lotus", "Luqi", "Marcos", "Maserati",
            "Mazda", "McLaren", "Mercedes-Benz", "MG", "Micro", "Mini", "Mitsubishi", "Morgan",
            "Nieve", "Niğmer", "Nissan", "Opel", "Orti", "Peugeot", "Plymouth", "Polestar",
            "Pontiac", "Porsche", "Proton", "Rainwoll", "Reeder", "Regal Raptor", "Relive",
            "Renault", "RKS", "Rolls-Royce", "Rover", "Saab", "Seat", "Skoda", "Smart",
            "Subaru", "Suzuki", "Tata", "Tesla", "The London Taxi", "Tofaş", "TOGG", "Toyota",
            "Vanderhall", "Volkswagen", "Volta", "Volvo", "XEV", "Yuki", "Acura", "DFM",
            "DFSK", "Forthing", "Foton", "GMC", "Hongqi", "Hummer", "Isuzu", "Jaecoo", "Jeep",
            "Lynk & Co", "Mahindra", "Mercury", "Oldsmobile", "Poyraz", "Seres", "Skywell",
            "SsangYong", "SWM", "TOGG", "Voyah", "Abush", "Aeon", "AJP", "Altai", "Apachi",
            "Apec", "Aprilia", "Ariic", "Asya", "Bajaj", "Banhe", "Baotian", "Barossa",
            "Belderia", "Benda Motor", "Benelli", "Beta", "Better", "Bianchi", "Bisan", "Boom",
            "Borelli Ledow", "Brixton", "BSA", "BuMoto/Jinling", "Cagiva", "Can-Am", "Caza",
            "CFmoto", "Cosmopolitan", "CRN", "CSN Motor", "Çelik Motor", "Daelim", "Dayun",
            "Delta Motorcycle", "Derbi", "Dofern", "Doohan", "Dorado", "Ducati", "Enbest",
            "Falcon", "Fantic", "FCM", "Fosti", "FYM", "GasGas", "Gilera", "Haojin", "Haojue",
            "Harley-Davidson", "Hazey Türk", "Hero", "Husaberg", "Husqvarna", "Hyosung", "Indian",
            "Işıldar", "Italjet", "IZH", "Jawa", "Jiajue", "Jinlun", "Jonway", "JPN Motor",
            "Kadırga", "Kamax", "Kangda", "Kanuni", "Kawasaki", "Kayo Moto", "Keeway", "Kimmi",
            "Kinetic", "Kinroad", "Kove", "Kral Motor", "KTM", "Kuba", "Kymco", "Lambretta",
            "Leksas", "Lifan", "LML", "Malaguti", "Megelli", "Meka Motor", "Memnun", "Minsk",
            "Mobylette", "Modenas", "Mondial", "Monero", "Moto Guzzi", "Motolux", "Moto Morini",
            "Motoran", "Motozeus", "Muravey", "Musatti", "Mutt", "MV Agusta", "MZ", "Nanok",
            "Ohvale", "OMİ", "PGO", "Piaggio", "Pioneer", "Presto", "Puch", "QJ", "Qooder",
            "Ramzey", "Renda", "Revolt", "Rewaco", "Rialli", "Rieju", "RKN", "RMG Moto Gusto",
            "Royal Alloy", "Royal Enfield", "Rutec", "Salcano", "Sam Motor", "Seger", "SFM",
            "Shenke", "Sherco", "Shinari", "Ski-doo", "Skygo", "Skyjet", "Skyteam", "Spada",
            "Stmax", "SYM", "Taktas Motor", "Telstar", "TGB", "Titan", "TM Racing", "Togo",
            "Triumph", "Truva", "TT", "TVS", "UğurSam", "UM", "Vespa", "Victory", "Vitello",
            "Voge", "Wuxi", "Xingyue", "Xintian", "Yiben", "Yiying", "Yuan", "Zealsun", "Zelsun",
            "Zongshen", "Zontes", "Zorro"
        };

        private List<string> Colours = new List<string>
            {
                "Black ⚫",
                "White ⚪",
                "Red 🔴",
                "Blue 🔵",
                "Green 🟢",
                "Yellow 🟡",
                "Orange 🟠",
                "Purple 🟣",
                "Brown 🟤",
                "Pink 🩷",
                "Gray ⚪",
                "Silver 🔘"
            };
            
            private List<string> FuelTypes = new List<string>
            {
                "Petrol ⛽",
                "Diesel 🛢️",
                "Electric ⚡",
                "LPG 💨",
                "Hybrid 🔋"
            };
            private List<string> GearTypes = new List<string>
            {
                "Manual",
                "Automatic",
                "Semi-Automatic"
            };
            private List<string> Tractions= new List<string>
            {
                "FWD (Front-Wheel Drive)",
                "RWD (Rear-Wheel Drive)",
                "AWD / 4WD",
                "4x2",
                "4x4"
            };
            private List<string> VehicleTypes = new List<string>
            {
                "Car 🚗",
                "SUV 🚙",
                "Sports Car 🏎️",
                "Truck 🚚",
                "Lorry 🚛",
                "Van 🚐",
                "Motorcycle 🏍️",
                "Scooter 🛵",
                "Tractor 🚜",
                "Taxi 🚕",
                "Fire Truck 🚒",
                "Bus 🚌"
            };

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Brands = Brands?.OrderBy(b => b).ToList() ?? new List<string>();
        
            var Years = Enumerable.Range(1950, 2025 - 1950 + 1)
                                  .Reverse()               
                                  .ToList();
            ViewBag.Years = Years;

            ViewBag.Colours = Colours;

            ViewBag.FuelTypes = FuelTypes;

            ViewBag.GearTypes = GearTypes;

            ViewBag.Tractions = Tractions;

            ViewBag.VehicleTypes = VehicleTypes;

            var NumberOfDoors = Enumerable.Range(0, 100 - 0 + 1).ToList();
            ViewBag.NumberOfDoors = NumberOfDoors;

            return View(new CarModel { RegistrationDate = DateTime.Today });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CarModel car)
        {
            if (!ModelState.IsValid)
                return View(car);

            car.Id = _cars.Count > 0 ? _cars.Max(c => c.Id) + 1 : 1;
            _cars.Add(car);

            TempData["Success"] = $"Car '{car.Brand} {car.Model}' added successfully.";
            return RedirectToAction(nameof(List));
        }

        [HttpGet]
        public IActionResult List()
        {
            return View(_cars);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var car = _cars.FirstOrDefault(c => c.Id == id);
            if (car != null)
            {   
                _cars.Remove(car);
                TempData["Success"] = $"Car '{car.Brand} {car.Model}' deleted successfully.";
            }
            return RedirectToAction(nameof(List));
        }

        [HttpGet]
        public IActionResult Detail(int Id)
        {
            var car = _cars.FirstOrDefault(c => c.Id == Id);
            if (car == null)
            {
                ViewBag.Message = "Car not found!";
                return View();
            }
            ViewBag.Car = car;
            return View(car);
        }


        [HttpGet]
        public IActionResult Update(int id)
        {
            var car = _cars.FirstOrDefault(c => c.Id == id);
            if (car == null)
            {
                TempData["Error"] = "Car not found!";
                return RedirectToAction(nameof(List));
            }

            ViewBag.Brands = Brands?.OrderBy(b => b).ToList() ?? new List<string>();
        
            var Years = Enumerable.Range(1950, 2025 - 1950 + 1)
                                  .Reverse()               
                                  .ToList();
            ViewBag.Years = Years;

            ViewBag.Colours = Colours;

            ViewBag.FuelTypes = FuelTypes;

            ViewBag.GearTypes = GearTypes;

            ViewBag.Tractions = Tractions;

            ViewBag.VehicleTypes = VehicleTypes;

            var NumberOfDoors = Enumerable.Range(0, 100 - 0 + 1).ToList();
            ViewBag.NumberOfDoors = NumberOfDoors;

            return View(car); 
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(CarModel updatedCar)
        {
            var existingCar = _cars.FirstOrDefault(c => c.Id == updatedCar.Id);
            if (existingCar == null)
            {
                ViewBag.Message = "Car not found!";
                return View("Update", updatedCar);
            }   

            existingCar.Brand = updatedCar.Brand;
            existingCar.Model = updatedCar.Model;
            existingCar.Year = updatedCar.Year;
            existingCar.Kilometers = updatedCar.Kilometers;
            existingCar.Price = updatedCar.Price;
            existingCar.Colour = updatedCar.Colour;
            existingCar.FuelType = updatedCar.FuelType;
            existingCar.GearType = updatedCar.GearType;
            existingCar.EnginePower = updatedCar.EnginePower;
            existingCar.EngineDisplacement = updatedCar.EngineDisplacement;
            existingCar.Traction = updatedCar.Traction;
            existingCar.VehicleType = updatedCar.VehicleType;
            existingCar.NumberOfDoors = updatedCar.NumberOfDoors;
            existingCar.RegistrationDate = updatedCar.RegistrationDate;

            TempData["Success"] = $"Car '{updatedCar.Brand} {updatedCar.Model}' updated successfully.";
            return RedirectToAction(nameof(List));
        }
    }
}