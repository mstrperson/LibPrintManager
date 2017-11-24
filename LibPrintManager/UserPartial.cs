using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPrintManager
{
    partial class User
    {
        /// <summary>
        /// Check to see if a User with this email exists.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool Exists(String email)
        {
            using (PrintManagerDatabaseEntities db = new PrintManagerDatabaseEntities())
            {
                if (db.Users.Where(user => user.Email.Equals(email)).Count() > 1)
                    throw new ArgumentException("Multiple Users registered to the same email.  Something is wrong...");
                return db.Users.Where(user => user.Email.Equals(email)).Count() == 1;
            }
        }

        /// <summary>
        /// Get the user ID of the user with this email.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static int GetIdByEmail(String email)
        {
            if (!Exists(email))
                throw new ArgumentException("No user with this email is registered.");
            using (PrintManagerDatabaseEntities db = new PrintManagerDatabaseEntities())
            {
                return db.Users.Where(user => user.Email.Equals(email)).Single().Id;
            }
        }

        public String JsonString
        {
            get
            {
                return String.Format("{" +
                    "\t\"Id\":\"{0}\",\n" +
                    "\t\"Name\":\"{1}\",\n" +
                    "\t\"Email\":\"{2}\",\n" +
                    "\t\"JobCount\":\"{3}\",\n" +
                    "}",
                    this.Id, this.Name, this.Email, this.Jobs.Count);
            }
        }
    }
}
