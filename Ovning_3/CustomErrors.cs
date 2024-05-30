using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_3
{
    public class CustomError1 : UserError
    {
        public override string UEMessage()
        {
            return "Custom error 1 occurred!";
        }
    }

    public class CustomError2 : UserError
    {
        public override string UEMessage()
        {
            return "Custom error 2 occurred!";
        }
    }

    public class CustomError3 : UserError
    {
        public override string UEMessage()
        {
            return "Custom error 3 occurred!";
        }
    }


}
