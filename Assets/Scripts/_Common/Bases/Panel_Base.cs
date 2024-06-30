using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Panel_Base : MonoBehaviour
{
    //
    public EPanelType pPanelType {private set; get; } = EPanelType.None;
    public bool pIsShow { private set; get; } = false;


    /// <summary>
    /// 
    /// </summary>
    protected virtual void Tick()
    {

    }

    /// <summary>
    /// 
    /// </summary>
    protected virtual void Tick_Sec()
    {

    }
}
