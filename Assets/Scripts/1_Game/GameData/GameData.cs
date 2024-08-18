using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData
{
    //
    public GameData_Students pDataStudents { private set; get; } = null;
    public GameData_Shop     pDataShop     { private set; get; } = null;


    public void Init()
    {
        //
        pDataStudents = new GameData_Students();
        pDataShop     = new GameData_Shop    ();
    }
}
