using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Manager_UI
{
    //
    static List<Panel_Base> _panels = new List<Panel_Base>();

    ///<summary>
    ///</summary>
    public static Panel_Base GetPanel(EPanelType panelType)
    {
        //
        foreach (Panel_Base panel in _panels)
        {
            if (panel.pPanelType == panelType)
                return panel;
        }

        //
        return null;
    }

    ///<summary>
    ///</summary>
    public static Panel_Base ShowPanel(EPanelType panelType)
    {
        //
        var panel = GetPanel(panelType);
        if (panel == null)
            return null;

        //
        if (panel.pIsShow == false)
            panel.gameObject.SetActive(true);

        //
        return panel;
    }
}
