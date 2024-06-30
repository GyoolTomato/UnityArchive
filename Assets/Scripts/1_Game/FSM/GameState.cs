using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MEC;

public static class GameState
{
    //
    static GameScene _gameScene = null;

    //
    static GameState_Lobby    _stateLobby    = null;
    static GameState_Main     _stateMain     = null;
    static GameState_Missions _stateMissions = null;
    static GameState_Shop     _stateShop     = null;
    static GameState_Stage    _stateStage    = null;

    static SceneState _curState = null;

    //
    static CoroutineHandle _coroutineHandle;

   
    //
    static public void Init(GameScene gameScene)
    {
        //
        Timing.KillCoroutines(_coroutineHandle);

        //
        _gameScene = gameScene;
        
        //
        _stateLobby    = new GameState_Lobby   (_gameScene);
        _stateMain     = new GameState_Main    (_gameScene);
        _stateMissions = new GameState_Missions(_gameScene);
        _stateShop     = new GameState_Shop    (_gameScene);
        _stateStage    = new GameState_Stage   (_gameScene);

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
    static public void ChangeScene(EGameState gameState)
    {
        //
        Timing.KillCoroutines(_coroutineHandle);

        _curState?.Exit();
        
        //
        switch (gameState)
        {
            case EGameState.Lobby   : _curState = _stateLobby   ; break;
            case EGameState.Main    : _curState = _stateMain    ; break;
            case EGameState.Missions: _curState = _stateMissions; break;
            case EGameState.Shop    : _curState = _stateShop    ; break;
            case EGameState.Stage   : _curState = _stateStage   ; break;
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
