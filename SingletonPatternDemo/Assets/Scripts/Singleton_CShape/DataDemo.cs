using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 使用单例【数据管理器】示例
/// </summary>
public class DataDemo : MonoBehaviour
{
    void Start()
    {
        string playerName = DataManager.Instance.GetPlayerName();
        int playerAge = DataManager.Instance.GetPlayerAge();
        string playerAddress = DataManager.Instance.GetPlayerAddress();

        Debug.Log("玩家名称：" + playerName);
        Debug.Log("玩家年龄：" + playerAge);
        Debug.Log("玩家地址：" + playerAddress);
    }







}
