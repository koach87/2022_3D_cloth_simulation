using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScemeManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}