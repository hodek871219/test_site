using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Navistar.Model.common
{
    [NotMapped]
    public class Entity
    {
        public Guid Id { get; set; }
    }
}
