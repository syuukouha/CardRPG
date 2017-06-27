using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginState : GameState
{
    protected override void OnLoadComplete()
    {
        UIManager.ShowView("LoginPanel");
    }

    protected override void OnStart()
    {
    }

    protected override void OnStop()
    {
        UIManager.HideView("LoginPanel");
    }
}
