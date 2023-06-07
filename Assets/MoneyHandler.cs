using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyHandler : MonoBehaviour
{
    public Image cursor;
    public Camera cam;
    public Text text;
    int cash;
    void Update()
    {
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out RaycastHit hit, 2.5F))
        {
            cursor.color = Color.cyan;
            if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Mouse0))
            {
                var money = hit.transform.GetComponentInParent<Money>();
                Debug.Log(money);
                if (money)
                {
                    money.OnPick();
                    cash++;
                    text.text = "Монеты : " + cash;
                }
            }
        }
        else cursor.color = Color.white;
    }
}
