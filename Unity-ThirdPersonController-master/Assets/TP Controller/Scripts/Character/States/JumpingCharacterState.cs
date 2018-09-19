using UnityEngine;
using System.Collections;

/// <summary>
/// The character is in the air, and he jumped to achieve that
/// </summary>
public class JumpingCharacterState : CharacterStateBase
{
	public override void Update(Character character,  SimpleTouchController touch, FixedTouchField field)
    {
		base.Update(character,touch,field);

        if (character.IsGrounded)
        {
            this.ToState(character, CharacterStateBase.GROUNDED_STATE);
        }
    }
}
