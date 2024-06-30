using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoState_Logo : SceneState
{
    //
    LogoScene _logoScene = null;

    //
    public LogoState_Logo(LogoScene logoScene)
    {
        _logoScene = logoScene;
    }

    //
    public void Enter()
    {
        LogoState.ChangeScene(ELogoState.LogIn);
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
