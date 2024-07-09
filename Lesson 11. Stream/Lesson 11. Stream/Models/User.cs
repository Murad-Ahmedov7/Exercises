﻿
namespace Lesson_11._Stream.Models
{
    internal class User
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public DateTime CurrentDate { get; set; }
        public double Norm { get => Weight / 20; }
        public double CurrentLitr { get; set; }
        public List<HistoryItem> History { get; set; } = new List<HistoryItem>();


    }
}
