using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MassTransit;
using MassTransit.MessageData.Values;

namespace ConsoleApp2test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var xxxx = 123;
            var zz = new TestAbc();
            var document = new PutMessageData<string>("asdf");
            zz.Test = document;
            var yy = zz.Test.Value;
            var zzz123 = yy.Result;

        }
    }

    public class TestAbc
    {
        public MessageData<string> Test { get; set; }
    }
}