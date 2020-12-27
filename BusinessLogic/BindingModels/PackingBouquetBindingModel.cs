using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BusinessLogic.BindingModels
{
    [DataContract]
    public class PackingBouquetBindingModel
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int BouquetId { get; set; }
        [DataMember]
        public int PackingId { get; set; }
        [DataMember]
        public int Count { get; set; }
    }
}
