using StalkerNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StalkerNet.ViewModels
{
    public class PersonViewModel
    {
        public virtual List<Person> peoplelist { get; set; }
    }
}