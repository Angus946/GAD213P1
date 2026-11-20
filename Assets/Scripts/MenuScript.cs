using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
   
    
    public void PlaySet()
    {
        SceneManager.LoadScene(1);
    }

    public void PlayRandom()
    {
        SceneManager.LoadScene(2);
    }
    public void PlayTrack()
    {
        SceneManager.LoadScene(3);
    }



}
