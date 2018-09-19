using System;

public interface ICharacterState
{
    void OnEnter(Character character);

    void OnExit(Character character);

	void Update(Character character, SimpleTouchController touchcontroller, FixedTouchField fixedTouch);

    void ToState(Character character, ICharacterState state);
}
