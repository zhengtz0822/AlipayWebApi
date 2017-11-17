using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiDemoContract.Models
{
    /// <summary>
    /// 订单包含的商品列表信息，Json格式，其它说明详见商品明细说明	
    /// </summary>
    public class Goods_detail
    {
        /// <summary>
        /// 必填
        /// 商品的编号
        /// </summary>
        public string goods_id { get; set; }
        /// <summary>
        /// 必填
        /// 商品名称
        /// </summary>
        public string goods_name { get; set; }
        /// <summary>
        /// 必填
        /// 商品数量
        /// </summary>
        public int quantity { get; set; }
        /// <summary>
        /// 必填
        /// 商品单价，单位为元
        /// </summary>
        public double price { get; set; }
        /// <summary>
        /// 可选
        /// 商品类目
        /// </summary>
        public string goods_category { get; set; }
        /// <summary>
        /// 可选
        /// 商品描述信息
        /// </summary>
        public string body { get;set;}
        /// <summary>
        /// 可选
        /// 商品的展示地址
        /// </summary>
        public string show_url { get; set; }
    }
}