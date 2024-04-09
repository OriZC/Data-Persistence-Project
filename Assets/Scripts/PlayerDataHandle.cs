using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataHandle : MonoBehaviour
{

    //Static Class for save The current player data
    //singleton pattern

    public static PlayerDataHandle Instance;

    public string PlayerName;
    public int Score;

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    
}
