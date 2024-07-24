﻿namespace testApi.Models.Domain
{
    public class Walk
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double LengthInKm { get; set; }

        public string? WalkImageUrl { get; set; }


        public Guid DifficultyId { get; set; }

        public Guid RegionId { get; set; }


        // navigation Properties

        public Difficulty Difficulty { get; set; }
    }
}
