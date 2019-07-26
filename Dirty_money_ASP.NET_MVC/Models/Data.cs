using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dirty_money_ASP.NET_MVC.Models
{
    public class Data
    {
        //[RegularExpression("^[0-9]*$", ErrorMessage = "Please enter valid date.")]
        //[DataType(DataType.PhoneNumber, ErrorMessage = "Not a number")]
        public double tb440kg { get; set; }
        public double tb440rate { get; set; }
        public double tb460kg { get; set; }
        public double tb460rate { get; set; }
        public double tb560kg { get; set; }
        public double tb560rate { get; set; }
        public double tb601kg { get; set; }
        public double tb601rate { get; set; }
        public double tb1000kg { get; set; }
        public double tb1000rate { get; set; }
        public double tb600colorkg { get; set; }
        public double tb600colorrate { get; set; }
        public double tb1000colorkg { get; set; }
        public double tb1000colorrate { get; set; }
        public double tb1000ex4kg { get; set; }
        public double tb1000ex4rate { get; set; }
        public double tb1000ex4colorkg { get; set; }
        public double tb1000ex4colorrate { get; set; }
        public double tb1500fbrkg { get; set; }
        public double tb1500fbrrate { get; set; }
        public double tb1500fbrcolorkg { get; set; }
        public double tb1500fbrcolorrate { get; set; }
        public double tbCash1 { get; set; }
        public double tbCash2 { get; set; }
        public double tbCash3 { get; set; }
        public double tbCash4 { get; set; }
        public double tbCash5 { get; set; }
        public double tbCash6 { get; set; }
        public double tbCash7 { get; set; }
        public double tbCash8 { get; set; }
        public double tbCash9 { get; set; }
        public double tbCash10 { get; set; }
        public double tbCash11 { get; set; }
        public double Total { get; set; }
    }
}