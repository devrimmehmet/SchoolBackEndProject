using Core.Entities;
using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class StudentStatus : IEntity
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string Description { get; set; }
    }
}
