using UnityEngine;

public class StatusBar : MonoBehaviour
{
    [SerializeField] Transform Bar;

    public void SetState(int current, int max)
    {
        float value = (float)current / max;
        if (value < 0)
        {
            value = 0;
        }
        else if (value > 1)
        {
            value = 1;
        }
        Bar.localScale = new Vector3(value, 1f, 1f);
    }
}
