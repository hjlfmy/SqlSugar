﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlSugar
{
    //局部类：拉姆达解析公用常量
    internal partial class ResolveExpress
    {
        /// <summary>
        /// 解析bool类型用到的字典
        /// </summary>
        public static List<ExpressBoolModel> ConstantBoolDictionary = new List<ExpressBoolModel>()
        {
               new ExpressBoolModel(){ Key=Guid.NewGuid(), OldValue="True", Type=SqlSugarTool.StringType},
               new ExpressBoolModel(){ Key=Guid.NewGuid(), OldValue="False",Type=SqlSugarTool.StringType},
               new ExpressBoolModel(){ Key=Guid.NewGuid(), OldValue="True",Type=SqlSugarTool.BoolType},
               new ExpressBoolModel(){ Key=Guid.NewGuid(), OldValue="False",Type=SqlSugarTool.BoolType}

        };
        /// <summary>
        /// 字段名解析错误
        /// </summary>
        public const string FileldErrorMessage = "OrderBy、GroupBy、In、Min和Max等操作不是有效拉姆达格式 ，正确格式 it=>it.name ";
        /// <summary>
        /// 拉姆达解析错误
        /// </summary>
        public const string ExpToSqlError= "拉姆达解析出错，例如(it=>it.id==a.id) it.id是字段，a.id就是参数,字段不支持任何函数,参数可支持的函数有 Trim 、Contains 、ObjToXXX、 Convert.ToXXX、Contains、String.IsNullOrEmpty、StartsWith和StartsEnd。 ";
        /// <summary>
        /// 运算符错误
        /// </summary>
        public const string OperatorError = "拉姆达解析出错：不支持{0}此种运算符查找！";
    }
}
