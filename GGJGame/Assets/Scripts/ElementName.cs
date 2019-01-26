﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[yl] 元素名
public class ElementName
{
    //[yl] Base Element Name
    public const string Man = "Man";                                    //男性
    public const string Woman = "Woman";                                //女性
    public const string Ill = "Ill";                                    //生病
    public const string Time = "Time";                                  //单位时间
    public const string Money = "Money";                                //单位金钱

    //[yl] Combine Element Name
    public const string IllMan = "IllMan";                              //生病男性
    public const string IllWoman = "IllWoman";                          //生病女性
    public const string Boy = "Boy";                                    //男孩
    public const string Girl = "Girl";                                  //女孩

    //[yl] Has Result Element Name

}


//[yl] 简单起见使用单例
public class ElementNameMgr
{
    private static ElementNameMgr instatnce;

    //constructor
    private ElementNameMgr()
    {
        Init();
    }

    public static ElementNameMgr getInstance()
    {
        if (null == instatnce)
            instatnce = new ElementNameMgr();
        return instatnce;
    }

    public Dictionary<string, string[]> elementsDict;
    public Dictionary<string[], string[]> netElementRelationDict;   //网状结构元素关系字典

    public void Init()
    {
        elementsDict = new Dictionary<string, string[]>();
        elementsDict.Add("Man", new string[] { "男性", ElementName.Man });
        elementsDict.Add("Woman", new string[] { "女性", ElementName.Woman });
        elementsDict.Add("Ill", new string[] { "生病", ElementName.Ill });
        elementsDict.Add("Time", new string[] { "单位时间", ElementName.Time });
        elementsDict.Add("Money", new string[] { "单位金钱", ElementName.Money });
        elementsDict.Add("IllMan", new string[] { "生病男性", ElementName.IllMan });
        elementsDict.Add("IllWoman", new string[] { "生病女性", ElementName.IllWoman });
        elementsDict.Add("Boy", new string[] { "男孩", ElementName.Boy });
        elementsDict.Add("Girl", new string[] { "女孩", ElementName.Girl });

    }

    //[yl] 网状结构
    public void NetDictInit()
    {
        netElementRelationDict = new Dictionary<string[], string[]>();
        netElementRelationDict.Add(
            new string[] { ElementName.Man, ElementName.Woman, ElementName.Time },
            new string[] { ElementName.Boy, ElementName.Girl});
        netElementRelationDict.Add(
            new string[] { ElementName.Man, ElementName.Ill },
            new string[] { ElementName.IllMan });

    }
}


