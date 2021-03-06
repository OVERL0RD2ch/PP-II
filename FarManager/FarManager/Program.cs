﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFarManager
{
    class Program
    {

        static void showState(DirectoryInfo cur, int pos)
            
        {
            Console.Clear();
            FileSystemInfo[] infos = cur.GetFileSystemInfos();

            for (int i = 0; i < infos.Length; i++)
            {

                if (pos == i)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                if (infos[i].GetType() == typeof(DirectoryInfo))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }

                Console.WriteLine(infos[i].Name);
            }
            


        }

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            int pos = 0;

            DirectoryInfo dir = new DirectoryInfo(@"C:\test");

            while (true)
            {
                Console.Clear();
                showState(dir, pos);

                ConsoleKeyInfo btn = Console.ReadKey();
                switch (btn.Key)
                {
                    case ConsoleKey.UpArrow:
                        pos--;
                        if (pos < 0)
                        {
                            pos = dir.GetFileSystemInfos().Length - 1;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        pos++;
                        if (pos >= dir.GetFileSystemInfos().Length - 1)
                        {
                            pos = 0;
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
                        break;
                    case ConsoleKey.Enter:
                        FileSystemInfo f = dir.GetFileSystemInfos()[pos];
                        int size = f.FullName.Length;
                        bool da = false;
                        if (f.FullName[size-3] == 't' && f.FullName[size - 2]=='x' && f.FullName[size - 1] == 't')
                        {
                            da = true;
                        }
                        if (f.GetType() == typeof(DirectoryInfo))
                        {
                            dir = new DirectoryInfo(f.FullName);
                            pos = 0;
                        }
                        else if (da ==true)
                        {
                             Console.Clear();
                             FileStream fs = new FileStream(f.FullName, FileMode.Open, FileAccess.Read);
                             StreamReader sr = new StreamReader(fs);
                             String line = sr.ReadToEnd();
                             Console.WriteLine(line);
                             Console.ReadKey();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("SMOrc, It's not txt file");
                            Console.ReadKey();

                        }
                        break;
                
                    case ConsoleKey.Escape:
                        dir = dir.Parent;
                        break;
                }
            }
        }
    }
}