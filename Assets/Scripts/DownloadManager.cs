using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DownloadManager : MonoBehaviour {
    #region 单例
    private static DownloadManager instance;
    public static DownloadManager Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType(typeof(DownloadManager)) as DownloadManager;
            return instance;
        }
    } 
    #endregion
    /// <summary>
    /// 回调委托
    /// </summary>
    /// <param name="args"></param>
    public delegate void LoadCallBack(params object[] args);

    public void LoadScene(string name,LoadCallBack loadHandler,params object[] args)
    {
        StartCoroutine(LoadSceneAsyncBundle(name, loadHandler, args));
    }
    private IEnumerator LoadSceneAsyncBundle(string name, LoadCallBack loadHandler, params object[] args)
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync(name);
        yield return ao;
        Resources.UnloadUnusedAssets();
        GC.Collect();
        if (loadHandler != null)
        {
            loadHandler(args);
        }
    }
}
