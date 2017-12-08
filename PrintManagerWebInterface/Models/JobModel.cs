using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibPrintManager;
using System.Runtime.Serialization;

namespace PrintManagerWebInterface.Models
{
    [DataContract]
    public class JobModel : Job
    {
        [DataMember(IsRequired = false, EmitDefaultValue = false)]
        public new int Id => base.Id;

        [DataMember(IsRequired = true)]
        public int OwnerId => base.UserId;

        [DataMember(IsRequired = true)]
        public new String FileName => base.FileName;

        [DataMember(IsRequired = true)]
        public String FileData => base.SerializeFile;

        [DataMember(IsRequired = false, EmitDefaultValue = false)]
        public new int StatusId => base.StatusId;

        [DataMember(IsRequired = false, EmitDefaultValue = false)]
        public new List<MessageModel> Messages
        {
            get
            {
                List<MessageModel> msgs = new List<MessageModel>();
                foreach (Message msg in base.Messages)
                    Messages.Add(new MessageModel()
                    {
                        Id = msg.Id,
                        Message = msg.Body,
                        JobId = msg.JobId
                    });

                return msgs;
            }
        }
    }
}