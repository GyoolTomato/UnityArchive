using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState_Main : SceneState
{
    //
    GameScene _gameScene = null;

    //
    public GameState_Main(GameScene scene)
    {
        _gameScene = scene;
    }

    //
    public void Enter()
    {
        var panel = Manager_UI.ShowPanel(EPanelType.None) as Panel_Main;
        panel.Init();
        
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
