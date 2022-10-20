using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager
{
    static GameManager _instance = new GameManager();
    public static GameManager Instance => _instance;
    GameManager() { }

    static int level = 1;
    public int Level
    {
        get => level;
        set => level = value;
    }

    static int highscore = 0;
    public int HighScore
    {
        get => highscore;
        set
        {
            if(highscore < value) highscore = value;
        }
    }


}
