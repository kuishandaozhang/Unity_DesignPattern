using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 脚本单例模式
/// </summary>
public class Singleton_Component : MonoBehaviour
{
    public static Singleton_Component Instance { get; private set; }

    void Awake()
    {
        Instance = this;
    }
}
