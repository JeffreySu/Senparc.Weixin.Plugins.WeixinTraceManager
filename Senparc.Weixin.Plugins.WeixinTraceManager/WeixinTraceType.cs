using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senparc.Weixin.Plugins.WeixinTraceManager
{
    /// <summary>
    /// 消息类型
    /// </summary>
    public enum WeixinTraceType
    {
        Normal,
        API,
        PostRequest,
        GetRequest,
        Exception
    }
}
