using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardsGenelator1: MonoBehaviour
{
    public GameObject[] cards;
    float x;
    void Start()
    {
        for (int i = 0; i < cards.Length; i++)
        {
            GameObject temp =cards[i];
            int randomIndex = Random.Range(i,cards.Length);
            cards[i] = cards[randomIndex];
            cards[randomIndex] = temp;
            x += 0.05f;
            var obj = Instantiate(cards[i], new Vector3(0f, x * 0.01f, 0f),Quaternion.Euler(180f,0f,0f));
            Debug.Log(cards[i]);
            obj.name = cards[i].name;
        }

            /*for (int i = 0; i < cards.Length; i++)
            {
                GameObject temp =cards[i];
                int randomIndex = Random.Range(i,cards.Length);
                cards[i] = cards[randomIndex];
                cards[randomIndex] = temp;
                x += 0.05f;
                Instantiate(cards[i], new Vector3(x *1.2f, 0f, 0f),Quaternion.identity);
                Debug.Log(cards[i]);
            }*/
    }

    void Update()
    {
        
    }

    public void onClickAct()
    {

        /*
        Debug.Log(cards[51 - counter].name);

        Vector3 tmp = GameObject.Find("cards[51 - counter].name").transform.position;
        GameObject.Find("cards[51 - counter].name").transform.position = new Vector3(tmp.x - 20, tmp.y * 0, tmp.z + 2 * counter);

        counter++;
        */
        var counterMax = 52;
        // Debug.Log("test");
        for(int counter = 0;counter < counterMax;counter++)
        {
            if (counter < 2)
            {
                Debug.Log(cards[51 - counter].name);
                GameObject tmp = GameObject.Find("cards[51 - counter].name");
                Vector3 cardsVector = this.transform.position;
                cardsVector = this.gameObject.transform.position;
                cardsVector.x = -5 + 2 * counter;
                cardsVector.y = 0;
                cardsVector.z = -10;
                Debug.Log("test" + counter);
            }
        }
    }
}