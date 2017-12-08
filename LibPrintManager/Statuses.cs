using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPrintManager
{
    public partial class JobStatus
    {
/*
0	Submitted	Your Job has been submitted and is pending review
1	Assigned	Your Job has been assigned to a printer queue.
2	In Progress	Your Job is currently being printed.
3	Delayed	    Your job has been delayed.  See messages for details.
4	Completed	Your job is Completed and ready for pickup.
5	Rejected - Not Printable	Your job request is not printable.  See messages for details.
6	Rejected - Request Denied	Your request has been denied at the discression of the Makerspace personel. See message for details
7	Rejected - Incorrect Format	Your request is in an invalid format and cannot be processed
8	Need more information	Your job requires additional information before we can print it.  See your messages or talk to an adult in charge.
9	Canceled	This job has been canceled by the person who requested it.
*/

        public static List<String> StatusMarkings
        {
            get
            {
                using (PrintManagerDatabaseEntities db = new PrintManagerDatabaseEntities())
                    return db.JobStatuses.OrderBy(js => js.Id).Select(js => js.Label).ToList();
            }
        }
    }

    public enum JobStatusMarking
    {
        Submitted,
        Assigned,
        InProgress,
        Delayed,
        Completed,
        NotPrintable,
        Denied,
        BadFormat,
        NeedMoreInfo,
        Canceled
    };
}
