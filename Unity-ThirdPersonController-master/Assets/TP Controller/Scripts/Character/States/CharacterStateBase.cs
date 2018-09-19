using UnityEngine;

public abstract class CharacterStateBase : ICharacterState
{
    public static readonly ICharacterState GROUNDED_STATE = new GroundedCharacterState();
    public static readonly ICharacterState JUMPING_STATE = new JumpingCharacterState();
    public static readonly ICharacterState IN_AIR_STATE = new InAirCharacterState();

    public virtual void OnEnter(Character character) { }

    public virtual void OnExit(Character character) { }

	public virtual void Update(Character character, SimpleTouchController touchControoller, FixedTouchField field)
    {
        character.ApplyGravity();
		character.MoveVector = PlayerInput.GetMovementInput(character.Camera,touchControoller);
		character.ControlRotation = PlayerInput.GetMouseRotationInput(field.TouchDist.x* 0.75f, field.TouchDist.y* 0.15f);
    }

    public virtual void ToState(Character character, ICharacterState state)
    {
        character.CurrentState.OnExit(character);
        character.CurrentState = state;
        character.CurrentState.OnEnter(character);
    }
}
