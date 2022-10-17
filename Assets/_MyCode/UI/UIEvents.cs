using TMPro;
using UnityEngine;

public class UIEvents : MonoBehaviour
{

    public TMP_InputField inputFieldSpawnDuration;
    public TMP_InputField inputFieldSpeed;
    public TMP_InputField inputFieldDistance;


    public void SeyBlockSpawnerSpawnDuration()
    {
        float f;
        if (float.TryParse(inputFieldSpawnDuration?.text, out f))
            StaticLinks.blockSpawner?.SetSpawnDuration(f);
    }
    public void SeyBlockSpawnerSpeed()
    {
        float f;
        if (float.TryParse(inputFieldSpeed?.text, out f))
            StaticLinks.blockSpawner?.SetSpeed(f);
    }
    public void SeyBlockSpawnerDistance()
    {
        float f;
        if (float.TryParse(inputFieldDistance?.text, out f))
            StaticLinks.blockSpawner?.SetDistance(f);
    }
}
