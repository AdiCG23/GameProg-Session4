using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void ChangeScene(string nama)
    {
        SceneManager.LoadScene(nama);
    }

    public static SceneChange instance;
    public void Awake()
    {
        if(instance == null)
        instance = this;
    }

    internal void ChangeScene(object v)
    {
        throw new NotImplementedException();
    }
}
