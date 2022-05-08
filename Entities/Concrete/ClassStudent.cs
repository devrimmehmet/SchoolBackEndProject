using Core.Entities;
using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class ClassStudent : IEntity
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public int StudentId { get; set; }
    }
}
