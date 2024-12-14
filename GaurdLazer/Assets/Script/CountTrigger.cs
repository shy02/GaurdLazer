using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CountTrigger : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textMeshPro;
    [SerializeField] GameManager gameManager;

    int Score = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.Score += 100;
        Score = gameManager.Score;
        textMeshPro.text = "Score : " + Score;
    }
}
