﻿namespace GeminiAPIs.Models
{
    public class GeminiAPIModels
    {
        public class Root
        {
            public List<Content> contents { get; set; }
        }

        public class Content
        {
            public List<Part> parts { get; set; }
        }

        public class Part
        {
            public string text { get; set; }
        }
    }
}
