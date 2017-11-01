﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mintcode.Zeus.Public.Data
{
    /// <summary>
    /// SQL操作符
    /// </summary>
    public enum OperationMethod
    {
        /// <summary>
        /// 等于
        /// </summary>
        Equal = 1,
        /// <summary>
        /// 小于
        /// </summary>
        Less = 2,
        /// <summary>
        /// 大于
        /// </summary>
        Greater = 3,
        /// <summary>
        /// 小于等于
        /// </summary>
        LessOrEqual = 4,
        /// <summary>
        /// 大于等于
        /// </summary>
        GreaterOrEqual = 5,
        /// <summary>
        /// 包含%-%
        /// </summary>
        Contains = 6,
        /// <summary>
        /// 开始包含-%
        /// </summary>
        StartsWith = 7,
        /// <summary>
        /// 结束包含%-
        /// </summary>
        EndsWith = 8,
        /// <summary>
        /// IN
        /// </summary>
        In = 9,
        /// <summary>
        /// 不等于
        /// </summary>
        NotEqual = 10,

        /// <summary>
        /// 不包含%-%
        /// </summary>
        NotContains = 11,

        /// <summary>
        /// 不等于null
        /// </summary>
        NotNull = 12,
        /// <summary>
        /// 等于null
        /// </summary>
        IsNull = 13,
        /// <summary>
        /// NotIn
        /// </summary>
        NotIn = 14
    }
}
