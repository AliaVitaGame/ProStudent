using UnityEngine;

public class PanelAnimation : MonoBehaviour
{
    private Animator _animator;

    private void Start()
    {
        if (gameObject.TryGetComponent(out Animator animator))
            _animator = animator;
    }


}
