using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator PlayerAnimator;
    public GameView NavGameView;
    public float DelayDuration;
    public GameObject rawImageVideo;

    private void Start()
    {
        NavGameView.attack.onClick.AddListener(attack);

        NavGameView.menu.onClick.AddListener(delegate{SceneChange.instance.ChangeScene("MainMenu"); });
    }
    public void attack()
    {
        PlayerAnimator.SetTrigger("Attack");
        Invoke(nameof(playVideo), DelayDuration);
    }

    public void invokeVideo()
    {
        Invoke(nameof(playVideo), DelayDuration);
    }

    public void playVideo()
    {
        rawImageVideo.SetActive(true);
        CallChangeSceneAfterSeconds();
    }

    public void CallChangeSceneAfterSeconds()
    {
        StartCoroutine(nameof(WaitAndChange));
    }

    IEnumerator WaitAndChange()
    {
        yield return new WaitForSeconds(4.0f);
        SceneChange.instance.ChangeScene("MainMenu");
    }
}
