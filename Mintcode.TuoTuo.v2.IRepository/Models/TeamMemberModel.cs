﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mintcode.TuoTuo.v2.IRepository.Models
{
    public class TeamMemberModel
    {
        public int ID { set; get; }

        public int teamID { set; get; }

        public int userID { set; get; }

        public string roleCode { set; get; }

        public List<string> tags { set; get; }

        public int state { set; get; }

        public string memberName { set; get; }

        public string memberMail { set; get; }

        public string mobile { get; set; }

        public string createUserMail { set; get; }

        public DateTime createTime { set; get; }

        public long createTimestamp { set; get; }
    }
}
