using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingFade : MonoBehaviour
{
    public Material newMaterial;
    public Renderer spriteRenderer;
    public Material InstancedMaterial;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<Renderer>();
        spriteRenderer.material = newMaterial;
        InstancedMaterial = gameObject.GetComponent<Renderer>().material;

        InstancedMaterial.SetFloat("Vector1_44E09FD1", -0.1f);
        //gameObject.GetComponent<SpriteRenderer>().enabled = false;

        ZoomOutTrigger.EndScene += BlacknessFade;
    }

    public void BlacknessFade()
    {
        InstancedMaterial.SetFloat("Vector1_44E09FD1", 0f);

        StartCoroutine(DissolveEffect());
    }

    IEnumerator DissolveEffect()
    {
        float x = 0.0f;
        float timeElapsed = 0.0f;
        while (timeElapsed < 0.5f)
        {
            InstancedMaterial.SetFloat("Vector1_8F0A723E", x);
            x = x + 0.1f;
            timeElapsed += Time.deltaTime;

            yield return new WaitForSeconds(0.25f);
        }

        //yield return new WaitForSeconds(3f);

        //float y = 1f;
        //float timeCountdown = 0.0f;

        //while (timeCountdown < 0.5f)
        //{
        //    InstancedMaterial.SetFloat("Vector1_8F0A723E", y);
        //    y = y - 0.1f;
        //    timeCountdown += Time.deltaTime;

        //    yield return new WaitForSeconds(0.05f);
        //}

    }

    private void OnDisable()
    {
        ZoomOutTrigger.EndScene -= BlacknessFade;
    }
}
