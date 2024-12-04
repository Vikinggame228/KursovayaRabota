using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    internal class Users
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
    }

    internal class Inventory_price
    {
        public int ID { get; set; }
        public string? type {  get; set; }
        public int? cost { get; set; }
        public string? count { get; set; }
    }
    internal class Transport
    {
        public int ID { get; set; }
        public string? Type { get; set; }
        public int? cost { get; set; }
        public string? place { get; set; }
    }
    internal class Office_equipment
    {
        public int ID { get; set; }
        public string? Type { get; set; }
        public int? cost { get; set; }
    }
    internal class Realestate 
    {
        public int ID { get; set; }
        public string? type { get; set; }
        public string? address { get; set; }
        public string? area { get; set; }
        public int? cost { get; set; }
    }
}