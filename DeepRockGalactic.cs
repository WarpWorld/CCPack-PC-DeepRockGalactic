using CrowdControl.Common;
using JetBrains.Annotations;
using ConnectorType = CrowdControl.Common.ConnectorType;

namespace CrowdControl.Games.Packs.DeepRockGalactic;

[UsedImplicitly]
public class DeepRockGalactic : FileEffectPack
{
    public override string ReadFile => "FSD\\Mods\\CC\\output.txt";
    public override string WriteFile => "FSD\\Mods\\CC\\input.txt";
    public static string ReadyCheckFile = "FSD\\Mods\\CC\\connector.txt";
    public static string GameStateFile = "FSD\\Mods\\CC\\gamestate.txt";

    public override ISimpleTCPPack.MessageFormatType MessageFormat => ISimpleTCPPack.MessageFormatType.CrowdControlLegacyIntermediate;

    public DeepRockGalactic(UserRecord player, Func<CrowdControlBlock, bool> responseHandler, Action<object> statusUpdateHandler) : base(player, responseHandler, statusUpdateHandler) { }

    public override Game Game { get; } = new("Deep Rock Galactic", "DeepRockGalactic", "PC", ConnectorType.FileConnector);
    
    //Parameters
    private readonly ParameterDef TargetsMain = new("Target Player", "targetPlayerType",
        new Parameter("Host", "1"),
        new Parameter("Random Teammate", "2"),
        new Parameter("All", "3")
    );
    private readonly ParameterDef TargetsRestricted = new("Target Player", "targetPlayerType",
        new Parameter("Host", "1"),
        new Parameter("Random Teammate", "2")
    );

    public override EffectList Effects => new List<Effect>
    {
        //Enemy - Glyphids Spawn
        new("Spawn Grunt [M]", "grunt_normal") { Price = 10, Quantity = 10, Category = "Enemy / Glyphid", Description = "Spawns a Grunt" },
        new("Spawn Slasher [M]", "grunt_slasher") { Price = 20, Quantity = 5, Category = "Enemy / Glyphid", Description = "Spawns a Slasher" },
        new("Spawn Guard [M]", "grunt_guard") { Price = 20, Quantity = 5, Category = "Enemy / Glyphid", Description = "Spawns a Guard" },
        new("Spawn Acid Spitter [M]", "grunt_spitter") { Price = 50, Quantity = 5, Category = "Enemy / Glyphid", Description = "Spawns an Acid Spitter" },
        new("Spawn Web Spitter [M]", "grunt_webber") { Price = 50, Quantity = 5, Category = "Enemy / Glyphid", Description = "Spawns a Webber" },
        new("Spawn Warden [M]", "grunt_warden") { Price = 100, Category = "Enemy / Glyphid", Description = "Spawns a Warden" },
        new("Spawn Swarmers [M]", "grunt_swarmers") { Price = 10, Quantity = 10, Category = "Enemy / Glyphid", Description = "Spawns a couple swarmers (Quantity x2)" },
        new("Spawn Praetorian [M]", "grunt_praetorian") { Price = 150, Quantity = 3, Category = "Enemy / Glyphid", Description = "Spawns an Praetorian" },
        new("Spawn Opressor [M]", "grunt_opressor") { Price = 250, Category = "Enemy / Glyphid", Description = "Spawns an Opressor" },
        new("Spawn Stingtail [M]", "grunt_stingtail") { Price = 200, Category = "Enemy / Glyphid", Description = "Spawns an Stingtail" },
        new("Spawn Septic Spreader [M]", "grunt_lobber") { Price = 200, Category = "Enemy / Glyphid", Description = "Spawns an Septic Spreader" },
        new("Spawn Menace [M]", "grunt_menace") { Price = 150, Category = "Enemy / Glyphid", Description = "Spawns an Menace" },
        new("Spawn Exploder [M]", "grunt_exploder") { Price = 50, Quantity = 5, Category = "Enemy / Glyphid", Description = "Spawns an Exploder" },
        new("Spawn Stalker [M]", "grunt_stalker") { Price = 250, Category = "Enemy / Glyphid", Description = "Spawns the Glyphid Stalker" }, //Season 5
        new("Spawn Bulk Detonator [M]", "grunt_bulk") { Price = 500, Category = "Enemy / Glyphid", Description = "Spawns a Bulk Detonator" },
        new("Spawn Crassus Bulk Detonator [M]", "grunt_bulk_gold") { Price = 750, Category = "Enemy / Glyphid", Description = "Spawns a Crassus Bulk Detonator" },
        new("Spawn Ghost Bulk Detonator [M]", "grunt_bulk_ghost") { Price = 1000, Category = "Enemy / Glyphid", Description = "Spawns a Ghost Bulk Detonator" },
        new("Spawn Dreadnaught (Boss) [M]", "grunt_dreadnaught") { Price = 1000, Category = "Enemy / Glyphid", Description = "Spawns the Glyphid Dreadnaught" },
        new("Spawn Arbalest (Boss) [M]", "grunt_twin_a") { Price = 500, Category = "Enemy / Glyphid", Description = "Spawns the Dreadnaught Twin Arbalest" },
        new("Spawn Lacerator (Boss) [M]", "grunt_twin_b") { Price = 500, Category = "Enemy / Glyphid", Description = "Spawns the Dreadnaught Twin Lacerator" },
        new("Spawn Hiveguard (Boss) [M]", "grunt_hiveguard") { Price = 1000, Category = "Enemy / Glyphid", Description = "Spawns the Dreadnaught Hiveguard" },


        //Enemy - Mactera
        new("Spawn Mactera Shooter [M]", "mactera_normal") { Price = 25, Quantity = 5, Category = "Enemy / Mactera", Description = "Spawns a Mactera Shooter" },
        new("Spawn Mactera Grabber [M]", "mactera_grabber") { Price = 100, Category = "Enemy / Mactera", Description = "Spawns a Mactera Greabber" },
        new("Spawn Mactera Goo Bomber [M]", "mactera_goobomber") { Price = 100, Category = "Enemy / Mactera", Description = "Spawns a Mactera Goo Bomber" },
        new("Spawn Mactera Tri-Jaw [M]", "mactera_trijaw") { Price = 100, Category = "Enemy / Mactera", Description = "Spawns a Mactera TriJaw" },
        new("Spawn Mactera Brundle [M]", "mactera_brundle") { Price = 50, Category = "Enemy / Mactera", Description = "Spawns a Mactera Brundle" },

        //Enemy - RockPox
        new("Spawn Rockpox Larva [M]", "rockpox_larva") { Price = 10, Quantity = 10, Category = "Enemy / RockPox", Description = "Spawns Some RockPox Larva (Quantity x2)" },
        new("Spawn Rockpox Grunt [M]", "rockpox_grunt") { Price = 50, Quantity = 5, Category = "Enemy / RockPox", Description = "Spawns a RockPox Grunt" },
        new("Spawn Rockpox Exploder [M]", "rockpox_exploder") { Price = 75, Quantity = 5, Category = "Enemy / RockPox", Description = "Spawns a RockPox Exploder" },
        new("Spawn Rockpox Spitter [M]", "rockpox_spitter") { Price = 75, Quantity = 5, Category = "Enemy / RockPox", Description = "Spawns a RockPox Spitter" },
        new("Spawn Rockpox Praetorian [M]", "rockpox_praetorian") { Price = 175, Quantity = 3, Category = "Enemy / RockPox", Description = "Spawns a RockPox Praetorian" },
        new("Spawn Rockpox Goo Bomber [M]", "rockpox_goobomber") { Price = 125, Category = "Enemy / RockPox", Description = "Spawns a RockPox Goo Bomber" },
        new("Spawn Rockpox Naedocyte Breeder [M]", "rockpox_breeder") { Price = 200, Category = "Enemy / RockPox", Description = "Spawns a RockPox Naedocyte Breeder" },
        new("Spawn Rockpox Corruptor (Boss) [M]", "rockpox_corruptor") { Price = 750, Category = "Enemy / RockPox", Description = "Spawns a RockPox Corruptor" },

        //Enemy - Rivals
        new("Spawn Rival Shredders [M]", "rival_shredders") { Price = 10, Quantity = 5, Category = "Enemy / Rivals", Description = "Spawns a small group of Rival Shredders (Quantity x2)" },
        new("Spawn Rival Patrol Bot [M]", "rival_patrolbot") { Price = 100, Quantity = 3, Category = "Enemy / Rivals", Description = "Spawns a Patrol Bot" },
        new("Spawn Rival Prospector Drone (Boss) [M]", "rival_prospector") { Price = 500, Category = "Enemy / Rivals", Description = "Spawns a Prospector Bot" },
        new("Spawn Rival Nemesis (Boss) [M]", "rival_nemesis") { Price = 500, Category = "Enemy / Rivals", Description = "Spawns a Nemesis" },

        //Enemy - Naedocyte
        new("Spawn Naedocyte Shockers [M]", "jelly_shockers") { Price = 10, Quantity = 5, Category = "Enemy / Naedocyte", Description = "Spawns a small group of Shockers (Quantity x3)" },
        new("Spawn Naedocyte Breeder [M]", "jelly_breeder") { Price = 150, Category = "Enemy / Naedocyte", Description = "Spawns a Naedocyte Breeder" },

        //Enemy - Other
        new("Spawn Nayaka Trawler [M]", "enemy_trawler") { Price = 150, Category = "Enemy / Other", Description = "Spawns a Nayaka Trawler" },
        new("Spawn Q'ronar Youngling [M]", "enemy_youngling") { Price = 100, Quantity = 3, Category = "Enemy / Other", Description = "Spawns a Q'ronar Youngling" },
        new("Spawn Q'ronar Shellback [M]", "enemy_shellback") { Price = 200, Category = "Enemy / Other", Description = "Spawns a Q'ronar Shellback" },
        new("Spawn Korlok Tyrant Weed (Boss) [M]", "enemy_tyrantweed") { Price = 500, Category = "Enemy / Other", Description = "Spawns a Tyrant Weed" },
        new("Spawn BET-C (Boss) [M]", "enemy_betc") { Price = 500, Category = "Enemy / Other", Description = "Spawns a BET-C" },
        new("Spawn Cave Leech [M]", "enemy_leech") { Price = 100, Category = "Enemy / Other", Description = "Spawns a Cave Leech" },
        new("Spawn Spitball Infector [M]", "enemy_spitballer") { Price = 100, Category = "Enemy / Other", Description = "Spawns a Spitball Infector Plant" },
        new("Spawn Barrage Infector [M]", "enemy_barrageinfector") { Price = 150, Category = "Enemy / Other", Description = "Spawns a Barrage Infector Plant" }, //Season 5
        new("Spawn Vartok Scale Bramble [M]", "enemy_scalebramble") { Price = 150, Category = "Enemy / Other", Description = "Spawns a Vartok Scale Bramble Plant" }, //Season 5
        new("Spawn Brood Nexus [M]", "enemy_broodnexus") { Price = 100, Category = "Enemy / Other", Description = "Spawns a Brood Nexus" },
        new("Spawn Stabber Vine [M]", "enemy_stabber") { Price = 100, Category = "Enemy / Other", Description = "Spawns a Stabber Vine" },
        new("Spawn Deeptora Wasp Nest [M]", "enemy_wasps") { Price = 50, Category = "Enemy / Other", Description = "Spawns a hive of Wasps" },
        new("Spawn Crawler [M]", "enemy_crawler") { Price = 150, Quantity = 5, Category = "Enemy / Other", Description = "Spawns a crawler from the deep core" }, //Season 5

        //Enemy - Custom
        new("Spawn Hunter Grabber [M]", "custom_huntergrabber") { Price = 100, Quantity = 2, Category = "Enemy / Custom", Description = "Spawns an Invisible Fast Grabber" },
        new("Spawn Mega Bulk [M]", "custom_megabulk") { Price = 500, Category = "Enemy / Custom", Description = "Spawns a Mega Sized Bulk with Random Types" },
        new("Spawn Jumpscare Bulk [M]", "custom_jumpscarebulk") { Price = 500, Category = "Enemy / Custom", Description = "Spawns a Mega Sized Bulk with Random Types" },
        new("Spawn Anxious Nuke Bug [M]", "custom_anxiousnukebug") { Price = 250, Category = "Enemy / Custom", Description = "Spawns an anxious lootbug that if given too little pets will explode, or too many pets will explode!" },
        new("Spawn Egg Menace [M]", "custom_eggmenace") { Price = 300, Category = "Enemy / Custom", Description = "Spawns a menace that shoots explosive and phermoned swarmer eggs!" },
        new("Spawn Wonky Grunts [M]", "custom_wonkygrunts") { Price = 50, Quantity = 10, Category = "Enemy / Custom", Description = "Spawns a random slasher or guard glyphid with randomized x y z dimensions" },
        new("Spawn Nesting Glyphids [M]", "custom_nestedglyphids") { Price = 300, Category = "Enemy / Custom", Description = "Spawns an Opressor, that splits into 2 Praetorians, then 4 grunts, then 8 swarmers!" },
        new("Spawn Cluster Bulk [M]", "custom_clusterbulk") { Price = 500, Category = "Enemy / Custom", Description = "Spawns a bulk that when killed drops a lot of cluster bomb explosions! Huge AoE!" },
        new("Spawn Reaper [M]", "custom_reaper") { Price = 1000, Category = "Enemy / Custom", Description = "Spawns a reaper stalker. It hunts the team for the whole mission respawning after death and getting stronger with each death!" },
        new("Spawn Thiccbug [M]", "custom_thiccbug") { Price = 200, Category = "Enemy / Custom", Description = "Spawns a Lootbug that steals the team's gold. They can get it back if they kill it. It also has a growing slappable booty." },

        //Critters
        new("Spawn Lootbug [M]", "critter_lootbug") { Price = 10, Quantity = 10, Category = "Critter", Description = "Spawns a Lootbug" }, 
        new("Spawn Naedocyte Cave Cruiser [M]", "critter_cavecruiser") { Price = 5, Category = "Critter", Description = "Spawns a Cave Cruiser" },
        new("Spawn Cave Vine [M]", "critter_cavevine") { Price = 5, Category = "Critter", Description = "Spawns a Cave Vine" },
        new("Spawn Silicate Harvester [M]", "critter_harvester") { Price = 10, Category = "Critter", Description = "Spawns a Silicate Harvester" },
        new("Spawn Cave Angel [M]", "critter_caveangel") { Price = 25, Quantity = 5,  Category = "Critter", Description = "Spawns a Cave Angel" },
        new("Spawn Fester Flea [M]", "critter_flea") { Price = 25, Quantity = 10, Category = "Critter", Description = "Spawns a Fester Flea" },

        //Helpful Items - Custom
        new("Give Molly a Gun! [M]", "custom_battlemolly") { Price = 200, Category = "Helpful / Custom", Description = "Spawns a minehead turret attached to each Mule / Mini-Mule!" },
        new("Spawn Pet Shredder [M]", "custom_petshredder") { Price = 200, Category = "Helpful / Custom", Description = "Spawns a friendly pet shredder with your name! (Lasts Mission Duration)" },
        new("Boost Molly! [M]", "custom_mollybooster") { Price = 100, Category = "Helpful / Custom", Duration = 30, Description = "Makes Molly go Turbo Speed for 30s!" },
        new("Roulettebug [M]", "custom_roulettebug") { Price = 100, Category = "Helpful / Custom", Description = "Spawn a Lootbug that spawns 1 of 10 events when it dies!" },
        new("Medi Battery [M]", "custom_medibattery") { Price = 250, Category = "Helpful / Custom", Description = "Spawn a Medibattery that can revive players after they get enough kills (If one exists instead add 100 kills to it's charge)." },

        //Helpful Items - Vanilla
        new("Spawn Minehead Sentry [M]", "helpful_battlesentry") { Price = 100, Quantity = 3, Category = "Helpful / Vanilla", Description = "Spawns a minehead turret!" },
        new("Spawn Floodlight [M]", "helpful_floodlight") { Price = 50, Category = "Helpful / Vanilla", Description = "Spawns a floodlight!" },
        new("Spawn Resupply Pod [M]", "helpful_resupply") { Price = 100, Quantity = 2, Category = "Helpful / Vanilla", Description = "Spawns a resupply for the team!" },
        new("Give Jet Boots [M]", "helpful_givejetboots") { Price = 150, Category = "Helpful / Vanilla", Duration = 30, Description = "Give ALl Players jet boots for the duration. (Default 30s)" },

        //Fun Effects
        //Beer Effects
        new("Drunk Target [A]", "beer_drunk") { Price = 200, Parameters = TargetsMain, Category = "Beer",  Duration = 15, Description = "Makes target drunk for 15s" },
        new("Target Random Beer [A]", "beer_random") { Price = 100, Parameters = TargetsMain, Category = "Beer", Description = "Gives the Target a Random Beer Effect." },
        new("Target Flintlock Delight [A]", "beer_flintlock") { Price = 100, Parameters = TargetsMain, Category = "Beer", Description = "Gives the Target a Flintlock Delight Beer Effect." },
        new("Target Malt Rockbeaerer [A]", "beer_rockbearer") { Price = 100, Parameters = TargetsMain, Category = "Beer", Description = "Gives the Target a Malt Rockbearer Beer Effect." },
        new("Target Underhill Deluxe [A]", "beer_underhill") { Price = 100, Parameters = TargetsMain, Category = "Beer", Description = "Gives the Target a Underhill Deluxe Beer Effect." },
        new("Target Blackreach Blonde [A]", "beer_blackreach") { Price = 100, Parameters = TargetsMain, Category = "Beer", Description = "Gives the Target a Blackreach Blonde Beer Effect." },
        new("Target Gut Wrecker [A]", "beer_gutwrecker") { Price = 100, Parameters = TargetsMain, Category = "Beer", Description = "Gives the Target a Gut Wrecker Beer Effect." },
        new("Target Burning Love [A]", "beer_burning") { Price = 100, Parameters = TargetsMain, Category = "Beer", Description = "Gives the Target a Burning Love Beer Effect." },
        new("Target Arkenstout [A]", "beer_arkenstout") { Price = 100, Parameters = TargetsMain, Category = "Beer", Description = "Gives the Target a Arkenstout Beer Effect." },
        new("Target Mactera Brew [A]", "beer_mactera") { Price = 100, Parameters = TargetsMain, Category = "Beer", Description = "Gives the Target a Mactera Brew Beer Effect." },
        new("Target Blacklock Lager [A]", "beer_blacklock") { Price = 100, Parameters = TargetsMain, Category = "Beer", Description = "Gives the Target a Blacklock Lager Beer Effect." },
        new("Target Seasoned Moonrider [A]", "beer_moonrider") { Price = 100, Parameters = TargetsRestricted, Category = "Beer", Description = "Gives the Target a Seasoned Moonrider Beer Effect." },

        //Target Effects
        new("Spawn Shield Target [M]", "target_shield") { Price = 100, Parameters = TargetsRestricted, Category = "Event", Duration = 10, Description = "Spawns a shield for the target!" },
        new("Spawn Red Sugar On Target [M]", "target_redsugar") { Price = 100, Category = "Event", Description = "Spawns red sugar on the target!" },
        new("Spawn Target Confetti [A]", "target_confetti") { Price = 10, Parameters =TargetsMain, Category = "Event", Description = "Spawns confetti on the target!" },

        //Full Team
        new("Spawn Shield All [M]", "all_shield") { Price = 200, Category = "Event", Duration = 10, Description = "Spawns a shield for everyone!" },
        new("Spawn Red Sugar All [M]", "all_redsugar") { Price = 200, Category = "Event", Description = "Spawns a Red Sugar Crystal for everyone!" },

        //Events
        new("Slomo Mode [M]", "event_slomo") { Price = 150, Category = "Event", Duration = 15, Description = "Put the game in slow motion for 15s" },
        new("Fastmo Mode [M]", "event_fastmo") { Price = 150, Category = "Event", Duration = 15, Description = "Put the game in fast motion for 15s" },
        new("EMP All Shields [M]", "event_emp") { Price = 250, Category = "Event", Description = "EMP the entire team's shields!" },
        new("Shuffle All Players [M]", "event_shuffleplayers") { Price = 200, Category = "Event", Description = "Randomly shuffle all player locations! (Does not work on solo player Game)" },
        new("Gather All Players On Target [M]", "event_gatherplayers") { Price = 200, Parameters = TargetsRestricted, Category = "Event", Description = "Randomly shuffle all player locations! (Does not work on solo player Game)" },
        new("Drop Tactical Nuke! [M]", "event_nuke") { Price = 500, Category = "Event", Description = "Drops a Nuke on the host's location with a small warning delay!", SessionCooldown = 60},
        new("Close Pod Doors [A]", "event_closepod") { Price = 50, Category = "Event", Duration = 10, Description = "Closes the Drop Pod Doors for the duration (Default 10s)" },
        new("Sink Equipment [M]", "event_sinkequipment") { Price = 50, Category = "Event", Description = "Sinks all Equipment and Pods 5m into the ground." },
        new("Spin Equipment [A]", "event_spinequipment") { Price = 50, Category = "Event", Duration = 10, Description = "Spins all Equipment and Pods for the duration. (Default 10s)" },
        new("Open Crevasse [M]", "event_env_crevasse") { Price = 100, Category = "Event", Description = "Open a Crevasse under the host!" },
        new("Open Crevasse XL [M]", "event_env_crevasse_xl") { Price = 200, Category = "Event", Description = "Open a Very Large Crevasse under the host!" },
        new("Open Crevasse XXL [M]", "event_env_crevasse_xxl") { Price = 400, Category = "Event", Description = "Open up the fabric of Hoxxes under the host!" },
        new("Spawn Frost Geyser [M]", "event_geyser_frost") { Price = 75, Category = "Event", Description = "Open up a Geyser that shoowts freezing air." },
        new("Spawn Air Geyser [M]", "event_geyser_air") { Price = 75, Category = "Event", Description = "Open up a Geyser that shoots bursts of air to launch dwarves." },
        new("Spawn Lava Geyser [M]", "event_geyser_lava") { Price = 75, Category = "Event", Description = "Open up a Geyser that shoots hot magma." },
        new("Display Popup Meme [A]", "event_popup_meme") { Price = 100, Category = "Event", Description = "Open up a Popup Meme on the host that they must close or wait 15s for it to close." },
        new("Confetti Everyone! [A]", "event_confetti_all") { Price = 10, Category = "Event", Description = "Pop some confetti on all players :D" },

        //Custom Bosses
        new("Hydra Bulk [M]", "boss_hydrabulk") { Price = 1000, Category = "Enemy / Boss", Description = "Spawns a Boss Bulk that splits into more smaller bulks as it dies! (Until Micro Hydra Bulks)", SessionCooldown = 60},

        //Holidays
        //Halloween
        new("Jaco Grunt [M]", "halloween_grunt") { Price = 25, Quantity = 5, Category = "Halloween", Description = "Spawn a Halloween themed grunt guard!" },
        new("Jaco Shooter [M]", "halloween_shooter") { Price = 25, Quantity = 5, Category = "Halloween", Description = "Spawn a Halloween themed mactera shooter!" },
        new("Little Ghost [M]", "halloween_shredder") { Price = 25, Quantity = 5, Category = "Halloween", Description = "Spawn a Halloween themed shredders (x2)" },
        new("Halloween Pet [M]", "halloween_pet") { Price = 25, Parameters = TargetsRestricted, Category = "Halloween", Description = "Spawn a friendly pet shredder to guard your target!" },
        new("Pumpkin Patch [M]", "halloween_pumpkinpatch") { Price = 100, Category = "Halloween", Description = "Spawn a pumpkin patch that spawns halloween themed enemies at random." },
        new("Candle Lobber [M]", "halloween_candlelobber") { Price = 100, Category = "Halloween", Description = "Spawn a candle wax lobber! Careful it burns!" },
        new("Witch Warden [M]", "halloween_witchwarden") { Price = 100, Category = "Halloween", Description = "Spawn a warden with a witchy theme and stronger magic!" },
        new("True Slasher [M]", "halloween_trueslasher") { Price = 500, Category = "Halloween", Description = "Send an unkillable slasher glyphid in a hockey mask to hunt the team!" },
        new("Horror [A]", "halloween_horror") { Price = 50, Category = "Halloween", Parameters = TargetsMain, Duration = 20, Description = "Send visual horrors to the target player." },

        //CC Special
        new("Hype Train", "event-hype-train") {}

    };

    static bool IsReady()
    {
        if(File.Exists(ReadyCheckFile))
        {
            string readyTest = File.ReadAllText(ReadyCheckFile);

            if (String.IsNullOrEmpty(readyTest))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        else
        {
            return false;
        }
        
    }

    protected override GameState GetGameState()
    {
        if (File.Exists(GameStateFile))
        {
            string fileTest = File.ReadAllText(GameStateFile);

            if (String.IsNullOrEmpty(fileTest))
            {
                return GameState.Unknown;
            }
            else
            {
                return GameState.Ready;
            }
        }
        else
        {
            return GameState.Unknown;
        }
    }

}