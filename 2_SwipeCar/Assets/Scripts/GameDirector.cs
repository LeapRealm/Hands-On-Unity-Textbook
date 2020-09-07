using UnityEngine;
using UnityEngine.UI; // UI를 사용하기 위해 필요

public class GameDirector : MonoBehaviour
{
    private GameObject car;
    private GameObject flag;
    private GameObject distance;

    private void Start()
    {
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
    }

    private void Update()
    {
        float length = this.flag.transform.position.x - this.car.transform.position.x;

        if (length >= 0)
        {
            this.distance.GetComponent<Text>().text = "목표 지점까지 " + length.ToString("F2") + "m";
        }
        else
        {
            this.distance.GetComponent<Text>().text = "게임 오버";
        }
    }
}