﻿using BigSchool01.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BigSchool01.ViewModels
{
    public class CourseViewModel
    {


        [Required(ErrorMessage = "Không Được Bỏ Trống")]
        [StringLength(250, ErrorMessage = " Không vượt qua 100 kí tự")]
        public string Place { get; set; }
        [Required(ErrorMessage = "Không Được Bỏ Trống")]
        [StringLength(250, ErrorMessage = " Không vượt qua 100 kí tự")]
        public string Date { get; set; }
        [Required(ErrorMessage = "Không Được Bỏ Trống")]
        [StringLength(250, ErrorMessage = " Không vượt qua 100 kí tự")]
        public string Time { get; set; }
        [Required]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }

       
       

        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1} ", Date, Time));
        }
    }
}