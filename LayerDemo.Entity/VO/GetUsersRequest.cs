using LayerDemo.Entity.VO.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace LayerDemo.Entity.VO
{
    public class GetUsersRequest : BaseRequest
    {
        public string UserId { get; set; }

        public string UserName { get; set; }

        public string IsEnabled { get; set; }
    }
}
