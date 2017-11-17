using Aop.Api;
using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using WebApiDemoContract.Models;

namespace WebApiDemoContract.Controllers
{
    public class CoderInfoController : ApiController
    {
        List<Product> lcoder = new List<Product>();
        Product coders = new Product();
        public string GetInfo()
        {
            coders.Id = 1;
            coders.Name = "neo.zheng";
            coders.Price = 100;
            lcoder.Add(coders);
            coders.Id = 2;
            coders.Name = "jack.wang";
            coders.Price = 98;
            lcoder.Add(coders);

            return lcoder.ToJson();
        }
        public string SetInfo(int id, string name, decimal price)
        {
            Product coders = new Product
            {
                Id = id,
                Name = name,
                Price = price
            };
            return coders.ToJson();
        }

        public string GetCreatePay()
        {
            //支付宝沙箱地址
            string serverUrl = @"https://openapi.alipaydev.com/gateway.do";
            //支付宝应用id
            string appId = "2016090900469755";
            //应用私钥
            string privateKeyPem = @"D:\CODE\My\WebApiDemoContract\WebApiDemoContract\Controllers" + "aop-sandbox-RSA-private-c#.pem"; ;
            

            IAopClient Alipayclient = new DefaultAopClient(serverUrl,appId,privateKeyPem);
            return Alipayclient.ToJson();
        }
        private static string GetCurrentPath()
        {
            string basePath = System.IO.Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName;
            return basePath + "/Controllers/";
            
        }
    }
}
