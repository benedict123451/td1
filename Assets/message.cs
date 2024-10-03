using UnityEngine;
using UnityEngine.UI;

public class DisplayTime : MonoBehaviour
{
    public Text congratulationText;  // Le texte UI pour afficher la félicitation et le temps(ne récupère pas le text )

    void Start()
    {
        // Récupérer le temps depuis le GameManager et l'afficher(ça marche pas)
        float timeTaken = GameManager.elapsedTime;
        congratulationText.text = "Félicitations ! Vous avez terminé en " + timeTaken.ToString("F2") + " secondes.";
    }
}