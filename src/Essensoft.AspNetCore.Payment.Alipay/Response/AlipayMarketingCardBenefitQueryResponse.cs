using Newtonsoft.Json;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCardBenefitQueryResponse.
    /// </summary>
    public class AlipayMarketingCardBenefitQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 会员卡模板外部权益列表
        /// </summary>
        [JsonProperty("mcard_template_benefit_query")]
        public List<McardTemplateBenefitQuery> McardTemplateBenefitQuery { get; set; }
    }
}
