using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 使用脚本单例【数据管理器】示例
/// </summary>
public class DataDemo_Com : MonoBehaviour
{
    void Start()
    {
        PlayerInfo playerInfo = DataManager_Com.Instance.GetPlayerInfo();


        Debug.Log("玩家名称：" + playerInfo.PlayerName);
        Debug.Log("玩家年龄：" + playerInfo.PlayerAge);
        Debug.Log("玩家地址：" + playerInfo.PlayerAddress);
    }
}
