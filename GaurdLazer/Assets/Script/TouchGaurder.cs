using UnityEngine;

public class TouchGaurder : MonoBehaviour
{
    [SerializeField] float force = 100f;
    public void Click_Obejct(GameObject LR)
    {
        LR.GetComponent<Rigidbody2D>().AddForce(Vector2.up * force,ForceMode2D.Force);
    }
}
