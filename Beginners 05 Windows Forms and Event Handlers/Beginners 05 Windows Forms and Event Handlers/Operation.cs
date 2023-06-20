using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginners_05_Windows_Forms_and_Event_Handlers
{
    public class Operation
    {
        public string LeftSide {get;set;}
        public string RightSide { get; set;}

        //El tipo de operación a llevar a cabo
        public OperationType OperationType { get; set;}

        public Operation InnerOperation { get; set;}

        //Constructor
        public Operation()
        {
            this.LeftSide = string.Empty;
            this.RightSide = string.Empty;
        }
    }
}
