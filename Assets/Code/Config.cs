using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

namespace Avangardum.TwilightRun
{
    [CreateAssetMenu(menuName = "Config")]
    public class Config : ScriptableObject, IPlayerCharactersConfig, ILevelGenerationConfig, ITutorialConfig
    {
        [field: SerializeField] public float PlayerCharacterBaseHorizontalSpeed { get; [UsedImplicitly] private set; }
        [field: SerializeField] public float PlayerCharacterSpeedMultiplierIncreaseSpeed { get; [UsedImplicitly] private set; }
        [field: SerializeField] public float PlayerCharacterSpeedMultiplierMax { get; [UsedImplicitly] private set; }
        [field: SerializeField] public float PlayerCharacterBaseJumpingDuration { get; [UsedImplicitly] private set; }
        [field: SerializeField] public float PlayerCharacterBaseFallingDuration { get; [UsedImplicitly] private set; }
        [field: SerializeField] public float PlayerCharacterBaseLandingDuration { get; [UsedImplicitly] private set; }
        [field: SerializeField] public float BeginningEmptinessLength { get; [UsedImplicitly] private set; }
        [field: SerializeField] public float LevelElementsGapLength { get; [UsedImplicitly] private set; }
        [field: SerializeField] public float ElementsDifficultyIncreaseSpeed { get; [UsedImplicitly] private set; }
        [field: SerializeField] public List<TutorialHintData> TutorialHintData { get; [UsedImplicitly] private set; }
    }
}