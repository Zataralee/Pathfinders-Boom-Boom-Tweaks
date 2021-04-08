using System.Collections.Generic;
using static WeaponThread.WeaponStructure;
using static WeaponThread.WeaponStructure.WeaponDefinition;
using static WeaponThread.WeaponStructure.WeaponDefinition.AnimationDef;
using static WeaponThread.WeaponStructure.WeaponDefinition.AnimationDef.PartAnimationSetDef.EventTriggers;
using static WeaponThread.WeaponStructure.WeaponDefinition.AnimationDef.RelMove.MoveType;
using static WeaponThread.WeaponStructure.WeaponDefinition.AnimationDef.RelMove;
namespace WeaponThread
{ // Don't edit above this line
    partial class Weapons
    {
        /// Possible Events ///
        
        //Reloading,
        //Firing,
        //Tracking,
        //Overheated,
        //TurnOn,
        //TurnOff,
        //BurstReload,
        //OutOfAmmo,
        //PreFire,
        //EmptyOnGameLoad,
        //StopFiring,
        //StopTracking

        private AnimationDef MXA_BreakWaterB2_Animation => new AnimationDef
        {
            WeaponAnimationSets = new[]
            {
				new PartAnimationSetDef()
                {
                    SubpartId = Names("Recoil2"),
                    BarrelId = "muzzle_projectile_2", //only used for firing, use "Any" for all muzzles
                    StartupFireDelay = 0,
                    AnimationDelays = Delays(FiringDelay : 0, ReloadingDelay: 0, OverheatedDelay: 0, TrackingDelay: 0, LockedDelay: 0, OnDelay: 0, OffDelay: 0, BurstReloadDelay: 0, OutOfAmmoDelay: 0, PreFireDelay: 0),//Delay before animation starts
                    Reverse = Events(),
                    Loop = Events(),
                    ResetEmissives = Events(),
                    EventMoveSets = new Dictionary<PartAnimationSetDef.EventTriggers, RelMove[]>
                    {
                        


                        [Firing] =
                            new[] //Firing, Reloading, Overheated, Tracking, On, Off, BurstReload, OutOfAmmo, PreFire define a new[] for each
                            {
                                new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 30, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = ExpoDecay, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                     EmissiveName = "TurnOn",//name of defined emissive
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 1), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
								
								new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 10, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Linear, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                     EmissiveName = "TurnOn",//name of defined emissive
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, -1), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                            },

					}
				},
            }
            
        };
    }
}
