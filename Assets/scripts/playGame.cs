using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class playGame : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
