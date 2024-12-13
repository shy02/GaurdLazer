using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CountTrigger : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textMeshPro;
    int Score = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score++;
        textMeshPro.text = "Score : " + Score;
    }
}
