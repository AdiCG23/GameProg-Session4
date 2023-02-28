using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public MenuView menuView;
    void Start()
    {
        menuView.MainMenu_Start.onClick.AddListener(delegate{SceneChange.instance.ChangeScene("Gameplay");});
        menuView.MainMenu_Ending.onClick.AddListener(delegate{SceneChange.instance.ChangeScene("Ending");});
    }
}
