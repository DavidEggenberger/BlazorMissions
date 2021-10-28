using System;

namespace BlazorMissions.Model
{
    public class Agent
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string Name { get; set; }
        public string Mission { get; set; }
        public bool Shown { get; set; }
    }
}
