﻿using System;
using System.Collections.Generic;

namespace TTTN.Models
{
    public class KHUYENMAI
    {
        public KHUYENMAI(CTKM ctkm)
        {
            CTKM = ctkm;
        }

        public KHUYENMAI()
        {
            
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime? NgayBatDau { get; set; }
        
        public DateTime? NgayKetThuc { get; set; }

        public string LyDoKM { get; set; }

        public NHANVIEN NVTaoKM { get; set; }

        public CTKM CTKM { get; set; }


    }
}