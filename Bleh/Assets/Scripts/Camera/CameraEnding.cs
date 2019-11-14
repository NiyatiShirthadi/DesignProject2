using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CC2D;

public class CameraEnding : MonoBehaviour
{
    public Transform target;
    public float smoothDampTime = 0.2f;
    [HideInInspector]
    public new Transform transform;
    public Vector3 cameraOffset;
    public bool useFixedUpdate = false;

    private Meepy_CharacterController _playerController;
    private Vector3 _smoothDampVelocity;


    void Awake()
    {

        target = GameObject.Find("Player").GetComponent<Transform>();
        transform = gameObject.transform;
        _playerController = target.GetComponent<Meepy_CharacterController>();

        ZoomOutTrigger.EndScene += Refocus;
    }

    public void Refocus()
    {
        StartCoroutine(movingCamera());
    }

    IEnumerator movingCamera()
    {
        yield return new WaitForSeconds(3f);

        float currentTime = 0f;
        float zoomTime = 1f;

        while (currentTime <= zoomTime)
        {
            currentTime += Time.deltaTime;

            //cameraOffset.x = Mathf.Lerp(0f, 16f, currentTime / zoomTime);
            //cameraOffset.x = 16f;
            //yield return new WaitForSeconds(0.025f);
            //cameraOffset.y = Mathf.Lerp(0f, -7.5f, currentTime / zoomTime);
            //cameraOffset.y = -7.5f;
            //yield return new WaitForSeconds(0.025f);
        }
    }


    void LateUpdate()
    {
        if (!useFixedUpdate)
            updateCameraPosition();
    }


    void FixedUpdate()
    {
        if (useFixedUpdate)
            updateCameraPosition();
    }


    void updateCameraPosition()
    {
        if (_playerController == null)
        {
            transform.position = Vector3.SmoothDamp(transform.position, target.position - cameraOffset, ref _smoothDampVelocity, smoothDampTime);
            return;
        }

        if (_playerController.velocity.x > 0)
        {
            transform.position = Vector3.SmoothDamp(transform.position, target.position - cameraOffset, ref _smoothDampVelocity, smoothDampTime);
        }
        else
        {
            var leftOffset = cameraOffset;
            leftOffset.x *= -1;
            transform.position = Vector3.SmoothDamp(transform.position, target.position - leftOffset, ref _smoothDampVelocity, smoothDampTime);
        }
    }

    private void OnDisable()
    {
        ZoomOutTrigger.EndScene -= Refocus;
    }

}


