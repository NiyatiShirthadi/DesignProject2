using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlacknessFadeIn : MonoBehaviour
{
    public delegate void DarknessCreated();
    public static event DarknessCreated tisDark;

    public Renderer spriteRenderer;
    public Material InstancedMaterial;

    

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<Renderer>();
        InstancedMaterial = spriteRenderer.material;

        InstancedMaterial.SetFloat("Vector1_44E09FD1", -0.1f);

        StartCoroutine(creatingBlackness());

    }

    IEnumerator creatingBlackness()
    {
        

        yield return new WaitForSeconds(3f);

        InstancedMaterial.SetFloat("Vector1_44E09FD1", 0f);

        float x = 0.0f;
        float timeElapsed = 0.0f;
        while (timeElapsed < 0.5f)
        {
            InstancedMaterial.SetFloat("Vector1_8F0A723E", x);
            x = x + 0.1f;
            timeElapsed += Time.deltaTime;

            yield return new WaitForSeconds(0.05f);
        }

        if (tisDark != null)
        {
           tisDark();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
