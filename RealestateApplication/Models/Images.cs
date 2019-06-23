using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RealestateApplication.Models.Images
{
    public class Images
    {
        public int Id { get; set; }
        public byte[] Image { get; set; }
        public int IdOfCorrespondingUser { get; set; }
    }
}
