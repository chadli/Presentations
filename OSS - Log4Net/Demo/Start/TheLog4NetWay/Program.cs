﻿using System;
using Log4NetDemo.Services;

namespace Log4NetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            log4net.Config.BasicConfigurator.Configure();
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));

            log.Debug("Program Started...");

            var user = new UserService().GetUserById(1);
            log.Debug("User Retrieved: Id = " + user.Id + " Name: " + user.Name);

            var menu = new MenuService().GetMenuByUser(user);

            Console.ReadLine();
        }
    }
}
