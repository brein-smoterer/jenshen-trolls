﻿using System.Text.Json;

namespace Genshin_Site.Data
{
    public class WeaponService
    {
        //private string fileName = "Weaopns.json";

        public IEnumerable<Weapon> GetWeapons(string? selectedWeaponType)
        {
            if (selectedWeaponType != null && selectedWeaponType != "null")
                return weapons.Where(x => x.Type == selectedWeaponType);

            return weapons;

        }

        public IEnumerable<string> GetWeaponTypes()
            => weapons.Select(x => x.Type).Distinct().OrderBy(x => x);
        public List<Weapon> Get()
        {
            return weapons;
        }

        //Load and save json
        //public List<Weapon> GetWeapon()
        //{
        //    if (weapon == null)
        //    {
        //        var WeaponString = File.ReadAllText(fileName);
        //        weapon = JsonSerializer.Deserialize<List<Weapon>>(WeaponString)!;
        //    }
        //    return weapon;
        //}

        //public void Save()
        //{
        //    string fileName = "Weapons.json";
        //    var jsonString = JsonSerializer.Serialize(weapon);
        //    File.WriteAllText(fileName, jsonString);
        //}

        private List<Weapon> weapons = new List<Weapon>()
    {
            new Weapon(
                "Traveler's Handy Sword",
                "Sword",
                "DEF 29.3%",
                "Each Elemental Orb or Particle collected restores 1~2 HP.",
                "https:img.game8.co/3314334/3e7a9688b870daa36b195588b4b411b7.png/show"),
            new Weapon(
                "Thrilling Tales of Dragon Slayers",
                "Catalyst",
                "HP 35.2%",
                "When switching characters, the new character taking the field has their ATK increased by 24~48% for 10s. This effect can only occur once every 20s.",
                "https:img.game8.co/3314333/025e3a73a44d007f4e973ef77e60bdd3.png/show"),
            new Weapon(
                "Black Tassel",
                "Polearm",
                "HP 46.9%",
                "Increases DMG against opponents affected by Pyro or Electro by 12~24%",
                "https:img.game8.co/3314339/db15531019b243e2d34a4a4ccbf1c9b0.png/show"),
            new Weapon(
                "'The Catch'",
                "Polearm",
                "Energy Recharge 45.9%",
                "Increases Elemental Burst DMG by 16~32% and Elemental Burst CRIT Rate by 6~12%.",
                "https:img.game8.co/3408158/aa0c7b64220627ff3c351eda77710fea.png/show"),
            new Weapon(
                "Akuoumaru",
                "Claymore",
                "ATK 41.3%",
                "For every point of the entire party's combined maximum Energy capacity, the Elemental Burst DMG of the character equipping this weapon is increased by 0.12~0.24%. A maximum of 40~80% increased Elemental Burst DMG can be achieved this way.",
                "https:img.game8.co/3441954/b020641893ee0a28f44a00881a65fcb2.png/show"),
            new Weapon(
                "Alley Hunter",
                "Bow",
                "ATK 27.6%",
                "While the character equipped with this weapon is in the party but not on the field, their DMG increases by 2~4% every second up to a max of 20~40%. When the character is on the field for more than 4s, the aforementioned DMG buff decreases by 4~8% per second until it reaches 0%.",
                "https:img.game8.co/3441962/32cf25b8629e2534c0fbc292a5688931.png/show"),
            new Weapon(
                "Amenoma Kageuchi",
                "Sword",
                "ATK 55.1%",
                "After casting an Elemental Skill, gain 1 Succession Seed. This effect can be triggered once every 5s. The Succession Seed lasts for 30s. Up to 3 Succession Seeds may exist simultaneously. After using an Elemental Burst, all Succession Seeds are consumed and after 2s, the character regenerates 6~12 Energy for each seed consumed.",
                "https:img.game8.co/3385781/11943394cc49218a47fd53753bfafc8c.png/show"),
            new Weapon(
                "Blackcliff Agate",
                "Catalyst",
                "CRIT DMG 55.1%",
                "After defeating an opponent, ATK is increased by 12~24% for 30s. This effect has a maximum of 3 stacks, and the duration of each stack is independent of the others.",
                "https:img.game8.co/3314394/e7a78868c9b123ce80a813da5d05b520.png/show"),
            new Weapon(
                "Blackcliff Longsword",
                "Sword",
                "CRIT DMG 36.8%",
                "After defeating an opponent, ATK is increased by 12~24% for 30s. This effect has a maximum of 3 stacks, and the duration of each stack is independent of the others.",
                "https:img.game8.co/3314395/ed36b836606ea3bbdc2c00773157d76b.png/show"),
            new Weapon(
                "Blackcliff Pole",
                "Polearm",
                "CRIT DMG 55.1%",
                "After defeating an opponent, ATK is increased by 12~24% for 30s. This effect has a maximum of 3 stacks, and the duration of each stack is independent of the others.",
                "https://img.game8.co/3314392/2294902481878d53c4a35ac31b875844.png/show"),
            new Weapon(
                "Blackcliff Slasher",
                "Claymore",
                "CRIT DMG 55.1%",
                "After defeating an opponent, ATK is increased by 12~24% for 30s. This effect has a maximum of 3 stacks, and the duration of each stack is independent of the others.",
                "https:img.game8.co/3314393/086a7d79ef72ebb44a716cdeaea286cf.png/show"),
            new Weapon(
                "Blackcliff Warbow",
                "Bow",
                "CRIT DMG 36.8%",
                "After defeating an opponent, ATK is increased by 12~24% for 30s. This effect has a maximum of 3 stacks, and the duration of each stack is independent of the others.",
                "https:img.game8.co/3314391/1d758510b397d6173177b275bf8d557e.png/show"),
            new Weapon(
                "Cinnabar Spindle",
                "Sword",
                "DEF 69.0%",
                "Elemental Skill DMG is increased by 40~80% of DEF. The effect will be triggered no more than once every 1.5s and will be cleared 0.1s after the Elemental Skill deals DMG.",
                "https://img.game8.co/3453993/51c1c5e022256e3ad176d4b713799669.png/show"),
            new Weapon(
                "Compound Bow",
                "Bow",
                "Elemental Mastery 58",
                "Normal Attack and Charged Attack hits increase ATK by 4~8% and Normal ATK SPD by 1.2~2.4% for 6s. Max 4 stacks. Can only occur once every 0.3s.",
                "https://img.game8.co/3314438/dfed00ca17ac5fabfc26841e24ad3813.png/show"),
            new Weapon(
                "Crescent Pike",
                "Polearm",
                "Physical DMG Bonus 34.5%",
                "After picking up an Elemental Orb/Particle, Normal and Charged Attacks deal an additional 20~40% ATK as DMG for 5s.",
                "https://img.game8.co/3314435/bf8d35e6b621c0fc2a0a16560fb7d5dc.png/show"),
            new Weapon(
                "Deathmatch",
                "Polearm",
                "CRIT Rate 36.8%",
                "If there are at least 2 opponents nearby, ATK is increased by 16~32% and DEF is increased by 16~32%. If there are fewer than 2 opponents nearby, ATK is increased by 24~48%.",
                "https://img.game8.co/3314421/9fa660ead54aa9e4dccfa883dc61b196.png/show"),
            new Weapon(
                "Dodoco Tales",
                "Catalyst",
                "ATK 55.1%",
                "Normal Attack hits on opponents increase Charged Attack DMG by 16~32% for 6s. Charged Attack hits on opponents increase ATK by 8~16% for 6s.",
                "https://img.game8.co/3372550/f562fe0d61bcbe105f5edc1e0f743e6e.png/show"),
            new Weapon(
                "Dragon's Bane",
                "Polearm",
                "Elemental Mastery 221",
                "Increases DMG against opponents affected by Hydro or Pyro by 20~36%.",
                "https://img.game8.co/3314485/dea459ec1fcf67eaffc3d7ff42f99b77.png/show"),
            new Weapon(
                "Dragonspine Spear",
                "Polearm",
                "Physical DMG Bonus 69.0%",
                "Hitting an opponent with Normal and Charged Attacks has a 60~100% chance of forming and dropping an Everfrost Icicle above them, dealing 80~140% AoE ATK DMG. Opponents affected by Cryo are dealt 200~360% ATK DMG instead by the icicle. Can only occur once every 10s.",
                "https://img.game8.co/3312591/aaaa63f51c73fb92c5914b00e0788417.png/show"),
            new Weapon(
                "End of the Line",
                "Bow",
                "Energy Recharge 45.9%",
                "Triggers the Flowrider effect after using an Elemental Skill, dealing 80~160% ATK as AoE DMG upon hitting an opponent with an attack. Flowrider will be removed after 15s or after causing 3 instances of AoE DMG. Only 1 instance of AoE DMG can be caused every 2s in this way. Flowrider can be triggered once every 12s.",
                "https://img.game8.co/3581032/6cba3d14fc8b77af59a64c12bcd21514.png/show"),
            new Weapon(
                "Eye of Perception",
                "Catalyst",
                "ATK 55.1%",
                "Normal and Charged Attacks have a 50% chance to fire a Bolt of Perception, dealing 240~360% ATK as DMG. This bolt can bounce between opponents a maximum of 4 times. This effect can occur once every 12~8s.",
                "https://img.game8.co/3314493/5346c2b9acc3860b631262eae454a9b9.png/show"),
            new Weapon(
                "Fading Twilight",
                "Bow",
                "Energy Recharge 30.6%",
                "Has three states, Evengleam, Afterglow, and Dawnblaze, which increase DMG dealt by 6%/10%/14%~12%/20%/28% respectively. When attacks hit opponents, this weapon will switch to the next state. This weapon can change states once every 7s. The character equipping this weapon can still trigger the state switch while not on the field.",
                "https://img.game8.co/3528571/196738ac2179f50f7f8215b8517b3e7c.png/show"),
            new Weapon(
                "Favonius Codex",
                "Catalyst",
                "Energy Recharge 45.9%",
                "CRIT hits have a 60~100% chance to generate a small amount of Elemental Particles, which will regenerate 6 Energy for the character. Can only occur once every 12~6s.",
                "https://img.game8.co/3314590/560132b7897a6642851d313d988d61a9.png/show"),
            new Weapon(
                "Favonius Greatsword",
                "Claymore",
                "Energy Recharge 61.3%",
                "CRIT hits have a 60~100% chance to generate a small amount of Elemental Particles, which will regenerate 6 Energy for the character. Can only occur once every 12~6s.",
                "https://img.game8.co/3314476/0a40ecf6456acb15bd8ab7203f982a30.png/show"),
            new Weapon(
                "Favonius Lance",
                "Polearm",
                "Energy Recharge 30.6%",
                "CRIT Hits have a 60~100% chance to generate a small amount of Elemental Particles, which will regenerate 6 Energy for the character. Can only occur once every 12~6s.",
                "https://img.game8.co/3314486/a2a0db169836e941c9c7a42889c2f29d.png/show"),
            new Weapon(
                "Favonius Sword",
                "Sword",
                "Energy Recharge 61.3%",
                "CRIT hits have a 60~100% chance to generate a small amount of Elemental Particles, which will regenerate 6 Energy for the character. Can only occur once every 12~6s.",
                "https://img.game8.co/3314483/042ba3ca7e48cb6c7a8d3c8d5be805c6.png/show"),
            new Weapon(
                "Favonius Warbow",
                "Bow",
                "Energy Recharge 61.3%",
                "CRIT hits have a 60~100% chance to generate a small amount of Elemental Particles, which will regenerate 6 Energy for the character. Can only occur once every 12~6s.",
                "https://img.game8.co/3314488/27bf81c6948beeeb3cb72376f4df668e.png/show"),
            new Weapon(
                "Festering Desire",
                "Sword",
                "Energy Recharge 45.9%",
                "Increases Elemental Skill DMG by 16~32% and Elemental Skill CRIT Rate by 6~12%.",
                "https://img.game8.co/3312290/ebd92d61ecf22e7cece4c67b1f7d1f97.jpeg/show"),
            new Weapon(
                "Forest Regalia",
                "Claymore",
                "Energy Recharge 30.6%",
                "After triggering Burning, Quicken, Aggravate, Spread, Bloom, Hyperbloom, or Burgeon, a Leaf of Consciousness will be created around the character for a maximum of 10s. When picked up, the Leaf will grant the character 60~120 Elemental Mastery for 12s. Only 1 Leaf can be generated this way every 20s. This effect can still be triggered if the character is not on the field. The Leaf of Consciousness' effect cannot stack.",
                "https://img.game8.co/3580943/04cbf6d1914c47c8d827e29fd6ba0be5.png/show"),
            new Weapon(
                "Frostbearer",
                "Catalyst",
                "ATK 41.3%",
                "Hitting an opponent with Normal and Charged Attacks has a 60~100% chance of forming and dropping an Everfrost Icicle above them, dealing 80~140% AoE ATK DMG. Opponents affected by Cryo are dealt 200~360% ATK DMG instead by the icicle. Can only occur once every 10s.",
                "https://img.game8.co/3310141/568e54b795ad1171d85d2d19c3492d23.png/show"),
            new Weapon(
                "Fruit of Fulfillment",
                "Catalyst",
                "Energy Recharge 45.9%",
                "Obtain the 'Wax and Wane' effect after an Elemental Reaction is triggered, gaining 24~36 Elemental Mastery while losing 5% ATK. For every 0.3s, 1 stack of Wax and Wane can be gained. Max 5 stacks. For every 6s that go by without an Elemental Reaction being triggered, 1 stack will be lost. This effect can be triggered even when the character is off-field.",
                "https://img.game8.co/3580944/c96ff14789d0dae6cecba30446e38d0c.png/show"),
            new Weapon(
                "Hakushin Ring",
                "Catalyst",
                "Energy Recharge 30.6%",
                "After the character equipped with this weapon triggers an Electro elemental reaction, nearby party members of an Elemental Type involved in the elemental reaction receive a 10~20% Elemental DMG Bonus for their element, lasting 6s. Elemental Bonuses gained in this way cannot be stacked.",
                "https://img.game8.co/3385778/46878fca7e70b64b50ac094446eacc53.png/show"),
            new Weapon(
                "Hamayumi",
                "Bow",
                "ATK 55.1%",
                "Increases Normal Attack DMG by 16~32% and Charged Attack DMG by 12~24%. When the equipping character's Energy reaches 100%, this effect is increased by 100%.",
                "https://img.game8.co/3441953/c51b98e63961d8ce32113e7c21780f8a.png/show"),
            new Weapon(
                "Ibis Piercer",
                "Bow",
                "ATK 27.6%",
                "The character's Elemental Mastery will increase by 40~80 within 6s after Charged Attacks hit opponents. Max 2 stacks. This effect can triggered once every 0.5s.",
                "https://img.game8.co/3715206/c58d507ad8f80b6083ef569f5c6d1653.png/show"),
            new Weapon(
                "Iron Sting",
                "Sword",
                "Elemental Mastery 165",
                "Dealing Elemental DMG increases all DMG by 6~12% for 6s. Max 2 stacks. Can only occur once every 1s.",
                "https://img.game8.co/3314433/4fb2afba31159663b239b33e38cb47c5.png/show"),
            new Weapon(
                "Kagotsurube Isshin",
                "Sword",
                "ATK 41.3%",
                "When a Normal, Charged, or Plunging Attack hits an opponent, it will whip up a Hewing Gale, dealing AoE DMG equal to 180% of ATK and increasing ATK by 15% for 8s. This effect can be triggered once every 8s.",
                "https://img.game8.co/3548017/40b01ba41ad5aef43d84ce31010b0d1c.png/show"),
            new Weapon(
                "Katsuragikiri Nagamasa",
                "Claymore",
                "Energy Recharge 45.9%",
                "Increases Elemental Skill DMG by 6~12%. After Elemental Skill hits an opponent, the character loses 3 Energy but regenerates 3~5 Energy every 2s for the next 6s. This effect can occur once every 10s. Can be triggered even when the character is not on the field.",
                "https://img.game8.co/3441964/deb90f78176238f39e9f5ae332e001c1.png/show"),
            new Weapon(
                "King's Squire",
                "Bow",
                "ATK 55.1%",
                "Obtain the Teachings of the Forest effect when unleashing Elemental Skills and Bursts, increasing Elemental Mastery by 60~140 for 12s. This effect will be removed when switching characters. When the Teachings of the Forest effect ends or is removed, it will deal 100~180% of ATK as DMG to 1 nearby opponent. The Teachings of the Forest effect can be triggered once every 20s.",
                "https://img.game8.co/3580942/4f1477a64bb5e75237c7b2fe903b02a3.png/show"),
            new Weapon(
                "Kitain Cross Spear",
                "Polearm",
                "Elemental Mastery 110",
                "Increases Elemental Skill DMG by 6~12%. After Elemental Skill hits an opponent, the character loses 3 Energy but regenerates 3~5 Energy every 2s for the next 6s. This effect can occur once every 10s. Can be triggered even when the character is not on the field.",
                "https://img.game8.co/3441963/1ebaf964564175460e6bdc2e556e6947.png/show"),
            new Weapon(
                "Lion's Roar",
                "Sword",
                "ATK 41.3%",
                "Increases DMG against enemies affected by Pyro or Electro by 20~36%.",
                "https://img.game8.co/3314480/604d2c85951b54ee14c8426aab08c908.png/show"),
            new Weapon(
                "Lithic Blade",
                "Claymore",
                "ATK 41.3%",
                "For every character in the party who hails from Liyue, the character who equips this weapon gains 7~11% ATK increase and 3~7% CRIT Rate increase. This effect stacks up to 4 times.",
                "https://img.game8.co/3522671/a8101fa56facd26ff5291d0fb97d01ee.png/show"),
            new Weapon(
                "Lithic Spear",
                "Polearm",
                "ATK 27.6%",
                "For every character in the party who hails from Liyue, the character who equips this weapon gains 7~11% ATK increase and a 3~7% CRIT Rate increase. This effect stacks up to 4 times.",
                "https://img.game8.co/3325101/bb337551b885279cf3607f2b805bbe55.png/show"),
            new Weapon(
                "Luxurious Sea-Lord",
                "Claymore",
                "ATK 55.1%",
                "Increases Elemental Burst DMG by 12~24%. When Elemental Burst hits opponents, there is a 100% chance of summoning a huge onrush of tuna that deals 100~200% ATK as AoE DMG. This effect can occur once every 15s.",
                "https://img.game8.co/3424574/ccdcb14165099185b9dd478662f40db3.png/show"),
            new Weapon(
                "Mailed Flower",
                "Claymore",
                "Elemental Mastery 110",
                "Within 8s after the character's Elemental Skill hits an opponent or the character triggers an Elemental Reaction, their ATK and Elemental Mastery will be increased by 12~24% and 48~96 respectively.",
                "https://img.game8.co/3655517/ee5bef25995e14421047405cd1307532.png/show"),
            new Weapon(
                "Makhaira Aquamarine",
                "Claymore",
                "Elemental Mastery 165",
                "The following effect will trigger every 10s: The equipping character will gain 24~48% of their Elemental Mastery as bonus ATK for 12s, with nearby party members gaining 30% of this buff for the same duration. Multiple instances of this weapon can allow this buff to stack. This effect will still trigger even if the character is not on the field.",
                "https://img.game8.co/3594477/a20ef92a85a283e6cd0d63a19bdbbed4.png/show"),
            new Weapon(
                "Mappa Mare",
                "Catalyst",
                "Elemental Mastery 110",
                "Triggering an Elemental reaction grants a 8~16% Elemental DMG Bonus for 10s. Max 2 stacks.",
                "https://img.game8.co/3314436/77efad7021cc15aa9502a9881404ea5a.png/show"),
            new Weapon(
                "Missive Windspear",
                "Polearm",
                "ATK 41.3%",
                "Within 10s after an Elemental Reaction is triggered, ATK is increased by 12~24% and Elemental Mastery is increased by 48~96.",
                "https://img.game8.co/3597601/fbbc6a1cbe94c0c742cfcc25ac0e532a.png/show"),
            new Weapon(
                "Mitternachts Waltz",
                "Bow",
                "Physical DMG Bonus 51.7%",
                "Normal Attack hits on opponents increase Elemental Skill DMG by 20~40% for 5s. Elemental Skill hits on opponents increase Normal Attack DMG by 20~40% for 5s.",
                "https://img.game8.co/3441960/15a38dc08ff658688a844178b7c06846.png/show"),
            new Weapon(
                "Moonpiercer",
                "Polearm",
                "Elemental Mastery 110",
                "After triggering Burning, Quicken, Aggravate, Spread, Bloom, Hyperbloom, or Burgeon, a Leaf of Revival will be created around the character for a maximum of 10s. When picked up, the Leaf will grant the character 16~32% ATK for 12s. Only 1 Leaf can be generated this way every 20s. This effect can still be triggered if the character is not on the field.",
                "https://img.game8.co/3580945/106a43a28f2a3e13eafd3096a404353e.png/show"),
            new Weapon(
                "Mouun's Moon",
                "Bow",
                "ATK 27.6%",
                "For every point of the entire party's combined maximum Energy capacity, the Elemental Burst DMG of the character equipping this weapon is increased by 0.12~0.24%. A maximum of 40~80% increased Elemental Burst DMG can be achieved this way.",
                "https://img.game8.co/3441957/785ccf1092585ecb1c8b9b1462cd9fff.png/show"),
            new Weapon(
                "Oathsworn Eye",
                "Catalyst",
                "ATK 27.6%",
                "Increases Energy Recharge by 24~48% for 10s after using an Elemental Skill.",
                "https://img.game8.co/3490615/ea3ba77e89fd02f295dc2009ea949aa5.png/show"),
            new Weapon(
                "Predator",
                "Bow",
                "ATK 41.3%",
                "This weapon's effect is only applied on the PlayStation Network: Dealing Cryo DMG to opponents increases this character's Normal and Charged Attack DMG by 10% for 6s. This effect can have a maximum of 2 stacks. Additionally, when Aloy equips Predator, ATK is increased by 66.",
                "https://img.game8.co/3441956/a7f5b2e3e3c8e2fa82564ea94463dcd6.png/show"),
            new Weapon(
                "Prototype Amber",
                "Catalyst",
                "HP 41.3%",
                "Using an Elemental Burst regenerates 4~6 Energy every 2s for 6s. All party members will regenerate 4~6% HP every 2s for this duration.",
                "https://img.game8.co/3314432/ecfc51360ac66ea8308c375a56e1f10e.png/show"),
            new Weapon(
                "Prototype Archaic",
                "Catalyst",
                "ATK 27.6%",
                "On hit, Normal or Charged Attacks have a 50% chance to deal an additional 240~480% ATK DMG to opponents within a small AoE. Can only occur once every 15s.",
                "https://img.game8.co/3314437/94b2ae2f09fb3f853905985f9b4135c6.png/show"),
            new Weapon(
                "Prototype Crescent",
                "Bow",
                "ATK 41.3%",
                "Charged Attack hits on weak points increase Movement SPD by 10% and ATK by 36~72% for 10s.",
                "https://img.game8.co/3314441/3c2dc168e62eff67c7117b16e87599f7.png/show"),
            new Weapon(
                "Prototype Rancour",
                "Sword",
                "Physical DMG Bonus 34.5%",
                "On hit, Normal or Charged Attacks increase ATK and DEF by 4~8% for 6s. Max 4 stacks. This effect can only occur once every 0.3s.",
                "https://img.game8.co/3314434/4a89775a4222b8619253c0cb5efb43f4.png/show"),
            new Weapon(
                "Prototype Starglitter",
                "Polearm",
                "Energy Recharge 45.9%",
                "After using an Elemental Skill, increases Normal and Charged Attack DMG by 8~16% for 12s. Max 2 stacks.",
                "https://img.game8.co/3314440/b61980bfb8c66ea9ceb63443be120f78.png/show"),
            new Weapon(
                "Rainslasher",
                "Claymore",
                "Elemental Mastery 165",
                "Increases DMG against opponents affected by Hydro or Electro by 20~36%.",
                "https://img.game8.co/3522669/6f5d4142b35e4a05a2acb89cb608a2c2.png/show"),
            new Weapon(
                "Royal Bow",
                "Bow",
                "ATK 41.3%",
                "Upon dealing damage to an opponent, increases CRIT Rate by 8~16%. Max 5 stacks. A CRIT hit removes all existing stacks.",
                "https://img.game8.co/3314397/ca46eab5002729b58ef845b858c1ead7.png/show"),
            new Weapon(
                "Royal Greatsword",
                "Catalyst",
                "ATK 27.6%",
                "Upon dealing damage to an opponent, increases CRIT Rate by 8~16%. Max 5 stacks. A CRIT hit removes all existing stacks.",
                "https://img.game8.co/3346262/6aff4095445484f60d27f9ef48ced049.png/show"),
            new Weapon(
                "Royal Grimoire",
                "Catalyst",
                "ATK 27.6%",
                "Upon dealing damage to an opponent, increases CRIT Rate by 8~16%. Max 5 stacks. A CRIT hit removes all existing stacks.",
                "https://img.game8.co/3314400/98ffec5e834ec29e2d23d7892287739e.png/show"),
            new Weapon(
                "Royal Longsword",
                "Sword",
                "ATK 41.3%",
                "Upon dealing damage to an opponent, increases CRIT Rate by 8~16%. Max 5 stacks. A CRIT hit removes all existing stacks.",
                "https://img.game8.co/3314416/dec4a2bc6f8204b3749be93dd89c23bb.png/show"),
            new Weapon(
                "Royal Spear",
                "Polearm",
                "ATK 27.6%",
                "Upon dealing damage to an opponent, increases CRIT Rate by 8~16%. Max 5 stacks. A CRIT hit removes all existing stacks.",
                "https://img.game8.co/3314396/fcbb7ee3eb9a9d8481fc315b53519735.png/show"),
            new Weapon(
                "Rust",
                "Bow",
                "ATK 41.3%",
                "Increases Normal Attack DMG by 40~80% but decreases Charged Attack DMG by 10%.",
                "https://img.game8.co/3314490/72c5ae525ba26d02d2b6c40b5569ad73.png/show"),
            new Weapon(
                "Sacrificial Bow",
                "Bow",
                "Energy Recharge 30.6%",
                "After dealing damage to an opponent with an Elemental Skill, the skill has a 40~80% chance to end its own CD. Can only occur once every 30~16s.",
                "https://img.game8.co/3314489/6cda8ba49361c10e9cadbca6e5b47aba.png/show"),
            new Weapon(
                "Sacrificial Fragments",
                "Catalyst",
                "Elemental Mastery 221",
                "After dealing damage to an opponent with an Elemental Skill, the skill has a 40~80% chance to end its own CD. Can only occur once every 30~16s.",
                "https://img.game8.co/3314492/c23eb4f6fe804b7e3a9a997fac937c94.png/show"),
            new Weapon(
                "Sacrificial Greatsword",
                "Claymore",
                "Energy Recharge 30.6%",
                "After dealing damage to an opponent with an Elemental Skill, the skill has a 40~80% chance to end its own CD. Can only occur once every 30~16s.",
                "https://img.game8.co/3314475/e7435217637d18327507c1566a72c710.png/show"),
            new Weapon(
                "Sacrificial Sword",
                "Sword",
                "Energy Recharge 61.3%",
                "After dealing damage to an opponent with an Elemental Skill, the skill has a 40~80% chance to end its own CD. Can only occur once every 30~16s.",
                "https://img.game8.co/3314479/f5992046e18934edf51385d836106243.png/show"),
            new Weapon(
                "Sapwood Blade",
                "Sword",
                "Energy Recharge 30.6%",
                "After triggering Burning, Quicken, Aggravate, Spread, Bloom, Hyperbloom, or Burgeon, a Leaf of Consciousness will be created around the character for a maximum of 10s. When picked up, the Leaf will grant the character 60~120 Elemental Mastery for 12s. Only 1 Leaf can be generated this way every 20s. This effect can still be triggered if the character is not on the field. The Leaf of Consciousness' effect cannot stack.",
                "https://img.game8.co/3580946/42fdcb51b7236943f0e7081648248ceb.png/show"),
            new Weapon(
                "Serpent Spine",
                "Claymore",
                "CRIT Rate 27.6%",
                "Every 4s a character is on the field, they will deal 6~10% more DMG and take 3~2% more DMG. This effect has a maximum of 5 stacks and will not be reset if the character leaves the field, but will be reduced by 1 stack when the character takes DMG.",
                "https://img.game8.co/3522670/7aec98405b498e3d033db3a3696467af.png/show"),
            new Weapon(
                "Snow-Tombed Starsilver",
                "Claymore",
                "Physical DMG Bonus 34.5%",
                "Hitting an opponent with Normal and Charged Attacks has a 60~100% chance of forming and dropping an Everfrost Icicle above them, dealing AoE DMG equal to 80~140% of ATK. Opponents affected by Cryo are instead dealt DMG equal to 200~360% of ATK. Can only occur once every 10s.",
                "https://img.game8.co/3312576/096d225d73b319b65ab9dd267b2d5e2e.png/show"),
            new Weapon(
                "Solar Pearl",
                "Catalyst",
                "CRIT Rate 27.6%",
                "Normal Attack hits increase Elemental Skill and Elemental Burst DMG by 20~40% for 6s. Likewise, Elemental Skill or Elemental Burst hits increase Normal Attack DMG by 20~40% for 6s.",
                "https://img.game8.co/3314398/d65ce89004cee8a7736c5eca7a2abfdd.png/show"),
            new Weapon(
                "Sword of Descension",
                "Sword",
                "ATK 35.2%",
                "This weapon's effect is only applied on the PlayStation Network: Hitting enemies with Normal or Charged Attacks grants a 50% chance to deal 200% ATK as DMG in a small AoE. This effect can only occur once every 10s. Additionally, if the Traveler equips the Sword of Descension, their ATK is increased by 66.",
                "https://img.game8.co/3346263/fb1a75e5f067bbbecd05a3c4183b0209.png/show"),
            new Weapon(
                "The Alley Flash",
                "Sword",
                "Elemental Mastery 55",
                "Increases DMG dealt by the character equipping this weapon by 12~24%. Taking DMG disables this effect for 5s.",
                "https://img.game8.co/3334893/270c37faba78c920941bd3e73fa36581.png/show"),
            new Weapon(
                "The Bell",
                "Claymore",
                "HP 41.3%",
                "Taking DMG generates a shield which absorbs DMG up to 20~32% of max HP. This shield lasts for 10s or until broken, and can only be triggered once every 45s. While protected by a shield, the character gains 12~24% increased DMG.",
                "https://img.game8.co/3314478/58ceb4cfcb54e9dcceaeb8c99cf7116b.png/show"),
            new Weapon(
                "The Black Sword",
                "Sword",
                "CRIT Rate 27.6%",
                "Increases DMG dealt by Normal and Charged Attacks by 20~40%. Additionally, regenerates 60~100% of ATK as HP when Normal and Charged Attacks score a CRIT Hit. This effect can occur once every 5s.",
                "https://img.game8.co/3314420/8a1f23d3b4b90ff418e7760224c37f2e.png/show"),
            new Weapon(
                "The Flute",
                "Sword",
                "ATK 41.3%",
                "Normal or Charged Attacks grant a Harmonic on hits. Gaining 5 Harmonics triggers the power of music and deals 100~200% ATK DMG to surrounding enemies. Harmonics last up to 30s, and a maximum of 1 can be gained every 0.5s.",
                "https://img.game8.co/3314484/da0eb7a3ce075d51f970fda9644d6271.png/show"),
            new Weapon(
                "The Stringless",
                "Bow",
                "Elemental Mastery 165",
                "Increases Elemental Skill and Elemental Burst DMG by 24~48%.",
                "https://img.game8.co/3314487/79dd9495f5329d39595706ccc31cd8f6.png/show"),
            new Weapon(
                "The Viridescent Hunt",
                "Bow",
                "CRIT Rate 27.6%",
                "Upon hit, Normal and Aimed Shot Attacks have a 50% chance to generate a Cyclone, which will continuously attract surrounding opponents, dealing 40~80% of ATK as DMG to these opponents every 0.5s for 4s. This effect can only occur once every 14~10s.",
                "https://img.game8.co/3314422/723b3502330fea6a6d3174e25f45681c.png/show"),
            new Weapon(
                "The Widsith",
                "Catalyst",
                "CRIT DMG 55.1%",
                "When a character takes the field, they will gain a random theme song for 10s. This can only occur once every 30s. Recitative: ATK is increased by 60~120%. Aria: Increases all Elemental DMG by 48~96%. Interlude: Elemental Mastery is increased by 240~480.",
                "https://img.game8.co/3314591/3a9b07fded3dd45454a6d850ca203499.png/show"),
            new Weapon(
                "Toukabou Shigure",
                "Sword",
                "Elemental Mastery 165",
                "After an attack hits opponents, it will inflict an instance of Cursed Parasol upon one of them for 10s. This effect can be triggered once every 15s. If this opponent is defeated during Cursed Parasol's duration, Cursed Parasol's CD will be refreshed immediately. The character wielding this weapon will deal 16~32% more DMG to the opponent affected by Cursed Parasol.",
                "https://img.game8.co/3623676/cf17c8a3bd127aa1a81876b6c27f837b.png/show"),
            new Weapon(
                "Wandering Evenstar",
                "Catalyst",
                "Elemental Mastery 165",
                "The following effect will trigger every 10s: The equipping character will gain 24~48% of their Elemental Mastery as bonus ATK for 12s, with nearby party members gaining 30% of this buff for the same duration. Multiple instances of this weapon can allow this buff to stack. This effect will still trigger even if the character is not on the field.",
                "https://img.game8.co/3596778/eb5ab1972d4b804d76d3e843597f08c9.png/show"),
            new Weapon(
                "Wavebreaker's Fin",
                "Polearm",
                "ATK 13.8%",
                "For every point of the entire party's combined maximum Energy capacity, the Elemental Burst DMG of the character equipping this weapon is increased by 0.12~0.24%. A maximum of 40~80% increased Elemental Burst DMG can be achieved this way.",
                "https://img.game8.co/3441959/8fdcfaaf4aaedcca596f1c4c5fae1e04.png/show"),
            new Weapon(
                "Whiteblind",
                "Claymore",
                "DEF 51.7%",
                "On hit, Normal or Charged Attacks increase ATK and DEF by 6~12% for 6s. Max 4 stacks (24~48% total). Can only occur once every 0.5s.",
                "https://img.game8.co/3314439/146f2f95aefb8a5dde9435deb6c3da85.png/show"),
            new Weapon(
                "Windblume Ode",
                "Bow",
                "Elemental Mastery 165",
                "After using an Elemental Skill, receive a boon from the ancient wish of the Windblume, increasing ATK by 16~32% for 6s.",
                "https://img.game8.co/3338725/c6294e05725ac16a55a63004810c7211.png/show"),
            new Weapon(
                "Wine and Song",
                "Catalyst",
                "Energy Recharge 30.6%",
                "Hitting an opponent with a Normal Attack decreases the Stamina consumption of Sprint or Alternate Sprint by 14~22% for 5s. Additionally, using a Sprint or Alternate Sprint ability increases ATK by 20~40% for 5s.",
                "https://img.game8.co/3459091/e9b5621eada2d1fc422a96e8763bc514.png/show"),
            new Weapon(
                "Xiphos' Moonlight",
                "Sword",
                "Elemental Mastery 165",
                "The following effect will trigger every 10s: The equipping character will gain 0.036~0.072% Energy Recharge for each point of Elemental Mastery they possess for 12s, with nearby party members gaining 30% of this buff for the same duration. Multiple instances of this weapon can allow this buff to stack. This effect will still trigger even if the character is not on the field.",
                "https://img.game8.co/3596943/c3832b64a46c6cc79b190a578180d1a7.png/show"),
            new Weapon(
                "A Thousand Floating Dreams",
                "Catalyst",
                "Elemental Mastery 265",
                "Party members other than the equipping character will provide the equipping character with buffs based on whether their Elemental Type is the same as the latter or not. If their Elemental Types are the same, increase Elemental Mastery by 32~64. If not, increase the equipping character's DMG Bonus from their Elemental Type by 10~26%. Each of the aforementioned effects can have up to 3 stacks. Additionally, all nearby party members other than the equipping character will have their Elemental Mastery increased by 40~48. Multiple such effects from multiple such weapons can stack.",
                "https://img.game8.co/3604186/0a10f4aac949038c4850e9f1f320689b.png/show"),
            new Weapon(
                "Amos' Bow",
                "Bow",
                "ATK 49.6%",
                "Increases Normal Attack and Charged Attack DMG by 12~24%. After a Normal or Charged Attack is fired, DMG dealt increases by a further 8~16% every 0.1 seconds the arrow is in the air for up to 5 times.",
                "https://img.game8.co/3314370/6ffcc5b665c0c0cdcfc6a5307efb50fc.png/show"),
            new Weapon(
                "Aqua Simulacra",
                "Bow",
                "CRIT DMG 88.2%",
                "HP is increased by 16~32%. When there are opponents nearby, the DMG dealt by the wielder of this weapon is increased by 20~40%. This will take effect whether the character is on-field or not.",
                "https://img.game8.co/3528570/002bacc1da7d27ed47513dcddf5664a3.png/show"),
            new Weapon(
                "Aquila Favonia",
                "Sword",
                "Physical DMG Bonus 41.3%",
                "ATK is increased by 20~40%. Triggers on taking DMG: the soul of the Falcon of the West awakens, holding the banner of the resistance aloft, regenerating HP equal to 100~160% of ATK and dealing 200~320% of ATK as DMG to surrounding opponents. This effect can only occur once every 15s.",
                "https://img.game8.co/3301808/a675f0895d38c5442d6619f737a57dc4.png/show"),
            new Weapon(
                "Beacon of the Reed Sea",
                "Claymore",
                "CRIT Rate 33.1%",
                "After the character's Elemental Skill hits an opponent, their ATK will be increased by 20~40% for 8s. After the character takes DMG, their ATK will be increased by 20~40% for 8s. The 2 aforementioned effects can be triggered even when the character is not on the field. Additionally, when not protected by a shield, the character's Max HP will be increased by 32~64%.",
                "https://img.game8.co/3660160/2623f4f3b7a7a6b15f3c11c97bb6371c.png/show"),
            new Weapon(
                "Calamity Queller",
                "Polearm",
                "ATK 16.5%",
                "Gain 12~24% All Elemental DMG Bonus. Obtain Consummation for 20s after using an Elemental Skill, causing ATK to increase by 3.2~6.4% per second. This ATK increase has a maximum of 6 stacks. When the character equipped with this weapon is not on the field, Consummation's ATK increase is doubled.",
                "https://img.game8.co/3466467/ce3773137658045cf6fb9be54efeddfc.png/show"),
            new Weapon(
                "Elegy for the End",
                "Bow",
                "Energy Recharge 55.1%",
                "A part of the 'Millennial Movement' that wanders amidst the winds. Increases Elemental Mastery by 60~120. When the Elemental Skills or Elemental Bursts of the character wielding this weapon hit opponents, that character gains a Sigil of Remembrance. This effect can be triggered once every 0.2s and can be triggered even if said character is not on the field. When you possess 4 Sigils of Remembrance, all of them will be consumed and all nearby party members will obtain the 'Millennial Movement: Farewell Song' effect for 12s.'Millennial Movement: Farewell Song' increases Elemental Mastery by 100~200 and increases ATK by 20~40%. Once this effect is triggered, you will not gain Sigils of Remembrance for 20s. Of the many effects of the 'Millennial Movement,' buffs of the same type will not stack.",
                "https://img.game8.co/3337676/5fa2d6425740a96a905eeb98b5989af2.png/show"),
            new Weapon(
                "Engulfing Lightning",
                "Polearm",
                "Energy Recharge 55.1%",
                "ATK increased by 28~56% of Energy Recharge over the base 100%. You can gain a maximum bonus of 80~120% ATK. Gain 30~50% Energy Recharge for 12s after using an Elemental Burst.",
                "https://img.game8.co/3406917/3b47d214c8da2606eaafa91926da532d.png/show"),
            new Weapon(
                "Everlasting Moonglow",
                "Catalyst",
                "HP 49.6%",
                "Healing Bonus increased by 10~20%, Normal Attack DMG is increased by 1~3.0% of the Max HP of the character equipping this weapon. For 12s after using an Elemental Burst, Normal Attacks that hit opponents will restore 0.6 Energy. Energy can be restored this way once every 0.1s.",
                "https://img.game8.co/3406916/f058c984d344ac944f12a5e62c655414.png/show"),
            new Weapon(
                "Freedom-Sworn",
                "Sword",
                "Elemental Mastery 198",
                "A part of the 'Millennial Movement' that wanders amidst the winds.'Increases DMG by 10~20%. When the character wielding this weapon triggers Elemental Reactions, they gain a Sigil of Rebellion. This effect can be triggered once every 0.5s and can be triggered even if said character is not on the field. When you possess 2 Sigils of Rebellion, all of them will be consumed and all nearby party members will obtain 'Millennial Movement: Song of Resistance' for 12s. 'Millennial Movement: Song of Resistance' increases Normal, Charged, and Plunging Attack DMG by 16~32% and increases ATK by 20~40%. Once this effect is triggered, you will not gain Sigils of Rebellion for 20s. Of the many effects of the 'Millennial Movement,' buffs of the same type will not stack.",
                "https://img.game8.co/3456283/700b83638b99dba8908463aa92f6b3d6.png/show"),
            new Weapon(
                "Haran Geppaku Futsu",
                "Sword",
                "CRIT Rate 33.1%",
                "Obtain 12~24% All Elemental DMG Bonus. When other nearby party members use Elemental Skills, the character equipping this weapon will gain 1 Wavespike stack. Max 2 stacks. This effect can be triggered once every 0.3s. When the character equipping this weapon uses an Elemental Skill, all stacks of Wavespike will be consumed to gain Rippling Upheaval: each stack of Wavespike consumed will increase Normal Attack DMG by 20~40% for 8s.",
                "https://img.game8.co/3511222/2310c3f7ed9c13a4249fccdc256199bb.png/show"),
            new Weapon(
                "Hunter's Path",
                "Bow",
                "CRIT Rate 44.1%",
                "Gain 12~24% All Elemental DMG Bonus. Obtain the Tireless Hunt effect after hitting an opponent with a Charged Attack. This effect increases Charged Attack DMG by 160~320% of Elemental Mastery. This effect will be removed after 12 Charged Attacks or 10s. Only 1 instance of Tireless Hunt can be gained every 12s.",
                "https://img.game8.co/3581031/e6635c46104684f58db0aaecada0b8fe.png/show"),
            new Weapon(
                "Jadefall's Splendor",
                "Catalyst",
                "HP 49.6%",
                "For 3s after using an Elemental Burst or creating a shield, the equipping character can gain the Primordial Jade Regalia effect: Restore 4.5~6.5 Energy every 2.5s, and gain 0.3~1.1% Elemental DMG Bonus for their corresponding Elemental Type for every 1,000 Max HP they possess, up to 12~44%. Primordial Jade Regalia will still take effect even if the equipping character is not on the field.",
                "https://img.game8.co/3685384/2f035d2cfcb6b8afb407cb15dee9e3fa.png/show"),
            new Weapon(
                "Kagura's Verity",
                "Catalyst",
                "CRIT DMG 66.2%",
                "Gains the Kagura Dance effect when using an Elemental Skill, causing the Elemental Skill DMG of the character wielding this weapon to increase by 12~24% for 16s. Max 3 stacks. This character will gain 12~24% All Elemental DMG Bonus when they possess 3 stacks.",
                "https://img.game8.co/3487589/f131eb7f0d3c359c363298bb403c522b.png/show"),
            new Weapon(
                "Key of Khaj-Nisut",
                "Sword",
                "HP 66.2%",
                "HP increased by 20~40%. When an Elemental Skill hits opponents, you gain the Grand Hymn effect for 20s. This effect increases the equipping character's Elemental Mastery by 0.12~0.24% of their Max HP. This effect can trigger once every 0.3s. Max 3 stacks. When this effect gains 3 stacks, or when the third stack's duration is refreshed, the Elemental Mastery of all nearby party members will be increased by 0.2~0.4% of the equipping character's max HP for 20s.",
                "https://img.game8.co/3596782/77719f703169b3aa39f6060ae55dc40b.png/show"),
            new Weapon(
                "Light of Foliar Incision",
                "Sword",
                "CRIT DMG 88.2%",
                "CRIT Rate is increased by 4~8%. After Normal Attacks deal Elemental DMG, the Foliar Incision effect will be obtained, increasing DMG dealt by Normal Attacks and Elemental Skills by 120~240% of Elemental Mastery. This effect will disappear after 28 DMG instances or 12s. You can obtain Foliar Incision once every 12s.",
                "https://img.game8.co/3635987/a22eb6f7a3fb484222553f7a0772a052.png/show"),
            new Weapon(
                "Lost Prayer to the Sacred Winds",
                "Catalyst",
                "CRIT Rate 33.1%",
                "Increases Movement SPD by 10%. When in battle, gain an 8~16% Elemental DMG Bonus every 4s. Max 4 stacks. Lasts until the character falls or leaves combat.",
                "https://img.game8.co/3346264/0e392bb85512e2abb709aa844b46eb77.png/show"),
            new Weapon(
                "Memory of Dust",
                "Catalyst",
                "ATK 49.6%",
                "Increases Shield Strength by 20~40%. Scoring hits on opponents increases ATK by 4~8% for 8s. Max 5 stacks. Can only occur once every 0.3s. While protected by a shield, this ATK increase effect is increased by 100%.",
                "https://img.game8.co/3314350/d958ab07423e73c246b074d4e8aa0e31.png/show"),
            new Weapon(
                "Mistsplitter Reforged",
                "Sword",
                "CRIT DMG 44.1%",
                "Gain a 12~24% Elemental DMG Bonus for all elements and receive the might of the Mistsplitter's Emblem. At stack levels 1/2/3, Mistsplitter's Emblem provides a 8/16/28~16/32/56% Elemental DMG Bonus for the character's Elemental Type. The character will obtain 1 stack of Mistsplitter's Emblem in each of the following scenarios: Normal Attack deals Elemental DMG (stack lasts 5s), casting Elemental Burst (stack lasts 10s); Energy is less than 100% (stack disappears when Energy is full). Each stack's duration is calculated independently.",
                "https://img.game8.co/3385777/e37e18f22714bbafe297e8a4beb96749.png/show"),
            new Weapon(
                "Polar Star",
                "Bow",
                "CRIT Rate 33.1%",
                "Elemental Skill and Elemental Burst DMG increased by 12~24%. After a Normal Attack, Charged Attack, Elemental Skill or Elemental Burst hits an opponent, 1 stack of Ashen Nightstar will be gained for 12s. When 1/2/3/4 stacks of Ashen Nightstar are present, ATK is increased by 10/20/30/48~20/40/60/96%. The stack of Ashen Nightstar created by the Normal Attack, Charged Attack, Elemental Skill or Elemental Burst will be counted independently of the others.",
                "https://img.game8.co/3441955/4d6e9bd57053a0002ee39fd2c79a5ded.png/show"),
            new Weapon(
                "Primordial Jade Cutter",
                "Sword",
                "CRIT Rate 44.1%",
                "HP increased by 20~40%. Additionally, provides an ATK Bonus based on 1.2~2.4% of the wielder's Max HP.",
                "https://img.game8.co/3324722/757eafc03c9cb40182204cd8af8e4163.png/show"),
            new Weapon(
                "Primordial Jade Winged-Spear",
                "Polearm",
                "CRIT Rate 22.1%",
                "On hit, increases ATK by 3.2~6.0% for 6s. Max 7 stacks. This effect can only occur once every 0.3s. While in possession of the maximum possible stacks, DMG dealt is increased by 12~24%.",
                "https://img.game8.co/3314371/b69ff07b01658994f8567f638e6173a1.png/show"),
            new Weapon(
                "Redhorn Stonethresher",
                "Claymore",
                "CRIT DMG 88.2%",
                "DEF is increased by 28~56%. Normal and Charged Attack DMG is increased by 40~80% of DEF.",
                "https://img.game8.co/3459955/1d2415e1d932c703b8f39d30358a2ee0.png/show"),
            new Weapon(
                "Skyward Atlas",
                "Catalyst",
                "ATK 33.1%",
                "Increases Elemental DMG Bonus by 12~24%. Normal Attack hits have a 50% chance to earn the favor of the clouds. which actively seek out nearby opponents to attack for 15s, dealing 160~320% ATK DMG. Can only occur once every 30s.",
                "https://img.game8.co/3301806/a6095a397ed72ce54a8dd128b4e7089b.png/show"),
            new Weapon(
                "Skyward Blade",
                "Sword",
                "Energy Recharge 55.1%",
                "CRIT Rate increased by 4~8%. Gains Skypiercing Might upon using an Elemental Burst: Increases Movement SPD by 10%, increases ATK SPD by 10%, and Normal and Charged hits deal additional DMG equal to 20~40% of ATK. Skypiercing Might lasts for 12s.",
                "https://img.game8.co/3314375/be522987f46d874d5a1f1e0e45dfd43b.png/show"),
            new Weapon(
                "Skyward Harp",
                "Bow",
                "CRIT Rate 22.1%",
                "Increases CRIT DMG by 20~40%. Hits have a 60~100% chance to inflict a small AoE attack, dealing 125% Physical ATK DMG. Can only occur once every 4~2s.",
                "https://img.game8.co/3346261/9c2f66fddbb0cbe55f2e79b8ac8c25a0.png/show"),
            new Weapon(
                "Skyward Pride",
                "Claymore",
                "Energy Recharge 36.8%",
                "Increases all DMG by 8~16%. After using an Elemental Burst, Normal or Charged Attack, on hit, creates a vacuum blade that does 80~160% of ATK as DMG to opponents along its path. Lasts for 20s or 8 vacuum blades.",
                "https://img.game8.co/3301809/49d0e32b13e22df7a2787f9e7ed24089.png/show"),
            new Weapon(
                "Skyward Spine",
                "Polearm",
                "Energy Recharge 36.8%",
                "Increases CRIT Rate by 8~16% and increases Normal ATK SPD by 12%. Additionally, Normal and Charged Attacks hits on opponents have a 50% chance to trigger a vacuum blade that deals 40~100% of ATK as DMG in a small AoE. This effect can occur no more than once every 2s.",
                "https://img.game8.co/3314372/9f2e6c60062269c38316327b39c7f16f.png/show"),
            new Weapon(
                "Song of Broken Pines",
                "Claymore",
                "Physical DMG Bonus 20.7%",
                "A part of the 'Millennial Movement' that wanders amidst the winds. Increases ATK by 16~32%, and when Normal or Charged Attacks hit opponents, the character gains a Sigil of Whispers. This effect can be triggered once every 0.3s. When you possess four Sigils of Whispers, all of them will be consumed and all nearby party members will obtain the 'Millennial Movement: Banner-Hymn' effect for 12s. 'Millennial Movement: Banner-Hymn' increases Normal ATK SPD by 12~24% and increases ATK by 20~40%. Once this effect is triggered, you will not gain Sigils of Whispers for 20s. Of the many effects of the 'Millennial Movement', buffs of the same type will not stack.",
                "https://img.game8.co/3360767/8f5b86dccec3b47d032dc259dfcebb2e.png/show"),
            new Weapon(
                "Staff of Homa",
                "Polearm",
                "CRIT DMG 66.2%",
                "HP increased by 20~40%. Additionally, provides an ATK Bonus based on 0.8~1.6% of the wielder's Max HP. When the wielder's HP is less than 50%, this ATK bonus is increased by an additional 1~1.8% of Max HP.",
                "https://img.game8.co/3331190/b98501cae978bb4735562626f192b3fb.png/show"),
            new Weapon(
                "Staff of the Scarlet Sands",
                "Polearm",
                "CRIT Rate 44.1%",
                "The equipping character gains 52~104% of their Elemental Mastery as bonus ATK. When an Elemental Skill hits opponents, the Dream of the Scarlet Sands effect will be gained for 10s: The equipping character will gain 28~56% of their Elemental Mastery as bonus ATK. Max 3 stacks.",
                "https://img.game8.co/3583010/03d67e2baf1b297b7fbd0c24440d95d2.png/show"),
            new Weapon(
                "Summit Shaper",
                "Sword",
                "ATK 49.6%",
                "Increases Shield Strength by 20~40%. Scoring hits on opponents increases ATK by 4~8% for 8s. Max 5 stacks. Can only occur once every 0.3s. While protected by a shield, this ATK increase effect is increased by 100%.",
                "https://img.game8.co/3311113/3b0e2ee76a9d421e3f7e4a640f7a9b99.png/show"),
            new Weapon(
                "The Unforged",
                "Claymore",
                "ATK 49.6%",
                "Increases Shield Strength by 20~40%. Scoring hits on opponents increases ATK by 4~8% for 8s. Max 5 stacks. Can only occur once every 0.3s. While protected by a shield, this ATK increase effect is increased by 100%.",
                "https://img.game8.co/3301791/2983bb1c36edb32b5e936f15973c82ab.png/show"),
            new Weapon(
                "Thundering Pulse",
                "Bow",
                "CRIT DMG 66.2%",
                "Increases ATK by 20~40% and grants the might of the Thunder Emblem. At stack levels 1/2/3, the Thunder Emblem increases Normal Attack DMG by 12/24/40~24/48/80%. The character will obtain 1 stack of Thunder Emblem in each of the following scenarios: Normal Attack deals DMG (stack lasts 5s), casting Elemental Skill (stack lasts 10s); Energy is less than 100% (stack disappears when Energy is full). Each stack's duration is calculated independently.",
                "https://img.game8.co/3441958/f896203efe9ce4f6598fa5ac23c3a196.png/show"),
            new Weapon(
                "Tulaytullah's Remembrance",
                "Catalyst",
                "CRIT DMG 44.1%",
                "Normal Attack SPD is increased by 10~20%. After the wielder unleashes an Elemental Skill, Normal Attack DMG will increase by 4.8~9.6% every second for 14s. After this character hits an opponent with a Normal Attack during this duration, Normal Attack DMG will be increased by 9.6~19.2%. This increase can be triggered once every 0.3s. The maximum Normal Attack DMG increase per single duration of the overall effect is 48~96%. The effect will be removed when the wielder leaves the field, and using the Elemental Skill again will reset all DMG buffs.",
                "https://img.game8.co/3616456/db1de5f246453058c1444c1c199bac13.png/show"),
            new Weapon(
                "Vortex Vanquisher",
                "Polearm",
                "ATK 49.6%",
                "Increases Shield Strength by 20~40%. Scoring hits on opponents increases ATK by 4~8% for 8s. Max 5 stacks. Can only occur once every 0.3s. While protected by a shield, this ATK increase effect is increased by 100%.",
                "https://img.game8.co/3522993/4ef7dfbd19f7ecf4656af9756c25d12c.png/show"),
            new Weapon(
                "Wolf's Gravestone",
                "Claymore",
                "ATK 49.6%",
                "Increases ATK by 20~40%. On hit, attacks against opponents with less than 30% HP increase all party members' ATK by 40~80% for 12s. Can only occur once every 30s.",
                "https://img.game8.co/3508899/bd5cea463de5add38a8d508d2da17070.png/show")
    };
    }
}
