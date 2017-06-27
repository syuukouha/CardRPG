using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonState : GameState {
    protected override void OnLoadComplete()
    {
        UIManager.ShowView("DungeonPanel");
    }

    protected override void OnStart()
    {
    }

    protected override void OnStop()
    {
        UIManager.HideView("DungeonPanel");
    }
}
