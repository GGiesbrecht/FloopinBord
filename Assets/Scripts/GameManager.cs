using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Animator birdAnimator;
    public Animator playButtonAnimator;
    public Animator blackScreenAnimator;

    public void Play() {
        birdAnimator.SetBool("GameStarted", true);
        playButtonAnimator.SetBool("GameStarted", true);
        blackScreenAnimator.SetBool("GameStarted", true);
    }
}
