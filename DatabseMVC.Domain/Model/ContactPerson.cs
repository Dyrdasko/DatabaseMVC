﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseMVC.Domain.Model
{
    public class ContactPerson
    {

        public int Id { get; set; }

        /// <summary>
        /// First name of person to contact
        /// </summary>
        [MaxLength(50)]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of person to contact
        /// </summary>
        [MaxLength(100)]
        public string LastName { get; set; }

        /// <summary>
        /// Phone number of person to contact
        /// </summary>
        [MaxLength(13)]
        public string PhoneNumber { get; set; }

        [InverseProperty("FirstContactPerson")]
        public virtual ICollection<Contractor> FirstContractor { get; set; }

        [InverseProperty("SecondaryContactPerson")]
        public virtual ICollection<Contractor>? SecondContractor { get; set; }
    }
}
