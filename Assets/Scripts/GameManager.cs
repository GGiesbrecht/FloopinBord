using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Animator birdAnimator;
    public Animator playButtonAnimator;
    public Animator blackScreenAnimator;

    public void Play() {
        birdAnimator.SetBool("GameStarted", true);
        playButtonAnimator.SetBool("GameStarted", true);
    }

    public void FadeToBlack() {
        blackScreenAnimator.SetBool("GameStarted", true);
    }

    public void LoadNextScene() {
        SceneManager.LoadScene("Play");
    }
}
