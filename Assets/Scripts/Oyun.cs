using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static UnityEngine.Random;

public class Oyun : MonoBehaviour
{
    public GameObject noktaPrefab;
    public TextMeshProUGUI scoreText;
    private float zamanSayaci = 0f;
    public TextMeshProUGUI zamanText;
    private int score;
    public List<Nokta> noktalar = new List<Nokta>();
    

    private void Start()
    {
        zamanSayaci += Time.deltaTime;
        // Noktalarý oluþtur
        for (int i = 0; i < 10; i++)
        {
            float x = Random.Range(-5f, 5f);
            float y = Random.Range(-3f, 3f);
            Color color = Random.ColorHSV();
            GameObject noktaObj = Instantiate(noktaPrefab, new Vector3(x, y, 0f), Quaternion.identity);
            Nokta nokta = noktaObj.GetComponent<Nokta>();
            nokta.color = color;
            noktalar.Add(nokta);
        }

       
    }

   


}
