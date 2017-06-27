using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 副本状态
/// </summary>
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
