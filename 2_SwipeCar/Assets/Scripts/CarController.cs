using UnityEngine;

public class CarController : MonoBehaviour
{
    private float speed = 0;
    private Vector2 startPos;

    private void Update()
    {
        // 스와이프 길이를 구한다.
        if (Input.GetMouseButtonDown(0))
        {
            // 마우스를 클릭한 좌표
            this.startPos = Input.mousePosition;
        } 
        else if (Input.GetMouseButtonUp(0))
        {
            // 마우스 버튼에서 손가락을 떼었을 때 좌표
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - this.startPos.x;

            // 스와이프 길이를 처음 속도로 변경한다.
            this.speed = swipeLength / (Screen.width / 100.0f);

            // 효과음 재생
            GetComponent<AudioSource>().Play();
        }

        transform.Translate(this.speed * Time.deltaTime, 0, 0);
        this.speed *= 0.99f;
    }
}