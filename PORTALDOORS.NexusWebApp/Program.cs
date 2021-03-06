// Program.cs 
// Copyright (c) 2007 - 2021 Brain Health Alliance. All Rights Reserved. 
// Licensed per the OSI approved MIT License (https://opensource.org/licenses/MIT).

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

using PDP.DREAM.NexusWebApp;

namespace PORTALDOORS.NexusWebApp
{
  public class Program
  {
    public static void Main(string[] args)
    {
      CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
      Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(
        webBuilder => { webBuilder.UseStartup<StartNexusWebApp>(); });

  } // class

} // namespace

