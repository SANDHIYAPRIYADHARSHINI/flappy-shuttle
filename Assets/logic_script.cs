using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logic_script : MonoBehaviour
{
    public int playerscore;
    public GameObject gameover;
    public Text score;
    [ContextMenu("Increase score")]
    public void countpoints(int scoretoadd)
    {
        playerscore += scoretoadd;
        score.text=playerscore.ToString();//coz playerscore is int and score is a string
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameover.SetActive(true);
    }
}
