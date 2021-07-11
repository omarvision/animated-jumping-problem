# animated-jumping-problem
I had a problem using jump animations from Mixamo.com where I couldn't sync up the jump and the landing on objects. So, I figured a way to get around that by duplicating the jump animation. Playing the first half of the getting ready for the jump. Playing the second half for the landing of the jump. I only applied the up force to the rigidbody at the proper frame of the animation up jump by using an animation event to call my script ApplyUpForce() method.

YouTube:  https://youtu.be/1DBWIMCeFFw
