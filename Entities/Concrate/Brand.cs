﻿using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrate
{
     public class Brand:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
