using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class VikingHealth : MonoBehaviour {

    [SerializeField]
    private float health;
    [SerializeField]
    private float customDamage;
    private float healthTemp;

    [Header("Referencias")]

    [SerializeField]
    private Text gameOverText;
    private SkinnedMeshRenderer[] objectRenderer = new SkinnedMeshRenderer[3];

    void Start()
    {
        objectRenderer = GetComponentsInChildren<SkinnedMeshRenderer>();
        healthTemp = health;
    }

    void Update()
    {
        Debug.Log(health);

        if (health <= 0)
        {
            gameOverText.text = "GAME OVER";
            Disapear();
        }

        //TEST

        if (Input.GetKeyDown(KeyCode.X))
        {
            MakeDamage(customDamage);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Restart();
        }
    }

    private void MakeDamage(float damage)
    {
        health -= damage;
    }

    private void Disapear()
    {
        for(int i = 0; i < objectRenderer.Length; i++)
        {
            objectRenderer[i].enabled = false;
        }
    }

    private void Restart()
    {
        for (int i = 0; i < objectRenderer.Length; i++)
        {
            objectRenderer[i].enabled = true;
        }

        health = healthTemp;
        gameOverText.text = "";
    }
}