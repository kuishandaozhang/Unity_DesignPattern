using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 纯C#类单例模式
/// </summary>
public class Singleton_CShape
{
    private static Singleton_CShape _instance;

    private Singleton_CShape()
    {

    }

    public static Singleton_CShape Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Singleton_CShape();
            }

            return _instance;
        }
    }
}
