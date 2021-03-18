using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace FileAnalyzer
{
    public class Reader
    {
        public string dir = "";

        public Reader(string dir)
        {
            this.dir = dir;
        }

        public void DirectorySearch(string dir)
        {
            try
            {
                foreach (string f in Directory.GetFiles(dir))
                {
                    Console.WriteLine(Path.GetFileName(f));
                }
                foreach (string d in Directory.GetDirectories(dir))
                {
                    Console.WriteLine(Path.GetFileName(d));
                    DirectorySearch(d);
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void GetDirectories()
        {
            List<string> AllFiles = new List<string>();
            void ParsePath(string path)
            {
                string[] SubDirs = Directory.GetDirectories(path);
                AllFiles.AddRange(SubDirs);
                AllFiles.AddRange(Directory.GetFiles(path));
                foreach (string subdir in SubDirs)
                    ParsePath(subdir);
            }
        } 
    }
};
