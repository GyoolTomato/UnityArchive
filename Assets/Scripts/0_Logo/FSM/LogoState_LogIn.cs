using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoState_LogIn : SceneState
{
    //
    LogoScene _logoScene = null;

    //
    public LogoState_LogIn(LogoScene logoScene)
    {
        _logoScene = logoScene;
    }

    //
    public void Enter()
    {
        LogoState.ChangeScene(ELogoState.Loading);
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
