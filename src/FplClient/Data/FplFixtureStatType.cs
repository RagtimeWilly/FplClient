using System.Runtime.Serialization;

namespace FplClient.Data
{
    public enum FplFixtureStatType
    {
        [EnumMember(Value = "minutes")]
        Minutes,
        [EnumMember(Value = "goals_scored")]
        GoalsScored,
        [EnumMember(Value = "assists")]
        Assists,
        [EnumMember(Value = "clean_sheets")]
        CleanSheets,
        [EnumMember(Value = "goals_conceded")]
        GoalsConceded,
        [EnumMember(Value = "own_goals")]
        OwnGoals,
        [EnumMember(Value = "penalties_saved")]
        PenaltiesSaved,
        [EnumMember(Value = "penalties_missed")]
        PenaltiesMissed,
        [EnumMember(Value = "yellow_cards")]
        YellowCards,
        [EnumMember(Value = "red_cards")]
        RedCards,
        [EnumMember(Value = "saves")]
        Saves,
        [EnumMember(Value = "bonus")]
        Bonus,
        [EnumMember(Value = "bps")]
        Bps,
        [EnumMember(Value = "influence")]
        Influence,
        [EnumMember(Value = "creativity")]
        Creativity,
        [EnumMember(Value = "threat")]
        Threat,
        [EnumMember(Value = "ict_index")]
        IctIndex
    }
}