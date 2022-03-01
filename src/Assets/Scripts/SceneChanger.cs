using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    public void StartScene()
    {
        SceneManager.LoadScene("Start");
    }
    public void SampleScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void MarsRoverScene()
    {
        SceneManager.LoadScene("MarsRover");
    }
}
