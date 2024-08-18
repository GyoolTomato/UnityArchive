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

        //
        Init();
    }

    /// <summary>
    /// 
    /// </summary>
    public void Init()
    {
        //
        Manager_Addressable.Init();

        //
        _comUserAssets.Init(EItemType.Crystal, EItemType.Gold);

       
    }

    /// <summary>
    /// 
    /// </summary>
    public void OnBtnPlayer()
    {
        
    }

    /// <summary>
    /// 
    /// </summary>
    public void OnBtnNotice()
    {

    }

    /// <summary>
    /// 
    /// </summary>
    public void OnBtnTalk()
    {

    }

    /// <summary>
    /// 
    /// </summary>
    public void OnBtnMissions()
    {

    }

    /// <summary>
    /// 
    /// </summary>
    public void OnBtnCashShop()
    {

    }

    /// <summary>
    /// 
    /// </summary>
    public void OnBtnLobbyCharacter()
    {

    }

    /// <summary>
    /// 
    /// </summary>
    public void OnBtnMail()
    {

    }

    /// <summary>
    /// 
    /// </summary>
    public void OnBtnOthers()
    {

    }
    
    /// <summary>
    /// 
    /// </summary>
    public void OnBtnHideUI()
    {

    }

    /// <summary>
    /// 
    /// </summary>
    public void OnBtnChangeView()
    {

    }

    /// <summary>
    /// 
    /// </summary>
    public void OnBtnCafe()
    {

    }

    /// <summary>
    /// 
    /// </summary>
    public void OnBtnSchedule()
    {

    }

    /// <summary>
    /// 
    /// </summary>
    public void OnBtnStudents()
    {

    }

    /// <summary>
    /// 
    /// </summary>
    public void OnBtnFormation()
    {

    }

    /// <summary>
    /// 
    /// </summary>
    public void OnBtnCircle()
    {

    }

    /// <summary>
    /// 
    /// </summary>
    public void OnBtnCraft()
    {

    }

    /// <summary>
    /// 
    /// </summary>
    public void OnBtnShop()
    {

    }

    /// <summary>
    /// 
    /// </summary>
    public void OnBtnGacha()
    {

    }
}
