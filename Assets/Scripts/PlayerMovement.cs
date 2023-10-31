using DG.Tweening;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 20f;
    public Swipe swipeControls;
    bool rightEnable = true;
    bool leftEnable = true;

    void Start()
    {
        DOTween.Init();
    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.World);

        if ((swipeControls.SwipeLeft|| Input.GetKeyDown(KeyCode.LeftArrow)) && leftEnable)
        {
            leftEnable = false;
            transform.DOMoveX(transform.position.x - 3, 0.2f).OnComplete(()=>setEnable(ref leftEnable));
        }
        if ((swipeControls.SwipeRight || Input.GetKeyDown(KeyCode.RightArrow)) && rightEnable)
        {
            rightEnable = false;
            transform.DOMoveX(transform.position.x + 3, 0.2f).OnComplete(() => setEnable(ref rightEnable));
        }
        
    }

    void setEnable(ref bool enable)
    {
        enable = true;
    }
}
