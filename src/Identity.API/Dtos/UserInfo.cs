﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.API.Dtos
{
    public class UserInfo
    {
        /// <summary>
        /// 用户Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// 职位
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 头像
        /// </summary>
        public string Avatar { get; set; }
    }
}
