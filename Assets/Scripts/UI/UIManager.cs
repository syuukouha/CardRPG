using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;
using UnityEngine.UI;
/// <summary>
/// UI管理类
/// </summary>
public class UIManager
{
    /// <summary>
    /// UI名字和游戏物体和UIView的映射
    /// </summary>
    private static Dictionary<string, KeyValuePair<GameObject, IView>> m_UIViews = new Dictionary<string, KeyValuePair<GameObject, IView>>();
    private static GameObject InstantiatePanel(string name)
    {
        GameObject prefab = ResourcesManger.Instance.GetUIPrefab(name);
        if (prefab == null)
        {
            Debug.LogError("prefab is null, prefabName:" + name);
            return null;
        }
        GameObject UIPrefab = GameObject.Instantiate(prefab);
        UIPrefab.name = name;
        //Canvas canvas = GameObject.FindObjectOfType<Canvas>();
        //if(canvas == null)
        //{
        //    Debug.LogError("Canvas is null");
        //    return null;
        //}
        //UIPrefab.transform.parent = canvas.transform;
        //UIPrefab.transform.localPosition = Vector3.zero;
        //UIPrefab.transform.localScale = Vector3.one;
        return UIPrefab;
    }
    public static void ShowView(string name)
    {
        IView view = null;
        GameObject panel = null;
        KeyValuePair<GameObject, IView> UIView;
        if (!m_UIViews.TryGetValue(name, out UIView)){
            view = Assembly.GetExecutingAssembly().CreateInstance(name) as IView;
            panel = InstantiatePanel(name);
            if(view == null || panel == null)
            {
                Debug.LogError("View or Panel is null. name :" + name);
                return;
            }
            m_UIViews.Add(name, new KeyValuePair<GameObject, IView>(panel, view));
        }
        else
        {
            view = UIView.Value;
            panel = UIView.Key;
        }
        panel.SetActive(true);
        view.Start();
    }
    public static void HideView(string name)
    {
        KeyValuePair<GameObject, IView> UIView;
        if (!m_UIViews.TryGetValue(name, out UIView))
            return;
        UIView.Key.SetActive(false);
        UIView.Value.Hide();
    }
    public static void DestoryAllView()
    {
        foreach (KeyValuePair<GameObject,IView> item in m_UIViews.Values)
        {
            item.Value.Destroy();
            GameObject.Destroy(item.Key);
        }
        m_UIViews.Clear();
        Resources.UnloadUnusedAssets();
    }
}
