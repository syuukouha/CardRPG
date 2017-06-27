using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcesManger : MonoBehaviour {
    #region 单例
    private static ResourcesManger instance;
    public static ResourcesManger Instance
    {
        get
        {
            if (instance == null)
                instance = new ResourcesManger();
            return instance;
        }
    }
    #endregion
    private string uiPanelPath = "UI/Panel";
    public GameObject GetUIPrefab(string name)
    {
        return LoadPrefab(name, uiPanelPath);
    }
    private GameObject LoadPrefab(string name,string path)
    {
        string loadPath = path + "/" + name;
        GameObject prefab = Resources.Load(loadPath) as GameObject;
        if(prefab == null)
        {
            Debug.LogError("LoadPrefab Faild. LoadPath:" + loadPath);
        }
        return prefab;
    }
}
