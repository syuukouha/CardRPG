using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 战斗状态
/// </summary>
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