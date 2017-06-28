using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ResourcesManger))]
[RequireComponent(typeof(DownloadManager))]
[RequireComponent(typeof(GameStateManager))]

public class GameMain : MonoBehaviour {

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
