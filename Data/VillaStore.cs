﻿using RestfulAPI.Models.Dto;

namespace RestfulAPI.Data
{
    public class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>
        {
            new VillaDTO { Id = 1, Name = "Pool View", Sqft=100, Occupancy=4 },
            new VillaDTO { Id = 2, Name = "Beach Views", Sqft=300, Occupancy=3 }
        };
    }
}
