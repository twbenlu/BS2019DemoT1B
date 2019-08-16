using System;
using System.Collections.Generic;

namespace Oil.Models
{
    public partial class Employee
    {
        public Employee()
        {
            DeliveryCar = new HashSet<DeliveryCar>();
            TicketEmployee = new HashSet<Ticket>();
            TicketViolationEmployee = new HashSet<Ticket>();
        }

        public Guid EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string IdentityCard { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public Guid? JobTitle { get; set; }
        public DateTime? StartDate { get; set; }
        public Guid? Station { get; set; }
        public DateTime? EndDate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public JobTitle JobTitleNavigation { get; set; }
        public Station StationNavigation { get; set; }
        public ICollection<DeliveryCar> DeliveryCar { get; set; }
        public ICollection<Ticket> TicketEmployee { get; set; }
        public ICollection<Ticket> TicketViolationEmployee { get; set; }
    }
}
