using System.Collections;
using UnityEngine;

public class Block : MonoBehaviour
{
    public void InitAndPlay(Vector3 moveVector, float speed, float time)
    {
        StartCoroutine(Move(moveVector, speed, time));
    }
    IEnumerator Move(Vector3 moveVector, float speed, float time)
    {
        while (time > 0)
        {
            transform.position += moveVector * speed * Time.deltaTime;
            time -= Time.deltaTime;
            yield return 1;
        }
        DestroyImmediate(gameObject);
        yield return null;
    }
}
