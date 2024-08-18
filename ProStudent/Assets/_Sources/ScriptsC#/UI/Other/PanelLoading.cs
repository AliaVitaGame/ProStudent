using System.Collections;
using UnityEngine;

public class PanelLoading : MonoBehaviour
{
    [SerializeField] private GameObject panel;

    private bool _isActive;

    public void StartSimulations(float time = 1)
    {
        if (_isActive) return;
        StartCoroutine(Simulations(time));
    }

    public void StartSimulationsRandomTime()
    {
        if(_isActive) return;
        StartCoroutine(Simulations(Random.Range(0.2f, 1f)));
    }

    private IEnumerator Simulations(float time = 1)
    {
        _isActive = true;
        SetActivePanel(true);
        yield return new WaitForSeconds(time);
        SetActivePanel(false);
        _isActive = false;
    }

    public void SetActivePanel(bool active) 
        => panel.SetActive(active);
}
