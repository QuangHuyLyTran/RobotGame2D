using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSence : MonoBehaviour
{
    public void Load()
    {
        Application.LoadLevel("Level 1");
    }
}
