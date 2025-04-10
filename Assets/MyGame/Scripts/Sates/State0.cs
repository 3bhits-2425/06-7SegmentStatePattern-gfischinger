// Represents 0 digit for a 7 segment display
public class State0 : ISevenSegmentDisplayState
{

    public int GetDigit() {
        return 0;
    }

    public ISevenSegmentDisplayState CountUp() {
        return new State1();
    }

    public ISevenSegmentDisplayState CountDown() {
        return new State9();
    }


}
