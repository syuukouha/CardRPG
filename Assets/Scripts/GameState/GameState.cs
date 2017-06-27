using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 状态设计模式游戏状态类
/// </summary>
public abstract class GameState
{
    /// <summary>
    /// 开始
    /// </summary>
    public void Start()
    {
        UIManager.ShowView("LoadingPanel");
        OnStart();
    }
    /// <summary>
    /// 停止
    /// </summary>
    public void Stop()
    {
        OnStop();
    }
    /// <summary>
    /// 读取完成
    /// </summary>
    /// <param name="args"></param>
    public void LoadComplete(params object[] args)
    {
        OnLoadComplete();
        UIManager.HideView("LoadingPanel");
    }
    protected abstract void OnStart();
    protected abstract void OnStop();
    protected abstract void OnLoadComplete();

}
