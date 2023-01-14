using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    CodeyMove cm;
    public float Speed;
    float baseSpeed;

    // Start is called before the first frame update
    void Start()
    {
        cm = GameObject.FindGameObjectWithTag("Player").GetComponent<CodeyMove>();
        baseSpeed = cm.Speed;
        cm.Speed = Speed;
        StartCoroutine(speedTime());
    }

    private void destroyGameObject()
    {
        Destroy(gameObject);
    }

    IEnumerator speedTime()
    {
        cm.Speed = Speed;
        yield return new WaitForSeconds(3f);
        cm.Speed = baseSpeed;
        destroyGameObject();
    }
}
