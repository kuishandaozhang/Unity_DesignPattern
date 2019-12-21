using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 玩家信息
/// </summary>
public class PlayerInfo
{
    private string playerName;          //名称
    private int playerAge;              //年龄
    private string playerAddress;       //地址


    #region 属性

    //名称
    public string PlayerName { get { return playerName; } set { playerName = value; } }

    //地址
    public string PlayerAddress { get { return playerAddress; } set { playerAddress = value; } }

    //年龄
    public int PlayerAge
    {
        get
        {
            return playerAge;
        }
        set
        {
            if (value < 0) value = 0;
            if (value > 100) value = 100;

            playerAge = value;
        }
    }

    #endregion


    public PlayerInfo(string playerName, int playerAge, string playerAddress)
    {
        this.playerName = playerName;
        this.playerAge = playerAge;
        this.playerAddress = playerAddress;
    }
}
