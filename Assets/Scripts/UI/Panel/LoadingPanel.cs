using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingPanel : IView
{
    protected override void OnClick(GameObject sender, object param)
    {
    }

    protected override void OnDestroy()
    {
    }

    protected override void OnDrag(GameObject sender, object param)
    {
    }

    protected override void OnHide()
    {
    }

    protected override void OnPress(GameObject sender, object param)
    {
    }

    protected override void OnShow()
    {
    }

    protected override void OnStart()
    {
        Debug.Log("LoadingPanel OnStart");
    }
}
