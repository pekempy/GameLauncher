﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher.Models
{
    class ExeSearch
    {
        public void SearchForShortcuts()
        {
                string programdata = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData).ToString();
                string startMenu = programdata + "\\Microsoft\\Windows\\Start Menu\\";
                startMenu = "C:\\Program Files";
                string[] ext = { ".exe", ".lnk", ".url" };
                foreach (string file in Directory.EnumerateFiles(startMenu, "*.*", SearchOption.AllDirectories).Where(s => ext.Any(ex => ex == Path.GetExtension(s))))
                {
                    Console.WriteLine(file);
                    //somehow need to work out which are games? If possible
                    //Otherwise, swap this method with something that can find purely games
                    //Once we've only got games printing out, we then need to open AddGame 
                    //Autofill in the path with whatever we've got, try and fill in title etc.

                //RE Steam - need to find steam directory, then read "Steam\Config\config.vdf" to find "BaseInstallFolder" for where user stores library
                //Then search the baseinstallfolders for the executables
                }
        }
    }
}