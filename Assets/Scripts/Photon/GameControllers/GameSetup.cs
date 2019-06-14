﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetup : MonoBehaviour
{
    public static GameSetup setup;

    public Transform[] spawnPoints;

    private void OnEnable()
    {
        if(GameSetup.setup == null)
        {
            GameSetup.setup = this;
        }
    }
}
