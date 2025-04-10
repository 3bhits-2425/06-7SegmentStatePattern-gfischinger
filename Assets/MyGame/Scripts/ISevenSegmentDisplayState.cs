public interface ISevenSegmentDisplayState {

    private static ISevenSegmentDisplayState _state;
    // get the number for the current state
    public int GetDigit();

    // important for singleton
    // get the state-object
    public static extern ISevenSegmentDisplayState GetState();

    public ISevenSegmentDisplayState CountDown(); //Switch to previous state
    public ISevenSegmentDisplayState CountUp(); //Switch to next state

}