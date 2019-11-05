using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothZoomOut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ZoomOutTrigger.EndScene += zoomOut;
    }

    public void zoomOut()
    {
        Debug.Log("Camera Zooming Out");
        //Camera.main.orthographicSize = 15f;

        StartCoroutine(zoomingNow());
        
    }

    IEnumerator zoomingNow()
    {
        float currentTime = 0f;
        float zoomTime = 2f;

        while (currentTime <= zoomTime)
        {
            currentTime += Time.deltaTime;
            Camera.main.orthographicSize = Mathf.Lerp(7.5f, 11.5f, currentTime / zoomTime);
            yield return new WaitForSeconds(0.025f);
        }
    }

    private void OnDisable()
    {
        ZoomOutTrigger.EndScene -= zoomOut;
    }
}
