using UnityEngine;
using UnityEngine.UI; // UI를 사용하므로 잊지 말고 추가

public class GameDirector : MonoBehaviour
{
    private GameObject hpGauge;

    private void Start()
    {
        hpGauge = GameObject.Find("hpGauge");
    }

    public void DecreaseHP()
    {
        hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
}