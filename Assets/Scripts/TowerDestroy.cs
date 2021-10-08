using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerDestroy : MonoBehaviour
{
    public bool isPlayer = true;
    private void OnDestroy()
    {
        if (!Data.isGameover)
        {
            if (isPlayer)
            {
                Data.isGameover = true;
                Data.isComplate = false;
                Debug.Log("Player Lost");
            }
            else
            {
                Data.isGameover = true;
                Data.isComplate = true;
                Debug.Log("Player Win");
            }
        }
    }
}
