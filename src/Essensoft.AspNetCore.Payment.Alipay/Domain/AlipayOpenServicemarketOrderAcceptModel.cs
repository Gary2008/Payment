using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenServicemarketOrderAcceptModel Data Structure.
    /// </summary>
    public class AlipayOpenServicemarketOrderAcceptModel : AlipayObject
    {
        /// <summary>
        /// 服务商品订单ID
        /// </summary>
        [JsonProperty("commodity_order_id")]
        public string CommodityOrderId { get; set; }
    }
}
