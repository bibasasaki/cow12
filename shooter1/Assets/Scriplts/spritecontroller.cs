
using UnityEngine;

public class spritecontroller : MonoBehaviour
{
    [SerializeField] float backAngle = 65f;
    [SerializeField] float sideAngle = 155f;
    [SerializeField] Transform mainTransform;
    [SerializeField] Animator animator;
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] Camera _camera;

    private void  Awake()
    {
        _camera = Camera.main;
    }
   
    private void LateUpdate()
    {
        Vector3 camForwardVector =  new Vector3(_camera.transform.forward.x, 0f, _camera.transform.forward.z);

        float signedAngle = Vector3.SignedAngle(mainTransform.forward, camForwardVector, Vector3.up);

        Vector2 animationDiraction  = new Vector2(0f, - 1f);

        float angle = Mathf.Abs(signedAngle);

        if (angle < backAngle)
        {
            animationDiraction = new Vector2(0f, -1f);
        }
        else if (angle < sideAngle)
        {
            animationDiraction = new Vector2(1f, 0f);
        }
        else
        {
            animationDiraction = new Vector2(0f, 1f);
        }
        animator.SetFloat("moveX", animationDiraction.x);
        animator.SetFloat("moveY", animationDiraction.y);
    }
}
