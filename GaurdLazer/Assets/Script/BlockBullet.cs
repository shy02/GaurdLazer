using UnityEngine;
using UnityEngine.UI;

public class BlockBullet : MonoBehaviour
{
    [SerializeField] Damage dmage;

    private void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log("Ãæµ¹");
        dmage.Getdamage(10);
    }
}
