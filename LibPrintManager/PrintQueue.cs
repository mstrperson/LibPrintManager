using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPrintManager
{
    public partial class Printer
    {
        /// <summary>
        /// Get this printer's active jobs in order by submission date.
        /// </summary>
        public IEnumerable<Job> ActiveJobs =>
            this.Jobs.Where(job => job.StatusId == (int)JobStatusMarking.Assigned).OrderBy(job => job.SubmissionDate);

        /// <summary>
        /// Get the next job in this printers ActiveJobs queue.
        /// </summary>
        public Job NextJob => ActiveJobs.First();

        /// <summary>
        /// Add a job to the Printer queue.
        /// The jobs status will automatically bet set to "Accepted"
        /// However, you must call "SaveChanges()" on the 
        /// database context after this method is run.
        /// </summary>
        /// <param name="job">The new job to be added to this Printer Queue</param>
        /// <exception cref="InvalidOperationException">
        /// Thrown if this printer is flagged as not working.
        /// </exception>
        public void AddJob(Job job)
        {
            if (!this.IsWorking)
                throw new InvalidOperationException("This printer is currently not working and cannot be assigned new jobs.");

            this.Jobs.Add(job);
            job.StatusId = (int)JobStatusMarking.Assigned;
            //TODO:Send email to Job owner to say that the job has been queued.
        }

        /// <summary>
        /// Count the number of Jobs waiting in this printer's queue.
        /// </summary>
        public int JobsWaiting => ActiveJobs.Count();

        /// <summary>
        /// Transfer a job from this printer to another printer's queue.
        /// 
        /// After successfully executing this method, you must save changes
        /// to the database context.
        /// </summary>
        /// <param name="job">The job to move</param>
        /// <param name="otherPrinter">Target printer to move the job to.</param>
        /// <exception cref="InvalidOperationException">
        /// Thrown if the job does not belong to this printer, 
        /// or if the target printer is flagged not working
        /// </exception>
        public void TransferJob(Job job, Printer otherPrinter)
        {
            if (!this.Jobs.Contains(job))
                throw new InvalidOperationException("That job is not currently in this printer's queue.");

            this.Jobs.Remove(job);
            otherPrinter.AddJob(job);
        }
    }
}
