using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ChesFine.Octopus.Web.Models
{
    [DataContract(Name ="Node")]
    public class TreeNodeModel
    {
        [DataMember(Name ="id")]
        public int Id { get; set; }
        [DataMember(Name = "text")]
        public string Text { get; set; }
        [DataMember(Name = "state")]
        public string State { get; set; }
        [DataMember(Name = "checked")]
        public bool Checked { get; set; }
        [DataMember(Name = "attributes")]
        public object Attributes { get; set; }
        [DataMember(Name = "children")]
        public List<TreeNodeModel> Children { get; set; }
    }

    public enum TreeNodeState
    {
        Open,
        Closed
    }
}