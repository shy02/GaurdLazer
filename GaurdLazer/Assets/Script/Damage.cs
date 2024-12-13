using UnityEngine;
using UnityEngine.UI;

public class Damage : MonoBehaviour
{
    [SerializeField] float MaxHP;
    float recentHP;
    private void Start()
    {
        GetComponent<Slider>().maxValue = MaxHP;
        GetComponent<Slider>().value = MaxHP;

        recentHP = MaxHP;
    }
    public void Getdamage(float dmg)
    {
        recentHP -= dmg;
        GetComponent <Slider>().value = recentHP;
    }
}
