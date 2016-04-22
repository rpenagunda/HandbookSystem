﻿using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace HandbookSystem.Models
{
    public class ModuleInfo
    {
        public int ModuleCode { get; set; }
        public string ModuleTitle { get; set; }

        [Display(Name = "Department:")]
        public string Department { get; set; }

        [Display(Name = "Credits:")]
        public string Credits { get; set; }

        [Display(Name = "Module Leader:")]
        public string ModuleLeader { get; set; }

        [Display(Name = "Module Leader Phone Number:")]
        public string ModuleLeaderPhone { get; set; }

        [Display(Name = "Room:")]
        public string ModuleRoom { get; set; }

        [Display(Name = "Module Leader Email Address:")]
        public string ModuleLeaderEmail { get; set; }

        [Display(Name = "Administrator Phone Number:")]
        public string AdministratorPhone { get; set; }

        [AllowHtml]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Inclusive Services:")]
        public string InclusiveServices { get; set; }

        [AllowHtml]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Module Overview:")]
        public string ModuleOverview { get; set; }

        [AllowHtml]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Advice:")]
        public string Advice { get; set; }

        [AllowHtml]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Learning Outcomes:")]
        public string LearningOutcomes { get; set; }

        [AllowHtml]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Outline Content:")]
        public string OutlineContent { get; set; }

        [AllowHtml]
        [DataType(DataType.MultilineText)]
        [Display(Name = "VLE Blackboard:")]
        public string VleBlackboard { get; set; }

        [AllowHtml]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Assesment:")]
        public string Assessment { get; set; }

        [AllowHtml]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Coursework/Assignment:")]
        public string Coursework { get; set; }

        [AllowHtml]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Reading List:")]
        public string ReadingList { get; set; }

        [AllowHtml]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Other Information:")]
        public string OtherInfo { get; set; }
    }
}