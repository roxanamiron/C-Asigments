﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments7
{
   public class Table
    {
        public int Width { get; set; }
        public int Height { get; set; }


        public Table(int width,int height)
        {
            Width = width;
            Height = height;
        }

        public Table()
        {
        }

        public virtual void ShowData()
        {
            Console.WriteLine("The width is {0} and the height is {1} of the table ",Width,Height);
        }
        
    }
}
