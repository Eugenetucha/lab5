using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Models;
public class RomanNumberException : Exception
{
    public override string Message
    {
        get
        {
            return "значение меньше либо равно нулю";
        }
    }
}