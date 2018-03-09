using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load_Level_Script : MonoBehaviour
{
    public void LoadLevel(string toLoad)
    {
        SceneManager.LoadScene(toLoad);
    }
}