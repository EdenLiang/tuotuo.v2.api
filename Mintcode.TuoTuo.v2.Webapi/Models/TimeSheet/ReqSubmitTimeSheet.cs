﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mintcode.TuoTuo.v2.Webapi.Models.TimeSheet
{
    public class ReqSubmitTimeSheet:RequestBaseModel
    {
        public int sheetID { set; get; }
    }
}
