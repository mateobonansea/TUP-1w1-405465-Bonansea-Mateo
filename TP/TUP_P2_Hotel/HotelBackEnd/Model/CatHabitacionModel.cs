﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.Model
{
    public class CatHabitacionModel
    {
        public int Id { get; set; }
        public string Descri { get; set; }
        public decimal Precio { get; set; }
        public CatHabitacionModel()
        {
            Id = 0;
            Descri = string.Empty;
            Precio = 0;
        }
    }
}
