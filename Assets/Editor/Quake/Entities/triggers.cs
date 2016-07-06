using System;

/*
 * (.5 .5 .5) ? notouch
 * Variable sized repeatable trigger.  Must be targeted at one or more entities.  If "health" is set, the trigger must be killed to activate each time.
 * If "delay" is set, the trigger waits some time after activating before firing.
 * "wait" : Seconds between triggerings. (.2 default)
 * If notouch is set, the trigger is only fired by other entities, not by touching.
 * NOTOUCH has been obsoleted by trigger_relay!
 * sounds
 * 1)	secret
 * 2)	beep beep
 * 3)	large switch
 * 4)
 * set "message" to text string
 */
public class trigger_multiple : entity_t
{
}

/*
 * (.5 .5 .5) ? notouch
 * Variable sized trigger. Triggers once, then removes itself.  You must set the key "target" to the name of another object in the level that has a matching
 * "targetname".  If "health" is set, the trigger must be killed to activate.
 * If notouch is set, the trigger is only fired by other entities, not by touching.
 * if "killtarget" is set, any objects that have a matching "target" will be removed when the trigger is fired.
 * if "angle" is set, the trigger will only fire when someone is facing the direction of the angle.  Use "360" for an angle of 0.
 * sounds
 * 1)	secret
 * 2)	beep beep
 * 3)	large switch
 * 4)
 * set "message" to text string
 */
public class trigger_once : entity_t
{
}

/*
 * (.5 .5 .5) (-8 -8 -8) (8 8 8)
 * This fixed size trigger cannot be touched, it can only be fired by other events.  It can contain killtargets, targets, delays, and messages.
 */
public class trigger_relay : entity_t
{
}

/*
 * (.5 .5 .5) ?
 * secret counter trigger
 * sounds
 * 1)	secret
 * 2)	beep beep
 * 3)
 * 4)
 * set "message" to text string
 */
public class trigger_secret : entity_t
{
}

/*
 * (.5 .5 .5) ? nomessage
 * Acts as an intermediary for an action that takes multiple inputs.
 * 
 * If nomessage is not set, t will print "1 more.. " etc when triggered and "sequence complete" when finished.
 * 
 * After the counter has been triggered "count" times (default 2), it will fire all of it's targets and remove itself.
 */
public class trigger_counter : entity_t
{
}

/*
 * (.5 .5 .5) (-8 -8 -8) (8 8 32)
 * This is the destination marker for a teleporter.  It should have a "targetname" field with the same value as a teleporter's "target" field.
 */
public class info_teleport_destination : entity_t
{
}

/*
 * (.5 .5 .5) ? PLAYER_ONLY SILENT
 * Any object touching this will be transported to the corresponding info_teleport_destination entity. You must set the "target" field, and create an object with a "targetname" field that matches.
 * 
 * If the trigger_teleport has a targetname, it will only teleport entities when it has been fired.
 */
public class trigger_teleport : entity_t
{
}

/*
 * (.5 .5 .5) ?
 * sets skill level to the value of "message".
 * Only used on start map.
 */
public class trigger_setskill : entity_t
{
}

/*
 * (.5 .5 .5) ?
 * Only fires if playing the registered version, otherwise prints the message
 */
public class trigger_onlyregistered : entity_t
{
}

/*
 * (.5 .5 .5) ?
 * Any object touching this will be hurt
 * set dmg to damage amount
 * defalt dmg = 5
 */
public class trigger_hurt : entity_t
{
}

/*
 * (.5 .5 .5) ? PUSH_ONCE
 * Pushes the player
 */
public class trigger_push : entity_t
{
}

/*
 * (.5 .5 .5) ?
 * Walking monsters that touch this will jump in the direction of the trigger's angle
 * "speed" default to 200, the speed thrown forward
 * "height" default to 200, the speed thrown upwards
 */
public class trigger_monsterjump : entity_t
{
}