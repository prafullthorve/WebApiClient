﻿using System;

namespace WebApiClientCore
{
    /// <summary>
    /// 表示代理类型的特性
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class ProxyTypeAttribute : Attribute
    {
        /// <summary>
        /// 获取所代理的目标接口
        /// </summary>
        public Type HttpApiType { get; }

        /// <summary>
        /// 代理类型的特性
        /// </summary>
        /// <param name="httpApiType">所代理的目标接口</param>
        public ProxyTypeAttribute(Type httpApiType)
        {
            this.HttpApiType = httpApiType;
        }
    }
}
