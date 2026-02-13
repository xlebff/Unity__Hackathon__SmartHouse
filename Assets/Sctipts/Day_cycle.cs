using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day_cycle : MonoBehaviour
{
    [SerializeField]
    private Light[] lights;
    [SerializeField]
    private bool day = true;

    [SerializeField]
    private float time = 0;

    private void FixedUpdate()
    {
        time += Time.deltaTime;
        if (time >= 10 && day)
        {
            StartCoroutine(GoDark());
        }
    }

    IEnumerator GoDark()
    {
        day = false;
        for (float i = 1; i > 0; i -= 0.0001f)
        {
            foreach (Light light in lights)
            {
                light.intensity = i;
            }
            yield return 1;
        }
    }

    IEnumerator GoLight()
    {
        day = true;
        for (float i = 0; i < 1; i += 0.0001f)
        {
            foreach (Light light in lights)
            {
                light.intensity = i;
            }
            yield return 1;
        }
    }
}
