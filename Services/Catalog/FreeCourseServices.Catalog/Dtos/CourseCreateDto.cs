﻿using System;

namespace FreeCourseServices.Catalog.Dtos
{
    public class CourseCreateDto
    {
        public string UserId { get; set; }
        public string CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public decimal Price { get; set; }
        public FeatureDto Feature { get; set; }
    }
}