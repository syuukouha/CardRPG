using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleState : GameState {
    protected override void OnLoadComplete()
    {
        UIManager.ShowView("BattlePanel");
    }

    protected override void OnStart()
    {
    }

    protected override void OnStop()
    {
        UIManager.HideView("BattlePanel");
    }
}