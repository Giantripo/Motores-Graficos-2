using System.Collections.Generic;
using UnityEngine;

public class Controller_Instantiator : MonoBehaviour
{
    public List<GameObject> enemies;
    public GameObject instantiatePos;
    public float respawningTimer;
    public float time = 0;
    public GameObject nafta;

    void Start()
    {
        Controller_Enemy.enemyVelocity = 2;
        ControllerNafta.naftaVelocity = 2;
    }

    void Update()
    {
        SpawnEnemies();
        ChangeVelocity();
    }

    private void ChangeVelocity()
    {
          //a medida que pasa el tiempo, este aumenta y hace que vayan mas rapido los enemigos
        time += Time.deltaTime;
        Controller_Enemy.enemyVelocity = Mathf.SmoothStep(1f, 15f, time / 45f);
        ControllerNafta.naftaVelocity = Mathf.SmoothStep(1f, 15f, time / 50f);
    }

    private void SpawnEnemies()
    {
        //hace que respawningTimer disminuya y genera el primer enemigo
        respawningTimer -= Time.deltaTime;
        //cuando respawningTimer es menor a 0 se genera un nuevo enemigo de forma aleatoria en la lista de enemigos que hay y tambien se controlan cada cuanto spawnean uno del otro
        if (respawningTimer <= 0)
        {
            Instantiate(enemies[UnityEngine.Random.Range(0, enemies.Count)], instantiatePos.transform);
            Instantiate(nafta, instantiatePos.transform);
            respawningTimer = UnityEngine.Random.Range(2, 6);
        }

    }

}
