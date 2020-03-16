using UnityEngine;
using UnityEngine.UI;

public class BlockSpawner : MonoBehaviour {

	public Transform[] spawnPoints;

	public GameObject blockPrefab;
    public Text count;
   
    int wave_count=0;
  

    public float timeBetweenWaves = 1f;

	private float timeToSpawn = 2f;

	void Update () {

		if (Time.time >= timeToSpawn)
		{
			SpawnBlocks();
			timeToSpawn = Time.time + timeBetweenWaves;
		}

	}

	void SpawnBlocks ()
	{
		int randomIndex = Random.Range(0, spawnPoints.Length);
        FindObjectOfType<AudioManager>().Play("Woosh");
        for (int i = 0; i < spawnPoints.Length; i++)
		{
			if (randomIndex != i)
			{
				Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
			}
		}
        
        wave_count++;
        count.text = wave_count.ToString();
      
	}
	
}
