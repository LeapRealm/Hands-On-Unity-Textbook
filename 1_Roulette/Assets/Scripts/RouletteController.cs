using UnityEngine;

public class RouletteController : MonoBehaviour
{
    private float rotSpeed = 0; // 회전 속도

    private void Update()
    {
        // 클릭하면 회전 속도를 설정한다.
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 4320;
        }

        // 회전 속도만큼 룰렛을 회전시킨다.
        transform.Rotate(0, 0, this.rotSpeed * Time.deltaTime);

        // 룰렛을 감속시킨다.
        this.rotSpeed *= 0.99f;
    }
}