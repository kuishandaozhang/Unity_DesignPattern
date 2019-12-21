using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 数据管理器 脚本单例
/// </summary>
public class DataManager_Com : MonoBehaviour
{
    public static DataManager_Com Instance { get; private set; }

    private void Awake()
    {
        Instance = this;

        InitPlayerInfo();
    }


    //玩家信息
    private PlayerInfo playerInfo;


    /// <summary>
    /// 初始化玩家信息
    /// </summary>
    private void InitPlayerInfo()
    {
        playerInfo = new PlayerInfo("严道葵", 22, "广州天河");
    }

    /// <summary>
    /// 获取玩家信息
    /// </summary>
    public PlayerInfo GetPlayerInfo()
    {
        return playerInfo;
    }
}
