using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testEF
{
    class UserInfo
    {
        //用户名、软件名、模块名、版本号、申请时间、处理结果、下载
        public string username { get; set; }
        public string software { get; set; }
        public string version { get; set; }
        public string model { get; set; }
        public Nullable<System.DateTime> send_time { get; set; }
        public string result { get; set; }
    }
}
