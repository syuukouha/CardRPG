﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 主城状态
/// </summary>
public class HomeState : GameState {
    protected override void OnLoadComplete()
    {
        UIManager.ShowView("MainPanel");
    }

    protected override void OnStart()
    {
    }

    protected override void OnStop()
    {
        UIManager.HideView("MainPanel");
    }
}
