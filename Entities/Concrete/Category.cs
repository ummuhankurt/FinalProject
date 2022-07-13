﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    // Çıplak class kalmasın.
    //IEntity'i implemente eden class'lar neydi? veritabanı tablosuydu. O zaman Category bir veritabanı tablosudur.
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
