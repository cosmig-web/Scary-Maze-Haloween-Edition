using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputDetector : MonoBehaviour
{
    public string sceneName = "Level1";

    void Update()
    {
        if (Input.anyKey)
        {
            SceneManager.LoadScene(sceneName);

        }
    }
}
