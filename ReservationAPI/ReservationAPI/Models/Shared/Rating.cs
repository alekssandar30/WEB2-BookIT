﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationAPI.Models.Shared
{
    public class Rating
    {
        public long Id { get; set; }
        public double Rate { get; set; }
        public string UserEmail { get; set; }
        public long? CarId { get; set; }
        public long? CarCompanyId { get; set; }

    }
}
