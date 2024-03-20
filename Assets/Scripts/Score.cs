using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Text scoreDisplay;
    public int threeStars = 3;
    public int twoStars = 6;
    public Animator scoreAnimator;
    public int nextLevel = 0;

    public void EndLevel()
    {
        Cannon cannon = FindFirstObjectByType<Cannon>();
        if (cannon)
        {
            int numProjectiles = cannon.numProjectiles;

            if (numProjectiles <= 0) 
            {
                print("How did you do that?");
                scoreDisplay.text = "How did you do that?";
            }
            else if (numProjectiles < threeStars) 
            {
                scoreDisplay.text = "Three Stars!";
                scoreAnimator.SetInteger("Stars", 3);
            }
            else if (numProjectiles < twoStars) 
            {
                scoreDisplay.text = "Two Stars!";
                scoreAnimator.SetInteger("Stars", 2);
            }
            else 
            {
                scoreDisplay.text = "One Stars!";
                scoreAnimator.SetInteger("Stars", 1);
            }
            Invoke("NextLevel", 2);
        }
    }
    void NextLevel()
    {
        SceneManager.LoadScene(nextLevel);
    }
}
