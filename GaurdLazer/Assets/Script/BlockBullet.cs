using UnityEngine;
using UnityEngine.UI;

public class BlockBullet : MonoBehaviour
{
    [SerializeField] Damage dmage;

    private void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log("�浹");
        dmage.Getdamage(10);
    }
}
