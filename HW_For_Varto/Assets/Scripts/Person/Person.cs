using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public abstract class Person : MonoBehaviour
{
    [SerializeField] private string _name;
    [SerializeField] private int _health;
    [SerializeField] private Transform _shootDir;
    [SerializeField] private GameObject _ammo;
    [SerializeField] private Button _shootButton;
    [SerializeField] private TMP_Text _healthText, _nameText, _looserText;
    [SerializeField] private GameObject _gameOverPanel; 
    public string Name => _name;
    public GameObject Ammo => _ammo;
    public Transform ShootDir => _shootDir;
    
    
    private void Awake()
    {
        _shootButton.onClick.AddListener(Shoot);
    }

    void Start()
    {
        ShowStat();
        ShowNameAndHealth();
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
            _healthText.text = $"Health: {value.ToString()}";
            _health = value;
        }
    }

    public void ShowNameAndHealth()
    {
        _healthText.text = $"Health: {_health.ToString()}";
        if (_name == "" || _name.Length > 6)
        {
            _name = gameObject.name;
        }
        _nameText.text = _name;
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
        _looserText.text = $"Looser: {Name}";
        _gameOverPanel.SetActive(true);
        Destroy(gameObject);
    }
}
