using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameButton : MonoBehaviour
{
    public int gameStartScreen;

    public void startGame() {
        SceneManager.LoadScene(gameStartScreen);
    }
}
