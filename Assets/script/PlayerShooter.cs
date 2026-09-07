using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    public BulletMover prefab;
    public Transform camTransform;


    private void Start()
    {
        if (camTransform == null)
            camTransform = transform.Find("Camera");
    }

    public void OnAttack()
    {
        Instantiate<BulletMover>(prefab, camTransform.position, camTransform.rotation);
    }

}
