using System;
using UnityEngine;


[CreateAssetMenu(menuName = "Game/EffectItemSO", fileName = "New EffectItemSO", order = 0)]
public class EffectItemSO : ScriptableObject
{
    public enum EffectType
    {
        SpeedUp,
        MaxHpUp
    }
    
    [Serializable]
    public class EffectItemData
    {
        public EffectType effectType;
        public PlayerStat targetStat;
        public EffectOperator effectOperator;
        public float duration;
        public EffectItem prefab;
        public Sprite effectSprite;

        public bool Equals(EffectItemData other)
        {
            return effectType == other.effectType &&
                   targetStat == other.targetStat &&
                   effectOperator.Equals(other.effectOperator) &&
                   Mathf.Approximately(duration, other.duration) &&
                   prefab == other.prefab &&
                   effectSprite == other.effectSprite;
        }
    }

    [Header("Speed Up Effect")]
    [SerializeField]
    private EffectItemData speedUpData;
    public EffectItemData SpeedUpEffect=> speedUpData;

    [Header("MaxHp Up Effect")]
    [SerializeField] 
    private EffectItemData maxHpUpData;

    public EffectItemData MaxHpUpEffect => maxHpUpData;
}
