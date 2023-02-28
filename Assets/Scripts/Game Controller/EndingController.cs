using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingController : MonoBehaviour
{
    public EndingView endingView;
    void Start()
    {
        endingView.BacktoMenuButton.onClick.AddListener(delegate { SceneChange.instance.ChangeScene("MainMenu"); });
    }

}
