using UnityEngine;

public class MenuContolller : MonoBehaviour
{


    public void RestartGame()
    {
        GameManger.instance.RestartGame();
    }

    public void QuitGame()
    {
        GameManger.instance.QuitGamne();
    }
}
