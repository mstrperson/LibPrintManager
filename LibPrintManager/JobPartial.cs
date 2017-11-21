﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LibPrintManager
{
    partial class Job
    {
        /// <summary>
        /// Export the Job file data to a local file.
        /// </summary>
        /// <param name="fileName">Pass the full file path here.</param>
        /// <param name="overwrite"></param>
        public void WriteToFile(String fileName, bool overwrite = false)
        {
            if(System.IO.File.Exists(fileName))
            {
                if (overwrite)
                    System.IO.File.Delete(fileName);
                else
                    throw new ArgumentException("That file already exists.  Pass with Overwrite permission.");
            }

            FileStream fs = new FileStream(fileName, FileMode.CreateNew);
            foreach(Byte bt in File)
            {
                fs.WriteByte(bt);
            }

            fs.Flush();
            fs.Close();
        }

        /// <summary>
        /// Get the file data as a Base64 string for transmission over a text protocol.
        /// </summary>
        /// <returns></returns>
        public String SerializeFile()
        {
            return Convert.ToBase64String(File);
        }
    }
}