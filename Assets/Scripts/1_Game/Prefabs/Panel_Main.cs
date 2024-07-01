using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel_Main : Panel_Base
{
    //
    [SerializeField] Com_UserAssets _comUserAssets = null;


    /// <summary>
    /// 
    /// </summary>
    protected override void Awake()
    {
        //
        base.Awake();

        //
        pPanelType = EPanelType.Main;
    }

    /// <summary>
    /// 
    /// </summary>
    public void Init()
    {
        //
        _comUserAssets.Init(EItemType.Crystal, EItemType.Gold);

        //
    }
}
