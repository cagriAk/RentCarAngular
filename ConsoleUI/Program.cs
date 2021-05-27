﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager(new EfUserDal());

            foreach (var item in userManager.GetAll().Data)
            {
                Console.WriteLine(item.FirstName);
            }

        }
    }
}
