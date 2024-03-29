﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass.Model
{
    [Table("Product_images")]

    public class Product_image
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Product_id { get; set; }
        public string Image { get; set; }


        public class Product_option
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Size { get; set; }
            [Required(ErrorMessage = "Chọn size không được để rỗng !")]

            public string Description { get; set; }
            public string Type { get; set; }

        }
    }
}
