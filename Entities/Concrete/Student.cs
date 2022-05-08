using Core.Entities;
using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Student : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IdentityNumber { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public byte[] PaswordSalt { get; set; }
        public byte[] PaswordHash { get; set; }
        public bool IsActive { get; set; }
    }
}
