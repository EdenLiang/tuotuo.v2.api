﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mintcode.TuoTuo.v2.IRepository.Models
{
    public class TaskInfoModel
    {
        public int taskID { get; set; }

        public int backLogID { get; set; }

        public int projectID { get; set; }

        public string projectName { get; set; }

        public string title { get; set; }

        public string content { get; set; }
        public string assignedName{get;set;}

        public string assignedEmail { get; set; }

        public string typeName{get;set;}
        
        public int time{get;set;}

        public int state { get; set; }
        
        public string currentUserMail{get;set;}

        public DateTime createTime { get; set; }

        public long createTimestamp { get; set; }
    }
}
