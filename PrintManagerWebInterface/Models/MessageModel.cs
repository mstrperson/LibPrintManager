using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibPrintManager;
using System.Runtime.Serialization;

namespace PrintManagerWebInterface.Models
{
    [DataContract]
    public class MessageModel
    {
        [DataMember(IsRequired = false, EmitDefaultValue = false)]
        public int Id { get; set; }

        [DataMember(IsRequired = true)]
        public String Message { get; set; }

        [DataMember(IsRequired = true)]
        public int JobId { get; set; }

        
    }
}