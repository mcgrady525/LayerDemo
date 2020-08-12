using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LayerDemo.Entity.Common
{
    [Description("风险等级")]
    public enum RiskLevelType : byte
    {
        [Display(Name = "低")]
        LOW,

        [Display(Name = "中")]
        MEDIUM,

        [Display(Name = "高")]
        HIGH
    }

    [Description("环境")]
    public enum EnvironmentType : byte
    {
        [Display(Name = "开发")]
        DEV,

        [Display(Name = "测试")]
        TEST,

        [Display(Name = "验收")]
        UAT,

        [Display(Name = "生产")]
        PROD
    }

    [Description("热门航线数据源")]
    public enum HotAirLineDataSourceType : byte
    {
        [Display(Name = "IBE+")]
        IBEPLUS,

        [Display(Name = "Shop")]
        SHOP,

        [Display(Name = "HBGJ")]
        HBGJ
    }

    public static class Enums
    {
        [Description("角色类型")]
        public enum RoleType : byte
        {
            [Display(Name = "管理员")]
            ADMIN,

            [Display(Name = "开发人员")]
            DEVELOPER,

            [Display(Name = "运维人员")]
            OPS
        }

        [Description("启用禁用")]
        public enum EnableDisabledType : byte
        {
            [Display(Name = "启用")]
            Y,

            [Display(Name = "禁用")]
            N
        }

        [Description("排序类型")]
        public enum OrderByType : byte
        {
            [Display(Name = "升序")]
            ASC,

            [Display(Name = "降序")]
            DESC
        }
    }
}
