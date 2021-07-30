using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toPlayScene : MonoBehaviour
{
    void Play() {
      UnityEngine.SceneManagement.SceneManager.LoadScene("Play");  
    }
}
