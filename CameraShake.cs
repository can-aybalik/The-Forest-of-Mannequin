using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public Light light;
    public GameObject redGuy;
    public GameObject horde;
    public HordeTrigger hordeTrigger;
    public IEnumerator Shake ( float duration, float magnitude)
    {
        Vector3 originalPos = transform.localPosition;
        float elapsed = 0.0f;
        while(elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            transform.localPosition = new Vector3(x, y, originalPos.z);
            light.color = Color.red;

            if (!hordeTrigger.triggered)
            {
                redGuy.SetActive(true);
            }
            else
            {
                horde.SetActive(true);
            }
            

            elapsed += Time.deltaTime;

            yield return null;
        }

        light.color = Color.white;


        redGuy.SetActive(false);
        horde.SetActive(false);
        transform.localPosition = originalPos;
    }
}
