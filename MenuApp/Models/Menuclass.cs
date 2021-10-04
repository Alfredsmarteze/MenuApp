using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuApp.Models
{


    public class Menuclass
    {



        //public Menuclass()
        //{
        //    ParentNames = new List<ParentList>()
        //    {
        //        new ParentList{ Text ="Menu1", Value=1},
        //        new ParentList{ Text ="Menu2", Value=2},
        //        new ParentList{ Text ="Menu3", Value=3},
        //        new ParentList{ Text ="Menu4", Value=4},
        //        new ParentList{ Text ="Menu5", Value=5},
        //        new ParentList{ Text ="Menu6", Value=6}
        //    };
        //}



        public int Id { get; set; }

       // public List<ParentList> ParentNames { get; set; }

        public Guid IdMenu { get; set; }

        public string IdApplication { get; set; }

        public string Controller { get; set; }

        public string Action { get; set; }

        public string Area { get; set; }

        public Guid ParentId { get; set; }

        public string IdParent { get; set; }

        public bool HasChildren { get; set; }

        public int DisplayOrder { get; set; }

        public string Icon { get; set; }

        public string MenuText { get; set; }

        public string DataRoute { get; set; }

        public bool IsMenu { get; set; }

     

    }
}
