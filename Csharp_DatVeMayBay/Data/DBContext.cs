using Csharp_DatVeMayBay.Models.Domain;
using Csharp_DatVeMayBay.Models.DTO;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace Csharp_DatVeMayBay.Data
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions options): base(options) {

        }

        public DbSet<Airport> Airports { get; set; }
        public DbSet<Airline> Airlines { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Creditcard> Creditcards { get; set; }

        public DbSet<UserVerification> UserVerifications { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           /* List<Airport> Airports = new List<Airport>();
            var NOIBAIAIRPORT = new Airport { AirportId = 1, AirportName = "Noi Bai International Airport", AirportLocation = "Hanoi, Vietnam", AirportCode = "HAN" };
            var TSNAIRPORT = new Airport { AirportId = 2, AirportName = "Tan Son Nhat International Airport", AirportLocation = "Ho Chi Minh City, Vietnam", AirportCode = "SGN" };
            var DNAIRPORT = new Airport { AirportId = 3, AirportName = "Da Nang International Airport", AirportLocation = "Da Nang, Vietnam", AirportCode = "DAD" };
            var CRAIRPORT = new Airport { AirportId = 4, AirportName = "Cam Ranh International Airport", AirportLocation = "Khanh Hoa, Vietnam", AirportCode = "CXR" };
            var PHUBAIAIRPORT = new Airport { AirportId = 5, AirportName = "Phu Bai International Airport", AirportLocation = "Hue, Vietnam", AirportCode = "HUI" };
            Airports.Add(NOIBAIAIRPORT);
            Airports.Add(TSNAIRPORT);
            Airports.Add(DNAIRPORT);
            Airports.Add(CRAIRPORT);
            Airports.Add(PHUBAIAIRPORT);
*/
            modelBuilder.Entity<Airport>().HasData(
                new Airport { AirportId = 1, AirportName = "Noi Bai International Airport", AirportLocation = "Hanoi, Vietnam", AirportCode = "HAN" },
                new Airport { AirportId = 2, AirportName = "Tan Son Nhat International Airport", AirportLocation = "Ho Chi Minh City, Vietnam", AirportCode = "SGN" },
                new Airport { AirportId = 3, AirportName = "Da Nang International Airport", AirportLocation = "Da Nang, Vietnam", AirportCode = "DAD" },
                new Airport { AirportId = 4, AirportName = "Cam Ranh International Airport", AirportLocation = "Khanh Hoa, Vietnam", AirportCode = "CXR" },
                new Airport { AirportId = 5, AirportName = "Phu Bai International Airport", AirportLocation = "Hue, Vietnam", AirportCode = "HUI" }
            );
            /* modelBuilder.Entity<Airport>().HasData(Airports);
             List<Airline> Airlines = new List<Airline>();
             var VietnamAirlines = new Airline { AirlineId = 1, AirlineName = "Vietnam Airlines", AirlineLogo = "./img/airlines/VietnamAirlinesLogo.png", AirlineCode = "VN" };
             var JetstarPacific = new Airline { AirlineId = 2, AirlineName = "Jetstar Pacific", AirlineLogo = "./img/airlines/JetStarLogo.png", AirlineCode = "BL" };
             var VietJetAir = new Airline { AirlineId = 3, AirlineName = "VietJet Air", AirlineLogo = "./img/airlines/VietjetAirLogo.png", AirlineCode = "VJ" };
             var BambooAirways = new Airline { AirlineId = 4, AirlineName = "Bamboo Airways", AirlineLogo = "./img/airlines/BambooAirwaysLogo.png", AirlineCode = "QH" };
             var PacificAirlines = new Airline { AirlineId = 5, AirlineName = "Pacific Airlines", AirlineLogo = "./img/airlines/PacificAirlinesLogo.png", AirlineCode = "PA" };
             Airlines.Add(VietnamAirlines);
             Airlines.Add(JetstarPacific);
             Airlines.Add(VietJetAir);
             Airlines.Add(BambooAirways);
             Airlines.Add(PacificAirlines);*/

            modelBuilder.Entity<Airline>().HasData(
               new Airline { AirlineId = 1, AirlineName = "Vietnam Airlines", AirlineLogo = "./img/airlines/VietnamAirlinesLogo.png", AirlineCode = "VN" },
               new Airline { AirlineId = 2, AirlineName = "Jetstar Pacific", AirlineLogo = "./img/airlines/JetStarLogo.png", AirlineCode = "BL" },
               new Airline { AirlineId = 3, AirlineName = "VietJet Air", AirlineLogo = "./img/airlines/VietjetAirLogo.png", AirlineCode = "VJ" },
               new Airline { AirlineId = 4, AirlineName = "Bamboo Airways", AirlineLogo = "./img/airlines/BambooAirwaysLogo.png", AirlineCode = "QH" },
               new Airline { AirlineId = 5, AirlineName = "Pacific Airlines", AirlineLogo = "./img/airlines/PacificAirlinesLogo.png", AirlineCode = "PA" }
            );
          /*  modelBuilder.Entity<Airline>().HasData(Airlines);*/

            User admin = new User { UserId = 1, UserEmail = "admin@gmail.com", FirstName = "Admin", LastName = "", Address = "", Dob = new DateTime(2003, 12, 7), PhoneNumber = "" };
            Account acc = new Account { UserEmail = "admin@gmail.com", Password = BCrypt.Net.BCrypt.EnhancedHashPassword("admin", 13), Enable = true, UserId = 1, Verified = true };
            User user = new User {UserId = 2, UserEmail = "ngvhao@gmail.com", FirstName = "Nguyễn Văn", LastName = "Hào", Address = "Huế, Việt Nam", Dob = new DateTime(2003, 12, 7), PhoneNumber = "0777777777" };
            Account acc2 = new Account { UserEmail = "ngvhao@gmail.com", Password = BCrypt.Net.BCrypt.EnhancedHashPassword("123",13), Enable = true , UserId = 2, Verified = true };

            modelBuilder.Entity<User>().HasData(admin);
            modelBuilder.Entity<Account>().HasData(acc);
            modelBuilder.Entity<User>().HasData(user);
            modelBuilder.Entity<Account>().HasData(acc2);


            var ListFlightAndSeat = GenerateSampleFlights(50);

            modelBuilder.Entity<Flight>().HasData(ListFlightAndSeat.Item1);

            modelBuilder.Entity<Seat>().HasData(ListFlightAndSeat.Item2);

        }
        public (List<Flight>, List<Seat>) GenerateSampleFlights(int count)
        {
            var flights = new List<Flight>();
            var seats = new List<Seat>();
            var random = new Random();
            var airlineIds = Enumerable.Range(1, 5).ToList();
            var countValue = 1;
            for (int i = 1; i <= count; i++)
            {
                var randomAirlineId = airlineIds[random.Next(0, airlineIds.Count)];
                /*var Airline = new Airline();
                foreach (var airline in Airlines)
                {
                    if (airline.AirlineId == randomAirlineId)
                    {
                        Airline = airline;
                        break;
                    }
                }
                Console.WriteLine(Airline.AirlineId);
                *//*Gán cố định nơi đi và nơi đến*//*
                Airport DepartureAirport = Airports.Find(airport => airport.AirportId == 1);
                Airport ArrivalAirport = Airports.Find(airport => airport.AirportId == 2);*/

                var departureTime = DateTime.Today.AddDays(random.Next(0, 5)).AddHours(random.Next(0, 24)).AddMinutes(random.Next(0, 60)).AddSeconds(0);// Tạo thời gian đi ngẫu nhiên trong khoảng từ 00:00 đến 23:59
                var flight = new Flight
                {
                    FlightId = i,
                    AirlineId = randomAirlineId, // Chọn một số ngẫu nhiên từ 1 đến 5 cho airline_id
                    DepartureAirportId = 1, // Sử dụng airport_id của sân bay đi cố định
                    ArrivalAirportId = 2, // Sử dụng airport_id của sân bay đến cố định
                    DepartureDatetime = departureTime,
                    ArrivalDatetime = departureTime.AddHours(random.Next(1, 8)).AddMinutes(random.Next(0, 60)).AddSeconds(0),
                    EconomyPrice = random.Next(800000, 1500000), // Giá vé kinh tế ngẫu nhiên từ 800,000 đến 1,500,000
                    BussinessPrice = random.Next(2000000, 3500000),// Giá vé hạng thương gia ngẫu nhiên từ 2,000,000 đến 3,500,000
                };
                flights.Add(flight);

             /*   Thêm ghế phụ thuộc*/
                for (char seatRow = 'A'; seatRow <= 'F'; seatRow++)
                {
                    for (int seatColumn = 1; seatColumn <= 6; seatColumn++)
                    {
                        var seat = new Seat
                        {
                            SeatId = countValue,
                            FlightId = flight.FlightId,
                            SeatColumn = seatColumn,
                            SeatRow = seatRow,
                            Status = Models.Enums.SeatStatus.Available
                        };
                        seats.Add(seat);
                        countValue++;
                    }
                }
            }
            return (flights, seats);
        }

    }

}
