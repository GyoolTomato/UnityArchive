using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager_Shop
{
    //
    private static Manager_Shop _instance = null;

    //
    public static Manager_Shop pInstance
    {
        get
        {
            if (_instance == null)
                _instance = new Manager_Shop();

            return _instance;
        }
    }


    /// <summary>
    /// 
    /// </summary>
    private Manager_Shop() {}
}
