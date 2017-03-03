using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIStartGameMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartNewGame()
    {
        UnityEditor.EditorUtility.DisplayDialog("开始游戏", "开始新游戏", "确定");
    }

    public void ContinueGame()
    {
        UnityEditor.EditorUtility.DisplayDialog("继续游戏", "继续游戏", "确定");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
