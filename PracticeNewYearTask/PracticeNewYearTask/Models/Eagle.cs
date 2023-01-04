using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeNewYearTask.Models
{
    internal class Eagle:Bird
    {
        public int Speed { get; set; }

        public virtual void Sound()
        {
            Console.WriteLine("Eagle sound");
        }
    }
}
