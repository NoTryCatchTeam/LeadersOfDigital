﻿using DataModels.Responses.Enums;

namespace Api.Data.Models
{
    public class Disability
    {
        public int DisabilityId { get; set; }
        public DisabilityType DisabilityType { get; set; }

        public int BarrierId { get; set; }
        public Barrier Barrier { get; set; }
    }
}