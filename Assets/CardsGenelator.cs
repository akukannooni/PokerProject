using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CardsGenelator: MonoBehaviour
{
    public GameObject[] cards;
    public GameObject change_canvas;
    public GameObject judgement_canvas;
    public int card_key = 0;
    public int card_limit = 1;
    public int card_number = 1;

    public int card_change_number_1 = 0;
    public int card_change_number_2 = 0;
    public int card_change_number_3 = 0;
    public int card_change_number_4 = 0;
    public int card_change_number_5 = 0;
    
    public int change_limit_1 = 0;
    public int change_limit_2 = 0;
    public int change_limit_3 = 0;
    public int change_limit_4 = 0;
    public int change_limit_5 = 0;
    public int all_limit = 0;
    public float x = -12.0f;

    public string rsfm;
    public string sfn;
    public string sfm;
    public string fokn;
    public string fhn;
    public string flm;
    public string stn;
    public string tokn;
    public string tpn1;
    public string tpn2;
    public string opn;
    public string kicker;

    public GameObject high_card_text;
    public GameObject one_pair_text;
    public GameObject two_pairs_text;
    public GameObject three_of_a_kind_text;
    public GameObject straight_text;
    public GameObject flash_text;
    public GameObject fullhouse_text;
    public GameObject four_of_a_kind_text;
    public GameObject straight_flash_text;
    public GameObject royal_straight_flash_text;

    GameObject card_1;
    GameObject card_2;
    GameObject card_3;
    GameObject card_4;
    GameObject card_5;

    void Start()
    {
        for (int i = 0; i < cards.Length; i++)
        {
            GameObject temp = cards[i];
            int randomIndex = Random.Range(i,cards.Length);
            cards[i] = cards[randomIndex];
            cards[randomIndex] = temp;
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
        all_limit++;
        if(all_limit <= 5)
        {
            if(card_limit <= 5)
            {
                if(card_number == 1)
                {
                    card_1 = Instantiate(cards[0 + card_key],new Vector3(x, 0f, 0f),Quaternion.Euler(0f, 0f, 0f));
                    card_key++;
                    card_limit++;
                    card_number++;
                    x += 6.0f;
                }
                else if(card_number == 2)
                {
                    card_2 = Instantiate(cards[0 + card_key],new Vector3(x, 0f, 0f),Quaternion.Euler(0f, 0f, 0f));
                    card_key++;
                    card_limit++;
                    card_number++;
                    x += 6.0f;
                }
                else if(card_number == 3)
                {
                    card_3 = Instantiate(cards[0 + card_key],new Vector3(x, 0f, 0f),Quaternion.Euler(0f, 0f, 0f));
                    card_key++;
                    card_limit++;
                    card_number++;
                    x += 6.0f;
                }
                else if(card_number == 4)
                {
                    card_4 = Instantiate(cards[0 + card_key],new Vector3(x, 0f, 0f),Quaternion.Euler(0f, 0f, 0f));
                    card_key++;
                    card_limit++;
                    card_number++;
                    x += 6.0f;
                }
                else if(card_number == 5)
                {
                    card_5 = Instantiate(cards[0 + card_key],new Vector3(x, 0f, 0f),Quaternion.Euler(0f, 0f, 0f));
                    card_key++;
                    card_limit++;
                    card_number++;

                    judgement_canvas.gameObject.SetActive(true);
                    change_canvas.gameObject.SetActive(true);
                }
                if(card_change_number_1 == 1)
                {
                    card_1 = Instantiate(cards[0 + card_key],new Vector3(-12.0f, 0f, 0f),Quaternion.Euler(0f, 0f, 0f));

                    card_key++;
                    card_limit++;
                    card_change_number_1 = 0;
                }

                if(card_change_number_2 == 1)
                {
                    card_2 = Instantiate(cards[0 + card_key],new Vector3(-6.0f, 0f, 0f),Quaternion.Euler(0f, 0f, 0f));

                    card_key++;
                    card_limit++;
                    card_change_number_2 = 0;
                }

                if(card_change_number_3 == 1)
                {
                    card_3 = Instantiate(cards[0 + card_key],new Vector3(0f, 0f, 0f),Quaternion.Euler(0f, 0f, 0f));

                    card_key++;
                    card_limit++;
                    card_change_number_3 = 0;
                }

                if(card_change_number_4 == 1)
                {
                    card_4 = Instantiate(cards[0 + card_key],new Vector3(6.0f, 0f, 0f),Quaternion.Euler(0f, 0f, 0f));

                    card_key++;
                    card_limit++;
                    card_change_number_4 = 0;
                }

                if(card_change_number_5 == 1)
                {
                    card_5 = Instantiate(cards[0 + card_key],new Vector3(12.0f, 0f, 0f),Quaternion.Euler(0f, 0f, 0f));

                    card_key++;
                    card_limit++;
                    card_change_number_5 = 0;
                }
            }
        }
        else if(all_limit == 6)
        {
            if(card_limit <= 5)
            {
                if(card_number == 1)
                {
                    card_1 = Instantiate(cards[0 + card_key],new Vector3(x, 0f, 0f),Quaternion.Euler(0f, 0f, 0f));
                    card_key++;
                    card_limit++;
                    card_number++;
                    x += 6.0f;
                }
                else if(card_number == 2)
                {
                    card_2 = Instantiate(cards[0 + card_key],new Vector3(x, 0f, 0f),Quaternion.Euler(0f, 0f, 0f));
                    card_key++;
                    card_limit++;
                    card_number++;
                    x += 6.0f;
                }
                else if(card_number == 3)
                {
                    card_3 = Instantiate(cards[0 + card_key],new Vector3(x, 0f, 0f),Quaternion.Euler(0f, 0f, 0f));
                    card_key++;
                    card_limit++;
                    card_number++;
                    x += 6.0f;
                }
                else if(card_number == 4)
                {
                    card_4 = Instantiate(cards[0 + card_key],new Vector3(x, 0f, 0f),Quaternion.Euler(0f, 0f, 0f));
                    card_key++;
                    card_limit++;
                    card_number++;
                    x += 6.0f;
                }
                else if(card_number == 5)
                {
                    card_5 = Instantiate(cards[0 + card_key],new Vector3(x, 0f, 0f),Quaternion.Euler(0f, 0f, 0f));
                    card_key++;
                    card_limit++;
                    card_number++;

                    judgement_canvas.gameObject.SetActive(true);
                    change_canvas.gameObject.SetActive(true);
                }

                if(card_change_number_1 == 1)
                {
                    card_1 = Instantiate(cards[0 + card_key],new Vector3(-12.0f, 0f, 0f),Quaternion.Euler(0f, 0f, 0f));

                    card_key++;
                    card_limit++;
                    card_change_number_1 = 0;
                }

                if(card_change_number_2 == 1)
                {
                    card_2 = Instantiate(cards[0 + card_key],new Vector3(-6.0f, 0f, 0f),Quaternion.Euler(0f, 0f, 0f));

                    card_key++;
                    card_limit++;
                    card_change_number_2 = 0;
                }

                if(card_change_number_3 == 1)
                {
                    card_3 = Instantiate(cards[0 + card_key],new Vector3(0f, 0f, 0f),Quaternion.Euler(0f, 0f, 0f));

                    card_key++;
                    card_limit++;
                    card_change_number_3 = 0;
                }

                if(card_change_number_4 == 1)
                {
                    card_4 = Instantiate(cards[0 + card_key],new Vector3(6.0f, 0f, 0f),Quaternion.Euler(0f, 0f, 0f));

                    card_key++;
                    card_limit++;
                    card_change_number_4 = 0;
                }

                if(card_change_number_5 == 1)
                {
                    card_5 = Instantiate(cards[0 + card_key],new Vector3(12.0f, 0f, 0f),Quaternion.Euler(0f, 0f, 0f));

                    card_key++;
                    card_limit++;
                    card_change_number_5 = 0;
                }
            }
            change_limit_1++;
            change_limit_2++;
            change_limit_3++;
            change_limit_4++;
            change_limit_5++;
        }
    }

    public void Cards_1_Change()
    {
        if(change_limit_1 == 0)
        {
            Destroy(card_1.gameObject);

            //card_1 = Instantiate(cards[0 + card_key],new Vector3(-12.0f, 0f, 0f),Quaternion.Euler(0f, 0f, 0f));
            card_limit--;
            card_key++;
            card_change_number_1 = 1;
            change_limit_1++;
        }
    }

    public void Cards_2_Change()
    {
        if(change_limit_2 == 0)
        {
            Destroy(card_2.gameObject);

            //card_2 = Instantiate(cards[0 + card_key],new Vector3(-6.0f, 0f, 0f),Quaternion.Euler(0f, 0f, 0f));
            card_limit--;
            card_key++;
            card_change_number_2 = 1;
            change_limit_2++;
        }
        
    }

    public void Cards_3_Change()
    {
        if(change_limit_3 == 0)
        {
            Destroy(card_3.gameObject);

            //card_3 = Instantiate(cards[0 + card_key],new Vector3(0f, 0f, 0f),Quaternion.Euler(0f, 0f, 0f));
            card_limit--;
            card_key++;
            card_change_number_3 = 1;
            change_limit_3++;
        }
    }

    public void Cards_4_Change()
    {
        if(change_limit_4 == 0)
        {
            Destroy(card_4.gameObject);

            //card_4 = Instantiate(cards[0 + card_key],new Vector3(6.0f, 0f, 0f),Quaternion.Euler(0f, 0f, 0f));
            card_limit--;
            card_key++;
            card_change_number_4 = 1;
            change_limit_4++;
        }

    }

    public void Cards_5_Change()
    {
        if(change_limit_5 == 0)
        {
            Destroy(card_5.gameObject);

            //card_5 = Instantiate(cards[0 + card_key],new Vector3(12.0f, 0f, 0f),Quaternion.Euler(0f, 0f, 0f));
            card_limit--;
            card_key++;
            card_change_number_5 = 1;
            change_limit_5++;
        }
    }

    public void Cards_Reset()
    {
        SceneManager.LoadScene("GameScene");

        card_key = 0;
        card_limit = 1;
        card_number = 1;

        card_change_number_1 = 0;
        card_change_number_2 = 0;
        card_change_number_3 = 0;
        card_change_number_4 = 0;
        card_change_number_5 = 0;
    
        change_limit_1 = 0;
        change_limit_2 = 0;
        change_limit_3 = 0;
        change_limit_4 = 0;
        change_limit_5 = 0;
        all_limit = 0;

        /* Destroy(card_1.gameObject);
        Destroy(card_2.gameObject);
        Destroy(card_3.gameObject);
        Destroy(card_4.gameObject);
        Destroy(card_5.gameObject);
        card_key = 0;
        card_limit = 1;
        card_number = 1;
        card_change_number_1 = 0;
        card_change_number_2 = 0;
        card_change_number_3 = 0;
        card_change_number_4 = 0;
        card_change_number_5 = 0;
        change_limit_1 = 0;
        change_limit_2 = 0;
        change_limit_3 = 0;
        change_limit_4 = 0;
        change_limit_5 = 0;
        all_limit = 0;
        x = -12.0f;
        for (int i = 0; i < cards.Length; i++)
        {
            GameObject temp =cards[i];
            int randomIndex = Random.Range(i,cards.Length);
            cards[i] = cards[randomIndex];
            cards[randomIndex] = temp;
        } */
    }
    
    public void Cards_Judgement()
    {
        int tags_1 = int.Parse(card_1.tag);
        int tags_2 = int.Parse(card_2.tag);
        int tags_3 = int.Parse(card_3.tag);
        int tags_4 = int.Parse(card_4.tag);
        int tags_5 = int.Parse(card_5.tag);
        int[] tags_all = {tags_1,tags_2,tags_3,tags_4,tags_5};
        List<string> list = new List<string>(){"A","K","Q","J",};
        string[] suit = {"spade","heart","diamond","club"};

        bool rsf = false;
        bool sf = false;
        bool fok = false;
        bool fh = false;
        bool fl = false;
        bool st = false;
        bool tok = false;
        bool tp = false;
        bool op = false;
        bool st54321 = false;
        bool stNormal = false;
        bool hc = false;

        for(int i = 10; i > 1; i--)
        {
            list.Add(i.ToString());
        }
        for(int i = 0; i < tags_all.Length; i++)
        {
            //配列の回数分回す
            for (int j = 0; j < tags_all.Length; j++)
            {
                //比較元より大きければ入れ替え
                if (tags_all[i] < tags_all[j])
                {
                    int y = tags_all[j];
                    tags_all[j] = tags_all[i];
                    tags_all[i] = y;
                }
            }
        }
        for(int m = 0; m < 13; m++)
        {
            //フラッシュ判定
            if(tags_all[0] % 4 == 0 && tags_all[1] % 4 == 0 && tags_all[2] % 4 == 0 && tags_all[3] % 4 == 0 && tags_all[4] % 4 == 0 ||
            tags_all[0] % 4 == 1 && tags_all[1] % 4 == 1 && tags_all[2] % 4 == 1 && tags_all[3] % 4 == 1 && tags_all[4] % 4 == 1 ||
            tags_all[0] % 4 == 2 && tags_all[1] % 4 == 2 && tags_all[2] % 4 == 2 && tags_all[3] % 4 == 2 && tags_all[4] % 4 == 2 ||
            tags_all[0] % 4 == 3 && tags_all[1] % 4 == 3 && tags_all[2] % 4 == 3 && tags_all[3] % 4 == 3 && tags_all[4] % 4 == 3)
            {
                fl = true;
                //ロイヤルストレートフラッシュ判定
                if(tags_all[0] / 4 == 0 && tags_all[1] / 4 == 1 && tags_all[2] / 4 == 2 && tags_all[3] / 4 == 3 && tags_all[4] / 4 == 4)
                {
                    rsf = true;
                    for(int i = 1; i < 8; i++)
                    {
                        //ストレートフラッシュ判定
                        if(tags_all[0] / 4 == i && tags_all[1] / 4 == i+1 && tags_all[2] / 4 == i+2 && tags_all[3] / 4 == i+3 && tags_all[4] / 4 == i+4 ||
                            tags_all[0] / 4 == 0 && tags_all[1] / 4 == 9 && tags_all[2] / 4 == 10 && tags_all[3] / 4 == 11 && tags_all[4] / 4 == 12)
                        {
                            sf = true;
                        }
                    }
                }
            }
            for(int l = 0; l < 8; l++)
            {
                //ストレート判定
                if(tags_all[0] / 4 == l && tags_all[1] / 4 == l+1 && tags_all[2] / 4 == l+2 && tags_all[3] / 4 == l+3 && tags_all[4] / 4 == l+4 ||
                    tags_all[0] / 4 == 0 && tags_all[1] / 4 == 9 && tags_all[2] / 4 == 10 && tags_all[3] / 4 == 11 && tags_all[4] / 4 == 12)
                {
                    st = true;
                }
                //ワンペア判定
                else if(tags_all[0] / 4 == m && tags_all[1] / 4 == m ||
                    tags_all[1] / 4 == m && tags_all[2] / 4 == m ||
                    tags_all[2] / 4 == m && tags_all[3] / 4 == m ||
                    tags_all[3] / 4 == m && tags_all[4] / 4 == m)
                {
                    op = true;
                    //フォーオブアカインド判定
                    if(tags_all[0] / 4 == m && tags_all[1] / 4 == m && tags_all[2] / 4 == m && tags_all[3] / 4 == m ||
                        tags_all[1] / 4 == m && tags_all[2] / 4 == m && tags_all[3] / 4 == m && tags_all[4] / 4 == m)
                    {
                        fok = true;
                    }
                    //フルハウス・スリーオブアカインド判定
                    else if(tags_all[0] / 4 == m && tags_all[1] / 4 == m && tags_all[2] / 4 == m)
                    {
                        for(int k = 1; k < 13; k++)
                        {
                            if(m != k && tags_all[3] / 4 == k && tags_all[4] / 4 == k)
                            {
                                fh = true;
                            }
                            else
                            {
                                tok = true;
                            }
                        }
                    }
                    else if(tags_all[2] / 4 == m && tags_all[3] / 4 == m && tags_all[4] / 4 == m)
                    {
                        for(int k = 1; k < 13; k++)
                        {
                            if(m != k && tags_all[0] / 4 == k && tags_all[1] / 4 == k)
                            {
                                fh = true;
                            }
                            else
                            {
                                tok = true;
                            }
                        }
                    }
                    else if(tags_all[1] / 4 == m && tags_all[2] / 4 == m && tags_all[3] / 4 == m)
                    {
                        tok = true;
                    }
                }
                //ツーペア・ハイカード判定
                for(int k = 1; k < 13; k++)
                {
                    if(tags_all[0] / 4 == m && tags_all[1] / 4 == m && m != k && tags_all[2] / 4 == k && tags_all[3] / 4 == k ||
                        tags_all[0] / 4 == m && tags_all[1] / 4 == m && m != k && tags_all[3] / 4 == k && tags_all[4] / 4 == k ||
                        tags_all[1] / 4 == m && tags_all[2] / 4 == m && m != k && tags_all[3] / 4 == k && tags_all[4] / 4 == k)
                    {
                        tp = true;
                    }
                    else
                    {
                        hc = true;
                    }
                }
            }
        }
        rsfm = list[tags_all[0] % 4];
        if(rsf == true && fl == true)
        {
            royal_straight_flash_text.SetActive(true);
            Debug.Log(rsfm +　"の" + "royal straight flash");
            Debug.Log(rsf);
        }
        for(int i = 0; i < 5; i++)
        {
            sfn = list[tags_all[i] / 4];
        }
        if(sf == true && fl == true)
        {
            sfm = list[tags_all[0] % 4];
            straight_flash_text.SetActive(true);
            Debug.Log(sfn + "で" + sfm + "の" + "straight");
            Debug.Log(sf);
        }
        fokn = list[tags_all[2] / 4];
        if(fok == true && op == true)
        {
            four_of_a_kind_text.SetActive(true);
            Debug.Log(fokn + "の" + "four of a kind");
            Debug.Log(fok);
        }
        fhn = list[tags_all[2] / 4];
        if(fh == true && op == true)
        {
            fullhouse_text.SetActive(true);
            Debug.Log(fhn + "の" + "fullhouse");
            Debug.Log(fh);
        }
        flm = suit[tags_all[0] % 4];
        if(fl == true && rsf == false && sf == false)
        {
            flash_text.SetActive(true);
            Debug.Log(flm + "の" + "flash");
            Debug.Log(fl);
        }
        if(st == true)
        {
            for(int i = 0; i < 5; i++)
            {
                if(tags_all[0] / 4 == 0 && tags_all[1] / 4 == 9)
                {
                    st54321 = true;
                }
                else
                {
                    stNormal = true;
                }
            }
        }
        if(st54321 == true)
        {
            straight_text.SetActive(true);
            Debug.Log(list[9] + list[10] + list[11] + list[12] + list[0] + "の" + "straight");
            Debug.Log(st);
        }
        else if(stNormal == true)
        {
            for(int i = 0; i < 5; i++)
            {
                stn = list[tags_all[i] / 4];
            }
            straight_text.SetActive(true);
            Debug.Log(stn + "の" + "straight");
            Debug.Log(st);
        }
        tokn = list[tags_all[2] / 4];
        if(tok == true && op == true && fh == false)
        {
            three_of_a_kind_text.SetActive(true);
            Debug.Log(tokn + "の" + "three of a kind");
            Debug.Log(tok);
        }
        tpn1 = list[tags_all[1] / 4];
        tpn2 = list[tags_all[3] / 4];
        if(tp == true && op == true && fh == false)
        {
            two_pairs_text.SetActive(true);
            Debug.Log(tpn1 + "と" + tpn2 + "の" + "two pairs");
            Debug.Log(tp);
        }
        else if(op == true && fh == false && tok == false && tp == false)
        {
            one_pair_text.SetActive(true);
            Debug.Log(op);
            if(tags_all[0] / 4 == tags_all[1] / 4)
            {
                opn = list[tags_all[0] / 4];
                kicker = list[tags_all[2] / 4];
                Debug.Log("キッカーが" + kicker + "で" + opn + "の" + "one pair");
            }
            else if(tags_all[1] / 4 == tags_all[2] / 4 ||
                tags_all[2] / 4 == tags_all[3] / 4)
            {
                opn = list[tags_all[2] / 4];
                kicker = list[tags_all[0] / 4];
                Debug.Log("キッカーが" + kicker + "で" + opn + "の" + "one pair");
            }
            else if(tags_all[3] / 4 == tags_all[4] / 4)
            {
                opn = list[tags_all[3] / 4];
                kicker = list[tags_all[0] / 4];
                Debug.Log("キッカーが" + kicker + "で" + opn + "の" + "one pair");
            }
        }
        if(hc == true && rsf == false && sf == false && fok == false && fh == false && fl == false && st == false && tok == false && tp == false && op == false)
        {
            high_card_text.SetActive(true);
            Debug.Log("high card");
        }
    }
}