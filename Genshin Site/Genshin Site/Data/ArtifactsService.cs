﻿using System.Text.Json;

namespace Genshin_Site.Data
{
    public class ArtifactsService
    {
        private string fileName = "ArtifactSets.json";
        private List<ArtifactSet> artifactSets;
        public List<ArtifactSet> GetSets()
        {
            if (artifactSets == null)
            {
                var artifactsString = File.ReadAllText(fileName);
                artifactSets = JsonSerializer.Deserialize<List<ArtifactSet>>(artifactsString)!;
            }
            return artifactSets;
        }

        //public  void Save()
        //{
        //    string fileName = "ArtifactSets.json";
        //    var jsonString = JsonSerializer.Serialize(artifactSets);
        //    File.WriteAllText(fileName, jsonString);
        //}

        //private List<ArtifactSet> artifactSets = new List<ArtifactSet>()
        //{
        //    new ArtifactSet(
        //        "Gladiator's Finale",
        //        "2 Piece: ATK +18%. 4 Piece: If the wielder of this artifact set uses a Sword, Claymore or Polearm, increases their Normal Attack DMG by 35%.",
        //        new Artifacts[]{new Artifacts("", "Flower of Life", ""), new Artifacts("", "Plume of Death", ""), new Artifacts("", "Sands of Eon", ""), new Artifacts("", "Goblet of Eonothem", ""), new Artifacts("", "Circlet of Logos", "")},
        //        "https://static.wikia.nocookie.net/gensin-impact/images/b/b1/Item_Gladiator%27s_Nostalgia.png"),
        //    new ArtifactSet("Wanderer's Troupe",
        //        "2 Piece: Increases Elemental Mastery by 80. 4 Piece: Increases Charged Attack DMG by 35% if the character uses a Catalyst or Bow.",
        //        new Artifacts[]{new Artifacts("", "Flower of Life", ""), new Artifacts("", "Plume of Death", ""), new Artifacts("", "Sands of Eon", ""), new Artifacts("", "Goblet of Eonothem", ""), new Artifacts("", "Circlet of Logos", "")},
        //        "https://static.wikia.nocookie.net/gensin-impact/images/a/ad/Item_Troupe%27s_Dawnlight.png"),
        //    new ArtifactSet("Noblesse Oblige",
        //        "2 Piece: Elemental Burst DMG +20%. 4 Piece: Using an Elemental Burst increases all party members' ATK by 20% for 12s. This effect cannot stack.",
        //        new Artifacts[]{new Artifacts("", "Flower of Life", ""), new Artifacts("", "Plume of Death", ""), new Artifacts("", "Sands of Eon", ""), new Artifacts("", "Goblet of Eonothem", ""), new Artifacts("", "Circlet of Logos", "")},
        //        "https://static.wikia.nocookie.net/gensin-impact/images/7/71/Item_Royal_Flora.png"),
        //    new ArtifactSet("Bloodstained Chivalry", 
        //        "2 Piece: Physical DMG Bonus +25%. 4 Piece: After defeating an opponent, increases Charged Attack DMG by 50%, and reduces its Stamina cost to 0 for 10s. Also triggers with wild animals such as boars, squirrels and frogs.",
        //        new Artifacts[]{new Artifacts("", "Flower of Life", ""), new Artifacts("", "Plume of Death", ""), new Artifacts("", "Sands of Eon", ""), new Artifacts("", "Goblet of Eonothem", ""), new Artifacts("", "Circlet of Logos", "")},
        //        "https://static.wikia.nocookie.net/gensin-impact/images/5/5b/Item_Bloodstained_Flower_of_Iron.png"),
        //    new ArtifactSet("Maiden Beloved", 
        //        "2 Piece: Character Healing Effectiveness +15%. 4 Piece: Using an Elemental Skill or Burst increases healing received by all party members by 20% for 10s.",
        //        new Artifacts[]{new Artifacts("", "Flower of Life", ""), new Artifacts("", "Plume of Death", ""), new Artifacts("", "Sands of Eon", ""), new Artifacts("", "Goblet of Eonothem", ""), new Artifacts("", "Circlet of Logos", "")},
        //        "https://static.wikia.nocookie.net/gensin-impact/images/d/dc/Item_Maiden%27s_Distant_Love.png"),
        //    new ArtifactSet("Viridescent Venerer", 
        //        "2 Piece: Anemo DMG Bonus +15%. 4 Piece: Increases Swirl DMG by 60%. Decreases opponent's Elemental RES to the element infused in the Swirl by 40% for 10s.",
        //        new Artifacts[]{new Artifacts("", "Flower of Life", ""), new Artifacts("", "Plume of Death", ""), new Artifacts("", "Sands of Eon", ""), new Artifacts("", "Goblet of Eonothem", ""), new Artifacts("", "Circlet of Logos", "")},
        //        "https://static.wikia.nocookie.net/gensin-impact/images/9/90/Item_In_Remembrance_of_Viridescent_Fields.png"),
        //    new ArtifactSet("Archaic Petra", 
        //        "2 Piece: Geo DMG Bonus +15%. 4 Piece: Upon obtaining an Elemental Shard created through a Crystallize Reaction, all party members gain 35% DMG Bonus for that particular element for 10s. Only one form of Elemental DMG Bonus can be gained in this manner at any one time.",
        //        new Artifacts[]{new Artifacts("", "Flower of Life", ""), new Artifacts("", "Plume of Death", ""), new Artifacts("", "Sands of Eon", ""), new Artifacts("", "Goblet of Eonothem", ""), new Artifacts("", "Circlet of Logos", "")},
        //        "https://static.wikia.nocookie.net/gensin-impact/images/9/9f/Item_Flower_of_Creviced_Cliff.png"),
        //    new ArtifactSet("Retracing Bolide", 
        //        "2 Piece: Increases Shield Strength by 35%. 4 Piece: While protected by a shield, gain an additional 40% Normal and Charged Attack DMG.",
        //        new Artifacts[]{new Artifacts("", "Flower of Life", ""), new Artifacts("", "Plume of Death", ""), new Artifacts("", "Sands of Eon", ""), new Artifacts("", "Goblet of Eonothem", ""), new Artifacts("", "Circlet of Logos", "")},
        //        "https://static.wikia.nocookie.net/gensin-impact/images/a/a6/Item_Summer_Night%27s_Bloom.png"),
        //    new ArtifactSet("Thundersoother", 
        //        "2 Piece: Electro RES increased by 40%. 4 Piece: Increases DMG against opponents affected by Electro by 35%.",
        //        new Artifacts[]{new Artifacts("", "Flower of Life", ""), new Artifacts("", "Plume of Death", ""), new Artifacts("", "Sands of Eon", ""), new Artifacts("", "Goblet of Eonothem", ""), new Artifacts("", "Circlet of Logos", "")},
        //        "https://static.wikia.nocookie.net/gensin-impact/images/e/ef/Item_Thundersoother%27s_Heart.png"),
        //    new ArtifactSet("Thundering Fury", 
        //        "2 Piece: Electro DMG Bonus +15%. 4 Piece: Increases DMG caused by Overloaded, Electro-Charged, Superconduct, and Hyperbloom by 40%, and the DMG Bonus conferred by Aggravate is increased by 20%. When Quicken or the aforementioned Elemental Reactions are triggered, Elemental Skill CD is decreased by 1s. Can only occur once every 0.8s.",
        //        new Artifacts[]{new Artifacts("", "Flower of Life", ""), new Artifacts("", "Plume of Death", ""), new Artifacts("", "Sands of Eon", ""), new Artifacts("", "Goblet of Eonothem", ""), new Artifacts("", "Circlet of Logos", "")},
        //        "https://static.wikia.nocookie.net/gensin-impact/images/5/57/Item_Thunderbird%27s_Mercy.png"),
        //    new ArtifactSet("Lavawalker", 
        //        "2 Piece: Pyro RES increased by 40%. 4 Piece: Increases DMG against opponents affected by Pyro by 35%.",
        //        new Artifacts[]{new Artifacts("", "Flower of Life", ""), new Artifacts("", "Plume of Death", ""), new Artifacts("", "Sands of Eon", ""), new Artifacts("", "Goblet of Eonothem", ""), new Artifacts("", "Circlet of Logos", "")},
        //        "https://static.wikia.nocookie.net/gensin-impact/images/b/b5/Item_Lavawalker%27s_Resolution.png"),
        //    new ArtifactSet("Crimson Witch of Flames", 
        //        "2 Piece: Pyro DMG Bonus +15%. 4 Piece: Increases Overloaded and Burning, and Burgeon DMG by 40%. Increases Vaporize and Melt DMG by 15%. Using Elemental Skill increases the 2-Piece Set Bonus by 50% of its starting value for 10s. Max 3 stacks.",
        //        new Artifacts[]{new Artifacts("", "Flower of Life", ""), new Artifacts("", "Plume of Death", ""), new Artifacts("", "Sands of Eon", ""), new Artifacts("", "Goblet of Eonothem", ""), new Artifacts("", "Circlet of Logos", "")},
        //        "https://static.wikia.nocookie.net/gensin-impact/images/0/0f/Item_Witch%27s_Flower_of_Blaze.png"),
        //    new ArtifactSet("Blizzard Strayer", 
        //        "2 Piece: Cryo DMG Bonus +15%. 4 Piece: When a character attacks an opponent affected by Cryo, their CRIT Rate is increased by 20%. If the opponent is Frozen, CRIT Rate is increased by an additional 20%.",
        //        new Artifacts[]{new Artifacts("", "Flower of Life", ""), new Artifacts("", "Plume of Death", ""), new Artifacts("", "Sands of Eon", ""), new Artifacts("", "Goblet of Eonothem", ""), new Artifacts("", "Circlet of Logos", "")},
        //        "https://static.wikia.nocookie.net/gensin-impact/images/6/69/Item_Snowswept_Memory.png"),
        //    new ArtifactSet("Heart of Depth", 
        //        "2 Piece: Hydro DMG Bonus +15%. 4 Piece: After using an Elemental Skill, increases Normal Attack and Charged Attack DMG by 30% for 15s.",
        //        new Artifacts[]{new Artifacts("", "Flower of Life", ""), new Artifacts("", "Plume of Death", ""), new Artifacts("", "Sands of Eon", ""), new Artifacts("", "Goblet of Eonothem", ""), new Artifacts("", "Circlet of Logos", "")},
        //        "https://static.wikia.nocookie.net/gensin-impact/images/4/40/Item_Gilded_Corsage.png"),
        //    new ArtifactSet("Tenacity of the Millelith", 
        //        "2 Piece: HP +20%. 4 Piece: When an Elemental Skill hits an opponent, the ATK of all nearby party members is increased by 20% and their Shield Strength is increased by 30% for 3s. This effect can be triggered once every 0.5s. This effect can still be triggered even when the character who is using this artifact set is not on the field.",
        //        new Artifacts[]{new Artifacts("", "Flower of Life", ""), new Artifacts("", "Plume of Death", ""), new Artifacts("", "Sands of Eon", ""), new Artifacts("", "Goblet of Eonothem", ""), new Artifacts("", "Circlet of Logos", "")},
        //        "https://static.wikia.nocookie.net/gensin-impact/images/5/51/Item_Flower_of_Accolades.png"),
        //    new ArtifactSet("Pale Flame", 
        //        "2 Piece: Physical DMG Bonus +25%. 4 Piece: When an Elemental Skill hits an opponent, ATK is increased by 9% for 7s. This effect stacks up to 2 times and can be triggered once every 0.3s. Once 2 stacks are reached, the 2-set effect is increased by 100%.",
        //        new Artifacts[]{new Artifacts("", "Flower of Life", ""), new Artifacts("", "Plume of Death", ""), new Artifacts("", "Sands of Eon", ""), new Artifacts("", "Goblet of Eonothem", ""), new Artifacts("", "Circlet of Logos", "")},
        //        "https://static.wikia.nocookie.net/gensin-impact/images/e/e7/Item_Stainless_Bloom.png"),
        //    new ArtifactSet("Shimenawa's Reminiscence", 
        //        "2 Piece: ATK +18%. 4 Piece: When casting an Elemental Skill, if the character has 15 or more Energy, they lose 15 Energy and Normal/Charged/Plunging Attack DMG is increased by 50% for 10s. This effect will not trigger again during that duration.",
        //        new Artifacts[]{new Artifacts("", "Flower of Life", ""), new Artifacts("", "Plume of Death", ""), new Artifacts("", "Sands of Eon", ""), new Artifacts("", "Goblet of Eonothem", ""), new Artifacts("", "Circlet of Logos", "")},
        //        "https://static.wikia.nocookie.net/gensin-impact/images/c/c2/Item_Entangling_Bloom.png"),
        //    new ArtifactSet("Emblem of Severed Fate", 
        //        "2 Piece: Energy Recharge +20%. 4 Piece: Increases Elemental Burst DMG by 25% of Energy Recharge. A maximum of 75% bonus DMG can be obtained in this way.",
        //        new Artifacts[]{new Artifacts("", "Flower of Life", ""), new Artifacts("", "Plume of Death", ""), new Artifacts("", "Sands of Eon", ""), new Artifacts("", "Goblet of Eonothem", ""), new Artifacts("", "Circlet of Logos", "")},
        //        "https://static.wikia.nocookie.net/gensin-impact/images/5/53/Item_Magnificent_Tsuba.png"),
        //    new ArtifactSet("Husk of Opulent Dreams", 
        //        "2 Piece: DEF +30%. 4 Piece: A character equipped with this Artifact set will obtain the Curiosity effect in the following conditions: When on the field, the character gains 1 stack after hitting an opponent with a Geo attack, triggering a maximum of once every 0.3s. When off the field, the character gains 1 stack every 3s. Curiosity can stack up to 4 times, each providing 6% DEF and a 6% Geo DMG Bonus. When 6 seconds pass without gaining a Curiosity stack, 1 stack is lost.",
        //        new Artifacts[]{new Artifacts("", "Flower of Life", ""), new Artifacts("", "Plume of Death", ""), new Artifacts("", "Sands of Eon", ""), new Artifacts("", "Goblet of Eonothem", ""), new Artifacts("", "Circlet of Logos", "")},
        //        "https://static.wikia.nocookie.net/gensin-impact/images/2/2b/Item_Bloom_Times.png"),
        //    new ArtifactSet("Ocean-Hued Clam", 
        //        "2 Piece: Healing Bonus +15%. 4 Piece: When the character equipping this artifact set heals a character in the party, a Sea-Dyed Foam will appear for 3 seconds, accumulating the amount of HP recovered from healing (including overflow healing). At the end of the duration, the Sea-Dyed Foam will explode, dealing DMG to nearby opponents based on 90% of the accumulated healing. (This DMG is calculated similarly to Reactions such as Electro-Charged, and Superconduct, but it is not affected by Elemental Mastery, Character Levels, or Reaction DMG Bonuses). Only one Sea-Dyed Foam can be produced every 3.5 seconds. Each Sea-Dyed Foam can accumulate up to 30,000 HP (including overflow healing). There can be no more than one Sea-Dyed Foam active at any given time. This effect can still be triggered even when the character who is using this artifact set is not on the field.",
        //        new Artifacts[]{new Artifacts("", "Flower of Life", ""), new Artifacts("", "Plume of Death", ""), new Artifacts("", "Sands of Eon", ""), new Artifacts("", "Goblet of Eonothem", ""), new Artifacts("", "Circlet of Logos", "")},
        //        "https://static.wikia.nocookie.net/gensin-impact/images/5/58/Item_Sea-Dyed_Blossom.png"),
        //    new ArtifactSet("Vermillion Hereafter", 
        //        "2 Piece: ATK +18%. 4 Piece: After using an Elemental Burst. this character will gain the Nascent Light effect, increasing their ATK by 8% for 16s. When the character's HP decreases, their ATK will further increase by 10%. This increase can occur this way maximum of 4 times. This effect can be triggered once every 0.8s. Nascent Light will be dispelled when the character leaves the field. If an Elemental Burst is used again during the duration of Nascent Light, the original Nascent Light will be dispelled.",
        //        new Artifacts[]{new Artifacts("", "Flower of Life", ""), new Artifacts("", "Plume of Death", ""), new Artifacts("", "Sands of Eon", ""), new Artifacts("", "Goblet of Eonothem", ""), new Artifacts("", "Circlet of Logos", "")},
        //        "https://static.wikia.nocookie.net/gensin-impact/images/1/11/Item_Flowering_Life.png"),
        //    new ArtifactSet("Echoes of an Offering", 
        //        "2 Piece: ATK +18%. 4 Piece: When Normal Attacks hit opponents, there is a 36% chance that it will trigger Valley Rite, which will increase Normal Attack DMG by 70% of ATK. This effect will be dispelled 0.05s after a Normal Attack deals DMG. If a Normal Attack fails to trigger Valley Rite, the odds of it triggering the next time will increase by 20%. This trigger can occur once every 0.2s.",
        //        new Artifacts[]{new Artifacts("", "Flower of Life", ""), new Artifacts("", "Plume of Death", ""), new Artifacts("", "Sands of Eon", ""), new Artifacts("", "Goblet of Eonothem", ""), new Artifacts("", "Circlet of Logos", "")},
        //        "https://static.wikia.nocookie.net/gensin-impact/images/6/64/Item_Soulscent_Bloom.png"),
        //    new ArtifactSet("Deepwood Memories", 
        //        "2 Piece: Dendro DMG Bonus +15%. 4 Piece: After Elemental Skills or Bursts hit opponents, the targets' Dendro RES will be decreased by 30% for 8s. This effect can be triggered even if the equipping character is not on the field.",
        //        new Artifacts[]{new Artifacts("", "Flower of Life", ""), new Artifacts("", "Plume of Death", ""), new Artifacts("", "Sands of Eon", ""), new Artifacts("", "Goblet of Eonothem", ""), new Artifacts("", "Circlet of Logos", "")},
        //        "https://static.wikia.nocookie.net/gensin-impact/images/a/ab/Item_Labyrinth_Wayfarer.png"),
        //    new ArtifactSet("Gilded Dreams", 
        //        "2 Piece: Increases Elemental Mastery by 80. 4 Piece: Within 8s of triggering an Elemental Reaction, the character equipping this will obtain buffs based on the Elemental Type of the other party members. ATK is increased by 14% for each party member whose Elemental Type is the same as the equipping character, and Elemental Mastery is increased by 50 for every party member with a different Elemental Type. Each of the aforementioned buffs will count up to 3 characters. This effect can be triggered once every 8s. The character who equips this can still trigger its effects when not on the field.",
        //        new Artifacts[]{new Artifacts("", "Flower of Life", ""), new Artifacts("", "Plume of Death", ""), new Artifacts("", "Sands of Eon", ""), new Artifacts("", "Goblet of Eonothem", ""), new Artifacts("", "Circlet of Logos", "")},
        //        "https://static.wikia.nocookie.net/gensin-impact/images/0/0c/Item_Dreaming_Steelbloom.png"),
        //    new ArtifactSet("Desert Pavilion Chronicle", 
        //        "2 Piece: Anemo DMG Bonus +15%. 4 Piece: When Charged Attacks hit opponents, the equipping character's Normal Attack SPD will increase by 10% while Normal, Charged, and Plunging Attack DMG will increase by 40% for 15s.",
        //        new Artifacts[]{new Artifacts("", "Flower of Life", ""), new Artifacts("", "Plume of Death", ""), new Artifacts("", "Sands of Eon", ""), new Artifacts("", "Goblet of Eonothem", ""), new Artifacts("", "Circlet of Logos", "")},
        //        "https://static.wikia.nocookie.net/gensin-impact/images/0/01/Item_The_First_Days_of_the_City_of_Kings.png"),
        //    new ArtifactSet("Flower of Paradise Lost", 
        //        "2 Piece: Increases Elemental Mastery by 80. 4 Piece: The equipping character's Bloom, Hyperbloom, and Burgeon reaction DMG are increased by 40%. Additionally, after the equipping character triggers Bloom, Hyperbloom, or Burgeon, they will gain another 25% bonus to the effect mentioned prior. Each stack of this lasts 10s. Max 4 stacks simultaneously. This effect can only be triggered once per second. The character who equips this can still trigger its effects when not on the field.",
        //        new Artifacts[]{new Artifacts("", "Flower of Life", ""), new Artifacts("", "Plume of Death", ""), new Artifacts("", "Sands of Eon", ""), new Artifacts("", "Goblet of Eonothem", ""), new Artifacts("", "Circlet of Logos", "")},
        //        "https://static.wikia.nocookie.net/gensin-impact/images/8/8f/Item_Ay-Khanoum%27s_Myriad.png"),
        //    new ArtifactSet("Nymph's Dream", 
        //        "2 Piece: Hydro DMG Bonus +15%. 4 Piece: After Normal, Charged, and Plunging Attacks, Elemental Skills, and Elemental Bursts hit opponents. 1 stack of Mirrored Nymph will triggered, lasting 8s. When under the effect of 1, 2, or 3 or more Mirrored Nymph stacks, ATK will be increased by 7%/16%/25%, and Hydro DMG will be increased by 4%/9%/15% Mirrored Nymph created by Normal, Charged, and Plunging Attacks, Elemental Skills, and Elemental Bursts exist independently.",
        //        new Artifacts[]{new Artifacts("", "Flower of Life", ""), new Artifacts("", "Plume of Death", ""), new Artifacts("", "Sands of Eon", ""), new Artifacts("", "Goblet of Eonothem", ""), new Artifacts("", "Circlet of Logos", "")},
        //        "https://static.wikia.nocookie.net/gensin-impact/images/7/7b/Item_Odyssean_Flower.png"),
        //    new ArtifactSet("Vourukasha's Glow", 
        //        "2 Piece: HP +20%. 4 Piece: Elemental Skill and Elemental Burst DMG will be increased by 10%. After the equipping character takes DMG, the aforementioned DMG Bonus is increased by 80% for 5s. This effect increase can have 5 stacks. The duration of each stack is counted independently. These effects can be triggered even when the equipping character is not on the field.",
        //        new Artifacts[]{new Artifacts("", "Flower of Life", ""), new Artifacts("", "Plume of Death", ""), new Artifacts("", "Sands of Eon", ""), new Artifacts("", "Goblet of Eonothem", ""), new Artifacts("", "Circlet of Logos", "")},
        //        "https://static.wikia.nocookie.net/gensin-impact/images/c/c5/Item_Stamen_of_Khvarena%27s_Origin.png")
        //};
    }
}
