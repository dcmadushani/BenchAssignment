using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.Common.DTO
{
    public class CustomerDto
    {
        /// <summary>
        /// gets and sets Customer Id
        /// </summary>
        public long CustomerId { get; set; }

        /// <summary>
        /// Gets and sets Firstname
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets and sets Lastname
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets and sets Phone
        /// </summary>
        public int? Phone { get; set; }

        /// <summary>
        /// Gets and sets Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets and sets Username
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets and sets Password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets and sets Registration date
        /// </summary>
        public DateTime? RegistedDate { get; set; }

        public ICollection<AddressDto> CustomerAddress { get; set; }

    }
}
