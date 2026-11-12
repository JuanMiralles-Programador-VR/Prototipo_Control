using UnityEngine;

public class GenerarCubos : MonoBehaviour
{
	[SerializeField] private GameObject _preFab;
	[SerializeField] private Transform _spawnPoint;
	public void SpawnPreFabs() 
	{
		Instantiate(_preFab,  _spawnPoint.position, _spawnPoint.rotation);
	}
}
