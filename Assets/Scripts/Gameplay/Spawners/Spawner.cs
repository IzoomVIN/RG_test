using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Gameplay.Spawners
{
    public abstract class Spawner : MonoBehaviour
    {
        [Header("Spawn properties")]
        [SerializeField] private GameObject _object;
        [SerializeField] private Transform _parent;
        [SerializeField] private Vector2 _spawnPeriodRange;
        [SerializeField] private Vector2 _spawnDelayRange;
        [SerializeField] private bool _autoStart = true;


        private void Start()
        {
            if (_autoStart)
                StartSpawn();
        }


        public void StartSpawn()
        {
            StartCoroutine(Spawn());
        }

        public void StopSpawn()
        {
            StopAllCoroutines();
        }


        private IEnumerator Spawn()
        {
            yield return new WaitForSeconds(Random.Range(_spawnDelayRange.x, _spawnDelayRange.y));
            
            while (true)
            {
                var obj = Instantiate(_object, transform.position, transform.rotation, _parent);
                InitObject(obj);
                yield return new WaitForSeconds(Random.Range(_spawnPeriodRange.x, _spawnPeriodRange.y));
            }
        }

        protected abstract void InitObject(GameObject obj);
    }
}
