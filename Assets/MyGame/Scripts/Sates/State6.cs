// Represents 6 digit for a 7 segment display
public class State6 : ISevenSegmentDisplayState
{
    static ISevenSegmentDisplayState _state;
    public int GetDigit() {
        return 6;
    }

    public ISevenSegmentDisplayState CountUp() {
        return State7.GetState();
    }

    public ISevenSegmentDisplayState CountDown() {
        return State5.GetState();
    }
    private State6() {
    }
    public static ISevenSegmentDisplayState GetState() {
        if (_state == null) {
            _state = new State6();
        }
        return _state;
    }

}
