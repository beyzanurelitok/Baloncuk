using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class NoktaOlusturucusu : MonoBehaviour
{
   
    private float zamanSayaci = 0f;
    public TextMeshProUGUI zamanText;
    public GameObject noktaPrefab;
    public int noktaSayisi;
    public float xSiniri;
    public float ySiniri;
    public TextMeshProUGUI scoreText;
    private int score;
    public TextMeshProUGUI levelText;
    private bool isGameOver = false;

    void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score;
        for (int i = 0; i < noktaSayisi; i++)
        {
            Vector2 noktaPozisyonu = new Vector2(Random.Range(-xSiniri, xSiniri), Random.Range(-ySiniri, ySiniri));
            Color noktaRengi = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
            GameObject nokta = Instantiate(noktaPrefab, noktaPozisyonu, Quaternion.identity);
            nokta.GetComponent<SpriteRenderer>().color = noktaRengi;
            nokta.AddComponent<BoxCollider2D>();
            nokta.AddComponent<Nokta>();
            nokta.GetComponent<Nokta>().parent = this;

        }



    }

    public void OnClick(Nokta nokta)
    {
        score++;
        Debug.Log("score arttýrýldý"+score);
    }


    void Update()
    {
        zamanSayaci += Time.deltaTime;
        zamanText.text = zamanSayaci.ToString("F2");
        if (Input.GetMouseButtonDown(0) && !isGameOver)
        {
            // Fare pozisyonundaki nesneyi al
            Collider2D týklanan = Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition));

            // Nesne varsa yok et
            if (týklanan != null)
            {
                noktaSayisi--;
                Destroy(týklanan.gameObject);
            }
            else
            {
                if (SceneManager.GetActiveScene().name == "level3")
                {
                    isGameOver = true;
                    SceneManager.LoadScene("GameOverScene");
                }
            }
            
        }
        scoreText.text = "Score: " + score;

      

    }
    
}
