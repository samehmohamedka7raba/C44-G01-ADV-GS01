using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advainced.Example1
{
    internal struct Employy
    {
        #region Ctor
        public Employy(int id, decimal salary, string name)
        {
            Id = id;
            Salary = salary;
            Name = name;

        }
        #endregion

        #region Properties
        public int Id {  get; set; }
        public decimal Salary { get; set; }
        public string Name { get; set; }
        #endregion

        #region Override ToString
        public override string ToString()
        {
            return $"Id : {Id} , Name : {Name} , Salary : {Salary}";
        }
        #endregion


        #region
        public static bool operator == (Employy left, Employy right)
        {
           // return left.Id ==right.Id && left.Salary ==right.Salary && left.Name ==right.Name ;
           return left.Equals(right) ;
        }

        public static bool operator != (Employy left, Employy right)
        {
            //return left.Id != right.Id || left.Salary != right.Salary || left.Name != right.Name;
                return !left.Equals(right) ;
        }
        #endregion




    }
}
