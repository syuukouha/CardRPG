using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UIPanelLayers
{
    BackgroundLayer = 0,
    DefaultLayer = 10,
    NormalLayer = 20,
    MainLayer = 30,
    MaskLayer = 40,
    PopLayer = 50,
    TipsLayer = 60,
    PrompLayer = 70,
    LoadingLayer = 80

}
/// <summary>
/// 界面基类
/// </summary>
public abstract class IView
{
    /// <summary>
    /// 开始
    /// </summary>
	public void Start ()
    {
        OnStart();
    }
    /// <summary>
    /// 显示
    /// </summary>
    public void Show()
    {
        OnShow();
    }
    /// <summary>
    /// 隐藏
    /// </summary>
    public void Hide()
    {
        OnHide();
    }
    /// <summary>
    /// 点击
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="param"></param>
    public void Click(GameObject sender,object param)
    {
        OnClick(sender, param);
    }
    /// <summary>
    /// 按下
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="param"></param>
    public void Press(GameObject sender, object param)
    {
        OnPress(sender, param);
    }
    /// <summary>
    /// 拖拽
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="param"></param>
    public void Drag(GameObject sender, object param)
    {
        OnDrag(sender, param);
    }
    /// <summary>
    /// 销毁
    /// </summary>
    public void Destroy()
    {
        OnDestroy();
    }
    protected abstract void OnStart();
    protected abstract void OnShow();
    protected abstract void OnHide();
    protected abstract void OnDestroy();
    protected abstract void OnClick(GameObject sender, object param);
    protected abstract void OnPress(GameObject sender, object param);
    protected abstract void OnDrag(GameObject sender, object param);


}
