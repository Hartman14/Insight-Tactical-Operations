using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour {

    public string nextLevel;

    public void ChangeLevel()
    {
        SceneManager.LoadScene(nextLevel);
    }

}
