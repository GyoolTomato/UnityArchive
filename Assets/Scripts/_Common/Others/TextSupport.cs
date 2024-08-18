using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(TextMeshProUGUI))]
public class TextSupport : MonoBehaviour
{
    //
    [SerializeField] int _key = 0;
    
    //
    TextMeshProUGUI _text = null;


    /// <summary>
    /// 
    /// </summary>
    void Awake()
    {
        _text = GetComponent<TextMeshProUGUI>();
    }

    /// <summary>
    /// 
    /// </summary>
   void OnEnable()
   {
        //
        if (_text == null)
            return;

        //
        _text.text = string.Empty;
    }
}
