using UnityEngine;
using UnityEngine.UI;

public abstract class Person : MonoBehaviour
{
    private string _name;
    [SerializeField] private int _health;
    [SerializeField] private Transform _shootDir;
    [SerializeField] private GameObject _ammo;
    [SerializeField] private Button _shootButton;
    public string Name => _name;
    private void Awake()
    {
        _shootButton.onClick.AddListener(Shoot);
    }

    void Start()
    {
        _name = gameObject.name;
        ShowStat();
    }
    public int Health
    {
        get { return _health; }
        set
        {
            if (value > 100)
                value = 100;
            if (value < 0)
                value = 0;
            _health = value;
        }
    }

    public virtual void ShowStat()
    {
        Debug.Log($"Person name is {_name}");
    }

    public abstract void TakeDamage(int damage);

    private void Shoot()
    {
        Instantiate(_ammo, _shootDir.position, Quaternion.identity);
    }

    public void Die()
    {
        Debug.Log($"{Name} in dead(((");
        _shootButton.interactable = false;
        Destroy(gameObject);
    }
}
