using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 数据管理器
/// </summary>
public class DataManager
{


    #region 单例模式
    private static DataManager _instance;

    private DataManager()
    {
        InitPlayerInfo();
    }

    public static DataManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new DataManager();
            }

            return _instance;
        }
    }
    #endregion


    #region 玩家信息
    private string playerName;          //玩家名称
    private int playerAge;              //玩家年龄
    private string playerAddress;       //玩家地址


    /// <summary>
    /// 初始化玩家信息
    /// </summary>
    private void InitPlayerInfo()
    {
        playerName = "严道葵";
        playerAge = 22;
        playerAddress = "广州天河";
    }
    #endregion


    #region 外部接口

    /// <summary>
    /// 获取玩家名称
    /// </summary>
    public string GetPlayerName()
    {
        return playerName;
    }

    /// <summary>
    /// 获取玩家年龄
    /// </summary>
    public int GetPlayerAge()
    {
        return playerAge;
    }
    
    /// <summary>
    /// 获取玩家地址
    /// </summary>
    public string GetPlayerAddress()
    {
        return playerAddress;
    }

    #endregion


}
