using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static float elapsedTime;  // Variable statique pour stocker le temps écoulé

    void Start()
    {
        // Réinitialiser le temps écoulé au début du niveau (ça marche pas)
        elapsedTime = 0f;
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;
    }

    public void CompleteLevel()
    {
        SceneManager.LoadScene("Felicitation");
    }
}