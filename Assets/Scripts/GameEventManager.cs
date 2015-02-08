using UnityEngine;
using System.Collections;

public class GameEventManager
{
    public static bool gameOver = false;

    public delegate void GameEvent();
    public static GameEvent WaterPickup;

    public static void TriggerWaterPickup()
    {
        Debug.Log("water pickup");
        if (WaterPickup != null)
        {
            
            WaterPickup();
        }
    }
}
