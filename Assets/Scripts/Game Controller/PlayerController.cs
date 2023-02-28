using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator PlayerAnimator;
    public GameView NavGameView;

    private void Start()
    {
        NavGameView.attack.onClick.AddListener(attack);

        NavGameView.menu.onClick.AddListener(delegate{SceneChange.instance.ChangeScene("MainMenu"); });
    }
    public void attack()
    {
        PlayerAnimator.SetTrigger("Attack");
    }
}
