using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MEC;

public static class LogoState
{
    //
    static LogoScene _logoScene = null;

    //
    static LogoState_Logo    _stateLogo    = null;
    static LogoState_LogIn   _stateLogIn   = null;
    static LogoState_Loading _stateLoading = null;

    static SceneState _curState = null;

    //
    static CoroutineHandle _coroutineHandle;

   
    //
    static public void Init(LogoScene logoScene)
    {
        //
        Timing.KillCoroutines(_coroutineHandle);

        //
        _logoScene = logoScene;
        
        //
        _stateLogo    = new LogoState_Logo   (_logoScene);
        _stateLogIn   = new LogoState_LogIn  (_logoScene);
        _stateLoading = new LogoState_Loading(_logoScene);

        //
        _curState = null;
    }

    //
    static public void Release()
    {
        //
        _curState?.Exit();

        //
        Timing.KillCoroutines(_coroutineHandle);
    }

    //
    static public void ChangeScene(ELogoState logoState)
    {
        //
        Timing.KillCoroutines(_coroutineHandle);

        _curState?.Exit();
        
        //
        switch (logoState)
        {
            case ELogoState.Logo   : _curState = _stateLogo   ; break;
            case ELogoState.LogIn  : _curState = _stateLogIn  ; break;
            case ELogoState.Loading: _curState = _stateLoading; break;
        }

        //
        _curState.Enter();

        _coroutineHandle = Timing.RunCoroutine(Update());
    }

    //
    static IEnumerator<float> Update()
    {
        while (true)
        {
            //
            _curState?.Update();

            //
            yield return 0f;
        }
    }
}
 