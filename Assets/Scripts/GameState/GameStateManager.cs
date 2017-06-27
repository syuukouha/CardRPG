using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;
/// <summary>
/// 状态管理类
/// </summary>
public class GameStateManager : MonoBehaviour
{
    /// <summary>
    /// 存储状态的字典
    /// </summary>
    private static Dictionary<string, GameState> m_GameStates;
    /// <summary>
    /// 当前状态
    /// </summary>
    private static GameState m_CurrentState;
	// Use this for initialization
	void Start ()
    {
        m_GameStates = new Dictionary<string, GameState>();
        m_CurrentState = null;
    }
    private static void SetState(GameState state)
    {
        if (state == null)
            return;
        if (state != m_CurrentState && m_CurrentState != null)
            m_CurrentState.Stop();
        m_CurrentState = state;
        m_CurrentState.Start();
    }
    /// <summary>
    /// 加载场景
    /// </summary>
    /// <param name="sceneID"></param>
    public static void LoadScene(int sceneID)
    {
        SceneData data = null;
        if (data == null)
        {
            Debug.LogError("Init SceneData is null. id:" + sceneID);
            return;
        }
        GameState state = null;
        if(!m_GameStates.TryGetValue(data.GameStateName,out state))
        {
            state = Assembly.GetExecutingAssembly().CreateInstance(data.GameStateName) as GameState;
            if(state == null)
            {
                Debug.LogError("Scene state is error." + data.GameStateName);
                return;
            }
            m_GameStates.Add(data.GameStateName, state);
        }
        SetState(state);
        //状态设置完毕，开始加载场景
        DownloadManager.Instance.LoadScene(data.LevelName, state.LoadComplete);
    }
}
