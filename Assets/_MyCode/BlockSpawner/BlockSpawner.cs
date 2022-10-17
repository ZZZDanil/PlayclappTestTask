using System.Collections;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    private float spawnDuration = 1;
    private float speed = 1;
    private float distance = 10;

    private Coroutine coroutine;

    public GameObject block;
    public Vector3 moveVector;

    private void Awake()
    {
        StaticLinks.blockSpawner = this;
    }

    void Start()
    {
        coroutine = StartCoroutine(Spawn());
    }

    public void SetSpawnDuration(float newSpawnDuration)
    {
        if (newSpawnDuration > 0 && newSpawnDuration < 10)
            spawnDuration = newSpawnDuration;
    }
    public void SetSpeed(float newSpeed)
    {
        if (newSpeed > 0 && newSpeed < 1000)
            speed = newSpeed;
    }
    public void SetDistance(float newDistance)
    {
        if (newDistance > 0 && newDistance < 1000)
            distance = newDistance;
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            if (block != null)
            {
                GameObject gameObject = Instantiate(block, transform);
                if (gameObject != null)
                {
                    float time = speed == 0 ? 0 : distance / speed;
                    gameObject.GetComponent<Block>()?.InitAndPlay(moveVector, speed, time);
                }
            }
            yield return new WaitForSeconds(spawnDuration);
        }
    }
}
