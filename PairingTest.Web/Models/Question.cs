using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PairingTest.Web.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public List<Option> Options { get; set; } = new List<Option>();
    }
}