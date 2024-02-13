﻿using Code;
using System;

namespace Code-First
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var student = new Student() { StudentName = "Faisal" };

                ctx.Students.Add(student);
                ctx.SaveChanges();
            }
            Console.WriteLine("Demo completed.");
            Console.ReadLine();
        }
    }
}