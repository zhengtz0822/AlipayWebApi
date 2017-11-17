using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiDemoContract.Models
{
    public class PublicRequestParameter
    {
        //支付宝分配给开发者的应用ID
        public string app_id { get; set; }
        //接口名称
        public string method { get; set; }
        //format仅支持JSON
        public string format { get; set; }
        //请求使用的编码格式，如utf-8,gbk,gb2312等
        public string charset { get; set; }
        //商户生成签名字符串所使用的签名算法类型，目前支持RSA2和RSA，推荐使用RSA2
        public string sign_type { get; set; }
        //商户请求参数的签名串，详见签名
        public string sign { get; set; }
        //发送请求的时间，格式"yyyy-MM-dd HH:mm:ss"
        public string timestamp { get; set; }
        //调用的接口版本，固定为：1.0
        public string version { get; set; }
        //支付宝服务器主动通知商户服务器里指定的页面http/https路径。
        public string notify_url { get; set; }
        
        public string app_auth_token { get; set; }

        public string biz_content { get; set; }
    }
}