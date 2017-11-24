using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LibPrintManager
{
    partial class Job
    {
        public String JsonString
        {
            get
            {
                return String.Format("{\n" +
                    "\t\"Id\":\"{0}\",\n" +
                    "\t\"Owner\":\"{1}\",\n" +
                    "\t\"FileName\":\"{2}\",\n" +
                    "\t\"Data\":\"{3}\",\n" +
                    "\t\"Status\":\"{4}\"\n" +
                    "}",
                    this.Id, this.UserId, this.FileName, this.SerializeFile, this.StatusId);
            }
        }

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
        public String SerializeFile
        {
            get
            {
                return Convert.ToBase64String(File);
            }
        }

        public static Job AddNewJob(FileStream inStream, string userEmail)
        {
            List<byte> fileBytes = new List<byte>();
            StreamReader reader = new StreamReader(inStream);
            while (!reader.EndOfStream)
                fileBytes.Add((byte)reader.BaseStream.ReadByte());

            using (PrintManagerDatabaseEntities db = new PrintManagerDatabaseEntities())
            {
                if (db.Users.Where(u => u.Email.ToLower().Equals(userEmail.ToLower())).Count() <= 0)
                {
                    db.Users.Add(new User()
                    {
                        Id = db.Users.Count(),
                        Name = userEmail,
                        Email = userEmail
                    });

                    db.SaveChanges();
                }

                User user = db.Users.Where(u => u.Email.ToLower().Equals(userEmail.ToLower())).Single();

                Job job = new Job()
                {
                    Id = db.Jobs.Count(),
                    StatusId = 0,
                    UserId = user.Id,
                    File = fileBytes.ToArray()
                };

                db.Jobs.Add(job);
                db.SaveChanges();

                return job;
            }
        }
    }
}
