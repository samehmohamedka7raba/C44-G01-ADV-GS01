using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advainced.Example1
{
    internal class Employy
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


        #region Override 
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




        #region Is 
        //public override bool Equals(object? obj)
        //{
        //    if (obj is null) return false;
        //    else if (obj is Employy employy)
        //        return this.Id == employy.id && this.Name == employy.Name && this.Salary == employy.Salary ;


        //}
        #endregion


        #region As
        public override bool Equals(object? obj)
        {
            Employy? employy = obj as Employy;
            if(employy is null)return false;
            else
                return this.Id == employy.id && this.Name == employy.Name && this.Salary == employy.Salary;


        }

        #endregion




    }
}
