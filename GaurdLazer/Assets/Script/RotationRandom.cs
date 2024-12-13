using System.Collections;
using UnityEngine;

public class RotationRandom : MonoBehaviour
{
    float randomZ;
    [SerializeField] Transform Bullet_;
    [SerializeField] Transform spawnL;
    [SerializeField] Transform spawnR;
    [SerializeField] GameObject bullet;
    private void Start()
    {
        StartCoroutine(RotationMuchine());
    }

    IEnumerator RotationMuchine()
    {
        float nowrot = transform.rotation.eulerAngles.z;
        if (nowrot > 300f) nowrot = nowrot - 360;
        Debug.Log(nowrot);
        randomZ = Random.Range(-30f, 30f);
        Debug.Log(randomZ);
        if (randomZ > nowrot)
        {
            for(float i = nowrot; i < randomZ; i++)
            {
                transform.rotation = Quaternion.Euler(0, 0, i);
                yield return new WaitForSeconds(0.01f);
            }
        }
        else 
        {
            for (float i = nowrot; i > randomZ; i--)
            {
                transform.rotation = Quaternion.Euler(0, 0, i);
                yield return new WaitForSeconds(0.01f);
            }
        }
        yield return new WaitForSeconds(5f);
        Shot_bullet();
        yield return new WaitForSeconds(1f);
        StartCoroutine(RotationMuchine());
    }

    public void Shot_bullet()
    {
        Debug.Log("shot");
        GameObject LeftBullet = Instantiate(bullet, spawnL.position,spawnL.rotation,Bullet_);
        LeftBullet.GetComponent<Bullet>().Shot();
        GameObject RightBullet = Instantiate(bullet, spawnR.position, spawnR.rotation, Bullet_);
        RightBullet.GetComponent<Bullet>().Shot();
    }
}
