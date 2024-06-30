using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogoScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LogoState.Init(this);

        LogoState.ChangeScene(ELogoState.Logo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //
    public void ChangeGameScene()
    {
        //
        // LogoState.ChangeScene

        //
        SceneManager.LoadScene("1_Game");
    }
}
