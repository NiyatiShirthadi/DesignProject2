using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BlacknessVisibility : MonoBehaviour
{
    public Material newMaterial;
    public Renderer spriteRenderer;
    public Material InstancedMaterial;

    private void Start()
    {

        spriteRenderer = gameObject.GetComponent<Renderer>();
        spriteRenderer.material = newMaterial;
        InstancedMaterial = gameObject.GetComponent<Renderer>().material;

        InstancedMaterial.SetFloat("Vector1_44E09FD1", -0.1f);
        //gameObject.GetComponent<SpriteRenderer>().enabled = false;

        CreateTheBlackness.letThereBeDark += RevealBlackness;
        LevelTransition.nextLevel += resetBlackness;

        
    }
    // Start is called before the first frame update
    private void Awake()
    {
        
    }
    
    public void resetBlackness()
    {
        StartCoroutine(DelayReset());
        
    }

    IEnumerator DelayReset()
    {
        yield return new WaitForSeconds(0.5f);
        InstancedMaterial.SetFloat("Vector1_44E09FD1", -0.1f);
    }

    public void RevealBlackness()
    {
        //Debug.Log("Blackness is HERE!");
        //gameObject.GetComponent<SpriteRenderer>().enabled = true;


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

            yield return new WaitForSeconds(0.05f);
        }
    }

    private void OnDisable()
    {
        CreateTheBlackness.letThereBeDark -= RevealBlackness;
        LevelTransition.nextLevel -= resetBlackness;

    }

}
