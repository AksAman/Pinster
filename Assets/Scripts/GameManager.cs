using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour {

	public GameObject shotPrefab;
	public float shotSpeed;
	public Transform parentCanvas, buttonTransform;
	public bool gameOver;
	public int score;
	public TextMeshProUGUI scoreText;

	public GameObject gameOverText;


	void Awake()
	{
		gameOver = false;
		score = 0;
		StopAllCoroutines ();
	}
	public void Shoot()
	{
		if (!gameOver) {
			GameObject shot = Instantiate<GameObject> (shotPrefab, buttonTransform.position, Quaternion.identity);
		}
	}

	void Update()
	{
		if(gameOver)
		{
			gameOverText.SetActive (true);
			StartCoroutine (RestartGame ());
		}

		scoreText.text = score.ToString ();
	}

	IEnumerator RestartGame ()
	{
		yield return new WaitForSeconds (3f);
		SceneManager.LoadScene (0);

	}
}
