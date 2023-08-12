﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveyME.Models
{
    public class EmployerDetails
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Editor { get; set; }
        public DateTime DateofCreation { get; set; }
        public DateTime? DateofModification { get; set; }
        public string IPAddress { get; set; }
        public string NameofEmployer { get; set; }
    }
}