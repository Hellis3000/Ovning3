using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning3

{
    public abstract class UserError
    {
        public virtual void UEMessage()
        {
           
        }



    }
    class NumericalInputError : UserError
    {

        public override void UEMessage()
        {
            Console.WriteLine("You tried to use a numeric input in a text only field. This fired an error!");
        }


    }

    class TextInputError : UserError
    {
        public override void UEMessage()
        {
            Console.WriteLine("You tried to use a text input in a numeric only field. This fired an error");
        }

    }
    class SwagInputError : UserError
    {
        public override void UEMessage()
        {
            Console.WriteLine("You have no swag. This fired an error");
        }

    }

    class UserInputError : UserError
    {
        public override void UEMessage()
        {
            Console.WriteLine("Wrong Person, Wrong Time. Error.");
        }

    }

    class GeneralError : UserError
    {
        public override void UEMessage()
        {
            Console.WriteLine("We have no idea what happened here, please contact our underpayed support people");
        }

    }
}


