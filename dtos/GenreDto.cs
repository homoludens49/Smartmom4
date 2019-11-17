using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Smartmom4.Models;


namespace Smartmom4.dtos
{
    public class GenreDto
    {
        public byte Id { get; set; }
        public string Name { get; set; }
    }
}