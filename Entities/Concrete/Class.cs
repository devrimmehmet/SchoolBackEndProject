using Core.Entities;
using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Class : IEntity
    {       
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        
    }
}
