using Csharp_DatVeMayBay.Models.Domain;
using Csharp_DatVeMayBay.Services.EmailService;

namespace Csharp_DatVeMayBay.Template_Method
{
    public class RoundTripBookingNotification : EmailBookingNotification
    {
        public RoundTripBookingNotification(Booking Booking, IEmailService emailService) : base(Booking, emailService)
        {
        }

        protected override string PrepareSubjectValue()
        {
            string subject = "[Starline] Round-Trip Ticket Information";
            return subject;
        }

        protected override string PrepareBodyValue()
        {
            string body = @"
                <html>
                <body>
                    <div style='border:1px solid black; padding:10px; width:500px;'>
                        <h2 style='color:#8DD3BB;'>Starline Airline</h2>
                        <p><strong>Passenger Name:</strong> " + Booking.User.FirstName + " " + Booking.User.LastName + @"</p>
                        <h3>Outbound Flight</h3>
                        <p><strong>TicketId:</strong> " + Booking.Tickets.First().TicketId + @"</p>
                        <p><strong>Flight Date:</strong> " + Booking.Flight.DepartureDatetime.ToString("MM/dd/yyyy") + @"</p>
                        <p><strong>Flight Time:</strong> " + Booking.Flight.DepartureDatetime.ToString("hh:mm tt") + @"</p>
                        <p><strong>Seat:</strong> " + Booking.Tickets.First().Seat.SeatRow + Booking.Tickets.First().Seat.SeatColumn + @"</p>
                        <p><strong>From:</strong> " + Booking.Flight.DepartureAirport.AirportName + "_" + Booking.Flight.DepartureAirport.AirportLocation + @"</p>
                        <p><strong>To:</strong> " + Booking.Flight.ArrivalAirport.AirportName + "_" + Booking.Flight.ArrivalAirport.AirportLocation + @"</p>
                        <p><strong>Ticket Class:</strong> " + Booking.Tickets.First().TicketClass + @"</p>
                        <p><strong>Airline:</strong> " + Booking.Flight.Airline.AirlineName + @"</p>
                        <p><strong>Airbus:</strong>" + " Airbus" + Booking.Flight.FlightId + @"</p>
                        <h3>Return Flight</h3>
                        <p><strong>TicketId:</strong> " + Booking.Tickets.Last().TicketId + @"</p>
                        <p><strong>Flight Date:</strong> " + Booking.FlightReturn.DepartureDatetime.ToString("MM/dd/yyyy") + @"</p>
                        <p><strong>Flight Time:</strong> " + Booking.FlightReturn.DepartureDatetime.ToString("hh:mm tt") + @"</p>
                        <p><strong>Gate:</strong> B7</p>
                        <p><strong>Seat:</strong> " + Booking.Tickets.Last().Seat.SeatRow + Booking.Tickets.First().Seat.SeatColumn + @"</p>
                        <p><strong>From:</strong> " + Booking.Flight.ArrivalAirport.AirportName + "_" + Booking.Flight.ArrivalAirport.AirportLocation + @"</p>
                        <p><strong>To:</strong> " + Booking.FlightReturn.DepartureAirport.AirportName + "_" + Booking.Flight.DepartureAirport.AirportLocation + @"</p>
                        <p><strong>Ticket Class:</strong> " + Booking.Tickets.Last().TicketClass + @"</p>
                        <p><strong>Airline:</strong> " + Booking.FlightReturn.Airline.AirlineName + @"</p>
                        <p><strong>Airbus:</strong> " + "Airbus" + Booking.FlightReturn.FlightId + @"</p>
                    </div>
                </body>
                </html>";

            return body;
        }
    }
}
