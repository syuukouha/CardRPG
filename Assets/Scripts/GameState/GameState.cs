using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameState
{
    public void Start()
    {
        UIManager.ShowView("LoadingPanel");
        OnStart();
    }
    public void Stop()
    {
        OnStop();
    }
    public void LoadComplete(params object[] args)
    {
        OnLoadComplete();
        UIManager.HideView("LoadingPanel");
    }
    protected abstract void OnStart();
    protected abstract void OnStop();
    protected abstract void OnLoadComplete();

}
