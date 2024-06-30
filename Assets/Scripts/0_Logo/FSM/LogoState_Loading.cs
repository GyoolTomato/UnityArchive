using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogoState_Loading : SceneState
{
    //
    LogoScene _logoScene = null;

    //
    public LogoState_Loading(LogoScene logoScene)
    {
        _logoScene = logoScene;
    }

    //
    public void Enter()
    {
        _logoScene.ChangeGameScene();
    }

    //
    public void Exit()
    {

    }

    //
    public void Update()
    {
        
    }
}
