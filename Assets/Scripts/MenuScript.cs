using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
   
}
