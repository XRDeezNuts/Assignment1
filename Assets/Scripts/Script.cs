using UnityEngine;
using Vuforia;

public class MyPrefabInstantiator : DefaultObserverEventHandler
{
        public GameObject modelPrefab;
        private GameObject _modelObject;

        protected override void OnTrackingFound()
        {
                Debug.Log("tracking found");
                // Instantiate the model prefab only if it hasn't been instantiated yet
                if (_modelObject == null) 
                        InstantiatePrefab();
                
                base.OnTrackingFound();
        }

        private void InstantiatePrefab()
        {
                if (modelPrefab == null) return;
                Debug.Log("Target found, adding content"); 
                _modelObject = Instantiate(modelPrefab, mObserverBehaviour.transform);
                _modelObject.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                _modelObject.SetActive(true);
        }
}