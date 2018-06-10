﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Model
{
    public class Academic
    {
        public int AcademicId { get; set; }
        public string Title { get; set; }
        
        public ICollection<Teacher> Teachers { get; set; }
    }
}
